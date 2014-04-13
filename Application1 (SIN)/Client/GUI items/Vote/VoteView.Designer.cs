namespace Client.GUI_items.Vote
{
    partial class VoteView
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
            this.itemList = new System.Windows.Forms.ListView();
            this.IdColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.voteItemBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.votePriceLine = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.voteNameLine = new System.Windows.Forms.TextBox();
            this.closeRightPanelBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.rightPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemList
            // 
            this.itemList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdColumn,
            this.NameColumn,
            this.PriceColumn});
            this.itemList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.itemList.FullRowSelect = true;
            this.itemList.GridLines = true;
            this.itemList.Location = new System.Drawing.Point(94, 72);
            this.itemList.Name = "itemList";
            this.itemList.ShowGroups = false;
            this.itemList.Size = new System.Drawing.Size(405, 196);
            this.itemList.TabIndex = 6;
            this.itemList.UseCompatibleStateImageBehavior = false;
            this.itemList.View = System.Windows.Forms.View.Details;
            this.itemList.SelectedIndexChanged += new System.EventHandler(this.itemList_SelectedIndexChanged);
            this.itemList.Resize += new System.EventHandler(this.itemList_Resize);
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
            // categoryBox
            // 
            this.categoryBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Location = new System.Drawing.Point(179, 32);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(157, 25);
            this.categoryBox.TabIndex = 5;
            this.categoryBox.SelectedIndexChanged += new System.EventHandler(this.categoryBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.label1.Location = new System.Drawing.Point(90, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Category:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.rightPanel.Controls.Add(this.label5);
            this.rightPanel.Controls.Add(this.voteItemBtn);
            this.rightPanel.Controls.Add(this.label3);
            this.rightPanel.Controls.Add(this.votePriceLine);
            this.rightPanel.Controls.Add(this.label2);
            this.rightPanel.Controls.Add(this.voteNameLine);
            this.rightPanel.Controls.Add(this.closeRightPanelBtn);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.ForeColor = System.Drawing.Color.Coral;
            this.rightPanel.Location = new System.Drawing.Point(591, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(287, 363);
            this.rightPanel.TabIndex = 7;
            this.rightPanel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(138)))), ((int)(((byte)(41)))));
            this.label5.Location = new System.Drawing.Point(84, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Vote Item";
            // 
            // voteItemBtn
            // 
            this.voteItemBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.voteItemBtn.BackColor = System.Drawing.Color.White;
            this.voteItemBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voteItemBtn.FlatAppearance.BorderSize = 0;
            this.voteItemBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.voteItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voteItemBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voteItemBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.voteItemBtn.Location = new System.Drawing.Point(118, 308);
            this.voteItemBtn.Name = "voteItemBtn";
            this.voteItemBtn.Size = new System.Drawing.Size(125, 34);
            this.voteItemBtn.TabIndex = 7;
            this.voteItemBtn.Text = "Vote";
            this.voteItemBtn.UseVisualStyleBackColor = false;
            this.voteItemBtn.Click += new System.EventHandler(this.voteItemBtn_Click);
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
            // votePriceLine
            // 
            this.votePriceLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.votePriceLine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.votePriceLine.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.votePriceLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.votePriceLine.Location = new System.Drawing.Point(89, 222);
            this.votePriceLine.Name = "votePriceLine";
            this.votePriceLine.ReadOnly = true;
            this.votePriceLine.Size = new System.Drawing.Size(154, 26);
            this.votePriceLine.TabIndex = 4;
            this.votePriceLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // voteNameLine
            // 
            this.voteNameLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.voteNameLine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.voteNameLine.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voteNameLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.voteNameLine.Location = new System.Drawing.Point(89, 170);
            this.voteNameLine.Name = "voteNameLine";
            this.voteNameLine.ReadOnly = true;
            this.voteNameLine.Size = new System.Drawing.Size(154, 26);
            this.voteNameLine.TabIndex = 1;
            this.voteNameLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.label4.Image = global::Client.Properties.Resources.coints_small;
            this.label4.Location = new System.Drawing.Point(71, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 21);
            this.label4.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pointsLabel);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(353, 32);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(232, 25);
            this.flowLayoutPanel1.TabIndex = 9;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.pointsLabel.Location = new System.Drawing.Point(3, 0);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(62, 21);
            this.pointsLabel.TabIndex = 10;
            this.pointsLabel.Text = "Points:";
            // 
            // VoteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.itemList);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.label1);
            this.Name = "VoteView";
            this.Size = new System.Drawing.Size(878, 363);
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView itemList;
        private System.Windows.Forms.ColumnHeader IdColumn;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader PriceColumn;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button voteItemBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox votePriceLine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox voteNameLine;
        private System.Windows.Forms.Button closeRightPanelBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label pointsLabel;
    }
}
