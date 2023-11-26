namespace CafeManagement
{
    partial class Signup
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
            this.Fname = new System.Windows.Forms.TextBox();
            this.LName = new System.Windows.Forms.TextBox();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.reEnterPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.createAccountBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.loginCBtn = new System.Windows.Forms.Button();
            this.welcomeText1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Fname
            // 
            this.Fname.Font = new System.Drawing.Font("Roboto Light", 9F);
            this.Fname.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Fname.Location = new System.Drawing.Point(58, 162);
            this.Fname.Multiline = true;
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(237, 30);
            this.Fname.TabIndex = 2;
            this.Fname.Text = "\'";
            this.Fname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Fname_Click);
            // 
            // LName
            // 
            this.LName.Font = new System.Drawing.Font("Roboto Light", 9F);
            this.LName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.LName.Location = new System.Drawing.Point(58, 226);
            this.LName.Multiline = true;
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(237, 30);
            this.LName.TabIndex = 3;
            this.LName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LName_TextChanged);
            // 
            // usernameTxt
            // 
            this.usernameTxt.Font = new System.Drawing.Font("Roboto Light", 9F);
            this.usernameTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.usernameTxt.Location = new System.Drawing.Point(60, 290);
            this.usernameTxt.Multiline = true;
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(237, 30);
            this.usernameTxt.TabIndex = 4;
            this.usernameTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.usernameTxt_click);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Roboto Light", 9F);
            this.passwordTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.passwordTxt.Location = new System.Drawing.Point(60, 352);
            this.passwordTxt.Multiline = true;
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(237, 30);
            this.passwordTxt.TabIndex = 5;
            this.passwordTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.passwordTxt_click);
            // 
            // reEnterPassword
            // 
            this.reEnterPassword.Font = new System.Drawing.Font("Roboto Light", 9F);
            this.reEnterPassword.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.reEnterPassword.Location = new System.Drawing.Point(60, 424);
            this.reEnterPassword.Multiline = true;
            this.reEnterPassword.Name = "reEnterPassword";
            this.reEnterPassword.Size = new System.Drawing.Size(237, 30);
            this.reEnterPassword.TabIndex = 6;
            this.reEnterPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rePasswordTxt_click);
            this.reEnterPassword.TextChanged += new System.EventHandler(this.reEnterPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(57, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label2.Location = new System.Drawing.Point(57, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label3.Location = new System.Drawing.Point(62, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Username";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label4.Location = new System.Drawing.Point(62, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label5.Location = new System.Drawing.Point(62, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Re-enter Password";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // createAccountBtn
            // 
            this.createAccountBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.createAccountBtn.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold);
            this.createAccountBtn.ForeColor = System.Drawing.Color.White;
            this.createAccountBtn.Location = new System.Drawing.Point(58, 539);
            this.createAccountBtn.Name = "createAccountBtn";
            this.createAccountBtn.Size = new System.Drawing.Size(239, 43);
            this.createAccountBtn.TabIndex = 8;
            this.createAccountBtn.Text = "Create Account";
            this.createAccountBtn.UseVisualStyleBackColor = false;
            this.createAccountBtn.Click += new System.EventHandler(this.createAccountBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Roboto Thin", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Customer",
            "Cashier",
            "Inventory Manager"});
            this.comboBox1.Location = new System.Drawing.Point(183, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.Text = "Choose who you are signing up as";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // phoneTxt
            // 
            this.phoneTxt.Font = new System.Drawing.Font("Roboto Light", 9F);
            this.phoneTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.phoneTxt.Location = new System.Drawing.Point(60, 490);
            this.phoneTxt.Multiline = true;
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(237, 30);
            this.phoneTxt.TabIndex = 2;
            this.phoneTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Fname_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.Fname);
            this.panel1.Controls.Add(this.phoneTxt);
            this.panel1.Controls.Add(this.LName);
            this.panel1.Controls.Add(this.usernameTxt);
            this.panel1.Controls.Add(this.createAccountBtn);
            this.panel1.Controls.Add(this.passwordTxt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.reEnterPassword);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(411, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 656);
            this.panel1.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label6.Location = new System.Drawing.Point(62, 469);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Contact Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Snow;
            this.label9.Font = new System.Drawing.Font("Lato Light", 14F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(54, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "Sign Up";
            // 
            // loginCBtn
            // 
            this.loginCBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginCBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.loginCBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginCBtn.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Bold);
            this.loginCBtn.ForeColor = System.Drawing.Color.White;
            this.loginCBtn.Location = new System.Drawing.Point(156, 352);
            this.loginCBtn.Name = "loginCBtn";
            this.loginCBtn.Size = new System.Drawing.Size(98, 38);
            this.loginCBtn.TabIndex = 19;
            this.loginCBtn.Text = "Sign In";
            this.loginCBtn.UseVisualStyleBackColor = false;
            this.loginCBtn.Click += new System.EventHandler(this.loginCBtn_Click);
            // 
            // welcomeText1
            // 
            this.welcomeText1.AutoSize = true;
            this.welcomeText1.Font = new System.Drawing.Font("Lato Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeText1.ForeColor = System.Drawing.Color.Snow;
            this.welcomeText1.Location = new System.Drawing.Point(31, 239);
            this.welcomeText1.Name = "welcomeText1";
            this.welcomeText1.Size = new System.Drawing.Size(360, 45);
            this.welcomeText1.TabIndex = 18;
            this.welcomeText1.Text = "Welcome To Sign Up";
            this.welcomeText1.Click += new System.EventHandler(this.welcomeText1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Lato Light", 12F);
            this.label8.ForeColor = System.Drawing.Color.Snow;
            this.label8.Location = new System.Drawing.Point(108, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Already Have An Account?";
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(800, 652);
            this.Controls.Add(this.loginCBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.welcomeText1);
            this.Controls.Add(this.label8);
            this.Name = "Signup";
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.TextBox LName;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox reEnterPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button createAccountBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button loginCBtn;
        private System.Windows.Forms.Label welcomeText1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
    }
}