namespace CafeManagement
{
    partial class CafeManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.AddItemPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.productPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.productCategory = new System.Windows.Forms.ComboBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.AddItemLabel = new System.Windows.Forms.Label();
            this.ViewProductPanel = new System.Windows.Forms.Panel();
            this.Viewitems = new System.Windows.Forms.Label();
            this.productViewGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.AddItemPanel.SuspendLayout();
            this.ViewProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productViewGrid)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1365, 76);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(601, 19);
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
            this.button2.Location = new System.Drawing.Point(1237, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Log Out";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CafeManagement.Properties.Resources.Brown_Simple_Round_Badge_Coffee_Shop_Logo_removebg_preview_removebg_preview1;
            this.pictureBox1.Location = new System.Drawing.Point(3, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lato Light", 10F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.button1.Location = new System.Drawing.Point(23, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "View Items";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button3.BackColor = System.Drawing.Color.Snow;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Lato Light", 10F);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.button3.Location = new System.Drawing.Point(23, 317);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 37);
            this.button3.TabIndex = 4;
            this.button3.Text = "Add Item";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button4.BackColor = System.Drawing.Color.Snow;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Lato Light", 10F);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.button4.Location = new System.Drawing.Point(23, 437);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 37);
            this.button4.TabIndex = 4;
            this.button4.Text = "Remove Item";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button5.BackColor = System.Drawing.Color.Snow;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Lato Light", 10F);
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.button5.Location = new System.Drawing.Point(23, 377);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 37);
            this.button5.TabIndex = 4;
            this.button5.Text = "Edit Item";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // AddItemPanel
            // 
            this.AddItemPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.AddItemPanel.Controls.Add(this.AddItemLabel);
            this.AddItemPanel.Controls.Add(this.SubmitBtn);
            this.AddItemPanel.Controls.Add(this.productCategory);
            this.AddItemPanel.Controls.Add(this.label4);
            this.AddItemPanel.Controls.Add(this.productPrice);
            this.AddItemPanel.Controls.Add(this.label3);
            this.AddItemPanel.Controls.Add(this.productName);
            this.AddItemPanel.Controls.Add(this.label2);
            this.AddItemPanel.Location = new System.Drawing.Point(416, 82);
            this.AddItemPanel.Name = "AddItemPanel";
            this.AddItemPanel.Size = new System.Drawing.Size(385, 567);
            this.AddItemPanel.TabIndex = 5;
            this.AddItemPanel.Visible = false;
            this.AddItemPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AddItemPanel_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 13F);
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(69, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // productName
            // 
            this.productName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.productName.Location = new System.Drawing.Point(73, 160);
            this.productName.Multiline = true;
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(240, 26);
            this.productName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 13F);
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(69, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Price";
            // 
            // productPrice
            // 
            this.productPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.productPrice.Location = new System.Drawing.Point(73, 227);
            this.productPrice.Multiline = true;
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(240, 26);
            this.productPrice.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 13F);
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(69, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Category";
            // 
            // productCategory
            // 
            this.productCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.productCategory.FormattingEnabled = true;
            this.productCategory.Items.AddRange(new object[] {
            "Breakfast",
            "Sandwiches",
            "Desi",
            "Sides",
            "Dessert",
            "Cold Drink",
            "Hot Beverages",
            "Shakes"});
            this.productCategory.Location = new System.Drawing.Point(73, 303);
            this.productCategory.Name = "productCategory";
            this.productCategory.Size = new System.Drawing.Size(240, 21);
            this.productCategory.TabIndex = 3;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.AutoSize = true;
            this.SubmitBtn.BackColor = System.Drawing.Color.Snow;
            this.SubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitBtn.Font = new System.Drawing.Font("Lato Light", 10F);
            this.SubmitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.SubmitBtn.Location = new System.Drawing.Point(148, 340);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(87, 29);
            this.SubmitBtn.TabIndex = 4;
            this.SubmitBtn.Text = "Add";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // AddItemLabel
            // 
            this.AddItemLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AddItemLabel.AutoSize = true;
            this.AddItemLabel.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItemLabel.ForeColor = System.Drawing.Color.Snow;
            this.AddItemLabel.Location = new System.Drawing.Point(143, 99);
            this.AddItemLabel.Name = "AddItemLabel";
            this.AddItemLabel.Size = new System.Drawing.Size(109, 29);
            this.AddItemLabel.TabIndex = 5;
            this.AddItemLabel.Text = "Add Item";
            // 
            // ViewProductPanel
            // 
            this.ViewProductPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.ViewProductPanel.Controls.Add(this.productViewGrid);
            this.ViewProductPanel.Controls.Add(this.Viewitems);
            this.ViewProductPanel.Location = new System.Drawing.Point(807, 82);
            this.ViewProductPanel.Name = "ViewProductPanel";
            this.ViewProductPanel.Size = new System.Drawing.Size(385, 567);
            this.ViewProductPanel.TabIndex = 6;
            this.ViewProductPanel.Visible = false;
            // 
            // Viewitems
            // 
            this.Viewitems.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Viewitems.AutoSize = true;
            this.Viewitems.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Viewitems.ForeColor = System.Drawing.Color.Snow;
            this.Viewitems.Location = new System.Drawing.Point(114, 99);
            this.Viewitems.Name = "Viewitems";
            this.Viewitems.Size = new System.Drawing.Size(165, 29);
            this.Viewitems.TabIndex = 5;
            this.Viewitems.Text = "View Products";
            // 
            // productViewGrid
            // 
            this.productViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productViewGrid.Location = new System.Drawing.Point(39, 160);
            this.productViewGrid.Name = "productViewGrid";
            this.productViewGrid.Size = new System.Drawing.Size(323, 297);
            this.productViewGrid.TabIndex = 6;
            // 
            // CafeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 779);
            this.Controls.Add(this.ViewProductPanel);
            this.Controls.Add(this.AddItemPanel);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "CafeManager";
            this.Text = "CafeManager";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.AddItemPanel.ResumeLayout(false);
            this.AddItemPanel.PerformLayout();
            this.ViewProductPanel.ResumeLayout(false);
            this.ViewProductPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productViewGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel AddItemPanel;
        private System.Windows.Forms.ComboBox productCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox productPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Label AddItemLabel;
        private System.Windows.Forms.Panel ViewProductPanel;
        private System.Windows.Forms.DataGridView productViewGrid;
        private System.Windows.Forms.Label Viewitems;
    }
}