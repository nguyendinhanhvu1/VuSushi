namespace ClientSide
{
    partial class StartFrm
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
            this.cbxTable = new System.Windows.Forms.ComboBox();
            this.lblTable = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnUnlock = new System.Windows.Forms.Button();
            this.btnLock = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxTable
            // 
            this.cbxTable.Enabled = false;
            this.cbxTable.FormattingEnabled = true;
            this.cbxTable.Location = new System.Drawing.Point(55, 6);
            this.cbxTable.Name = "cbxTable";
            this.cbxTable.Size = new System.Drawing.Size(121, 21);
            this.cbxTable.TabIndex = 0;
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(12, 9);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(37, 13);
            this.lblTable.TabIndex = 1;
            this.lblTable.Text = "Table:";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(15, 44);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(1320, 549);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start (開始)";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnUnlock
            // 
            this.btnUnlock.Location = new System.Drawing.Point(195, 4);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(75, 23);
            this.btnUnlock.TabIndex = 3;
            this.btnUnlock.Text = "Unlock";
            this.btnUnlock.UseVisualStyleBackColor = true;
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click);
            // 
            // btnLock
            // 
            this.btnLock.Location = new System.Drawing.Point(276, 4);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(75, 23);
            this.btnLock.TabIndex = 4;
            this.btnLock.Text = "Lock";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1260, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StartFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 605);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.btnUnlock);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.cbxTable);
            this.Name = "StartFrm";
            this.Text = "Welcome to Vu Sushi!";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTable;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Button btnStart;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnUnlock;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Button button1;
    }
}

