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

namespace SushiStore
{
    public partial class UserMngFrm : Form
    {
        string connString = ConfigurationManager.ConnectionStrings["con"].ToString();
        public UserMngFrm()
        {
            InitializeComponent();
            lstUser.Columns.Add("Staff ID", 130);
            lstUser.Columns.Add("Staff Name", 130);
            lstUser.Columns.Add("Staff User", 130);
        }

        private void UserMngFrm_Load(object sender, EventArgs e)
        {
            UpdateUser();
            
            

        }

        private void lstUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUser.SelectedItems.Count > 0)
            {
                txtStaffID.Text = lstUser.SelectedItems[0].SubItems[0].Text;
                txtName.Text = lstUser.SelectedItems[0].SubItems[1].Text;
                txtUser.Text = lstUser.SelectedItems[0].SubItems[2].Text;
            }
            else
            {
                return;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtStaffID.Text == "" || txtName.Text == "" || txtUser.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("記入してください。");
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {

                    connection.Open();
                    SqlCommand command = new SqlCommand("UPDATE Staff Set [StaffName] = @StaffName, [Username] = @StaffUser, [Password] = @StaffPass WHERE [StaffID] = @StaffID", connection);
                    command.Parameters.AddWithValue("@StaffName", txtName.Text);
                    command.Parameters.AddWithValue("@StaffUser", txtUser.Text);
                    command.Parameters.AddWithValue("@StaffPass", txtPass.Text);
                    command.Parameters.AddWithValue("@StaffID", txtStaffID.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Done");
                    UpdateUser();
                    connection.Close();
                }
            }
        }

       public void UpdateUser()
        {
            lstUser.Items.Clear();
            using (SqlConnection connection = new SqlConnection(connString))
            {

                connection.Open();
                SqlDataReader reader = null;
                SqlCommand command = new SqlCommand("SELECT [StaffID],[StaffName],[Username] from  Staff order by StaffID", connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {

                    lstUser.Items.Add(new ListViewItem(new[] { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() }));

                }
                reader.Close();
                connection.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStaffID.Text = null;
            txtName.Text = null;
            txtUser.Text = null;
            txtPass.Text = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtUser.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("記入してください。");
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    SqlCommand cmdcheckuser = new SqlCommand("Select * from Staff where [Username] = @username", connection);
                    cmdcheckuser.Parameters.AddWithValue("@username",txtUser.Text);
                    SqlDataReader reader = cmdcheckuser.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("人員存在している");
                        reader.Close();
                    }
                    else
                    {
                        SqlCommand command = new SqlCommand("INSERT INTO Staff([StaffName],[Username],[Password]) VALUES (@StaffName, @UserName, @Password)", connection);
                        command.Parameters.AddWithValue("@StaffName", txtName.Text);
                        command.Parameters.AddWithValue("@UserName", txtUser.Text);
                        command.Parameters.AddWithValue("@Password", txtPass.Text);                      
                        command.ExecuteNonQuery();
                        MessageBox.Show("Done");
                        UpdateUser();
                        connection.Close();
                    }
                }
            }
        }
    }
}

