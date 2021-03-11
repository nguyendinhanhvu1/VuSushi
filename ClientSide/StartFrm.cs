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
using Microsoft.VisualBasic;
using System.Data.SqlClient;

namespace ClientSide
{
    public partial class StartFrm : Form
    {
        string connString = ConfigurationManager.ConnectionStrings["con"].ToString();
        public StartFrm()
        {
            InitializeComponent();
            
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {

            cbxTable.Items.Clear();
            using (SqlConnection connection = new SqlConnection(connString))
            {

                connection.Open();
                SqlDataReader reader = null;
                SqlCommand command = new SqlCommand("SELECT TableID, TableNumber from [Table] order by TableID", connection);
                reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Value");
                while (reader.Read())
                {
                    dt.Rows.Add(reader[0].ToString(), reader[1].ToString());

                }
                cbxTable.ValueMember = dt.Columns[0].ToString();
                cbxTable.DisplayMember = dt.Columns[1].ToString();
                cbxTable.DataSource = dt;
                reader.Close();
                connection.Close();

            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string sessionID = DateTime.Now.ToString("MMddyyyyHHmmss") + cbxTable.SelectedValue.ToString();
            using (SqlConnection connection = new SqlConnection(connString))
            {

                connection.Open();
                SqlCommand command = new SqlCommand("Update [Table] Set DetailID = @DetailID, TableStatus = 0 Where TableID = @TableID", connection);
                command.Parameters.AddWithValue("@DetailID",sessionID);
                command.Parameters.AddWithValue("@TableID", cbxTable.SelectedValue.ToString());
                command.ExecuteNonQuery();
                connection.Close();

            }
            MainFrm form = new MainFrm(cbxTable.SelectedValue.ToString(), sessionID );
            this.Visible = false;
            form.ShowDialog();
            this.Show();
        }


        private void btnUnlock_Click(object sender, EventArgs e)
        {
            string checkpass = Interaction.InputBox("Enter password", "Login to set table", "");
            if (checkpass == "admin")
            {
                cbxTable.Enabled = true;
            }
            else
            {
                cbxTable.Enabled = false;
            }
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            cbxTable.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
