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
            this.AddItemLabel = new System.Windows.Forms.Label();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.productCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.productPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ViewProductPanel = new System.Windows.Forms.Panel();
            this.productViewGrid = new System.Windows.Forms.DataGridView();
            this.Viewitems = new System.Windows.Forms.Label();
            this.EditItemPanel = new System.Windows.Forms.Panel();
            this.submitEditBtn = new System.Windows.Forms.Button();
            this.EditPriceTxt = new System.Windows.Forms.TextBox();
            this.editNameTxt = new System.Windows.Forms.TextBox();
            this.EditProdGridView = new System.Windows.Forms.DataGridView();
            this.editViewBtn = new System.Windows.Forms.Button();
            this.editTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DeletePanel = new System.Windows.Forms.Panel();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.deleteTxtBox = new System.Windows.Forms.TextBox();
            this.deleteLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.AddItemPanel.SuspendLayout();
            this.ViewProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productViewGrid)).BeginInit();
            this.EditItemPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditProdGridView)).BeginInit();
            this.DeletePanel.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1000, 76);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(419, 19);
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
            this.button2.Location = new System.Drawing.Point(872, 19);
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
            this.button1.Location = new System.Drawing.Point(23, 176);
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
            this.button3.Location = new System.Drawing.Point(23, 228);
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
            this.button4.Location = new System.Drawing.Point(23, 348);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 37);
            this.button4.TabIndex = 4;
            this.button4.Text = "Remove Item";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button5.BackColor = System.Drawing.Color.Snow;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Lato Light", 10F);
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.button5.Location = new System.Drawing.Point(23, 288);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 37);
            this.button5.TabIndex = 4;
            this.button5.Text = "Edit Item";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
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
            this.AddItemPanel.Location = new System.Drawing.Point(502, 85);
            this.AddItemPanel.Name = "AddItemPanel";
            this.AddItemPanel.Size = new System.Drawing.Size(385, 567);
            this.AddItemPanel.TabIndex = 5;
            this.AddItemPanel.Visible = false;
            this.AddItemPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AddItemPanel_Paint);
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
            // productPrice
            // 
            this.productPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.productPrice.Location = new System.Drawing.Point(73, 227);
            this.productPrice.Multiline = true;
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(240, 26);
            this.productPrice.TabIndex = 2;
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
            // productName
            // 
            this.productName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.productName.Location = new System.Drawing.Point(73, 160);
            this.productName.Multiline = true;
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(240, 26);
            this.productName.TabIndex = 1;
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
            // ViewProductPanel
            // 
            this.ViewProductPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.ViewProductPanel.Controls.Add(this.productViewGrid);
            this.ViewProductPanel.Controls.Add(this.Viewitems);
            this.ViewProductPanel.Location = new System.Drawing.Point(502, 85);
            this.ViewProductPanel.Name = "ViewProductPanel";
            this.ViewProductPanel.Size = new System.Drawing.Size(385, 567);
            this.ViewProductPanel.TabIndex = 6;
            this.ViewProductPanel.Visible = false;
            // 
            // productViewGrid
            // 
            this.productViewGrid.BackgroundColor = System.Drawing.Color.Snow;
            this.productViewGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.productViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productViewGrid.Location = new System.Drawing.Point(30, 168);
            this.productViewGrid.Name = "productViewGrid";
            this.productViewGrid.Size = new System.Drawing.Size(323, 164);
            this.productViewGrid.TabIndex = 6;
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
            this.Viewitems.Click += new System.EventHandler(this.Viewitems_Click);
            // 
            // EditItemPanel
            // 
            this.EditItemPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.EditItemPanel.Controls.Add(this.submitEditBtn);
            this.EditItemPanel.Controls.Add(this.EditPriceTxt);
            this.EditItemPanel.Controls.Add(this.editNameTxt);
            this.EditItemPanel.Controls.Add(this.EditProdGridView);
            this.EditItemPanel.Controls.Add(this.editViewBtn);
            this.EditItemPanel.Controls.Add(this.editTextBox);
            this.EditItemPanel.Controls.Add(this.label5);
            this.EditItemPanel.Controls.Add(this.label8);
            this.EditItemPanel.Controls.Add(this.label7);
            this.EditItemPanel.Controls.Add(this.label6);
            this.EditItemPanel.Location = new System.Drawing.Point(502, 85);
            this.EditItemPanel.Name = "EditItemPanel";
            this.EditItemPanel.Size = new System.Drawing.Size(385, 567);
            this.EditItemPanel.TabIndex = 7;
            this.EditItemPanel.Visible = false;
            // 
            // submitEditBtn
            // 
            this.submitEditBtn.Font = new System.Drawing.Font("Lato Light", 10F);
            this.submitEditBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.submitEditBtn.Location = new System.Drawing.Point(127, 501);
            this.submitEditBtn.Name = "submitEditBtn";
            this.submitEditBtn.Size = new System.Drawing.Size(87, 29);
            this.submitEditBtn.TabIndex = 11;
            this.submitEditBtn.Text = "Submit";
            this.submitEditBtn.UseVisualStyleBackColor = true;
            this.submitEditBtn.Click += new System.EventHandler(this.submitEditBtn_Click);
            // 
            // EditPriceTxt
            // 
            this.EditPriceTxt.Location = new System.Drawing.Point(34, 456);
            this.EditPriceTxt.Multiline = true;
            this.EditPriceTxt.Name = "EditPriceTxt";
            this.EditPriceTxt.Size = new System.Drawing.Size(273, 26);
            this.EditPriceTxt.TabIndex = 10;
            // 
            // editNameTxt
            // 
            this.editNameTxt.Location = new System.Drawing.Point(34, 381);
            this.editNameTxt.Multiline = true;
            this.editNameTxt.Name = "editNameTxt";
            this.editNameTxt.Size = new System.Drawing.Size(273, 26);
            this.editNameTxt.TabIndex = 9;
            // 
            // EditProdGridView
            // 
            this.EditProdGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EditProdGridView.Location = new System.Drawing.Point(34, 283);
            this.EditProdGridView.Name = "EditProdGridView";
            this.EditProdGridView.Size = new System.Drawing.Size(273, 69);
            this.EditProdGridView.TabIndex = 8;
            this.EditProdGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // editViewBtn
            // 
            this.editViewBtn.Font = new System.Drawing.Font("Lato Light", 10F);
            this.editViewBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.editViewBtn.Location = new System.Drawing.Point(127, 214);
            this.editViewBtn.Name = "editViewBtn";
            this.editViewBtn.Size = new System.Drawing.Size(87, 29);
            this.editViewBtn.TabIndex = 7;
            this.editViewBtn.Text = "View";
            this.editViewBtn.UseVisualStyleBackColor = true;
            this.editViewBtn.Click += new System.EventHandler(this.editViewBtn_Click);
            // 
            // editTextBox
            // 
            this.editTextBox.Location = new System.Drawing.Point(34, 183);
            this.editTextBox.Multiline = true;
            this.editTextBox.Name = "editTextBox";
            this.editTextBox.Size = new System.Drawing.Size(273, 25);
            this.editTextBox.TabIndex = 6;
            this.editTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(121, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Edit Product";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lato", 13F);
            this.label8.ForeColor = System.Drawing.Color.Snow;
            this.label8.Location = new System.Drawing.Point(30, 431);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Enter new Price";
            this.label8.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lato", 13F);
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(30, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Enter new Name";
            this.label7.Click += new System.EventHandler(this.label6_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato", 13F);
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(30, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Enter product to edit";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // DeletePanel
            // 
            this.DeletePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.DeletePanel.Controls.Add(this.Deletebtn);
            this.DeletePanel.Controls.Add(this.deleteTxtBox);
            this.DeletePanel.Controls.Add(this.deleteLabel);
            this.DeletePanel.Controls.Add(this.label9);
            this.DeletePanel.Location = new System.Drawing.Point(502, 85);
            this.DeletePanel.Name = "DeletePanel";
            this.DeletePanel.Size = new System.Drawing.Size(385, 567);
            this.DeletePanel.TabIndex = 8;
            this.DeletePanel.Visible = false;
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.Snow;
            this.Deletebtn.Font = new System.Drawing.Font("Lato Light", 10F);
            this.Deletebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.Deletebtn.Location = new System.Drawing.Point(139, 225);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(87, 29);
            this.Deletebtn.TabIndex = 7;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // deleteTxtBox
            // 
            this.deleteTxtBox.Location = new System.Drawing.Point(44, 189);
            this.deleteTxtBox.Multiline = true;
            this.deleteTxtBox.Name = "deleteTxtBox";
            this.deleteTxtBox.Size = new System.Drawing.Size(273, 25);
            this.deleteTxtBox.TabIndex = 6;
            // 
            // deleteLabel
            // 
            this.deleteLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deleteLabel.AutoSize = true;
            this.deleteLabel.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteLabel.ForeColor = System.Drawing.Color.Snow;
            this.deleteLabel.Location = new System.Drawing.Point(105, 99);
            this.deleteLabel.Name = "deleteLabel";
            this.deleteLabel.Size = new System.Drawing.Size(174, 29);
            this.deleteLabel.TabIndex = 5;
            this.deleteLabel.Text = "Delete Product";
            this.deleteLabel.Click += new System.EventHandler(this.Viewitems_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lato", 13F);
            this.label9.ForeColor = System.Drawing.Color.Snow;
            this.label9.Location = new System.Drawing.Point(40, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Enter product to delete";
            this.label9.Click += new System.EventHandler(this.label6_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Snow;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Lato Light", 10F);
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.button6.Location = new System.Drawing.Point(23, 477);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 46);
            this.button6.TabIndex = 9;
            this.button6.Text = "Manage Employees";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Snow;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Lato Light", 10F);
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.button7.Location = new System.Drawing.Point(23, 408);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(110, 46);
            this.button7.TabIndex = 10;
            this.button7.Text = "Manage Menu";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // CafeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 702);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.DeletePanel);
            this.Controls.Add(this.EditItemPanel);
            this.Controls.Add(this.ViewProductPanel);
            this.Controls.Add(this.AddItemPanel);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
            this.EditItemPanel.ResumeLayout(false);
            this.EditItemPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditProdGridView)).EndInit();
            this.DeletePanel.ResumeLayout(false);
            this.DeletePanel.PerformLayout();
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
        private System.Windows.Forms.Panel EditItemPanel;
        private System.Windows.Forms.TextBox editTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView EditProdGridView;
        private System.Windows.Forms.Button editViewBtn;
        private System.Windows.Forms.Button submitEditBtn;
        private System.Windows.Forms.TextBox EditPriceTxt;
        private System.Windows.Forms.TextBox editNameTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel DeletePanel;
        private System.Windows.Forms.Label deleteLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox deleteTxtBox;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}