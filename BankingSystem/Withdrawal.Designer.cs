namespace BankingSystem
{
    partial class Withdrawal
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
            this.dashboard_Parent = new System.Windows.Forms.Panel();
            this.dashBoard_panel = new System.Windows.Forms.Panel();
            this.ExcuteDeposit = new System.Windows.Forms.Button();
            this.getDepositAmount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.CreationErr = new System.Windows.Forms.Label();
            this.dashboard_Parent.SuspendLayout();
            this.dashBoard_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getDepositAmount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashboard_Parent
            // 
            this.dashboard_Parent.Controls.Add(this.dashBoard_panel);
            this.dashboard_Parent.Controls.Add(this.CreationErr);
            this.dashboard_Parent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboard_Parent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard_Parent.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dashboard_Parent.ForeColor = System.Drawing.Color.White;
            this.dashboard_Parent.Location = new System.Drawing.Point(0, 0);
            this.dashboard_Parent.Name = "dashboard_Parent";
            this.dashboard_Parent.Size = new System.Drawing.Size(876, 684);
            this.dashboard_Parent.TabIndex = 3;
            // 
            // dashBoard_panel
            // 
            this.dashBoard_panel.Controls.Add(this.ExcuteDeposit);
            this.dashBoard_panel.Controls.Add(this.getDepositAmount);
            this.dashBoard_panel.Controls.Add(this.label4);
            this.dashBoard_panel.Controls.Add(this.panel1);
            this.dashBoard_panel.Controls.Add(this.groupBox1);
            this.dashBoard_panel.Controls.Add(this.panel8);
            this.dashBoard_panel.Location = new System.Drawing.Point(3, 85);
            this.dashBoard_panel.Name = "dashBoard_panel";
            this.dashBoard_panel.Size = new System.Drawing.Size(869, 592);
            this.dashBoard_panel.TabIndex = 21;
            // 
            // ExcuteDeposit
            // 
            this.ExcuteDeposit.BackColor = System.Drawing.Color.SeaGreen;
            this.ExcuteDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExcuteDeposit.Location = new System.Drawing.Point(686, 542);
            this.ExcuteDeposit.Name = "ExcuteDeposit";
            this.ExcuteDeposit.Size = new System.Drawing.Size(141, 46);
            this.ExcuteDeposit.TabIndex = 25;
            this.ExcuteDeposit.Text = "Withdrawal";
            this.ExcuteDeposit.UseVisualStyleBackColor = false;
            this.ExcuteDeposit.Click += new System.EventHandler(this.ExcuteDeposit_Click);
            // 
            // getDepositAmount
            // 
            this.getDepositAmount.DecimalPlaces = 2;
            this.getDepositAmount.Location = new System.Drawing.Point(290, 555);
            this.getDepositAmount.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.getDepositAmount.Name = "getDepositAmount";
            this.getDepositAmount.Size = new System.Drawing.Size(174, 34);
            this.getDepositAmount.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.label4.Location = new System.Drawing.Point(57, 561);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 28);
            this.label4.TabIndex = 23;
            this.label4.Text = "Deposit Amount";
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Location = new System.Drawing.Point(41, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 368);
            this.panel1.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(41, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 93);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(62, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(375, 42);
            this.label3.TabIndex = 0;
            this.label3.Text = "below are your Avalaible Account In our institute are:\r\n1. select the account you" +
    " wish to Withdraw From\r\n";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(41, 1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(786, 49);
            this.panel8.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(9, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 46);
            this.label2.TabIndex = 14;
            this.label2.Text = "Withdrawal";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CreationErr
            // 
            this.CreationErr.AutoSize = true;
            this.CreationErr.BackColor = System.Drawing.Color.Transparent;
            this.CreationErr.ForeColor = System.Drawing.Color.Red;
            this.CreationErr.Location = new System.Drawing.Point(122, 9);
            this.CreationErr.Name = "CreationErr";
            this.CreationErr.Size = new System.Drawing.Size(129, 28);
            this.CreationErr.TabIndex = 20;
            this.CreationErr.Text = "CreationError";
            this.CreationErr.Visible = false;
            // 
            // Withdrawal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 684);
            this.Controls.Add(this.dashboard_Parent);
            this.Name = "Withdrawal";
            this.Text = "Withdrawal";
            this.dashboard_Parent.ResumeLayout(false);
            this.dashboard_Parent.PerformLayout();
            this.dashBoard_panel.ResumeLayout(false);
            this.dashBoard_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getDepositAmount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel dashboard_Parent;
        public System.Windows.Forms.Panel dashBoard_panel;
        private System.Windows.Forms.Button ExcuteDeposit;
        private System.Windows.Forms.NumericUpDown getDepositAmount;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label CreationErr;
    }
}