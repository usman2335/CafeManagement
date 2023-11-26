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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.loginCBtn = new System.Windows.Forms.Button();
            this.signupBtn = new System.Windows.Forms.Button();
            this.welcomeText1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginCBtn
            // 
            this.loginCBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.loginCBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.loginCBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginCBtn.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Bold);
            this.loginCBtn.ForeColor = System.Drawing.Color.White;
            this.loginCBtn.Location = new System.Drawing.Point(92, 359);
            this.loginCBtn.Name = "loginCBtn";
            this.loginCBtn.Size = new System.Drawing.Size(187, 46);
            this.loginCBtn.TabIndex = 2;
            this.loginCBtn.Text = "LOG IN";
            this.loginCBtn.UseVisualStyleBackColor = false;
            this.loginCBtn.Click += new System.EventHandler(this.loginCBtn_Click);
            // 
            // signupBtn
            // 
            this.signupBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.signupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupBtn.Font = new System.Drawing.Font("Lato", 11F, System.Drawing.FontStyle.Bold);
            this.signupBtn.ForeColor = System.Drawing.Color.White;
            this.signupBtn.Location = new System.Drawing.Point(92, 422);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(187, 46);
            this.signupBtn.TabIndex = 3;
            this.signupBtn.Text = "SIGN UP";
            this.signupBtn.UseVisualStyleBackColor = false;
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // welcomeText1
            // 
            this.welcomeText1.AutoSize = true;
            this.welcomeText1.Font = new System.Drawing.Font("Lato Black", 27.75F, System.Drawing.FontStyle.Bold);
            this.welcomeText1.ForeColor = System.Drawing.Color.White;
            this.welcomeText1.Location = new System.Drawing.Point(516, 141);
            this.welcomeText1.Name = "welcomeText1";
            this.welcomeText1.Size = new System.Drawing.Size(175, 45);
            this.welcomeText1.TabIndex = 4;
            this.welcomeText1.Text = "About Us";
            this.welcomeText1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.logo);
            this.panel1.Controls.Add(this.loginCBtn);
            this.panel1.Controls.Add(this.signupBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 580);
            this.panel1.TabIndex = 5;
            // 
            // logo
            // 
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logo.Image = global::CafeManagement.Properties.Resources.Brown_Simple_Round_Badge_Coffee_Shop_Logo_removebg_preview_removebg_preview;
            this.logo.Location = new System.Drawing.Point(48, 44);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(304, 260);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.welcomeText1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 580);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lato Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(442, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 238);
            this.label1.TabIndex = 4;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.panel2);
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
        private System.Windows.Forms.Label label1;
    }
}