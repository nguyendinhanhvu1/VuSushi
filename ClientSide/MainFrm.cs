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
    
    public partial class MainFrm : Form
    {
        string IDNumber;
        string SessionID;
        string connString = ConfigurationManager.ConnectionStrings["con"].ToString();
        ImageList myImageList = new ImageList();
       static OrderServingFrm formcoming = new OrderServingFrm();
        public MainFrm(string ID, string Session)
        {
            InitializeComponent();
            this.IDNumber = ID;
            this.SessionID = Session;
            lstOrder.Columns.Add("ID",30);
            lstOrder.Columns.Add("Name", 150);
            lstOrder.Columns.Add("Date", 130);
            lstOrder.Columns.Add("Price", 130);
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            lblID.Text = IDNumber;
            lblSessionID.Text = SessionID;
           
            GetAllproduct();
            InitTimer();
        }
        public void Getproduct(string category)
        {
            int count = 0;
            myImageList.Images.Clear();
            lstProduct.Items.Clear();
            myImageList.ImageSize = new Size(186, 186);
            myImageList.ColorDepth = ColorDepth.Depth32Bit;
            using (SqlConnection connection = new SqlConnection(connString))             
            {

                    connection.Open();
                    SqlDataReader reader = null;
                    SqlCommand command = new SqlCommand(@"SELECT Product.ProdID, Product.ProdName, Product.ProdImg, Product.ProdPrice
                                                                FROM Category INNER JOIN Product ON Category.CatID = Product.CatID 
                                                                Where Category.CatID = @CatID and Product.Prodstatus = 1", connection);
                command.Parameters.AddWithValue("@CatID", category);
                    reader = command.ExecuteReader();

                while (reader.Read())                  
                {
                    byte[] imagebytes = (byte[])reader[2];
                    MemoryStream ms = new MemoryStream(imagebytes);
                    myImageList.Images.Add(Image.FromStream(ms));
                    lstProduct.Items.Add(new ListViewItem
                    {
                        Name = reader[0].ToString(),
                        ImageIndex = count,
                        Text = reader[1].ToString() + " " + reader[3].ToString() + "¥",
                        Tag = reader[3].ToString()

                    }); ;
                    count++;
                }
                    reader.Close();
                    connection.Close();
            }

            lstProduct.LargeImageList = myImageList;

        }
        public void GetAllproduct()
        {
            int count = 0;
            myImageList.Images.Clear();
            lstProduct.Items.Clear();
            myImageList.ImageSize = new Size(186, 186);
            myImageList.ColorDepth = ColorDepth.Depth32Bit;
            using (SqlConnection connection = new SqlConnection(connString))
            {

                connection.Open();
                SqlDataReader reader = null;
                SqlCommand command = new SqlCommand(@"SELECT Product.ProdID, Product.ProdName, Product.ProdImg, Product.ProdPrice
                                                                FROM Category INNER JOIN Product ON Category.CatID = Product.CatID 
                                                                Where Product.Prodstatus = 1", connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    byte[] imagebytes = (byte[])reader[2];
                    MemoryStream ms = new MemoryStream(imagebytes);
                    myImageList.Images.Add(Image.FromStream(ms));
                    lstProduct.Items.Add(new ListViewItem
                    {
                        Name = reader[0].ToString(),
                        ImageIndex = count,
                        Text = reader[1].ToString() + " " + reader[3].ToString() + "¥",
                        Tag = reader[3].ToString()

                    }); ;
                    count++;
                }
                reader.Close();
                connection.Close();
            }

            lstProduct.LargeImageList = myImageList;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Getproduct("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Getproduct("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Getproduct("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Getproduct("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Getproduct("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Getproduct("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Getproduct("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Getproduct("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Getproduct("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Getproduct("10");
        }

        private void lstProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }



        private void button11_Click(object sender, EventArgs e)
        {
            GetAllproduct();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                for (int i = 0; i < lstOrder.Items.Count; i++)

                {
                    string OrderID = DateTime.Now.ToString("MMddyyyyHHmmss") + lstOrder.Items[i].SubItems[0].Text + i;
                    string ProdID = lstOrder.Items[i].SubItems[0].Text;
                    string OrderDate = lstOrder.Items[i].SubItems[2].Text;
                    string OrderPaid = lstOrder.Items[i].SubItems[3].Text;
                    SqlCommand command = new SqlCommand("INSERT INTO [Order]([OrderID], [ProdID], [OrdDate], [Paid]) VALUES (@OrderID, @ProdID, @OrdDate, @Paid)", connection);
                    command.Parameters.AddWithValue("@OrderID", OrderID);
                    command.Parameters.AddWithValue("@ProdID", ProdID);
                    command.Parameters.AddWithValue("@OrdDate", OrderDate);
                    command.Parameters.AddWithValue("@Paid", OrderPaid);
                    command.ExecuteNonQuery();
                    SqlCommand command2 = new SqlCommand("INSERT INTO [OrderDetail]([DetailID], [TableID], [OrderID]) VALUES (@DetailID, @TableID, @OrderID)", connection);
                    command2.Parameters.AddWithValue("@DetailID", lblSessionID.Text);
                    command2.Parameters.AddWithValue("@TableID", lblID.Text);
                    command2.Parameters.AddWithValue("@OrderID", OrderID);
                    command2.ExecuteNonQuery();
                }
                MessageBox.Show("We have heard your order!");
                lstOrder.Items.Clear();
                connection.Close();
            }

        }

        private void lstProduct_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lstProduct.SelectedItems.Count > 0)
            {
                DialogResult res = MessageBox.Show("Are you sure you want to order this?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    string ID = lstProduct.SelectedItems[0].Name;
                    string Name = lstProduct.SelectedItems[0].Text;
                    string Price = lstProduct.SelectedItems[0].Tag.ToString();
                    lstOrder.Items.Add(new ListViewItem(new[] { ID, Name, DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"),  Price}));
                }
                if (res == DialogResult.Cancel)
                {
                    return;
                }
            }
            else
            {
                return;
            }

        }

        private void lstProduct_Click(object sender, EventArgs e)
        {

            lstProduct.SelectedItems.Clear();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            OrderHistoryFrm form = new OrderHistoryFrm(lblID.Text, lblSessionID.Text);
            form.ShowDialog();
        }



        public void InitTimer()
        {
            Timer timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 2000; // in miliseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {

                connection.Open();
                SqlDataReader reader = null;
                SqlCommand command = new SqlCommand(@"SELECT OrderDetail.DetailID, [Order].OrderID, [Order].ServedDate
FROM [Order] INNER JOIN OrderDetail ON [Order].OrderID = OrderDetail.OrderID
WHERE (((OrderDetail.DetailID)=@DetailID) AND (([Order].ServedDate) Between @date1 And @date2))
", connection);
                command.Parameters.AddWithValue("@DetailID", lblSessionID.Text);
                command.Parameters.AddWithValue("@date1", DateTime.Now.AddSeconds(-2).ToString("MM/dd/yyyy HH:mm:ss"));
                command.Parameters.AddWithValue("@date2", DateTime.Now.AddSeconds(5).ToString("MM/dd/yyyy HH:mm:ss"));
                reader = command.ExecuteReader();
                if (reader.HasRows == true)
                {
                    if (formcoming.Visible == false)
                    {
                        formcoming.TopMost = true;
                        formcoming.SessionID = this.SessionID;
                        formcoming.ShowDialog();
                    }
                }
                reader.Close();
                connection.Close();
            }
        }

        public void ClearUndoneOrder()
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {

                connection.Open();
                SqlDataReader reader = null;
                SqlCommand command = new SqlCommand(@"SELECT [Order].OrderID
FROM [Order] INNER JOIN OrderDetail ON [Order].OrderID = OrderDetail.OrderID
WHERE (((OrderDetail.DetailID)=@DetailID) AND (([Order].ServedDate) Is Null));
", connection);
                command.Parameters.AddWithValue(@"DetailID", SessionID);
                reader = command.ExecuteReader();
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {

                        SqlCommand command2 = new SqlCommand("DELETE FROM OrderDetail Where OrderDetail.OrderID = @OrderID", connection);
                        command2.Parameters.AddWithValue("@OrderID", reader[0].ToString());
                        SqlCommand command3 = new SqlCommand("DELETE FROM [Order] Where [Order].OrderID = @OrderID", connection);
                        command3.Parameters.AddWithValue("@OrderID", reader[0].ToString());
                        command2.ExecuteNonQuery();
                        command3.ExecuteNonQuery();
                    }
                }

                reader.Close();
                connection.Close();

            }
        }
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to checkout?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                ClearUndoneOrder();
                MessageBox.Show("Thanks for using Vu Sushi!");
                this.Close();
            }
        }
    }
}
