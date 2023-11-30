namespace CafeManagement
{
    partial class ManageMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.AddToMenuPanel = new System.Windows.Forms.Panel();
            this.productIDTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.viewItemsGrid = new System.Windows.Forms.DataGridView();
            this.RemoveFromMenuPanel = new System.Windows.Forms.Panel();
            this.removeTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.AddToMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewItemsGrid)).BeginInit();
            this.RemoveFromMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1302, 79);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(542, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cafe Manager";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Snow;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.button2.Location = new System.Drawing.Point(1174, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Log Out";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(510, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Manage Menu";
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Snow;
            this.AddBtn.Font = new System.Drawing.Font("Lato Light", 10F);
            this.AddBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.AddBtn.Location = new System.Drawing.Point(53, 308);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(119, 50);
            this.AddBtn.TabIndex = 9;
            this.AddBtn.Text = "Add To Menu";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.BackColor = System.Drawing.Color.Snow;
            this.RemoveBtn.Font = new System.Drawing.Font("Lato Light", 10F);
            this.RemoveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.RemoveBtn.Location = new System.Drawing.Point(53, 425);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(119, 50);
            this.RemoveBtn.TabIndex = 9;
            this.RemoveBtn.Text = "Remove From Menu";
            this.RemoveBtn.UseVisualStyleBackColor = false;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // AddToMenuPanel
            // 
            this.AddToMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.AddToMenuPanel.Controls.Add(this.button5);
            this.AddToMenuPanel.Controls.Add(this.productIDTxt);
            this.AddToMenuPanel.Controls.Add(this.label7);
            this.AddToMenuPanel.Controls.Add(this.label6);
            this.AddToMenuPanel.Location = new System.Drawing.Point(679, 169);
            this.AddToMenuPanel.Name = "AddToMenuPanel";
            this.AddToMenuPanel.Size = new System.Drawing.Size(504, 499);
            this.AddToMenuPanel.TabIndex = 11;
            this.AddToMenuPanel.Visible = false;
            // 
            // productIDTxt
            // 
            this.productIDTxt.Location = new System.Drawing.Point(66, 183);
            this.productIDTxt.Multiline = true;
            this.productIDTxt.Name = "productIDTxt";
            this.productIDTxt.Size = new System.Drawing.Size(382, 30);
            this.productIDTxt.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lato", 13F);
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(62, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Enter Product ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(185, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Add To Menu";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Snow;
            this.button5.Font = new System.Drawing.Font("Lato", 8.25F);
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.button5.Location = new System.Drawing.Point(190, 240);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 40);
            this.button5.TabIndex = 13;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CafeManagement.Properties.Resources.Brown_Simple_Round_Badge_Coffee_Shop_Logo_removebg_preview_removebg_preview1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // viewItemsGrid
            // 
            this.viewItemsGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.viewItemsGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.viewItemsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.viewItemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewItemsGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.viewItemsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.viewItemsGrid.Location = new System.Drawing.Point(198, 308);
            this.viewItemsGrid.Name = "viewItemsGrid";
            this.viewItemsGrid.Size = new System.Drawing.Size(456, 183);
            this.viewItemsGrid.TabIndex = 14;
            this.viewItemsGrid.Visible = false;
            // 
            // RemoveFromMenuPanel
            // 
            this.RemoveFromMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.RemoveFromMenuPanel.Controls.Add(this.button1);
            this.RemoveFromMenuPanel.Controls.Add(this.removeTxt);
            this.RemoveFromMenuPanel.Controls.Add(this.label3);
            this.RemoveFromMenuPanel.Controls.Add(this.label4);
            this.RemoveFromMenuPanel.Location = new System.Drawing.Point(679, 169);
            this.RemoveFromMenuPanel.Name = "RemoveFromMenuPanel";
            this.RemoveFromMenuPanel.Size = new System.Drawing.Size(504, 499);
            this.RemoveFromMenuPanel.TabIndex = 11;
            this.RemoveFromMenuPanel.Visible = false;
            // 
            // removeTxt
            // 
            this.removeTxt.Location = new System.Drawing.Point(66, 183);
            this.removeTxt.Multiline = true;
            this.removeTxt.Name = "removeTxt";
            this.removeTxt.Size = new System.Drawing.Size(382, 30);
            this.removeTxt.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 13F);
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(62, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Enter Product ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(134, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Remove From Menu";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lato", 8.25F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.button1.Location = new System.Drawing.Point(192, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lato Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Go Back";
            // 
            // pictureBox2
            // 
//            this.pictureBox2.Image = global::CafeManagement.Properties.Resources.icons8_back_100;
            this.pictureBox2.Location = new System.Drawing.Point(25, 123);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ManageMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 702);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.viewItemsGrid);
            this.Controls.Add(this.RemoveFromMenuPanel);
            this.Controls.Add(this.AddToMenuPanel);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "ManageMenu";
            this.Text = "ManageMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.AddToMenuPanel.ResumeLayout(false);
            this.AddToMenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewItemsGrid)).EndInit();
            this.RemoveFromMenuPanel.ResumeLayout(false);
            this.RemoveFromMenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Panel AddToMenuPanel;
        private System.Windows.Forms.TextBox productIDTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView viewItemsGrid;
        private System.Windows.Forms.Panel RemoveFromMenuPanel;
        private System.Windows.Forms.TextBox removeTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}