
namespace SushiStore
{
    partial class ReportFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnTopSellMonth = new System.Windows.Forms.Button();
            this.datePickFrom = new System.Windows.Forms.DateTimePicker();
            this.datePickTo = new System.Windows.Forms.DateTimePicker();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 12);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1080, 635);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // btnTopSellMonth
            // 
            this.btnTopSellMonth.Location = new System.Drawing.Point(1107, 72);
            this.btnTopSellMonth.Name = "btnTopSellMonth";
            this.btnTopSellMonth.Size = new System.Drawing.Size(200, 74);
            this.btnTopSellMonth.TabIndex = 1;
            this.btnTopSellMonth.Text = "Top Sell By Month";
            this.btnTopSellMonth.UseVisualStyleBackColor = true;
            this.btnTopSellMonth.Click += new System.EventHandler(this.button1_Click);
            // 
            // datePickFrom
            // 
            this.datePickFrom.Location = new System.Drawing.Point(1134, 12);
            this.datePickFrom.Name = "datePickFrom";
            this.datePickFrom.Size = new System.Drawing.Size(200, 20);
            this.datePickFrom.TabIndex = 2;
            // 
            // datePickTo
            // 
            this.datePickTo.Location = new System.Drawing.Point(1134, 38);
            this.datePickTo.Name = "datePickTo";
            this.datePickTo.Size = new System.Drawing.Size(200, 20);
            this.datePickTo.TabIndex = 3;
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(1098, 19);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(30, 13);
            this.fromLabel.TabIndex = 4;
            this.fromLabel.Text = "From";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(1098, 44);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(20, 13);
            this.toLabel.TabIndex = 4;
            this.toLabel.Text = "To";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1107, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 74);
            this.button1.TabIndex = 1;
            this.button1.Text = "Top Sell By Range";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ReportFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 659);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.datePickTo);
            this.Controls.Add(this.datePickFrom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTopSellMonth);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "ReportFrm";
            this.Text = "ReportFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btnTopSellMonth;
        private System.Windows.Forms.DateTimePicker datePickFrom;
        private System.Windows.Forms.DateTimePicker datePickTo;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Button button1;
    }
}