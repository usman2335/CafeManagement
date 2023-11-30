namespace CafeManagement
{
    partial class InventoryManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ViewInventoryPanel = new System.Windows.Forms.Panel();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.checkInvText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.viewInventoryGrid = new System.Windows.Forms.DataGridView();
            this.AddItemPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.addText = new System.Windows.Forms.TextBox();
            this.quantityTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.RemoveItemPanel = new System.Windows.Forms.Panel();
            this.RemoveTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ViewInventoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewInventoryGrid)).BeginInit();
            this.AddItemPanel.SuspendLayout();
            this.RemoveItemPanel.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1350, 79);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(566, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Inventory Manager";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Snow;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.button2.Location = new System.Drawing.Point(1222, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "Log Out";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EditBtn.BackColor = System.Drawing.Color.Snow;
            this.EditBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Lato Light", 10F);
            this.EditBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.EditBtn.Location = new System.Drawing.Point(34, 376);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(110, 37);
            this.EditBtn.TabIndex = 10;
            this.EditBtn.Text = "Edit Inventory";
            this.EditBtn.UseVisualStyleBackColor = false;
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RemoveBtn.BackColor = System.Drawing.Color.Snow;
            this.RemoveBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.RemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveBtn.Font = new System.Drawing.Font("Lato Light", 10F);
            this.RemoveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.RemoveBtn.Location = new System.Drawing.Point(34, 436);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(110, 37);
            this.RemoveBtn.TabIndex = 11;
            this.RemoveBtn.Text = "Remove Item";
            this.RemoveBtn.UseVisualStyleBackColor = false;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddBtn.BackColor = System.Drawing.Color.Snow;
            this.AddBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Lato Light", 10F);
            this.AddBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.AddBtn.Location = new System.Drawing.Point(34, 316);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(110, 37);
            this.AddBtn.TabIndex = 12;
            this.AddBtn.Text = "Add Item";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ViewBtn
            // 
            this.ViewBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ViewBtn.BackColor = System.Drawing.Color.Snow;
            this.ViewBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.ViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewBtn.Font = new System.Drawing.Font("Lato Light", 10F);
            this.ViewBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.ViewBtn.Location = new System.Drawing.Point(34, 264);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(110, 37);
            this.ViewBtn.TabIndex = 13;
            this.ViewBtn.Text = "View Inventory";
            this.ViewBtn.UseVisualStyleBackColor = false;
            this.ViewBtn.Click += new System.EventHandler(this.button1_Click);
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
            // ViewInventoryPanel
            // 
            this.ViewInventoryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.ViewInventoryPanel.Controls.Add(this.viewInventoryGrid);
            this.ViewInventoryPanel.Controls.Add(this.EnterBtn);
            this.ViewInventoryPanel.Controls.Add(this.checkInvText);
            this.ViewInventoryPanel.Controls.Add(this.label4);
            this.ViewInventoryPanel.Controls.Add(this.label10);
            this.ViewInventoryPanel.Location = new System.Drawing.Point(570, 118);
            this.ViewInventoryPanel.Name = "ViewInventoryPanel";
            this.ViewInventoryPanel.Size = new System.Drawing.Size(504, 499);
            this.ViewInventoryPanel.TabIndex = 14;
            this.ViewInventoryPanel.Visible = false;
            // 
            // EnterBtn
            // 
            this.EnterBtn.Font = new System.Drawing.Font("Lato", 8.25F);
            this.EnterBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.EnterBtn.Location = new System.Drawing.Point(189, 426);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(127, 40);
            this.EnterBtn.TabIndex = 13;
            this.EnterBtn.Text = "Enter";
            this.EnterBtn.UseVisualStyleBackColor = true;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // checkInvText
            // 
            this.checkInvText.Location = new System.Drawing.Point(66, 390);
            this.checkInvText.Multiline = true;
            this.checkInvText.Name = "checkInvText";
            this.checkInvText.Size = new System.Drawing.Size(382, 30);
            this.checkInvText.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 13F);
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(56, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Enter Product Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(157, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "View Inventory";
            // 
            // viewInventoryGrid
            // 
            this.viewInventoryGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.viewInventoryGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.viewInventoryGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.viewInventoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewInventoryGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.viewInventoryGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.viewInventoryGrid.Location = new System.Drawing.Point(28, 137);
            this.viewInventoryGrid.Name = "viewInventoryGrid";
            this.viewInventoryGrid.Size = new System.Drawing.Size(456, 183);
            this.viewInventoryGrid.TabIndex = 15;
            this.viewInventoryGrid.Visible = false;
            // 
            // AddItemPanel
            // 
            this.AddItemPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.AddItemPanel.Controls.Add(this.button1);
            this.AddItemPanel.Controls.Add(this.label6);
            this.AddItemPanel.Controls.Add(this.label5);
            this.AddItemPanel.Controls.Add(this.quantityTxt);
            this.AddItemPanel.Controls.Add(this.addText);
            this.AddItemPanel.Controls.Add(this.label2);
            this.AddItemPanel.Controls.Add(this.label7);
            this.AddItemPanel.Controls.Add(this.label3);
            this.AddItemPanel.Location = new System.Drawing.Point(570, 118);
            this.AddItemPanel.Name = "AddItemPanel";
            this.AddItemPanel.Size = new System.Drawing.Size(504, 499);
            this.AddItemPanel.TabIndex = 15;
            this.AddItemPanel.Visible = false;
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(137, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Add Item In Inventory";
            // 
            // addText
            // 
            this.addText.Location = new System.Drawing.Point(60, 145);
            this.addText.Multiline = true;
            this.addText.Name = "addText";
            this.addText.Size = new System.Drawing.Size(294, 30);
            this.addText.TabIndex = 12;
            // 
            // quantityTxt
            // 
            this.quantityTxt.Location = new System.Drawing.Point(388, 145);
            this.quantityTxt.Multiline = true;
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(28, 30);
            this.quantityTxt.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(422, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "+";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(424, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lato", 13F);
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(367, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Quantity";
            this.label7.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.button1.Location = new System.Drawing.Point(160, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // RemoveItemPanel
            // 
            this.RemoveItemPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.RemoveItemPanel.Controls.Add(this.button3);
            this.RemoveItemPanel.Controls.Add(this.RemoveTxt);
            this.RemoveItemPanel.Controls.Add(this.label8);
            this.RemoveItemPanel.Controls.Add(this.label9);
            this.RemoveItemPanel.Location = new System.Drawing.Point(570, 118);
            this.RemoveItemPanel.Name = "RemoveItemPanel";
            this.RemoveItemPanel.Size = new System.Drawing.Size(504, 499);
            this.RemoveItemPanel.TabIndex = 14;
            this.RemoveItemPanel.Visible = false;
            // 
            // RemoveTxt
            // 
            this.RemoveTxt.Location = new System.Drawing.Point(74, 159);
            this.RemoveTxt.Multiline = true;
            this.RemoveTxt.Name = "RemoveTxt";
            this.RemoveTxt.Size = new System.Drawing.Size(382, 30);
            this.RemoveTxt.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Snow;
            this.label8.Location = new System.Drawing.Point(129, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(276, 29);
            this.label8.TabIndex = 6;
            this.label8.Text = "Remove From Inventory";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lato", 13F);
            this.label9.ForeColor = System.Drawing.Color.Snow;
            this.label9.Location = new System.Drawing.Point(70, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 22);
            this.label9.TabIndex = 11;
            this.label9.Text = "Enter Inventory ID";
            this.label9.Click += new System.EventHandler(this.label3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lato", 13F);
            this.label10.ForeColor = System.Drawing.Color.Snow;
            this.label10.Location = new System.Drawing.Point(58, 365);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 22);
            this.label10.TabIndex = 11;
            this.label10.Text = "Enter Product Name";
            this.label10.Click += new System.EventHandler(this.label3_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Lato", 8.25F);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.button3.Location = new System.Drawing.Point(200, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 40);
            this.button3.TabIndex = 13;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // InventoryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 702);
            this.Controls.Add(this.AddItemPanel);
            this.Controls.Add(this.RemoveItemPanel);
            this.Controls.Add(this.ViewInventoryPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.ViewBtn);
            this.Controls.Add(this.AddBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "InventoryManager";
            this.Text = "InventoryManager";
            this.Load += new System.EventHandler(this.InventoryManager_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ViewInventoryPanel.ResumeLayout(false);
            this.ViewInventoryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewInventoryGrid)).EndInit();
            this.AddItemPanel.ResumeLayout(false);
            this.AddItemPanel.PerformLayout();
            this.RemoveItemPanel.ResumeLayout(false);
            this.RemoveItemPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button ViewBtn;
        private System.Windows.Forms.Panel ViewInventoryPanel;
        private System.Windows.Forms.Button EnterBtn;
        private System.Windows.Forms.TextBox checkInvText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView viewInventoryGrid;
        private System.Windows.Forms.Panel AddItemPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox quantityTxt;
        private System.Windows.Forms.TextBox addText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel RemoveItemPanel;
        private System.Windows.Forms.TextBox RemoveTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
    }
}