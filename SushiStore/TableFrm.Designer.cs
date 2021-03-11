namespace SushiStore
{
    partial class TableFrm
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
            this.lstTable = new System.Windows.Forms.ListView();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblSession = new System.Windows.Forms.Label();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.tbxNumber = new System.Windows.Forms.TextBox();
            this.tbxDistance = new System.Windows.Forms.TextBox();
            this.tbxSession = new System.Windows.Forms.TextBox();
            this.cbxStatus = new System.Windows.Forms.CheckBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnAvaiable = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstTable
            // 
            this.lstTable.FullRowSelect = true;
            this.lstTable.HideSelection = false;
            this.lstTable.Location = new System.Drawing.Point(12, 85);
            this.lstTable.Name = "lstTable";
            this.lstTable.Size = new System.Drawing.Size(494, 299);
            this.lstTable.TabIndex = 0;
            this.lstTable.UseCompatibleStateImageBehavior = false;
            this.lstTable.View = System.Windows.Forms.View.Details;
            this.lstTable.SelectedIndexChanged += new System.EventHandler(this.lstTable_SelectedIndexChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(519, 85);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(51, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Table ID:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(519, 111);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(77, 13);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "Table Number:";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(519, 135);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(66, 13);
            this.lblDistance.TabIndex = 1;
            this.lblDistance.Text = "Distance (s):";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(519, 166);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(68, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Table status:";
            // 
            // lblSession
            // 
            this.lblSession.AutoSize = true;
            this.lblSession.Location = new System.Drawing.Point(519, 192);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(82, 13);
            this.lblSession.TabIndex = 1;
            this.lblSession.Text = "Current session:";
            // 
            // tbxID
            // 
            this.tbxID.Location = new System.Drawing.Point(618, 82);
            this.tbxID.Name = "tbxID";
            this.tbxID.ReadOnly = true;
            this.tbxID.Size = new System.Drawing.Size(162, 20);
            this.tbxID.TabIndex = 2;
            // 
            // tbxNumber
            // 
            this.tbxNumber.Location = new System.Drawing.Point(618, 108);
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.Size = new System.Drawing.Size(162, 20);
            this.tbxNumber.TabIndex = 2;
            // 
            // tbxDistance
            // 
            this.tbxDistance.Location = new System.Drawing.Point(618, 136);
            this.tbxDistance.Name = "tbxDistance";
            this.tbxDistance.Size = new System.Drawing.Size(162, 20);
            this.tbxDistance.TabIndex = 2;
            // 
            // tbxSession
            // 
            this.tbxSession.Location = new System.Drawing.Point(618, 189);
            this.tbxSession.Name = "tbxSession";
            this.tbxSession.Size = new System.Drawing.Size(162, 20);
            this.tbxSession.TabIndex = 2;
            // 
            // cbxStatus
            // 
            this.cbxStatus.AutoSize = true;
            this.cbxStatus.Location = new System.Drawing.Point(765, 166);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(15, 14);
            this.cbxStatus.TabIndex = 3;
            this.cbxStatus.UseVisualStyleBackColor = true;
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(12, 400);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 23);
            this.btnAll.TabIndex = 4;
            this.btnAll.Text = "Show all";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnAvaiable
            // 
            this.btnAvaiable.Location = new System.Drawing.Point(411, 400);
            this.btnAvaiable.Name = "btnAvaiable";
            this.btnAvaiable.Size = new System.Drawing.Size(95, 23);
            this.btnAvaiable.TabIndex = 4;
            this.btnAvaiable.Text = "Available only";
            this.btnAvaiable.UseVisualStyleBackColor = true;
            this.btnAvaiable.Click += new System.EventHandler(this.btnAvaiable_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(797, 106);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(797, 80);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(797, 134);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(705, 215);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(75, 44);
            this.btnCheckout.TabIndex = 7;
            this.btnCheckout.Text = "Check Out";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 63);
            this.label1.TabIndex = 8;
            this.label1.Text = "テーブル状態";
            // 
            // TableFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 454);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAvaiable);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.tbxSession);
            this.Controls.Add(this.tbxDistance);
            this.Controls.Add(this.tbxNumber);
            this.Controls.Add(this.tbxID);
            this.Controls.Add(this.lblSession);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lstTable);
            this.Name = "TableFrm";
            this.Text = "Table";
            this.Load += new System.EventHandler(this.TableFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstTable;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblSession;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.TextBox tbxNumber;
        private System.Windows.Forms.TextBox tbxDistance;
        private System.Windows.Forms.TextBox tbxSession;
        private System.Windows.Forms.CheckBox cbxStatus;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnAvaiable;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label label1;
    }
}