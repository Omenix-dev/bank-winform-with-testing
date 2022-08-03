namespace BankingSystem
{
    partial class Register
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Fname = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this._Lname = new System.Windows.Forms.TextBox();
            this.Re_type = new System.Windows.Forms.TextBox();
            this.Sign_up = new System.Windows.Forms.Button();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Female = new System.Windows.Forms.RadioButton();
            this.fNamErr = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.EmailErr = new System.Windows.Forms.Label();
            this.PassErr = new System.Windows.Forms.Label();
            this.RetypeErr = new System.Windows.Forms.Label();
            this.GenderErr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BankingSystem.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(199, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 123);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(171, 167);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(191, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Register your Details";
            // 
            // Fname
            // 
            this.Fname.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Fname.Location = new System.Drawing.Point(51, 228);
            this.Fname.Multiline = true;
            this.Fname.Name = "Fname";
            this.Fname.PlaceholderText = "  First Name";
            this.Fname.Size = new System.Drawing.Size(204, 48);
            this.Fname.TabIndex = 3;
            this.Fname.Enter += new System.EventHandler(this.Fname_Enter);
            this.Fname.Leave += new System.EventHandler(this.Fname_Leave);
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Email.Location = new System.Drawing.Point(51, 306);
            this.Email.Multiline = true;
            this.Email.Name = "Email";
            this.Email.PlaceholderText = "  Email@email.com";
            this.Email.Size = new System.Drawing.Size(426, 48);
            this.Email.TabIndex = 4;
            this.Email.Enter += new System.EventHandler(this.Email_Enter);
            this.Email.Leave += new System.EventHandler(this.Email_Leave);
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password.Location = new System.Drawing.Point(51, 384);
            this.Password.MaxLength = 14;
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.PlaceholderText = "  Password";
            this.Password.Size = new System.Drawing.Size(426, 48);
            this.Password.TabIndex = 5;
            this.Password.Enter += new System.EventHandler(this.Password_Enter);
            this.Password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // _Lname
            // 
            this._Lname.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._Lname.Location = new System.Drawing.Point(273, 228);
            this._Lname.Multiline = true;
            this._Lname.Name = "_Lname";
            this._Lname.PlaceholderText = "  Last Name";
            this._Lname.Size = new System.Drawing.Size(204, 48);
            this._Lname.TabIndex = 6;
            this._Lname.Enter += new System.EventHandler(this._Lname_Enter);
            this._Lname.Leave += new System.EventHandler(this._Lname_Leave);
            // 
            // Re_type
            // 
            this.Re_type.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Re_type.Location = new System.Drawing.Point(51, 463);
            this.Re_type.Multiline = true;
            this.Re_type.Name = "Re_type";
            this.Re_type.PasswordChar = '*';
            this.Re_type.PlaceholderText = "  Retype Password";
            this.Re_type.Size = new System.Drawing.Size(426, 48);
            this.Re_type.TabIndex = 7;
            this.Re_type.Enter += new System.EventHandler(this.Re_type_Enter);
            this.Re_type.Leave += new System.EventHandler(this.Re_type_Leave);
            // 
            // Sign_up
            // 
            this.Sign_up.Font = new System.Drawing.Font("Swis721 BlkCn BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sign_up.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Sign_up.Location = new System.Drawing.Point(171, 593);
            this.Sign_up.Name = "Sign_up";
            this.Sign_up.Size = new System.Drawing.Size(175, 50);
            this.Sign_up.TabIndex = 8;
            this.Sign_up.Text = "Sign up";
            this.Sign_up.UseVisualStyleBackColor = true;
            this.Sign_up.Click += new System.EventHandler(this.Sign_up_Click);
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Male.Location = new System.Drawing.Point(51, 526);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(62, 25);
            this.Male.TabIndex = 9;
            this.Male.TabStop = true;
            this.Male.Text = "male";
            this.Male.UseVisualStyleBackColor = true;
            this.Male.Click += new System.EventHandler(this.Male_Click);
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Female.Location = new System.Drawing.Point(171, 526);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(78, 25);
            this.Female.TabIndex = 10;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            this.Female.Click += new System.EventHandler(this.Female_Click);
            // 
            // fNamErr
            // 
            this.fNamErr.AutoEllipsis = true;
            this.fNamErr.AutoSize = true;
            this.fNamErr.ForeColor = System.Drawing.Color.Red;
            this.fNamErr.Location = new System.Drawing.Point(51, 210);
            this.fNamErr.Name = "fNamErr";
            this.fNamErr.Size = new System.Drawing.Size(51, 15);
            this.fNamErr.TabIndex = 11;
            this.fNamErr.Text = "fNamErr";
            this.fNamErr.Visible = false;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.ForeColor = System.Drawing.Color.Red;
            this.lName.Location = new System.Drawing.Point(275, 210);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(42, 15);
            this.lName.TabIndex = 12;
            this.lName.Text = "lName";
            this.lName.Visible = false;
            // 
            // EmailErr
            // 
            this.EmailErr.AutoSize = true;
            this.EmailErr.ForeColor = System.Drawing.Color.Red;
            this.EmailErr.Location = new System.Drawing.Point(51, 288);
            this.EmailErr.Name = "EmailErr";
            this.EmailErr.Size = new System.Drawing.Size(50, 15);
            this.EmailErr.TabIndex = 13;
            this.EmailErr.Text = "EmailErr";
            this.EmailErr.Visible = false;
            // 
            // PassErr
            // 
            this.PassErr.AutoSize = true;
            this.PassErr.ForeColor = System.Drawing.Color.Red;
            this.PassErr.Location = new System.Drawing.Point(51, 366);
            this.PassErr.Name = "PassErr";
            this.PassErr.Size = new System.Drawing.Size(44, 15);
            this.PassErr.TabIndex = 14;
            this.PassErr.Text = "PassErr";
            this.PassErr.Visible = false;
            // 
            // RetypeErr
            // 
            this.RetypeErr.AutoSize = true;
            this.RetypeErr.ForeColor = System.Drawing.Color.Red;
            this.RetypeErr.Location = new System.Drawing.Point(51, 445);
            this.RetypeErr.Name = "RetypeErr";
            this.RetypeErr.Size = new System.Drawing.Size(57, 15);
            this.RetypeErr.TabIndex = 15;
            this.RetypeErr.Text = "RetypeErr";
            this.RetypeErr.Visible = false;
            // 
            // GenderErr
            // 
            this.GenderErr.AutoSize = true;
            this.GenderErr.ForeColor = System.Drawing.Color.Red;
            this.GenderErr.Location = new System.Drawing.Point(51, 514);
            this.GenderErr.Name = "GenderErr";
            this.GenderErr.Size = new System.Drawing.Size(59, 15);
            this.GenderErr.TabIndex = 16;
            this.GenderErr.Text = "GenderErr";
            this.GenderErr.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(145, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 34);
            this.label1.TabIndex = 17;
            this.label1.Text = "Daemon Institute";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(522, 703);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenderErr);
            this.Controls.Add(this.RetypeErr);
            this.Controls.Add(this.PassErr);
            this.Controls.Add(this.EmailErr);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.fNamErr);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.Sign_up);
            this.Controls.Add(this.Re_type);
            this.Controls.Add(this._Lname);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(538, 742);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(538, 742);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_FormClosed);
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox _Lname;
        private System.Windows.Forms.TextBox Re_type;
        private System.Windows.Forms.Button Sign_up;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label EmailErr;
        private System.Windows.Forms.Label PassErr;
        private System.Windows.Forms.Label RetypeErr;
        private System.Windows.Forms.Label GenderErr;
        private System.Windows.Forms.Label fNamErr;
        private System.Windows.Forms.Label label1;
    }
}