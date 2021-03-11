namespace SushiStore
{
    partial class Form1
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnUserMng = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnOrderlist = new System.Windows.Forms.Button();
            this.btnTablemanager = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(12, 13);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(55, 13);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(73, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(622, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 120);
            this.button2.TabIndex = 3;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUserMng
            // 
            this.btnUserMng.Location = new System.Drawing.Point(372, 50);
            this.btnUserMng.Name = "btnUserMng";
            this.btnUserMng.Size = new System.Drawing.Size(98, 120);
            this.btnUserMng.TabIndex = 4;
            this.btnUserMng.Text = "User Manager";
            this.btnUserMng.UseVisualStyleBackColor = true;
            this.btnUserMng.Click += new System.EventHandler(this.btnUserMng_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(251, 50);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(98, 120);
            this.btnProduct.TabIndex = 5;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnOrderlist
            // 
            this.btnOrderlist.Location = new System.Drawing.Point(133, 50);
            this.btnOrderlist.Name = "btnOrderlist";
            this.btnOrderlist.Size = new System.Drawing.Size(98, 120);
            this.btnOrderlist.TabIndex = 6;
            this.btnOrderlist.Text = "Order list";
            this.btnOrderlist.UseVisualStyleBackColor = true;
            this.btnOrderlist.Click += new System.EventHandler(this.btnOrderlist_Click);
            // 
            // btnTablemanager
            // 
            this.btnTablemanager.Location = new System.Drawing.Point(15, 50);
            this.btnTablemanager.Name = "btnTablemanager";
            this.btnTablemanager.Size = new System.Drawing.Size(98, 120);
            this.btnTablemanager.TabIndex = 7;
            this.btnTablemanager.Text = "Table Manager";
            this.btnTablemanager.UseVisualStyleBackColor = true;
            this.btnTablemanager.Click += new System.EventHandler(this.btnTablemanager_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(494, 50);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(98, 120);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnUserMng_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 236);
            this.Controls.Add(this.btnTablemanager);
            this.Controls.Add(this.btnOrderlist);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnUserMng);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUserMng;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnOrderlist;
        private System.Windows.Forms.Button btnTablemanager;
        private System.Windows.Forms.Button btnReport;
    }
}

