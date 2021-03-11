using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClientSide
{
    public partial class OrderServingFrm : Form
    {
        string connString = ConfigurationManager.ConnectionStrings["con"].ToString();
        ImageList myImageList = new ImageList();
        private Timer timer1;
        public string SessionID;
        public OrderServingFrm( )
        {
            InitializeComponent();
        }

        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 5000; // in miliseconds
            timer1.Start();
        }
        public void InitTimer2()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer2_Tick);
            timer1.Interval = 2000; // in miliseconds
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            GetServing();
            if (lstServing.Items.Count == 0)
            {
                this.Hide();
            }
        }
        private void OrderServingFrm_Load(object sender, EventArgs e)
        {
            GetServing();
            InitTimer2();
        }

        public void GetServing()
        {
            int count = 0;
            myImageList.Images.Clear();
            lstServing.Items.Clear();
            myImageList.ImageSize = new Size(186, 186);
            myImageList.ColorDepth = ColorDepth.Depth32Bit;
            using (SqlConnection connection = new SqlConnection(connString))             
            {

                    connection.Open();
                    SqlDataReader reader = null;
                    SqlCommand command = new SqlCommand(@"SELECT Product.ProdName, Product.ProdPrice, Product.ProdImg
FROM Product INNER JOIN ([Order] INNER JOIN OrderDetail ON [Order].OrderID = OrderDetail.OrderID) ON Product.ProdID = [Order].ProdID
WHERE OrderDetail.DetailID = @DetailID AND [Order].ServedDate BETWEEN @date1 and @date2
ORDER BY [Order].ServedDate;
", connection);
                command.Parameters.AddWithValue("@DetailID",SessionID);
                command.Parameters.AddWithValue("@date1", DateTime.Now.AddSeconds(-2).ToString("MM/dd/yyyy HH:mm:ss")) ;
                command.Parameters.AddWithValue("@date2", DateTime.Now.AddSeconds(5).ToString("MM/dd/yyyy HH:mm:ss")) ;
                reader = command.ExecuteReader();

                while (reader.Read())                  
                {
                    byte[] imagebytes = (byte[])reader[2];
                    MemoryStream ms = new MemoryStream(imagebytes);
                    myImageList.Images.Add(Image.FromStream(ms));
                    lstServing.Items.Add(new ListViewItem
                    {
                        ImageIndex = count,
                        Text = reader[0].ToString() + " " + reader[1].ToString()+ "yen",

                    }); ;
                    count++;
                }
                    reader.Close();
                    connection.Close();
            }

            lstServing.LargeImageList = myImageList;

        }
    } 
}
