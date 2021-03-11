using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SushiStore
{
    public partial class Form1 : Form
    {
        public string StaffID;
        public string Staffname;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblName.Text = Staffname;
            if (Staffname == "Nguyen Dinh Anh Vu")
            {
                btnUserMng.Enabled = true;
                btnReport.Enabled = true;
                btnProduct.Enabled = true;
            }
            else 
            {
                btnUserMng.Enabled = false;
                btnReport.Enabled = false;
                btnProduct.Enabled = false;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUserMng_Click(object sender, EventArgs e)
        {
            UserMngFrm userform = new UserMngFrm();
            userform.ShowDialog();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductFrm productfrm = new ProductFrm();
            productfrm.ShowDialog();
        }

        private void btnOrderlist_Click(object sender, EventArgs e)
        {
            OrderFrm form = new OrderFrm(StaffID);
            form.ShowDialog();
        }

        private void btnTablemanager_Click(object sender, EventArgs e)
        {
            TableFrm form = new TableFrm();
            form.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportFrm form = new ReportFrm();
            form.ShowDialog();
        }
    }
}
