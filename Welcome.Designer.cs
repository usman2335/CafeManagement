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
            this.loginCBtn = new System.Windows.Forms.Button();
            this.signupBtn = new System.Windows.Forms.Button();
            this.welcomeText1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginCBtn
            // 
            this.loginCBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(107)))), ((int)(((byte)(93)))));
            this.loginCBtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginCBtn.ForeColor = System.Drawing.Color.MistyRose;
            this.loginCBtn.Location = new System.Drawing.Point(298, 205);
            this.loginCBtn.Name = "loginCBtn";
            this.loginCBtn.Size = new System.Drawing.Size(187, 46);
            this.loginCBtn.TabIndex = 2;
            this.loginCBtn.Text = "Login";
            this.loginCBtn.UseVisualStyleBackColor = false;
            this.loginCBtn.Click += new System.EventHandler(this.loginCBtn_Click);
            // 
            // signupBtn
            // 
            this.signupBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(107)))), ((int)(((byte)(93)))));
            this.signupBtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupBtn.ForeColor = System.Drawing.Color.MistyRose;
            this.signupBtn.Location = new System.Drawing.Point(298, 268);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(187, 46);
            this.signupBtn.TabIndex = 3;
            this.signupBtn.Text = "Signup";
            this.signupBtn.UseVisualStyleBackColor = false;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // welcomeText1
            // 
            this.welcomeText1.AutoSize = true;
            this.welcomeText1.Font = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Bold);
            this.welcomeText1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.welcomeText1.Location = new System.Drawing.Point(217, 105);
            this.welcomeText1.Name = "welcomeText1";
            this.welcomeText1.Size = new System.Drawing.Size(362, 42);
            this.welcomeText1.TabIndex = 4;
            this.welcomeText1.Text = "Rozan-e-Taleem Café";
            this.welcomeText1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.welcomeText1);
            this.Controls.Add(this.signupBtn);
            this.Controls.Add(this.loginCBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button loginCBtn;
        private System.Windows.Forms.Button signupBtn;
        private System.Windows.Forms.Label welcomeText1;
    }
}