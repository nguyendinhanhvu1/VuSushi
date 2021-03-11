namespace SushiStore
{
    partial class ProductFrm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstCategory = new System.Windows.Forms.ListView();
            this.lstProduct = new System.Windows.Forms.ListView();
            this.txtProID = new System.Windows.Forms.TextBox();
            this.lblProdID = new System.Windows.Forms.Label();
            this.lblProdName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtProName = new System.Windows.Forms.TextBox();
            this.txtProdPrice = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddImg = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(662, 241);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 36);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstCategory
            // 
            this.lstCategory.FullRowSelect = true;
            this.lstCategory.HideSelection = false;
            this.lstCategory.Location = new System.Drawing.Point(12, 108);
            this.lstCategory.MultiSelect = false;
            this.lstCategory.Name = "lstCategory";
            this.lstCategory.Size = new System.Drawing.Size(255, 453);
            this.lstCategory.TabIndex = 2;
            this.lstCategory.UseCompatibleStateImageBehavior = false;
            this.lstCategory.View = System.Windows.Forms.View.Details;
            this.lstCategory.SelectedIndexChanged += new System.EventHandler(this.lstCategory_SelectedIndexChanged);
            // 
            // lstProduct
            // 
            this.lstProduct.FullRowSelect = true;
            this.lstProduct.HideSelection = false;
            this.lstProduct.Location = new System.Drawing.Point(301, 108);
            this.lstProduct.MultiSelect = false;
            this.lstProduct.Name = "lstProduct";
            this.lstProduct.Size = new System.Drawing.Size(293, 453);
            this.lstProduct.TabIndex = 3;
            this.lstProduct.UseCompatibleStateImageBehavior = false;
            this.lstProduct.View = System.Windows.Forms.View.Details;
            this.lstProduct.SelectedIndexChanged += new System.EventHandler(this.lstProduct_SelectedIndexChanged);
            // 
            // txtProID
            // 
            this.txtProID.Location = new System.Drawing.Point(759, 108);
            this.txtProID.Name = "txtProID";
            this.txtProID.ReadOnly = true;
            this.txtProID.Size = new System.Drawing.Size(211, 20);
            this.txtProID.TabIndex = 4;
            // 
            // lblProdID
            // 
            this.lblProdID.AutoSize = true;
            this.lblProdID.Location = new System.Drawing.Point(659, 111);
            this.lblProdID.Name = "lblProdID";
            this.lblProdID.Size = new System.Drawing.Size(61, 13);
            this.lblProdID.TabIndex = 5;
            this.lblProdID.Text = "Product ID:";
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Location = new System.Drawing.Point(659, 143);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(78, 13);
            this.lblProdName.TabIndex = 5;
            this.lblProdName.Text = "Product Name:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(659, 173);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(49, 13);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price (¥):";
            // 
            // txtProName
            // 
            this.txtProName.Location = new System.Drawing.Point(759, 140);
            this.txtProName.Name = "txtProName";
            this.txtProName.Size = new System.Drawing.Size(211, 20);
            this.txtProName.TabIndex = 4;
            // 
            // txtProdPrice
            // 
            this.txtProdPrice.Location = new System.Drawing.Point(759, 170);
            this.txtProdPrice.Name = "txtProdPrice";
            this.txtProdPrice.Size = new System.Drawing.Size(211, 20);
            this.txtProdPrice.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(1012, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddImg
            // 
            this.btnAddImg.Location = new System.Drawing.Point(1012, 301);
            this.btnAddImg.Name = "btnAddImg";
            this.btnAddImg.Size = new System.Drawing.Size(75, 23);
            this.btnAddImg.TabIndex = 7;
            this.btnAddImg.Text = "Add image";
            this.btnAddImg.UseVisualStyleBackColor = true;
            this.btnAddImg.Click += new System.EventHandler(this.btnAddImg_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(784, 241);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 36);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(895, 241);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 36);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(659, 206);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 13);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Available:";
            // 
            // cbxStatus
            // 
            this.cbxStatus.AutoSize = true;
            this.cbxStatus.Location = new System.Drawing.Point(955, 205);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(15, 14);
            this.cbxStatus.TabIndex = 9;
            this.cbxStatus.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 63);
            this.label1.TabIndex = 10;
            this.label1.Text = "商品管理";
            // 
            // ProductFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 582);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnAddImg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblProdName);
            this.Controls.Add(this.lblProdID);
            this.Controls.Add(this.txtProdPrice);
            this.Controls.Add(this.txtProName);
            this.Controls.Add(this.txtProID);
            this.Controls.Add(this.lstProduct);
            this.Controls.Add(this.lstCategory);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Name = "ProductFrm";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.ProductFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lstCategory;
        private System.Windows.Forms.ListView lstProduct;
        private System.Windows.Forms.TextBox txtProID;
        private System.Windows.Forms.Label lblProdID;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtProName;
        private System.Windows.Forms.TextBox txtProdPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddImg;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox cbxStatus;
        private System.Windows.Forms.Label label1;
    }
}