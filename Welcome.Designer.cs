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
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginCBtn
            // 
            this.loginCBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(107)))), ((int)(((byte)(93)))));
            this.loginCBtn.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginCBtn.ForeColor = System.Drawing.Color.MistyRose;
            this.loginCBtn.Location = new System.Drawing.Point(92, 288);
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
            this.signupBtn.Location = new System.Drawing.Point(92, 351);
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
            this.welcomeText1.Location = new System.Drawing.Point(36, 29);
            this.welcomeText1.Name = "welcomeText1";
            this.welcomeText1.Size = new System.Drawing.Size(362, 42);
            this.welcomeText1.TabIndex = 4;
            this.welcomeText1.Text = "Rozan-e-Taleem Café";
            this.welcomeText1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.logo);
            this.panel1.Controls.Add(this.loginCBtn);
            this.panel1.Controls.Add(this.signupBtn);
            this.panel1.Location = new System.Drawing.Point(435, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 450);
            this.panel1.TabIndex = 5;
            // 
            // logo
            // 
            this.logo.Image = global::CafeManagement.Properties.Resources.Brown_Simple_Round_Badge_Coffee_Shop_Logo_removebg_preview_removebg_preview;
            this.logo.Location = new System.Drawing.Point(52, 29);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(275, 225);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(217)))), ((int)(((byte)(237)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.welcomeText1);
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 450);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(114)))), ((int)(((byte)(157)))));
            this.panel3.Location = new System.Drawing.Point(43, 113);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(339, 274);
            this.panel3.TabIndex = 5;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button loginCBtn;
        private System.Windows.Forms.Button signupBtn;
        private System.Windows.Forms.Label welcomeText1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}