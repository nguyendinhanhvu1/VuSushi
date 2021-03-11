using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace SushiStore
{


    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string StaffID, StaffName;
            string connString = ConfigurationManager.ConnectionStrings["con"].ToString();
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                SqlDataReader reader = null;
                SqlCommand command = new SqlCommand("SELECT * from  Staff WHERE Username=@User and Password = @Pass", connection);
                command.Parameters.AddWithValue("@User", TbxUser.Text);
                command.Parameters.AddWithValue("@Pass", TbxPass.Text);
                reader = command.ExecuteReader();
                if (reader.HasRows)

                {
                    while (reader.Read())
                    {
                        StaffID = reader["StaffID"].ToString();
                        StaffName = reader["StaffName"].ToString();
                        Form1 mainform = new Form1();
                        mainform.StaffID = StaffID;
                        mainform.Staffname = StaffName;
                        this.Hide();
                        mainform.ShowDialog();
                        this.Show();
                        TbxPass.Text = TbxUser.Text = null;
                    }
                    reader.Close();
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Login failed (ログイン出来ない)");
                    reader.Close();
                    connection.Close();
                }
            }
           
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
