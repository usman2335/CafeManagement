namespace CafeManagement
{
    partial class WelcomeSelectorSignIn
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
            this.label6 = new System.Windows.Forms.Label();
            this.CustomerSignin_button = new System.Windows.Forms.Button();
            this.EmployeeSignIn_button = new System.Windows.Forms.Button();
            this.ManagerSigin_button = new System.Windows.Forms.Button();
            this.WhoIsSingin_Text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(114)))), ((int)(((byte)(125)))));
            this.label6.Location = new System.Drawing.Point(332, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 14);
            this.label6.TabIndex = 19;
            this.label6.Text = "Select the Login Option";
            // 
            // CustomerSignin_button
            // 
            this.CustomerSignin_button.AutoSize = true;
            this.CustomerSignin_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(114)))), ((int)(((byte)(125)))));
            this.CustomerSignin_button.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerSignin_button.ForeColor = System.Drawing.Color.MistyRose;
            this.CustomerSignin_button.Location = new System.Drawing.Point(304, 311);
            this.CustomerSignin_button.Name = "CustomerSignin_button";
            this.CustomerSignin_button.Size = new System.Drawing.Size(187, 46);
            this.CustomerSignin_button.TabIndex = 18;
            this.CustomerSignin_button.Text = "Sign In As Customer";
            this.CustomerSignin_button.UseVisualStyleBackColor = false;
            // 
            // EmployeeSignIn_button
            // 
            this.EmployeeSignIn_button.AutoSize = true;
            this.EmployeeSignIn_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(114)))), ((int)(((byte)(125)))));
            this.EmployeeSignIn_button.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeSignIn_button.ForeColor = System.Drawing.Color.MistyRose;
            this.EmployeeSignIn_button.Location = new System.Drawing.Point(304, 243);
            this.EmployeeSignIn_button.Name = "EmployeeSignIn_button";
            this.EmployeeSignIn_button.Size = new System.Drawing.Size(187, 46);
            this.EmployeeSignIn_button.TabIndex = 17;
            this.EmployeeSignIn_button.Text = "Sign In As Employee";
            this.EmployeeSignIn_button.UseVisualStyleBackColor = false;
            // 
            // ManagerSigin_button
            // 
            this.ManagerSigin_button.AutoSize = true;
            this.ManagerSigin_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(114)))), ((int)(((byte)(125)))));
            this.ManagerSigin_button.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerSigin_button.ForeColor = System.Drawing.Color.MistyRose;
            this.ManagerSigin_button.Location = new System.Drawing.Point(304, 176);
            this.ManagerSigin_button.Name = "ManagerSigin_button";
            this.ManagerSigin_button.Size = new System.Drawing.Size(187, 46);
            this.ManagerSigin_button.TabIndex = 16;
            this.ManagerSigin_button.Text = "Sign In As Manager";
            this.ManagerSigin_button.UseVisualStyleBackColor = false;
            // 
            // WhoIsSingin_Text
            // 
            this.WhoIsSingin_Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.WhoIsSingin_Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WhoIsSingin_Text.Font = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhoIsSingin_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(114)))), ((int)(((byte)(125)))));
            this.WhoIsSingin_Text.Location = new System.Drawing.Point(245, 61);
            this.WhoIsSingin_Text.Name = "WhoIsSingin_Text";
            this.WhoIsSingin_Text.Size = new System.Drawing.Size(336, 43);
            this.WhoIsSingin_Text.TabIndex = 15;
            this.WhoIsSingin_Text.Text = "Who is Signing up?";
            // 
            // WelcomeSelectorSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CustomerSignin_button);
            this.Controls.Add(this.EmployeeSignIn_button);
            this.Controls.Add(this.ManagerSigin_button);
            this.Controls.Add(this.WhoIsSingin_Text);
            this.Name = "WelcomeSelectorSignIn";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CustomerSignin_button;
        private System.Windows.Forms.Button EmployeeSignIn_button;
        private System.Windows.Forms.Button ManagerSigin_button;
        private System.Windows.Forms.TextBox WhoIsSingin_Text;
    }
}