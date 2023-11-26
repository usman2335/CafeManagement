namespace CafeManagement
{
    partial class Login
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
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.welcomeText1 = new System.Windows.Forms.Label();
            this.createAccountBtn = new System.Windows.Forms.Button();
            this.loginCBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.passwordTxt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.passwordTxt.Location = new System.Drawing.Point(54, 341);
            this.passwordTxt.Multiline = true;
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(216, 30);
            this.passwordTxt.TabIndex = 10;
            this.passwordTxt.TextChanged += new System.EventHandler(this.passwordTxt_TextChanged);
            // 
            // usernameTxt
            // 
            this.usernameTxt.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F);
            this.usernameTxt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.usernameTxt.Location = new System.Drawing.Point(54, 257);
            this.usernameTxt.Multiline = true;
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(216, 30);
            this.usernameTxt.TabIndex = 9;
            this.usernameTxt.TextChanged += new System.EventHandler(this.usernameTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(50, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(50, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Snow;
            this.label4.Font = new System.Drawing.Font("Lato Light", 14F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(50, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sign In";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.usernameTxt);
            this.panel1.Controls.Add(this.passwordTxt);
            this.panel1.Controls.Add(this.createAccountBtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(414, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 691);
            this.panel1.TabIndex = 14;
            // 
            // welcomeText1
            // 
            this.welcomeText1.AutoSize = true;
            this.welcomeText1.Font = new System.Drawing.Font("Lato Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeText1.ForeColor = System.Drawing.Color.Snow;
            this.welcomeText1.Location = new System.Drawing.Point(42, 236);
            this.welcomeText1.Name = "welcomeText1";
            this.welcomeText1.Size = new System.Drawing.Size(331, 45);
            this.welcomeText1.TabIndex = 15;
            this.welcomeText1.Text = "Welcome To Log in";
            // 
            // createAccountBtn
            // 
            this.createAccountBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.createAccountBtn.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold);
            this.createAccountBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(231)))));
            this.createAccountBtn.Location = new System.Drawing.Point(54, 397);
            this.createAccountBtn.Name = "createAccountBtn";
            this.createAccountBtn.Size = new System.Drawing.Size(216, 43);
            this.createAccountBtn.TabIndex = 11;
            this.createAccountBtn.Text = "Login";
            this.createAccountBtn.UseVisualStyleBackColor = false;
            this.createAccountBtn.Click += new System.EventHandler(this.createAccountBtn_Click);
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
            this.loginCBtn.TabIndex = 16;
            this.loginCBtn.Text = "Sign Up";
            this.loginCBtn.UseVisualStyleBackColor = false;
            this.loginCBtn.Click += new System.EventHandler(this.loginCBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lato Light", 12F);
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(121, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Haven\'t Signed Up Yet?";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(800, 652);
            this.Controls.Add(this.loginCBtn);
            this.Controls.Add(this.welcomeText1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label welcomeText1;
        private System.Windows.Forms.Button createAccountBtn;
        private System.Windows.Forms.Button loginCBtn;
        private System.Windows.Forms.Label label3;
    }
}