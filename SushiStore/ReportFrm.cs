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
    public partial class ReportFrm : Form
    {
        string connString = ConfigurationManager.ConnectionStrings["con"].ToString();
        public ReportFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(@"SELECT        TOP (100) PERCENT COUNT(dbo.[Order].OrderID) AS [Doanh so], dbo.Product.ProdID AS Expr1, dbo.Product.ProdName, MONTH(dbo.[Order].OrdDate) AS Thang
FROM            dbo.Product INNER JOIN
                         dbo.[Order] ON dbo.Product.ProdID = dbo.[Order].ProdID
WHERE        (dbo.[Order].OrdDate BETWEEN @FromDate AND @ToDate)
GROUP BY dbo.Product.ProdID, dbo.Product.ProdName, MONTH(dbo.[Order].OrdDate)
ORDER BY [Doanh so] DESC, Thang DESC", connection);
                command.Parameters.AddWithValue("@FromDate", datePickFrom.Value);
                command.Parameters.AddWithValue("@ToDate", datePickTo.Value);
                DataSet dataReport = new DataSet();
                SqlDataAdapter sa = new SqlDataAdapter();
                sa.SelectCommand = command;
                sa.Fill(dataReport, "Product");
                TopSellByMonthReport myDataReport = new TopSellByMonthReport();
                myDataReport.SetDataSource(dataReport);
                crystalReportViewer1.ReportSource = myDataReport;
                connection.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(@"SELECT        TOP (100) PERCENT COUNT(dbo.[Order].OrderID) AS [Doanh so], dbo.Product.ProdID AS ID, dbo.Product.ProdName, DAY(dbo.[Order].OrdDate) AS NGAY, MONTH(dbo.[Order].OrdDate) AS THANG
FROM            dbo.Product INNER JOIN
                         dbo.[Order] ON dbo.Product.ProdID = dbo.[Order].ProdID
WHERE        (dbo.[Order].OrdDate BETWEEN @FromDate AND @ToDate)
GROUP BY dbo.Product.ProdID, dbo.Product.ProdName, DAY(dbo.[Order].OrdDate), MONTH(dbo.[Order].OrdDate)
ORDER BY [Doanh so] DESC", connection);
                command.Parameters.AddWithValue("@FromDate", datePickFrom.Value);
                command.Parameters.AddWithValue("@ToDate", datePickTo.Value);
                DataSet dataReport = new DataSet();
                SqlDataAdapter sa = new SqlDataAdapter();
                sa.SelectCommand = command;
                sa.Fill(dataReport, "Product");
                TopSellByDay myDataReport = new TopSellByDay();
                myDataReport.SetDataSource(dataReport);
                crystalReportViewer1.ReportSource = myDataReport;
                connection.Close();
            }
        }
    }
}
