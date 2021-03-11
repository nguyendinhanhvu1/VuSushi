namespace SushiStore
{
    partial class OrderFrm
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
            this.lstOrder = new System.Windows.Forms.ListView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblTableName = new System.Windows.Forms.Label();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.txtProdID = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProdname = new System.Windows.Forms.TextBox();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.txtOrderdate = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnServed = new System.Windows.Forms.Button();
            this.lblTableDis = new System.Windows.Forms.Label();
            this.txtTabledis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstOrder
            // 
            this.lstOrder.FullRowSelect = true;
            this.lstOrder.HideSelection = false;
            this.lstOrder.Location = new System.Drawing.Point(12, 88);
            this.lstOrder.MultiSelect = false;
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(638, 442);
            this.lstOrder.TabIndex = 0;
            this.lstOrder.UseCompatibleStateImageBehavior = false;
            this.lstOrder.View = System.Windows.Forms.View.Details;
            this.lstOrder.SelectedIndexChanged += new System.EventHandler(this.lstOrder_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 536);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(638, 53);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Location = new System.Drawing.Point(692, 91);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(68, 13);
            this.lblTableName.TabIndex = 2;
            this.lblTableName.Text = "Table Name:";
            // 
            // txtTable
            // 
            this.txtTable.Location = new System.Drawing.Point(802, 88);
            this.txtTable.Name = "txtTable";
            this.txtTable.ReadOnly = true;
            this.txtTable.Size = new System.Drawing.Size(190, 20);
            this.txtTable.TabIndex = 3;
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(692, 117);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(50, 13);
            this.lblOrderID.TabIndex = 2;
            this.lblOrderID.Text = "Order ID:";
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(802, 114);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.ReadOnly = true;
            this.txtOrder.Size = new System.Drawing.Size(190, 20);
            this.txtOrder.TabIndex = 3;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(692, 143);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(61, 13);
            this.lblProductID.TabIndex = 2;
            this.lblProductID.Text = "Product ID:";
            // 
            // txtProdID
            // 
            this.txtProdID.Location = new System.Drawing.Point(802, 140);
            this.txtProdID.Name = "txtProdID";
            this.txtProdID.ReadOnly = true;
            this.txtProdID.Size = new System.Drawing.Size(190, 20);
            this.txtProdID.TabIndex = 3;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(692, 169);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(78, 13);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Product Name:";
            // 
            // txtProdname
            // 
            this.txtProdname.Location = new System.Drawing.Point(802, 166);
            this.txtProdname.Name = "txtProdname";
            this.txtProdname.ReadOnly = true;
            this.txtProdname.Size = new System.Drawing.Size(190, 20);
            this.txtProdname.TabIndex = 3;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(692, 195);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(62, 13);
            this.lblOrderDate.TabIndex = 2;
            this.lblOrderDate.Text = "Order Date:";
            // 
            // txtOrderdate
            // 
            this.txtOrderdate.Location = new System.Drawing.Point(802, 192);
            this.txtOrderdate.Name = "txtOrderdate";
            this.txtOrderdate.ReadOnly = true;
            this.txtOrderdate.Size = new System.Drawing.Size(190, 20);
            this.txtOrderdate.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(917, 272);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnServed
            // 
            this.btnServed.Location = new System.Drawing.Point(695, 272);
            this.btnServed.Name = "btnServed";
            this.btnServed.Size = new System.Drawing.Size(75, 23);
            this.btnServed.TabIndex = 5;
            this.btnServed.Text = "Order";
            this.btnServed.UseVisualStyleBackColor = true;
            this.btnServed.Click += new System.EventHandler(this.btnServed_Click);
            // 
            // lblTableDis
            // 
            this.lblTableDis.AutoSize = true;
            this.lblTableDis.Location = new System.Drawing.Point(692, 221);
            this.lblTableDis.Name = "lblTableDis";
            this.lblTableDis.Size = new System.Drawing.Size(82, 13);
            this.lblTableDis.TabIndex = 2;
            this.lblTableDis.Text = "Table Distance:";
            // 
            // txtTabledis
            // 
            this.txtTabledis.Location = new System.Drawing.Point(802, 218);
            this.txtTabledis.Name = "txtTabledis";
            this.txtTabledis.ReadOnly = true;
            this.txtTabledis.Size = new System.Drawing.Size(190, 20);
            this.txtTabledis.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 63);
            this.label1.TabIndex = 9;
            this.label1.Text = "オーダー管理";
            // 
            // OrderFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 601);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnServed);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtTabledis);
            this.Controls.Add(this.lblTableDis);
            this.Controls.Add(this.txtOrderdate);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.txtProdname);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.txtProdID);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.txtTable);
            this.Controls.Add(this.lblTableName);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lstOrder);
            this.Name = "OrderFrm";
            this.Text = "Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstOrder;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox txtProdID;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProdname;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.TextBox txtOrderdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnServed;
        private System.Windows.Forms.Label lblTableDis;
        private System.Windows.Forms.TextBox txtTabledis;
        private System.Windows.Forms.Label label1;
    }
}