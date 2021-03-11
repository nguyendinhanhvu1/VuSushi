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

namespace SushiStore
{
    public partial class ProductFrm : Form
    {
        string connString = ConfigurationManager.ConnectionStrings["con"].ToString();

        public ProductFrm()
        {
            InitializeComponent();
            lstCategory.Columns.Add("ID", 30);
            lstCategory.Columns.Add("Category Name", 130);
            lstProduct.Columns.Add("ID", 30);
            lstProduct.Columns.Add("Product Name", 130);
            lstProduct.Columns.Add("Price", 80);
            lstProduct.Columns.Add("Avaiable",50);
        }

        private void ProductFrm_Load(object sender, EventArgs e)
        {
            GetCategory();
        }
        public void GetCategory()
        {
            lstCategory.Items.Clear();
            using (SqlConnection connection = new SqlConnection(connString))
            {

                connection.Open();
                SqlDataReader reader = null;
                SqlCommand command = new SqlCommand("SELECT * from Category order by CatID", connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {

                    lstCategory.Items.Add(new ListViewItem(new[] { reader[0].ToString(), reader[1].ToString() }));

                }
                reader.Close();
                connection.Close();
            }
        }
        public void Getproduct()
        {
            if (lstCategory.SelectedItems.Count > 0)
            {
                lstProduct.Items.Clear();
                using (SqlConnection connection = new SqlConnection(connString))
                {

                    connection.Open();
                    SqlDataReader reader = null;
                    SqlCommand command = new SqlCommand(@"SELECT Product.ProdID, Product.ProdName, Product.ProdPrice, Product.Prodstatus 
                                                                FROM Category INNER JOIN Product ON Category.CatID = Product.CatID 
                                                                Where Category.CatID = @CatID", connection);
                    command.Parameters.AddWithValue("@CatID", lstCategory.SelectedItems[0].SubItems[0].Text);
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {

                        lstProduct.Items.Add(new ListViewItem(new[] { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString() }));

                    }
                    reader.Close();
                    connection.Close();
                }
            }
            else
            {
                return;
            }
        }
        private void lstCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clearselected();
            Getproduct();
        }

        private void lstProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProduct.SelectedItems.Count > 0)
            {
                txtProID.Text = lstProduct.SelectedItems[0].SubItems[0].Text;
                txtProName.Text = lstProduct.SelectedItems[0].SubItems[1].Text;
                txtProdPrice.Text = lstProduct.SelectedItems[0].SubItems[2].Text;
                switch (lstProduct.SelectedItems[0].SubItems[3].Text)
                {
                    case "True":
                        cbxStatus.Checked = true;
                        break;
                    case "False":
                        cbxStatus.Checked = false;
                        break;
                    default:
                        return;
                        
                }
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("Select Product.ProdImg from Product where Product.ProdID = @ProdID",connection);
                    command.Parameters.AddWithValue("@ProdID", lstProduct.SelectedItems[0].SubItems[0].Text);
                    byte[] imagebytes = (byte[])command.ExecuteScalar();
                    MemoryStream ms = new MemoryStream(imagebytes);
                    pictureBox1.Image = Image.FromStream(ms);
                    connection.Close();
                }
            }
            else
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstCategory.SelectedItems.Count > 0)
            {
                
                if (txtProdPrice.Text == "" || txtProName.Text == "" || pictureBox1.Image == null)
                {
                    MessageBox.Show("まだ記入してない所がある");
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    Image img = pictureBox1.Image;
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] imgbytes = ms.ToArray();
                    using (SqlConnection connection = new SqlConnection(connString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("INSERT INTO Product([CatID],[ProdName],[ProdImg],[ProdPrice],[ProdStatus]) VALUES (@CatID, @ProdName, @ProdImg, @ProdPrice,@ProdStatus)", connection);
                        command.Parameters.AddWithValue("@CatID", lstCategory.SelectedItems[0].SubItems[0].Text);
                        command.Parameters.AddWithValue("@ProdName",txtProName.Text);
                        command.Parameters.AddWithValue("@ProdImg", imgbytes);
                        command.Parameters.AddWithValue("@ProdPrice", txtProdPrice.Text);
                        command.Parameters.AddWithValue("@ProdStatus", cbxStatus.Checked);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Done");
                        Getproduct();
                        connection.Close();
                    }
                }
               
            }
            else
            {
                MessageBox.Show("Please select product category!");
                return;
            }
        }

        private void btnAddImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Multiselect = false,
                ValidateNames = true,
                Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"
            };
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(ofd.FileName);
                    using (FileStream stream = new FileStream(fi.FullName, FileMode.Open, FileAccess.Read))
                    {
                    txtProName.Text = Path.GetFileNameWithoutExtension(fi.FullName) ;
                        pictureBox1.Image = Image.FromStream(stream);
                    }              
                }
            }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clearselected();
        }
        public void Clearselected()
        {
            cbxStatus.Checked = false;
            txtProdPrice.Text = null;
            txtProID.Text = null;
            txtProName.Text = null;
            pictureBox1.Image = null;
            if (lstProduct.SelectedItems.Count > 0)
            {
                lstProduct.SelectedItems[0].Selected = false;
            }
            else
            {
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtProdPrice.Text == "" || txtProName.Text == "" || pictureBox1.Image == null || txtProID.Text == "")
            {
                MessageBox.Show("まだ記入してない所がある");
            }
            else
            {
                
                MemoryStream ms = new MemoryStream();
                Image img = pictureBox1.Image;
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] imgbytes = ms.ToArray();
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("Update Product Set [CatID] = @CatID, [ProdName] = @ProdName, [ProdImg] = @ProdImg, [ProdPrice] = @ProdPrice, [ProdStatus] = @ProdStatus WHERE [ProdID] = @ProdID", connection);
                    command.Parameters.AddWithValue("@CatID", lstCategory.SelectedItems[0].SubItems[0].Text);
                    command.Parameters.AddWithValue("@ProdName", txtProName.Text);
                    command.Parameters.AddWithValue("@ProdImg", imgbytes);
                    command.Parameters.AddWithValue("@ProdPrice", txtProdPrice.Text);
                    command.Parameters.AddWithValue("@ProdStatus", cbxStatus.Checked);
                    command.Parameters.AddWithValue("@ProdID", txtProID.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Done");
                    Getproduct();
                    connection.Close();
                }
            }
        }


    }
    }

