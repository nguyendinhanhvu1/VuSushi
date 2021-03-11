namespace ClientSide
{
    partial class MainFrm
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
            this.lblTableID = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblSession = new System.Windows.Forms.Label();
            this.lblSessionID = new System.Windows.Forms.Label();
            this.lstProduct = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.lstOrder = new System.Windows.Forms.ListView();
            this.button11 = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTableID
            // 
            this.lblTableID.AutoSize = true;
            this.lblTableID.Location = new System.Drawing.Point(13, 13);
            this.lblTableID.Name = "lblTableID";
            this.lblTableID.Size = new System.Drawing.Size(51, 13);
            this.lblTableID.TabIndex = 0;
            this.lblTableID.Text = "Table ID:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(70, 13);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblSession
            // 
            this.lblSession.AutoSize = true;
            this.lblSession.Location = new System.Drawing.Point(160, 13);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(82, 13);
            this.lblSession.TabIndex = 0;
            this.lblSession.Text = "Current session:";
            // 
            // lblSessionID
            // 
            this.lblSessionID.AutoSize = true;
            this.lblSessionID.Location = new System.Drawing.Point(248, 13);
            this.lblSessionID.Name = "lblSessionID";
            this.lblSessionID.Size = new System.Drawing.Size(18, 13);
            this.lblSessionID.TabIndex = 0;
            this.lblSessionID.Text = "ID";
            // 
            // lstProduct
            // 
            this.lstProduct.HideSelection = false;
            this.lstProduct.Location = new System.Drawing.Point(16, 85);
            this.lstProduct.MultiSelect = false;
            this.lstProduct.Name = "lstProduct";
            this.lstProduct.Size = new System.Drawing.Size(817, 533);
            this.lstProduct.TabIndex = 1;
            this.lstProduct.UseCompatibleStateImageBehavior = false;
            this.lstProduct.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstProduct_ItemSelectionChanged);
            this.lstProduct.SelectedIndexChanged += new System.EventHandler(this.lstProduct_SelectedIndexChanged);
            this.lstProduct.Click += new System.EventHandler(this.lstProduct_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Nigiri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(97, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Limited time";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(178, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Tempura";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(259, 56);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Cheese - Mayo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(353, 56);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Meat";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(434, 56);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 2;
            this.button6.Text = "Gunkan";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(515, 56);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 2;
            this.button7.Text = "Scroll";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(596, 56);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 2;
            this.button8.Text = "Desert";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(677, 56);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 2;
            this.button9.Text = "Drink";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(758, 56);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 2;
            this.button10.Text = "Side menu";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // lstOrder
            // 
            this.lstOrder.HideSelection = false;
            this.lstOrder.Location = new System.Drawing.Point(913, 85);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(366, 533);
            this.lstOrder.TabIndex = 3;
            this.lstOrder.UseCompatibleStateImageBehavior = false;
            this.lstOrder.View = System.Windows.Forms.View.Details;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(16, 27);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(817, 23);
            this.button11.TabIndex = 4;
            this.button11.Text = "All Product";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(1301, 85);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(123, 123);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Location = new System.Drawing.Point(1301, 214);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(123, 123);
            this.btnHistory.TabIndex = 5;
            this.btnHistory.Text = "Order history";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(1301, 343);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(123, 123);
            this.btnCheckout.TabIndex = 5;
            this.btnCheckout.Text = "Check Out";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 637);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.lstOrder);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstProduct);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblSessionID);
            this.Controls.Add(this.lblSession);
            this.Controls.Add(this.lblTableID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainFrm";
            this.Text = "Vu Sushi";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTableID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblSession;
        private System.Windows.Forms.Label lblSessionID;
        private System.Windows.Forms.ListView lstProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ListView lstOrder;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnCheckout;
    }
}