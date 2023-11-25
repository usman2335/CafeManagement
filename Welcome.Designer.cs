namespace CafeManagement
{
    partial class Welcome
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
            this.welcomeText = new System.Windows.Forms.TextBox();
            this.loginABtn = new System.Windows.Forms.Button();
            this.loginCBtn = new System.Windows.Forms.Button();
            this.signupBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeText
            // 
            this.welcomeText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.welcomeText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.welcomeText.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.welcomeText.Location = new System.Drawing.Point(218, 105);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(336, 47);
            this.welcomeText.TabIndex = 0;
            this.welcomeText.Text = "Rozan-e-Taleem Café";
            this.welcomeText.TextChanged += new System.EventHandler(this.welcomeText_TextChanged);
            // 
            // loginABtn
            // 
            this.loginABtn.AutoSize = true;
            this.loginABtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(107)))), ((int)(((byte)(93)))));
            this.loginABtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginABtn.ForeColor = System.Drawing.Color.MistyRose;
            this.loginABtn.Location = new System.Drawing.Point(185, 187);
            this.loginABtn.Name = "loginABtn";
            this.loginABtn.Size = new System.Drawing.Size(187, 46);
            this.loginABtn.TabIndex = 1;
            this.loginABtn.Text = "Login As Admin";
            this.loginABtn.UseVisualStyleBackColor = false;
            this.loginABtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // loginCBtn
            // 
            this.loginCBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(107)))), ((int)(((byte)(93)))));
            this.loginCBtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.loginCBtn.ForeColor = System.Drawing.Color.MistyRose;
            this.loginCBtn.Location = new System.Drawing.Point(409, 187);
            this.loginCBtn.Name = "loginCBtn";
            this.loginCBtn.Size = new System.Drawing.Size(187, 46);
            this.loginCBtn.TabIndex = 2;
            this.loginCBtn.Text = "Login As Customer";
            this.loginCBtn.UseVisualStyleBackColor = false;
            this.loginCBtn.Click += new System.EventHandler(this.loginCBtn_Click);
            // 
            // signupBtn
            // 
            this.signupBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(107)))), ((int)(((byte)(93)))));
            this.signupBtn.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.signupBtn.ForeColor = System.Drawing.Color.MistyRose;
            this.signupBtn.Location = new System.Drawing.Point(283, 255);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(187, 46);
            this.signupBtn.TabIndex = 3;
            this.signupBtn.Text = "Signup";
            this.signupBtn.UseVisualStyleBackColor = false;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.signupBtn);
            this.Controls.Add(this.loginCBtn);
            this.Controls.Add(this.loginABtn);
            this.Controls.Add(this.welcomeText);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox welcomeText;
        private System.Windows.Forms.Button loginABtn;
        private System.Windows.Forms.Button loginCBtn;
        private System.Windows.Forms.Button signupBtn;
    }
}