namespace CafeManagement
{
    partial class Form2
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
            this.WhoIsLogin_Text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CustomerLog_button = new System.Windows.Forms.Button();
            this.CashierLog_button = new System.Windows.Forms.Button();
            this.ManagerLog_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WhoIsLogin_Text
            // 
            this.WhoIsLogin_Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.WhoIsLogin_Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WhoIsLogin_Text.Font = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhoIsLogin_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(114)))), ((int)(((byte)(125)))));
            this.WhoIsLogin_Text.Location = new System.Drawing.Point(249, 79);
            this.WhoIsLogin_Text.Name = "WhoIsLogin_Text";
            this.WhoIsLogin_Text.Size = new System.Drawing.Size(336, 43);
            this.WhoIsLogin_Text.TabIndex = 1;
            this.WhoIsLogin_Text.Text = "Who is Logging in?";
            this.WhoIsLogin_Text.TextChanged += new System.EventHandler(this.welcomeText_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(114)))), ((int)(((byte)(125)))));
            this.label6.Location = new System.Drawing.Point(336, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 14);
            this.label6.TabIndex = 14;
            this.label6.Text = "Select the Login Option";
            // 
            // CustomerLog_button
            // 
            this.CustomerLog_button.AutoSize = true;
            this.CustomerLog_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(114)))), ((int)(((byte)(125)))));
            this.CustomerLog_button.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLog_button.ForeColor = System.Drawing.Color.MistyRose;
            this.CustomerLog_button.Location = new System.Drawing.Point(308, 313);
            this.CustomerLog_button.Name = "CustomerLog_button";
            this.CustomerLog_button.Size = new System.Drawing.Size(187, 46);
            this.CustomerLog_button.TabIndex = 4;
            this.CustomerLog_button.Text = "Login As Customer";
            this.CustomerLog_button.UseVisualStyleBackColor = false;
            this.CustomerLog_button.Click += new System.EventHandler(this.CustomerLog_button_Click);
            // 
            // CashierLog_button
            // 
            this.CashierLog_button.AutoSize = true;
            this.CashierLog_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(114)))), ((int)(((byte)(125)))));
            this.CashierLog_button.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashierLog_button.ForeColor = System.Drawing.Color.MistyRose;
            this.CashierLog_button.Location = new System.Drawing.Point(308, 245);
            this.CashierLog_button.Name = "CashierLog_button";
            this.CashierLog_button.Size = new System.Drawing.Size(187, 46);
            this.CashierLog_button.TabIndex = 3;
            this.CashierLog_button.Text = "Login As Cashier";
            this.CashierLog_button.UseVisualStyleBackColor = false;
            this.CashierLog_button.Click += new System.EventHandler(this.CashierLog_button_Click);
            // 
            // ManagerLog_button
            // 
            this.ManagerLog_button.AutoSize = true;
            this.ManagerLog_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(114)))), ((int)(((byte)(125)))));
            this.ManagerLog_button.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerLog_button.ForeColor = System.Drawing.Color.MistyRose;
            this.ManagerLog_button.Location = new System.Drawing.Point(308, 178);
            this.ManagerLog_button.Name = "ManagerLog_button";
            this.ManagerLog_button.Size = new System.Drawing.Size(187, 46);
            this.ManagerLog_button.TabIndex = 2;
            this.ManagerLog_button.Text = "Login As Manager";
            this.ManagerLog_button.UseVisualStyleBackColor = false;
            this.ManagerLog_button.Click += new System.EventHandler(this.loginABtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CustomerLog_button);
            this.Controls.Add(this.CashierLog_button);
            this.Controls.Add(this.ManagerLog_button);
            this.Controls.Add(this.WhoIsLogin_Text);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WhoIsLogin_Text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CustomerLog_button;
        private System.Windows.Forms.Button CashierLog_button;
        private System.Windows.Forms.Button ManagerLog_button;
    }
}