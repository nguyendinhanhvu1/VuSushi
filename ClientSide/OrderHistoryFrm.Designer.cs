namespace ClientSide
{
    partial class OrderHistoryFrm
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
            this.lstOrderedItem = new System.Windows.Forms.ListView();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstOrderedItem
            // 
            this.lstOrderedItem.HideSelection = false;
            this.lstOrderedItem.Location = new System.Drawing.Point(22, 75);
            this.lstOrderedItem.Name = "lstOrderedItem";
            this.lstOrderedItem.Size = new System.Drawing.Size(760, 468);
            this.lstOrderedItem.TabIndex = 0;
            this.lstOrderedItem.UseCompatibleStateImageBehavior = false;
            this.lstOrderedItem.View = System.Windows.Forms.View.Details;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(837, 75);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 169);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = "Order History";
            // 
            // OrderHistoryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 555);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lstOrderedItem);
            this.Name = "OrderHistoryFrm";
            this.Text = "Order history";
            this.Load += new System.EventHandler(this.OrderHistoryFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstOrderedItem;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
    }
}