using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClientSide
{
    public partial class OrderHistoryFrm : Form
    {
        string TableID;
        string SessionID;
        string connString = ConfigurationManager.ConnectionStrings["con"].ToString();
        public OrderHistoryFrm(string TableID, string SessionID)
        {
            InitializeComponent();
            lstOrderedItem.Columns.Add("Order ID", 130);
            lstOrderedItem.Columns.Add("Product Name", 130);
            lstOrderedItem.Columns.Add("Order Date", 130);
            lstOrderedItem.Columns.Add("Served Date", 130);
            lstOrderedItem.Columns.Add("Paid", 30);
            this.TableID = TableID;
            this.SessionID = SessionID; 
        }

        private void OrderHistoryFrm_Load(object sender, EventArgs e)
        {
            lstOrderedItem.Items.Clear();
            using (SqlConnection connection = new SqlConnection(connString))
            {

                connection.Open();
                SqlDataReader reader = null;
                SqlCommand command = new SqlCommand(@"SELECT [Order].OrderID, Product.ProdName, [Order].OrdDate, [Order].ServedDate, [Order].Paid
                                                        FROM (Product INNER JOIN [Order] ON Product.ProdID = [Order].ProdID) INNER JOIN OrderDetail ON [Order].OrderID = OrderDetail.OrderID
                            WHERE (((OrderDetail.DetailID)=@SessionID) AND ((OrderDetail.TableID)=@TableID)) ORDER BY [Order].OrdDate DESC;", connection);
                command.Parameters.AddWithValue("@SessionID", this.SessionID);
                command.Parameters.AddWithValue("@TableID", this.TableID);
                reader = command.ExecuteReader();

                while (reader.Read())
                {

                    lstOrderedItem.Items.Add(new ListViewItem(new[] { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString() }));

                }
                reader.Close();
                connection.Close();

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
