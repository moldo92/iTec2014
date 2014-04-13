namespace Client.GUI_items.Users
{
    partial class UserView
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
            this.usersList = new System.Windows.Forms.ListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PointsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupsBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PasswordColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rightPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.saveItemBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.savePointLine = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveNameLine = new System.Windows.Forms.TextBox();
            this.closeRightPanelBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.usernameLine = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.savePasswordLine = new System.Windows.Forms.TextBox();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // usersList
            // 
            this.usersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usersList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.PointsColumn,
            this.UsernameColumn,
            this.PasswordColumn});
            this.usersList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.usersList.FullRowSelect = true;
            this.usersList.GridLines = true;
            this.usersList.Location = new System.Drawing.Point(99, 71);
            this.usersList.Name = "usersList";
            this.usersList.ShowGroups = false;
            this.usersList.Size = new System.Drawing.Size(334, 196);
            this.usersList.TabIndex = 6;
            this.usersList.UseCompatibleStateImageBehavior = false;
            this.usersList.View = System.Windows.Forms.View.Details;
            this.usersList.SelectedIndexChanged += new System.EventHandler(this.usersList_SelectedIndexChanged);
            this.usersList.Resize += new System.EventHandler(this.usersList_Resize);
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 84;
            // 
            // PointsColumn
            // 
            this.PointsColumn.Text = "Points";
            this.PointsColumn.Width = 109;
            // 
            // groupsBox
            // 
            this.groupsBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupsBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.groupsBox.FormattingEnabled = true;
            this.groupsBox.Location = new System.Drawing.Point(184, 31);
            this.groupsBox.Name = "groupsBox";
            this.groupsBox.Size = new System.Drawing.Size(157, 25);
            this.groupsBox.TabIndex = 5;
            this.groupsBox.SelectedIndexChanged += new System.EventHandler(this.categoryBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.label1.Location = new System.Drawing.Point(95, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Groups:";
            // 
            // UsernameColumn
            // 
            this.UsernameColumn.Text = "Username";
            // 
            // PasswordColumn
            // 
            this.PasswordColumn.Text = "Password";
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.rightPanel.Controls.Add(this.label7);
            this.rightPanel.Controls.Add(this.savePasswordLine);
            this.rightPanel.Controls.Add(this.label6);
            this.rightPanel.Controls.Add(this.usernameLine);
            this.rightPanel.Controls.Add(this.label5);
            this.rightPanel.Controls.Add(this.saveItemBtn);
            this.rightPanel.Controls.Add(this.label3);
            this.rightPanel.Controls.Add(this.savePointLine);
            this.rightPanel.Controls.Add(this.label2);
            this.rightPanel.Controls.Add(this.saveNameLine);
            this.rightPanel.Controls.Add(this.closeRightPanelBtn);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.ForeColor = System.Drawing.Color.Coral;
            this.rightPanel.Location = new System.Drawing.Point(460, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(361, 343);
            this.rightPanel.TabIndex = 7;
            this.rightPanel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(138)))), ((int)(((byte)(41)))));
            this.label5.Location = new System.Drawing.Point(105, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Modify User";
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
            this.saveItemBtn.Location = new System.Drawing.Point(228, 291);
            this.saveItemBtn.Name = "saveItemBtn";
            this.saveItemBtn.Size = new System.Drawing.Size(117, 34);
            this.saveItemBtn.TabIndex = 7;
            this.saveItemBtn.Text = "Save";
            this.saveItemBtn.UseVisualStyleBackColor = false;
            this.saveItemBtn.Click += new System.EventHandler(this.saveItemBtn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(138)))), ((int)(((byte)(41)))));
            this.label3.Location = new System.Drawing.Point(25, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Points:";
            // 
            // savePointLine
            // 
            this.savePointLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.savePointLine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.savePointLine.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePointLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.savePointLine.Location = new System.Drawing.Point(137, 233);
            this.savePointLine.Name = "savePointLine";
            this.savePointLine.Size = new System.Drawing.Size(208, 26);
            this.savePointLine.TabIndex = 4;
            this.savePointLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(138)))), ((int)(((byte)(41)))));
            this.label2.Location = new System.Drawing.Point(25, 201);
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
            this.saveNameLine.Location = new System.Drawing.Point(137, 201);
            this.saveNameLine.Name = "saveNameLine";
            this.saveNameLine.Size = new System.Drawing.Size(208, 26);
            this.saveNameLine.TabIndex = 1;
            this.saveNameLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // closeRightPanelBtn
            // 
            this.closeRightPanelBtn.FlatAppearance.BorderSize = 0;
            this.closeRightPanelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeRightPanelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(138)))), ((int)(((byte)(41)))));
            this.closeRightPanelBtn.Location = new System.Drawing.Point(336, 3);
            this.closeRightPanelBtn.Name = "closeRightPanelBtn";
            this.closeRightPanelBtn.Size = new System.Drawing.Size(22, 23);
            this.closeRightPanelBtn.TabIndex = 0;
            this.closeRightPanelBtn.Text = "x";
            this.closeRightPanelBtn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.closeRightPanelBtn.UseVisualStyleBackColor = true;
            this.closeRightPanelBtn.Click += new System.EventHandler(this.closeRightPanelBtn_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(138)))), ((int)(((byte)(41)))));
            this.label6.Location = new System.Drawing.Point(25, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Username:";
            // 
            // usernameLine
            // 
            this.usernameLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.usernameLine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameLine.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.usernameLine.Location = new System.Drawing.Point(137, 137);
            this.usernameLine.Name = "usernameLine";
            this.usernameLine.ReadOnly = true;
            this.usernameLine.Size = new System.Drawing.Size(208, 26);
            this.usernameLine.TabIndex = 9;
            this.usernameLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(138)))), ((int)(((byte)(41)))));
            this.label7.Location = new System.Drawing.Point(25, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Password:";
            // 
            // savePasswordLine
            // 
            this.savePasswordLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.savePasswordLine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.savePasswordLine.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePasswordLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.savePasswordLine.Location = new System.Drawing.Point(137, 169);
            this.savePasswordLine.Name = "savePasswordLine";
            this.savePasswordLine.Size = new System.Drawing.Size(208, 26);
            this.savePasswordLine.TabIndex = 11;
            this.savePasswordLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // UserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.usersList);
            this.Controls.Add(this.groupsBox);
            this.Controls.Add(this.label1);
            this.Name = "UserView";
            this.Size = new System.Drawing.Size(821, 343);
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView usersList;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader PointsColumn;
        private System.Windows.Forms.ComboBox groupsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader UsernameColumn;
        private System.Windows.Forms.ColumnHeader PasswordColumn;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox savePasswordLine;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox usernameLine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveItemBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox savePointLine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox saveNameLine;
        private System.Windows.Forms.Button closeRightPanelBtn;
    }
}
