namespace Client.GUI_items.Items
{
    partial class Items
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.ItemsView = new System.Windows.Forms.ListView();
            this.IdColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rightPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.saveItemBtn = new System.Windows.Forms.Button();
            this.saveCategoryBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.savePriceLine = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveNameLine = new System.Windows.Forms.TextBox();
            this.closeRightPanelBtn = new System.Windows.Forms.Button();
            this.addCategoryPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.addCategoryBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.newCategoryLine = new System.Windows.Forms.TextBox();
            this.closeAddCategoryPanel = new System.Windows.Forms.Button();
            this.addCategoryOpenPanelBtn = new System.Windows.Forms.Button();
            this.rightPanel.SuspendLayout();
            this.addCategoryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.label1.Location = new System.Drawing.Point(92, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // categoryBox
            // 
            this.categoryBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Location = new System.Drawing.Point(181, 30);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(157, 25);
            this.categoryBox.TabIndex = 1;
            this.categoryBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ItemsView
            // 
            this.ItemsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdColumn,
            this.NameColumn,
            this.PriceColumn});
            this.ItemsView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.ItemsView.FullRowSelect = true;
            this.ItemsView.GridLines = true;
            this.ItemsView.Location = new System.Drawing.Point(96, 70);
            this.ItemsView.Name = "ItemsView";
            this.ItemsView.ShowGroups = false;
            this.ItemsView.Size = new System.Drawing.Size(405, 196);
            this.ItemsView.TabIndex = 3;
            this.ItemsView.UseCompatibleStateImageBehavior = false;
            this.ItemsView.View = System.Windows.Forms.View.Details;
            this.ItemsView.SelectedIndexChanged += new System.EventHandler(this.itemsList_SelectedIndexChanged);
            this.ItemsView.Resize += new System.EventHandler(this.ItemsView_Resize);
            // 
            // IdColumn
            // 
            this.IdColumn.Text = "Id";
            this.IdColumn.Width = 0;
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 200;
            // 
            // PriceColumn
            // 
            this.PriceColumn.Text = "Price";
            this.PriceColumn.Width = 200;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.rightPanel.Controls.Add(this.label5);
            this.rightPanel.Controls.Add(this.saveItemBtn);
            this.rightPanel.Controls.Add(this.saveCategoryBox);
            this.rightPanel.Controls.Add(this.label4);
            this.rightPanel.Controls.Add(this.label3);
            this.rightPanel.Controls.Add(this.savePriceLine);
            this.rightPanel.Controls.Add(this.label2);
            this.rightPanel.Controls.Add(this.saveNameLine);
            this.rightPanel.Controls.Add(this.closeRightPanelBtn);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.ForeColor = System.Drawing.Color.Coral;
            this.rightPanel.Location = new System.Drawing.Point(540, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(287, 361);
            this.rightPanel.TabIndex = 4;
            this.rightPanel.Visible = false;
            this.rightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(138)))), ((int)(((byte)(41)))));
            this.label5.Location = new System.Drawing.Point(65, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Modify Items";
            // 
            // saveItemBtn
            // 
            this.saveItemBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveItemBtn.BackColor = System.Drawing.Color.White;
            this.saveItemBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveItemBtn.FlatAppearance.BorderSize = 0;
            this.saveItemBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.saveItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveItemBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveItemBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.saveItemBtn.Location = new System.Drawing.Point(118, 306);
            this.saveItemBtn.Name = "saveItemBtn";
            this.saveItemBtn.Size = new System.Drawing.Size(125, 34);
            this.saveItemBtn.TabIndex = 7;
            this.saveItemBtn.Text = "Save";
            this.saveItemBtn.UseVisualStyleBackColor = false;
            this.saveItemBtn.Click += new System.EventHandler(this.saveItemBtn_Click);
            // 
            // saveCategoryBox
            // 
            this.saveCategoryBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.saveCategoryBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveCategoryBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveCategoryBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.saveCategoryBox.FormattingEnabled = true;
            this.saveCategoryBox.Location = new System.Drawing.Point(118, 275);
            this.saveCategoryBox.Name = "saveCategoryBox";
            this.saveCategoryBox.Size = new System.Drawing.Size(125, 25);
            this.saveCategoryBox.TabIndex = 5;
            this.saveCategoryBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(138)))), ((int)(((byte)(41)))));
            this.label4.Location = new System.Drawing.Point(14, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Category:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(138)))), ((int)(((byte)(41)))));
            this.label3.Location = new System.Drawing.Point(14, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price:";
            // 
            // savePriceLine
            // 
            this.savePriceLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.savePriceLine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.savePriceLine.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePriceLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.savePriceLine.Location = new System.Drawing.Point(89, 222);
            this.savePriceLine.Name = "savePriceLine";
            this.savePriceLine.Size = new System.Drawing.Size(154, 26);
            this.savePriceLine.TabIndex = 4;
            this.savePriceLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(138)))), ((int)(((byte)(41)))));
            this.label2.Location = new System.Drawing.Point(14, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // saveNameLine
            // 
            this.saveNameLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.saveNameLine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.saveNameLine.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveNameLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.saveNameLine.Location = new System.Drawing.Point(89, 170);
            this.saveNameLine.Name = "saveNameLine";
            this.saveNameLine.ReadOnly = true;
            this.saveNameLine.Size = new System.Drawing.Size(154, 26);
            this.saveNameLine.TabIndex = 1;
            this.saveNameLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.saveNameLine.TextChanged += new System.EventHandler(this.usernameLine_TextChanged);
            // 
            // closeRightPanelBtn
            // 
            this.closeRightPanelBtn.FlatAppearance.BorderSize = 0;
            this.closeRightPanelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeRightPanelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(138)))), ((int)(((byte)(41)))));
            this.closeRightPanelBtn.Location = new System.Drawing.Point(262, 3);
            this.closeRightPanelBtn.Name = "closeRightPanelBtn";
            this.closeRightPanelBtn.Size = new System.Drawing.Size(22, 23);
            this.closeRightPanelBtn.TabIndex = 0;
            this.closeRightPanelBtn.Text = "x";
            this.closeRightPanelBtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.closeRightPanelBtn.UseVisualStyleBackColor = true;
            this.closeRightPanelBtn.Click += new System.EventHandler(this.closeRightPanelBtn_Click);
            // 
            // addCategoryPanel
            // 
            this.addCategoryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.addCategoryPanel.Controls.Add(this.label6);
            this.addCategoryPanel.Controls.Add(this.addCategoryBtn);
            this.addCategoryPanel.Controls.Add(this.label9);
            this.addCategoryPanel.Controls.Add(this.newCategoryLine);
            this.addCategoryPanel.Controls.Add(this.closeAddCategoryPanel);
            this.addCategoryPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.addCategoryPanel.ForeColor = System.Drawing.Color.Coral;
            this.addCategoryPanel.Location = new System.Drawing.Point(253, 0);
            this.addCategoryPanel.Name = "addCategoryPanel";
            this.addCategoryPanel.Size = new System.Drawing.Size(287, 361);
            this.addCategoryPanel.TabIndex = 9;
            this.addCategoryPanel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(138)))), ((int)(((byte)(41)))));
            this.label6.Location = new System.Drawing.Point(59, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 30);
            this.label6.TabIndex = 8;
            this.label6.Text = "Add Category";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // addCategoryBtn
            // 
            this.addCategoryBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.addCategoryBtn.BackColor = System.Drawing.Color.White;
            this.addCategoryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCategoryBtn.FlatAppearance.BorderSize = 0;
            this.addCategoryBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.addCategoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategoryBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategoryBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.addCategoryBtn.Location = new System.Drawing.Point(123, 222);
            this.addCategoryBtn.Name = "addCategoryBtn";
            this.addCategoryBtn.Size = new System.Drawing.Size(125, 34);
            this.addCategoryBtn.TabIndex = 7;
            this.addCategoryBtn.Text = "Add";
            this.addCategoryBtn.UseVisualStyleBackColor = false;
            this.addCategoryBtn.Click += new System.EventHandler(this.addCategoryBtn_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(138)))), ((int)(((byte)(41)))));
            this.label9.Location = new System.Drawing.Point(19, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Name:";
            // 
            // newCategoryLine
            // 
            this.newCategoryLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.newCategoryLine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newCategoryLine.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCategoryLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.newCategoryLine.Location = new System.Drawing.Point(94, 171);
            this.newCategoryLine.Name = "newCategoryLine";
            this.newCategoryLine.Size = new System.Drawing.Size(154, 26);
            this.newCategoryLine.TabIndex = 1;
            this.newCategoryLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // closeAddCategoryPanel
            // 
            this.closeAddCategoryPanel.FlatAppearance.BorderSize = 0;
            this.closeAddCategoryPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeAddCategoryPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(138)))), ((int)(((byte)(41)))));
            this.closeAddCategoryPanel.Location = new System.Drawing.Point(262, 3);
            this.closeAddCategoryPanel.Name = "closeAddCategoryPanel";
            this.closeAddCategoryPanel.Size = new System.Drawing.Size(22, 23);
            this.closeAddCategoryPanel.TabIndex = 0;
            this.closeAddCategoryPanel.Text = "x";
            this.closeAddCategoryPanel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.closeAddCategoryPanel.UseVisualStyleBackColor = true;
            this.closeAddCategoryPanel.Click += new System.EventHandler(this.closeAddCategoryPanel_Click);
            // 
            // addCategoryOpenPanelBtn
            // 
            this.addCategoryOpenPanelBtn.BackgroundImage = global::Client.Properties.Resources.add_small;
            this.addCategoryOpenPanelBtn.FlatAppearance.BorderSize = 0;
            this.addCategoryOpenPanelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategoryOpenPanelBtn.Location = new System.Drawing.Point(344, 28);
            this.addCategoryOpenPanelBtn.Name = "addCategoryOpenPanelBtn";
            this.addCategoryOpenPanelBtn.Size = new System.Drawing.Size(27, 27);
            this.addCategoryOpenPanelBtn.TabIndex = 10;
            this.addCategoryOpenPanelBtn.UseVisualStyleBackColor = true;
            this.addCategoryOpenPanelBtn.Click += new System.EventHandler(this.addCategoryOpenPanelBtn_Click);
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.addCategoryPanel);
            this.Controls.Add(this.addCategoryOpenPanelBtn);
            this.Controls.Add(this.ItemsView);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rightPanel);
            this.Name = "Items";
            this.Size = new System.Drawing.Size(827, 361);
            this.Load += new System.EventHandler(this.Items_Load);
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.addCategoryPanel.ResumeLayout(false);
            this.addCategoryPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.ListView ItemsView;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader PriceColumn;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.ColumnHeader IdColumn;
        private System.Windows.Forms.Button closeRightPanelBtn;
        private System.Windows.Forms.TextBox saveNameLine;
        private System.Windows.Forms.ComboBox saveCategoryBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox savePriceLine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveItemBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel addCategoryPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addCategoryBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox newCategoryLine;
        private System.Windows.Forms.Button closeAddCategoryPanel;
        private System.Windows.Forms.Button addCategoryOpenPanelBtn;
    }
}
