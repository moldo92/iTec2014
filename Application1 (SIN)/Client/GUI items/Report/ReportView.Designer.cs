namespace Client.GUI_items.Report
{
    partial class ReportView
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
            this.button1 = new System.Windows.Forms.Button();
            this.currencyBox = new System.Windows.Forms.ComboBox();
            this.budgetTextBox = new System.Windows.Forms.TextBox();
            this.reportList = new System.Windows.Forms.ListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PointsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VotesColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BudgetColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bugdetLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(496, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Get report";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // currencyBox
            // 
            this.currencyBox.FormattingEnabled = true;
            this.currencyBox.Items.AddRange(new object[] {
            "EUR",
            "RON",
            "USD"});
            this.currencyBox.Location = new System.Drawing.Point(420, 68);
            this.currencyBox.Name = "currencyBox";
            this.currencyBox.Size = new System.Drawing.Size(70, 21);
            this.currencyBox.TabIndex = 19;
            // 
            // budgetTextBox
            // 
            this.budgetTextBox.Location = new System.Drawing.Point(357, 69);
            this.budgetTextBox.Name = "budgetTextBox";
            this.budgetTextBox.Size = new System.Drawing.Size(57, 20);
            this.budgetTextBox.TabIndex = 18;
            // 
            // reportList
            // 
            this.reportList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.PointsColumn,
            this.VotesColumn,
            this.BudgetColumn});
            this.reportList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.reportList.FullRowSelect = true;
            this.reportList.GridLines = true;
            this.reportList.Location = new System.Drawing.Point(286, 98);
            this.reportList.Name = "reportList";
            this.reportList.ShowGroups = false;
            this.reportList.Size = new System.Drawing.Size(334, 196);
            this.reportList.TabIndex = 17;
            this.reportList.UseCompatibleStateImageBehavior = false;
            this.reportList.View = System.Windows.Forms.View.Details;
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
            // VotesColumn
            // 
            this.VotesColumn.Text = "Votes";
            // 
            // BudgetColumn
            // 
            this.BudgetColumn.Text = "Budget";
            // 
            // bugdetLabel
            // 
            this.bugdetLabel.AutoSize = true;
            this.bugdetLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bugdetLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(34)))));
            this.bugdetLabel.Location = new System.Drawing.Point(282, 69);
            this.bugdetLabel.Name = "bugdetLabel";
            this.bugdetLabel.Size = new System.Drawing.Size(69, 21);
            this.bugdetLabel.TabIndex = 16;
            this.bugdetLabel.Text = "Budget:";
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.currencyBox);
            this.Controls.Add(this.budgetTextBox);
            this.Controls.Add(this.reportList);
            this.Controls.Add(this.bugdetLabel);
            this.Name = "ReportView";
            this.Size = new System.Drawing.Size(902, 361);
            this.Resize += new System.EventHandler(this.ReportView_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox currencyBox;
        private System.Windows.Forms.TextBox budgetTextBox;
        private System.Windows.Forms.ListView reportList;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader PointsColumn;
        private System.Windows.Forms.ColumnHeader VotesColumn;
        private System.Windows.Forms.ColumnHeader BudgetColumn;
        private System.Windows.Forms.Label bugdetLabel;



    }
}
