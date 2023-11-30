namespace CafeManagement
{
    partial class Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.HomeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BG_panel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.totalTxt = new System.Windows.Forms.TextBox();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.NameList = new System.Windows.Forms.ListBox();
            this.CartGrid = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyNum = new System.Windows.Forms.NumericUpDown();
            this.PriceTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddC_button = new System.Windows.Forms.Button();
            this.MenuGrid = new System.Windows.Forms.DataGridView();
            this.Cat_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BG_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QtyNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.HomeLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 68);
            this.panel1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.label5.Location = new System.Drawing.Point(428, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Menu";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(918, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Log Out";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(516, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contact Us";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // HomeLabel
            // 
            this.HomeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeLabel.AutoSize = true;
            this.HomeLabel.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeLabel.ForeColor = System.Drawing.Color.Snow;
            this.HomeLabel.Location = new System.Drawing.Point(332, 24);
            this.HomeLabel.Name = "HomeLabel";
            this.HomeLabel.Size = new System.Drawing.Size(61, 23);
            this.HomeLabel.TabIndex = 2;
            this.HomeLabel.Text = "Home";
            this.HomeLabel.Click += new System.EventHandler(this.HomeLabel_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(647, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "About Us";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lato Black", 24F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(270, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "A feast for your senses";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(14, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "View All Items ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Breakfast",
            "Sandwiches",
            "Desi",
            "Sides",
            "Dessert",
            "Cold Drink",
            "Hot Beverages",
            "Shakes"});
            this.comboBox1.Location = new System.Drawing.Point(14, 217);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Select Category";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BG_panel
            // 
            this.BG_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.BG_panel.Controls.Add(this.label7);
            this.BG_panel.Controls.Add(this.totalTxt);
            this.BG_panel.Controls.Add(this.ViewBtn);
            this.BG_panel.Controls.Add(this.NameList);
            this.BG_panel.Controls.Add(this.CartGrid);
            this.BG_panel.Controls.Add(this.QtyNum);
            this.BG_panel.Controls.Add(this.PriceTxt);
            this.BG_panel.Controls.Add(this.label6);
            this.BG_panel.Controls.Add(this.label4);
            this.BG_panel.Controls.Add(this.AddC_button);
            this.BG_panel.Controls.Add(this.MenuGrid);
            this.BG_panel.Controls.Add(this.label2);
            this.BG_panel.Location = new System.Drawing.Point(131, 62);
            this.BG_panel.Name = "BG_panel";
            this.BG_panel.Size = new System.Drawing.Size(916, 573);
            this.BG_panel.TabIndex = 7;
            this.BG_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.BG_panel_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(718, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Total:";
            // 
            // totalTxt
            // 
            this.totalTxt.Location = new System.Drawing.Point(764, 318);
            this.totalTxt.Name = "totalTxt";
            this.totalTxt.Size = new System.Drawing.Size(100, 20);
            this.totalTxt.TabIndex = 15;
            this.totalTxt.Text = "1000";
            // 
            // ViewBtn
            // 
            this.ViewBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ViewBtn.BackColor = System.Drawing.Color.Snow;
            this.ViewBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.ViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewBtn.Font = new System.Drawing.Font("Lato Light", 10F);
            this.ViewBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.ViewBtn.Location = new System.Drawing.Point(635, 375);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(110, 37);
            this.ViewBtn.TabIndex = 14;
            this.ViewBtn.Text = "Place Order";
            this.ViewBtn.UseVisualStyleBackColor = false;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // NameList
            // 
            this.NameList.FormattingEnabled = true;
            this.NameList.Location = new System.Drawing.Point(53, 331);
            this.NameList.Name = "NameList";
            this.NameList.Size = new System.Drawing.Size(347, 108);
            this.NameList.TabIndex = 12;
            this.NameList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // CartGrid
            // 
            this.CartGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Price,
            this.Qty});
            this.CartGrid.Location = new System.Drawing.Point(521, 90);
            this.CartGrid.Name = "CartGrid";
            this.CartGrid.Size = new System.Drawing.Size(343, 222);
            this.CartGrid.TabIndex = 11;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            // 
            // QtyNum
            // 
            this.QtyNum.BackColor = System.Drawing.Color.Snow;
            this.QtyNum.Location = new System.Drawing.Point(53, 488);
            this.QtyNum.Name = "QtyNum";
            this.QtyNum.Size = new System.Drawing.Size(67, 20);
            this.QtyNum.TabIndex = 10;
            this.QtyNum.ValueChanged += new System.EventHandler(this.QtyNum_ValueChanged);
            // 
            // PriceTxt
            // 
            this.PriceTxt.Location = new System.Drawing.Point(201, 488);
            this.PriceTxt.Multiline = true;
            this.PriceTxt.Name = "PriceTxt";
            this.PriceTxt.Size = new System.Drawing.Size(68, 21);
            this.PriceTxt.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(198, 467);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(50, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantity";
            // 
            // AddC_button
            // 
            this.AddC_button.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Bold);
            this.AddC_button.Location = new System.Drawing.Point(336, 473);
            this.AddC_button.Name = "AddC_button";
            this.AddC_button.Size = new System.Drawing.Size(97, 35);
            this.AddC_button.TabIndex = 5;
            this.AddC_button.Text = " Add To Cart";
            this.AddC_button.UseVisualStyleBackColor = true;
            this.AddC_button.Click += new System.EventHandler(this.AddC_button_Click);
            // 
            // MenuGrid
            // 
            this.MenuGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MenuGrid.Location = new System.Drawing.Point(53, 90);
            this.MenuGrid.Name = "MenuGrid";
            this.MenuGrid.Size = new System.Drawing.Size(347, 235);
            this.MenuGrid.TabIndex = 0;
            this.MenuGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MenuGrid_CellContentClick);
            // 
            // Cat_button
            // 
            this.Cat_button.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cat_button.Location = new System.Drawing.Point(14, 260);
            this.Cat_button.Name = "Cat_button";
            this.Cat_button.Size = new System.Drawing.Size(97, 35);
            this.Cat_button.TabIndex = 8;
            this.Cat_button.Text = "Apply Category";
            this.Cat_button.UseVisualStyleBackColor = true;
            this.Cat_button.Click += new System.EventHandler(this.Cat_button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Cat_button);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(-4, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(137, 573);
            this.panel2.TabIndex = 9;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1042, 630);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BG_panel);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Menu";
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BG_panel.ResumeLayout(false);
            this.BG_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QtyNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label HomeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel BG_panel;
        private System.Windows.Forms.DataGridView MenuGrid;
        private System.Windows.Forms.Button Cat_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox PriceTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddC_button;
        private System.Windows.Forms.NumericUpDown QtyNum;
        private System.Windows.Forms.DataGridView CartGrid;
        private System.Windows.Forms.ListBox NameList;
        private System.Windows.Forms.Button ViewBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox totalTxt;
    }
}