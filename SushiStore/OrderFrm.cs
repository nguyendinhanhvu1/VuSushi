using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SushiStore
{
    public partial class OrderFrm : Form
    {
        string StaffID;
        string connString = ConfigurationManager.ConnectionStrings["con"].ToString();
        public OrderFrm(string StaffID)
        {
            InitializeComponent();
            this.StaffID = StaffID;
            lstOrder.Columns.Add("Table Name", 80);
            lstOrder.Columns.Add("Order ID", 130);
            lstOrder.Columns.Add("Product ID", 80);
            lstOrder.Columns.Add("Product Name", 130);
            lstOrder.Columns.Add("Order Date", 130);
            lstOrder.Columns.Add("Table distance", 30);
        }
        public void GetOrderList()
        {
            lstOrder.Items.Clear();
            using (SqlConnection connection = new SqlConnection(connString))
            {

                connection.Open();
                SqlDataReader reader = null;
                SqlCommand command = new SqlCommand(@"SELECT [Table].TableNumber, [Order].OrderID, [Order].ProdID, Product.ProdName, [Order].OrdDate, [Table].TableDistance
                                                        FROM [Table] INNER JOIN (Product INNER JOIN ([Order] INNER JOIN OrderDetail ON [Order].OrderID = OrderDetail.OrderID) ON Product.ProdID = [Order].ProdID) ON [Table].TableID = OrderDetail.TableID
                                                        WHERE ((([Order].ServedDate) Is Null))
                                                        ORDER BY [Order].OrdDate;", connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {

                    lstOrder.Items.Add(new ListViewItem(new[] { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString() }));

                }
                reader.Close();
                connection.Close();
            }
        }
        public void Cleartext()
        {
            txtOrder.Text = txtOrderdate.Text = txtProdID.Text = txtProdname.Text = txtTable.Text = txtTabledis.Text = null;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetOrderList();
        }

        private void lstOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOrder.SelectedItems.Count > 0)
            {
                txtTable.Text = lstOrder.SelectedItems[0].SubItems[0].Text;
                txtOrder.Text = lstOrder.SelectedItems[0].SubItems[1].Text;
                txtProdID.Text = lstOrder.SelectedItems[0].SubItems[2].Text;
                txtProdname.Text = lstOrder.SelectedItems[0].SubItems[3].Text;
                txtOrderdate.Text = lstOrder.SelectedItems[0].SubItems[4].Text;
                txtTabledis.Text = lstOrder.SelectedItems[0].SubItems[5].Text;
            }
            else
            { return;}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtOrder.Text == null)
            {
                MessageBox.Show("Please select order first");
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM [OrderDetail] Where [OrderID] = @OrderID", connection);
                    command.Parameters.AddWithValue("@OrderID", txtOrder.Text);
                    SqlCommand command2 = new SqlCommand("DELETE FROM [Order] Where [OrderID] = @OrderID", connection);
                    command2.Parameters.AddWithValue("@OrderID", txtOrder.Text);
                    command.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    MessageBox.Show("Done");
                    GetOrderList();
                    Cleartext();
                    connection.Close();
                }
            }
           
        }

        private void btnServed_Click(object sender, EventArgs e)
        {

            if (txtOrder.Text == null)
            {
                MessageBox.Show("Please select order first");
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    string ServedTime = DateTime.Now.AddSeconds(Convert.ToDouble(txtTabledis.Text)).ToString("MM/dd/yyyy HH:mm:ss");
                    connection.Open();
                    SqlCommand command = new SqlCommand("UPDATE [Order] SET [StaffID] = @StaffID, [ServedDate] = @ServedDate WHERE [OrderID] = @OrderrID", connection);
                    command.Parameters.AddWithValue("@StaffID", StaffID);
                    command.Parameters.AddWithValue("@ServedDate", ServedTime);
                    command.Parameters.AddWithValue("@OrderrID", txtOrder.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Done");
                    GetOrderList();
                    Cleartext();
                    connection.Close();
                }
            }
        }
    }
}
