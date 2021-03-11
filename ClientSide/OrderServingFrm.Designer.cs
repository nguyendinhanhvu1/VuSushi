namespace ClientSide
{
    partial class OrderServingFrm
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
            this.lstServing = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstServing
            // 
            this.lstServing.HideSelection = false;
            this.lstServing.Location = new System.Drawing.Point(12, 201);
            this.lstServing.MultiSelect = false;
            this.lstServing.Name = "lstServing";
            this.lstServing.Size = new System.Drawing.Size(1179, 423);
            this.lstServing.TabIndex = 0;
            this.lstServing.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(720, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "忘れないで商品をお取りください❕";
            // 
            // OrderServingFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 636);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstServing);
            this.Name = "OrderServingFrm";
            this.Text = "Incoming order";
            this.Load += new System.EventHandler(this.OrderServingFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstServing;
        private System.Windows.Forms.Label label1;
    }
}