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
    public partial class TableFrm : Form
    {
        string connString = ConfigurationManager.ConnectionStrings["con"].ToString();
        public TableFrm()
        {
            InitializeComponent();
            lstTable.Columns.Add("Table ID", 60);
            lstTable.Columns.Add("Table Number", 80);
            lstTable.Columns.Add("Table Distance", 80);
            lstTable.Columns.Add("Table Status", 80);
            lstTable.Columns.Add("Current Session", 80);
        }

        private void TableFrm_Load(object sender, EventArgs e)
        {
            GetAllTable();
        }

        private void lstTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTable.SelectedItems.Count > 0)
            {
                tbxID.Text = lstTable.SelectedItems[0].SubItems[0].Text;
                tbxNumber.Text = lstTable.SelectedItems[0].SubItems[1].Text;
                tbxDistance.Text = lstTable.SelectedItems[0].SubItems[2].Text;
                switch (lstTable.SelectedItems[0].SubItems[3].Text)
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
                tbxSession.Text = lstTable.SelectedItems[0].SubItems[4].Text;

            }
            else { return; }
        }

        public void GetAllTable()
        {

            lstTable.Items.Clear();
            using (SqlConnection connection = new SqlConnection(connString))
            {

                connection.Open();
                SqlDataReader reader = null;
                SqlCommand command = new SqlCommand("SELECT * from [Table] order by TableID", connection);
                reader = command.ExecuteReader();
                
                while (reader.Read())
                {

                    lstTable.Items.Add(new ListViewItem(new[] { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString() }));

                }
                reader.Close();
                connection.Close();

            }
        }
        public void GetAvailable()
        {
            lstTable.Items.Clear();
            using (SqlConnection connection = new SqlConnection(connString))
            {

                connection.Open();
                SqlDataReader reader = null;
                SqlCommand command = new SqlCommand("SELECT * from [Table] where [TableStatus] = 1 order by TableID", connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {

                    lstTable.Items.Add(new ListViewItem(new[] { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString() }));

                }
                reader.Close();
                connection.Close();

            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            GetAllTable();
        }

        private void btnAvaiable_Click(object sender, EventArgs e)
        {
            GetAvailable();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            cbxStatus.Checked = false;
            tbxDistance.Text = null;
            tbxID.Text = null;
            tbxNumber.Text = null;
            tbxSession.Text = null;
            if (lstTable.SelectedItems.Count > 0)
            {
                lstTable.SelectedItems[0].Selected = false;
            }
            else
            {
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbxDistance.Text == "" || tbxID.Text == "" || tbxNumber.Text == null)
            {
                MessageBox.Show("まだ記入してない所がある");
            }
            else
            {

                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("Update [Table] Set [TableNumber] = @TableNumber, [TableDistance] = @TableDistance, [TableStatus] = @TableStatus, [DetailID] = @DetailID WHERE [TableID] = @TableID", connection);
                    command.Parameters.AddWithValue("@TableNumber", tbxNumber.Text);
                    command.Parameters.AddWithValue("@TableDistance", tbxDistance.Text);
                    command.Parameters.AddWithValue("@TableStatus", cbxStatus.Checked);
                    command.Parameters.AddWithValue("@DetailID", tbxSession.Text);
                    command.Parameters.AddWithValue("@TableID", tbxID.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Done");
                    GetAllTable();
                    connection.Close();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbxDistance.Text == null  || tbxNumber.Text == null)
            {
                MessageBox.Show("まだ記入してない所がある");
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO [Table]([TableNumber],[TableDistance],[TableStatus],[DetailID]) VALUES (@TableNumber, @TableDistance, @TableStatus, @DetailID)", connection);
                    command.Parameters.AddWithValue("@TableNumber", tbxNumber.Text);
                    command.Parameters.AddWithValue("@TableDistance", tbxDistance.Text);
                    command.Parameters.AddWithValue("@TableStatus", cbxStatus.Checked);
                    command.Parameters.AddWithValue("@DetailID", tbxSession.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Done");
                    GetAllTable();
                    connection.Close();
                }
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to checkout? (お会計しても宜しいでしょうか？)", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                if (tbxSession.Text == null)
                {
                    return;
                }
                else
                {
                    using (SqlConnection connection = new SqlConnection(connString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("Update [Table] Set [TableStatus] = 'True', [DetailID] = NULL WHERE [TableID] = @TableID", connection);
                        command.Parameters.AddWithValue("TableID",tbxID.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Done");
                        GetAllTable();
                        connection.Close();
                    }
                    CheckOutFrm checkout = new CheckOutFrm(tbxSession.Text);
                    checkout.ShowDialog();
                }
            }
            if (res == DialogResult.Cancel)
            {
                return;
            }
            
        }
    }
}
