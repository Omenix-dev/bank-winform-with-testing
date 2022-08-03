namespace BankingSystem
{
    partial class CreateAccount
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Print_butt = new System.Windows.Forms.Button();
            this.Transfer_butt = new System.Windows.Forms.Button();
            this.Withdraw_butt = new System.Windows.Forms.Button();
            this.Deposit_butt = new System.Windows.Forms.Button();
            this.Create_butt = new System.Windows.Forms.Button();
            this.Dash_butt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Username = new System.Windows.Forms.Label();
            this.dashboard_Parent = new System.Windows.Forms.Panel();
            this.dashBoard_panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.CreationAmount = new System.Windows.Forms.NumericUpDown();
            this.createButt = new System.Windows.Forms.Button();
            this.Savings_Account = new System.Windows.Forms.RadioButton();
            this.Current_Account = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.CreationErr = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.dashboard_Parent.SuspendLayout();
            this.dashBoard_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreationAmount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.36199F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.63801F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dashboard_Parent, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1105, 749);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.Print_butt);
            this.panel1.Controls.Add(this.Transfer_butt);
            this.panel1.Controls.Add(this.Withdraw_butt);
            this.panel1.Controls.Add(this.Deposit_butt);
            this.panel1.Controls.Add(this.Create_butt);
            this.panel1.Controls.Add(this.Dash_butt);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 743);
            this.panel1.TabIndex = 0;
            // 
            // Print_butt
            // 
            this.Print_butt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Print_butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Print_butt.FlatAppearance.BorderSize = 0;
            this.Print_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Print_butt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Print_butt.ForeColor = System.Drawing.Color.White;
            this.Print_butt.Location = new System.Drawing.Point(-3, 634);
            this.Print_butt.Name = "Print_butt";
            this.Print_butt.Size = new System.Drawing.Size(228, 53);
            this.Print_butt.TabIndex = 6;
            this.Print_butt.Text = "Print statement";
            this.Print_butt.UseVisualStyleBackColor = false;
            this.Print_butt.Click += new System.EventHandler(this.Print_butt_Click);
            // 
            // Transfer_butt
            // 
            this.Transfer_butt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Transfer_butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Transfer_butt.FlatAppearance.BorderSize = 0;
            this.Transfer_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Transfer_butt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Transfer_butt.ForeColor = System.Drawing.Color.White;
            this.Transfer_butt.Location = new System.Drawing.Point(-3, 537);
            this.Transfer_butt.Name = "Transfer_butt";
            this.Transfer_butt.Size = new System.Drawing.Size(228, 53);
            this.Transfer_butt.TabIndex = 5;
            this.Transfer_butt.Text = "Transfer";
            this.Transfer_butt.UseVisualStyleBackColor = false;
            this.Transfer_butt.Click += new System.EventHandler(this.Transfer_butt_Click);
            // 
            // Withdraw_butt
            // 
            this.Withdraw_butt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Withdraw_butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Withdraw_butt.FlatAppearance.BorderSize = 0;
            this.Withdraw_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Withdraw_butt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Withdraw_butt.ForeColor = System.Drawing.Color.White;
            this.Withdraw_butt.Location = new System.Drawing.Point(-3, 451);
            this.Withdraw_butt.Name = "Withdraw_butt";
            this.Withdraw_butt.Size = new System.Drawing.Size(228, 53);
            this.Withdraw_butt.TabIndex = 4;
            this.Withdraw_butt.Text = "withdraw";
            this.Withdraw_butt.UseVisualStyleBackColor = false;
            this.Withdraw_butt.Click += new System.EventHandler(this.Withdraw_butt_Click);
            // 
            // Deposit_butt
            // 
            this.Deposit_butt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Deposit_butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Deposit_butt.FlatAppearance.BorderSize = 0;
            this.Deposit_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deposit_butt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Deposit_butt.ForeColor = System.Drawing.Color.White;
            this.Deposit_butt.Location = new System.Drawing.Point(-3, 370);
            this.Deposit_butt.Name = "Deposit_butt";
            this.Deposit_butt.Size = new System.Drawing.Size(228, 53);
            this.Deposit_butt.TabIndex = 3;
            this.Deposit_butt.Text = "Deposit";
            this.Deposit_butt.UseVisualStyleBackColor = false;
            this.Deposit_butt.Click += new System.EventHandler(this.Deposit_butt_Click);
            // 
            // Create_butt
            // 
            this.Create_butt.BackColor = System.Drawing.Color.White;
            this.Create_butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Create_butt.FlatAppearance.BorderSize = 0;
            this.Create_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Create_butt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Create_butt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Create_butt.Location = new System.Drawing.Point(-3, 286);
            this.Create_butt.Name = "Create_butt";
            this.Create_butt.Size = new System.Drawing.Size(228, 53);
            this.Create_butt.TabIndex = 2;
            this.Create_butt.Text = "Create Account";
            this.Create_butt.UseVisualStyleBackColor = false;
            this.Create_butt.Click += new System.EventHandler(this.Create_butt_Click);
            // 
            // Dash_butt
            // 
            this.Dash_butt.BackColor = System.Drawing.Color.Transparent;
            this.Dash_butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dash_butt.FlatAppearance.BorderSize = 0;
            this.Dash_butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dash_butt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Dash_butt.ForeColor = System.Drawing.Color.White;
            this.Dash_butt.Location = new System.Drawing.Point(-3, 205);
            this.Dash_butt.Name = "Dash_butt";
            this.Dash_butt.Size = new System.Drawing.Size(228, 53);
            this.Dash_butt.TabIndex = 1;
            this.Dash_butt.Text = "DashBoard";
            this.Dash_butt.UseVisualStyleBackColor = false;
            this.Dash_butt.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BankingSystem.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(36, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Username.Font = new System.Drawing.Font("Simple Outline Pat", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Username.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Username.Location = new System.Drawing.Point(9, 162);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(189, 24);
            this.Username.TabIndex = 1;
            this.Username.Text = "Welcome Omeni saviour";
            // 
            // dashboard_Parent
            // 
            this.dashboard_Parent.Controls.Add(this.dashBoard_panel);
            this.dashboard_Parent.Controls.Add(this.CreationErr);
            this.dashboard_Parent.Controls.Add(this.Logout);
            this.dashboard_Parent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboard_Parent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard_Parent.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dashboard_Parent.ForeColor = System.Drawing.Color.White;
            this.dashboard_Parent.Location = new System.Drawing.Point(227, 3);
            this.dashboard_Parent.Name = "dashboard_Parent";
            this.dashboard_Parent.Size = new System.Drawing.Size(875, 743);
            this.dashboard_Parent.TabIndex = 1;
            this.dashboard_Parent.Paint += new System.Windows.Forms.PaintEventHandler(this.dashboard_butt_Paint);
            // 
            // dashBoard_panel
            // 
            this.dashBoard_panel.Controls.Add(this.label4);
            this.dashBoard_panel.Controls.Add(this.CreationAmount);
            this.dashBoard_panel.Controls.Add(this.createButt);
            this.dashBoard_panel.Controls.Add(this.Savings_Account);
            this.dashBoard_panel.Controls.Add(this.Current_Account);
            this.dashBoard_panel.Controls.Add(this.groupBox1);
            this.dashBoard_panel.Controls.Add(this.panel8);
            this.dashBoard_panel.Location = new System.Drawing.Point(3, 102);
            this.dashBoard_panel.Name = "dashBoard_panel";
            this.dashBoard_panel.Size = new System.Drawing.Size(869, 592);
            this.dashBoard_panel.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(59, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 32);
            this.label4.TabIndex = 26;
            this.label4.Text = "Deposit Money";
            // 
            // CreationAmount
            // 
            this.CreationAmount.DecimalPlaces = 2;
            this.CreationAmount.Location = new System.Drawing.Point(255, 435);
            this.CreationAmount.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.CreationAmount.Name = "CreationAmount";
            this.CreationAmount.Size = new System.Drawing.Size(120, 34);
            this.CreationAmount.TabIndex = 25;
            // 
            // createButt
            // 
            this.createButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.createButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButt.Location = new System.Drawing.Point(177, 521);
            this.createButt.Name = "createButt";
            this.createButt.Size = new System.Drawing.Size(575, 51);
            this.createButt.TabIndex = 24;
            this.createButt.Text = "Create Account";
            this.createButt.UseVisualStyleBackColor = false;
            this.createButt.Click += new System.EventHandler(this.createButt_Click);
            // 
            // Savings_Account
            // 
            this.Savings_Account.AutoSize = true;
            this.Savings_Account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savings_Account.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Savings_Account.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Savings_Account.Location = new System.Drawing.Point(59, 368);
            this.Savings_Account.Name = "Savings_Account";
            this.Savings_Account.Size = new System.Drawing.Size(206, 36);
            this.Savings_Account.TabIndex = 23;
            this.Savings_Account.TabStop = true;
            this.Savings_Account.Text = "Savings Account";
            this.Savings_Account.UseVisualStyleBackColor = true;
            this.Savings_Account.Click += new System.EventHandler(this.Savings_Account_Click);
            // 
            // Current_Account
            // 
            this.Current_Account.AutoSize = true;
            this.Current_Account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Current_Account.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Current_Account.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Current_Account.Location = new System.Drawing.Point(59, 302);
            this.Current_Account.Name = "Current_Account";
            this.Current_Account.Size = new System.Drawing.Size(205, 36);
            this.Current_Account.TabIndex = 22;
            this.Current_Account.TabStop = true;
            this.Current_Account.Text = "Current Account";
            this.Current_Account.UseVisualStyleBackColor = true;
            this.Current_Account.Click += new System.EventHandler(this.Current_Account_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(57, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 181);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(62, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(562, 105);
            this.label3.TabIndex = 0;
            this.label3.Text = "the Avalaible Account In our institute are:\r\n\r\n1.  Current Account: this account " +
    "can be created with little or no amount\r\n\r\n2. Savings Account: this Account must" +
    " be created with a minimum of #1000.00K";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(41, 8);
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
            this.label2.Size = new System.Drawing.Size(367, 46);
            this.label2.TabIndex = 14;
            this.label2.Text = "Create Account section";
            // 
            // CreationErr
            // 
            this.CreationErr.AutoSize = true;
            this.CreationErr.BackColor = System.Drawing.Color.Transparent;
            this.CreationErr.ForeColor = System.Drawing.Color.Red;
            this.CreationErr.Location = new System.Drawing.Point(121, 9);
            this.CreationErr.Name = "CreationErr";
            this.CreationErr.Size = new System.Drawing.Size(129, 28);
            this.CreationErr.TabIndex = 20;
            this.CreationErr.Text = "CreationError";
            this.CreationErr.Visible = false;
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.Transparent;
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Logout.Location = new System.Drawing.Point(754, 9);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(90, 36);
            this.Logout.TabIndex = 0;
            this.Logout.Text = "Log out";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 749);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(1121, 788);
            this.MinimumSize = new System.Drawing.Size(1121, 766);
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateAccount";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateAccount_FormClosed);
            this.Load += new System.EventHandler(this.CreateAccount_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.dashboard_Parent.ResumeLayout(false);
            this.dashboard_Parent.PerformLayout();
            this.dashBoard_panel.ResumeLayout(false);
            this.dashBoard_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CreationAmount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Print_butt;
        private System.Windows.Forms.Button Transfer_butt;
        private System.Windows.Forms.Button Withdraw_butt;
        private System.Windows.Forms.Button Deposit_butt;
        private System.Windows.Forms.Button Create_butt;
        private System.Windows.Forms.Button Dash_butt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label CreationErr;
        private System.Windows.Forms.Panel dashBoard_panel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown CreationAmount;
        private System.Windows.Forms.Button createButt;
        private System.Windows.Forms.RadioButton Savings_Account;
        private System.Windows.Forms.RadioButton Current_Account;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button Logout;
        public System.Windows.Forms.Panel dashboard_Parent;
    }
}