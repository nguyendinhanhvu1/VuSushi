using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SushiStore
{
    public partial class CheckOutFrm : Form
    {
        string connString = ConfigurationManager.ConnectionStrings["con"].ToString();
        string DetailID;
        public CheckOutFrm(string DetailID)
        {
            InitializeComponent();
            this.DetailID = DetailID;
            UpdateReportData();
        }

        private void CheckOutFrm_Load(object sender, EventArgs e)
        {
            
        }

        void UpdateReportData()
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(@"SELECT        dbo.OrderDetail.DetailID, dbo.[Table].TableNumber, dbo.Staff.StaffName, dbo.Product.ProdName, dbo.[Order].OrdDate, dbo.[Order].ServedDate, dbo.[Order].Paid
FROM            dbo.[Order] INNER JOIN
                         dbo.OrderDetail ON dbo.[Order].OrderID = dbo.OrderDetail.OrderID INNER JOIN
                         dbo.Product ON dbo.[Order].ProdID = dbo.Product.ProdID INNER JOIN
                         dbo.Staff ON dbo.[Order].StaffID = dbo.Staff.StaffID INNER JOIN
                         dbo.[Table] ON dbo.OrderDetail.TableID = dbo.[Table].TableID
WHERE        (dbo.OrderDetail.DetailID = @DetailID)", connection);
                command.Parameters.AddWithValue("@DetailID", DetailID);
                DataSet dataReport = new DataSet();
                SqlDataAdapter sa = new SqlDataAdapter();
                sa.SelectCommand = command;
                sa.Fill(dataReport, "DataTable1");
                CheckoutReport myDataReport = new CheckoutReport();
                myDataReport.SetDataSource(dataReport);
                crystalReportViewer1.ReportSource = myDataReport;
                connection.Close();
            }
        }
    }
}
