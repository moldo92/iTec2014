namespace Client
{
    partial class MainWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartBtn = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            this.usdRadioBtn = new System.Windows.Forms.RadioButton();
            this.euroRadioBtn = new System.Windows.Forms.RadioButton();
            this.ronRadioBtn = new System.Windows.Forms.RadioButton();
            this.getReportBtn = new System.Windows.Forms.Button();
            this.budgetTextBox = new System.Windows.Forms.TextBox();
            this.reportList = new System.Windows.Forms.ListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PointsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VotesColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BudgetColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bugdetLabel = new System.Windows.Forms.Label();
            this.leftFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.clientsButton = new System.Windows.Forms.Button();
            this.itemsButton = new System.Windows.Forms.Button();
            this.voteButton = new System.Windows.Forms.Button();
            this.reportBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voteItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.welcomeMessage = new System.Windows.Forms.Label();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.leftFlowPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.toolStripContainer1.ContentPanel.Controls.Add(this.contentPanel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.leftFlowPanel);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1152, 490);
            this.toolStripContainer1.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            this.toolStripContainer1.LeftToolStripPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(89)))), ((int)(((byte)(101)))));
            this.toolStripContainer1.LeftToolStripPanel.Click += new System.EventHandler(this.toolStripContainer1_LeftToolStripPanel_Click);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1152, 514);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.TopToolStripPanel.Click += new System.EventHandler(this.toolStripContainer1_TopToolStripPanel_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.welcomeMessage);
            this.contentPanel.Controls.Add(this.chart);
            this.contentPanel.Controls.Add(this.chartBtn);
            this.contentPanel.Controls.Add(this.exportBtn);
            this.contentPanel.Controls.Add(this.usdRadioBtn);
            this.contentPanel.Controls.Add(this.euroRadioBtn);
            this.contentPanel.Controls.Add(this.ronRadioBtn);
            this.contentPanel.Controls.Add(this.getReportBtn);
            this.contentPanel.Controls.Add(this.budgetTextBox);
            this.contentPanel.Controls.Add(this.reportList);
            this.contentPanel.Controls.Add(this.bugdetLabel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(63, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1089, 490);
            this.contentPanel.TabIndex = 2;
            this.contentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.contentPanel_Paint);
            this.contentPanel.Resize += new System.EventHandler(this.contentPanel_Resize);
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(745, 106);
            this.chart.Name = "chart";
            this.chart.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.chart.Size = new System.Drawing.Size(300, 300);
            this.chart.TabIndex = 21;
            this.chart.Text = "chart1";
            // 
            // chartBtn
            // 
            this.chartBtn.BackColor = System.Drawing.Color.White;
            this.chartBtn.Enabled = false;
            this.chartBtn.FlatAppearance.BorderSize = 0;
            this.chartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chartBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.chartBtn.Image = global::Client.Properties.Resources.rsz_chart;
            this.chartBtn.Location = new System.Drawing.Point(439, 44);
            this.chartBtn.Name = "chartBtn";
            this.chartBtn.Size = new System.Drawing.Size(55, 56);
            this.chartBtn.TabIndex = 20;
            this.chartBtn.UseVisualStyleBackColor = false;
            this.chartBtn.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // exportBtn
            // 
            this.exportBtn.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.exportBtn.Location = new System.Drawing.Point(412, 15);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(82, 23);
            this.exportBtn.TabIndex = 19;
            this.exportBtn.Text = "Export";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // usdRadioBtn
            // 
            this.usdRadioBtn.AutoSize = true;
            this.usdRadioBtn.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usdRadioBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.usdRadioBtn.Location = new System.Drawing.Point(264, 62);
            this.usdRadioBtn.Name = "usdRadioBtn";
            this.usdRadioBtn.Size = new System.Drawing.Size(52, 21);
            this.usdRadioBtn.TabIndex = 18;
            this.usdRadioBtn.Text = "USD";
            this.usdRadioBtn.UseVisualStyleBackColor = true;
            this.usdRadioBtn.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // euroRadioBtn
            // 
            this.euroRadioBtn.AutoSize = true;
            this.euroRadioBtn.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.euroRadioBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.euroRadioBtn.Location = new System.Drawing.Point(264, 40);
            this.euroRadioBtn.Name = "euroRadioBtn";
            this.euroRadioBtn.Size = new System.Drawing.Size(50, 21);
            this.euroRadioBtn.TabIndex = 17;
            this.euroRadioBtn.Text = "EUR";
            this.euroRadioBtn.UseVisualStyleBackColor = true;
            // 
            // ronRadioBtn
            // 
            this.ronRadioBtn.AutoSize = true;
            this.ronRadioBtn.Checked = true;
            this.ronRadioBtn.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ronRadioBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ronRadioBtn.Location = new System.Drawing.Point(264, 16);
            this.ronRadioBtn.Name = "ronRadioBtn";
            this.ronRadioBtn.Size = new System.Drawing.Size(54, 21);
            this.ronRadioBtn.TabIndex = 16;
            this.ronRadioBtn.TabStop = true;
            this.ronRadioBtn.Text = "RON";
            this.ronRadioBtn.UseVisualStyleBackColor = true;
            // 
            // getReportBtn
            // 
            this.getReportBtn.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getReportBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.getReportBtn.Location = new System.Drawing.Point(324, 15);
            this.getReportBtn.Name = "getReportBtn";
            this.getReportBtn.Size = new System.Drawing.Size(82, 23);
            this.getReportBtn.TabIndex = 15;
            this.getReportBtn.Text = "Get report";
            this.getReportBtn.UseVisualStyleBackColor = true;
            this.getReportBtn.Click += new System.EventHandler(this.getReportBtn_Click);
            // 
            // budgetTextBox
            // 
            this.budgetTextBox.Location = new System.Drawing.Point(201, 41);
            this.budgetTextBox.Name = "budgetTextBox";
            this.budgetTextBox.Size = new System.Drawing.Size(57, 20);
            this.budgetTextBox.TabIndex = 13;
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
            this.reportList.Location = new System.Drawing.Point(130, 106);
            this.reportList.Name = "reportList";
            this.reportList.ShowGroups = false;
            this.reportList.Size = new System.Drawing.Size(364, 196);
            this.reportList.TabIndex = 12;
            this.reportList.UseCompatibleStateImageBehavior = false;
            this.reportList.View = System.Windows.Forms.View.Details;
            this.reportList.Resize += new System.EventHandler(this.reportList_Resize);
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
            this.BudgetColumn.Width = 108;
            // 
            // bugdetLabel
            // 
            this.bugdetLabel.AutoSize = true;
            this.bugdetLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bugdetLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(34)))));
            this.bugdetLabel.Location = new System.Drawing.Point(126, 41);
            this.bugdetLabel.Name = "bugdetLabel";
            this.bugdetLabel.Size = new System.Drawing.Size(69, 21);
            this.bugdetLabel.TabIndex = 9;
            this.bugdetLabel.Text = "Budget:";
            // 
            // leftFlowPanel
            // 
            this.leftFlowPanel.Controls.Add(this.clientsButton);
            this.leftFlowPanel.Controls.Add(this.itemsButton);
            this.leftFlowPanel.Controls.Add(this.voteButton);
            this.leftFlowPanel.Controls.Add(this.reportBtn);
            this.leftFlowPanel.Controls.Add(this.button3);
            this.leftFlowPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.leftFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.leftFlowPanel.Name = "leftFlowPanel";
            this.leftFlowPanel.Size = new System.Drawing.Size(63, 490);
            this.leftFlowPanel.TabIndex = 1;
            this.leftFlowPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.leftFlowPanel_Paint);
            // 
            // clientsButton
            // 
            this.clientsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(34)))));
            this.clientsButton.FlatAppearance.BorderSize = 0;
            this.clientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientsButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.clientsButton.Image = global::Client.Properties.Resources.users_small;
            this.clientsButton.Location = new System.Drawing.Point(3, 3);
            this.clientsButton.Name = "clientsButton";
            this.clientsButton.Size = new System.Drawing.Size(55, 55);
            this.clientsButton.TabIndex = 0;
            this.clientsButton.UseVisualStyleBackColor = false;
            this.clientsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // itemsButton
            // 
            this.itemsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(34)))));
            this.itemsButton.FlatAppearance.BorderSize = 0;
            this.itemsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemsButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.itemsButton.Image = global::Client.Properties.Resources.items_small1;
            this.itemsButton.Location = new System.Drawing.Point(3, 64);
            this.itemsButton.Name = "itemsButton";
            this.itemsButton.Size = new System.Drawing.Size(55, 55);
            this.itemsButton.TabIndex = 1;
            this.itemsButton.UseVisualStyleBackColor = false;
            this.itemsButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // voteButton
            // 
            this.voteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(34)))));
            this.voteButton.FlatAppearance.BorderSize = 0;
            this.voteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voteButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voteButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.voteButton.Image = global::Client.Properties.Resources.vote_small;
            this.voteButton.Location = new System.Drawing.Point(3, 125);
            this.voteButton.Name = "voteButton";
            this.voteButton.Size = new System.Drawing.Size(55, 55);
            this.voteButton.TabIndex = 3;
            this.voteButton.UseVisualStyleBackColor = false;
            this.voteButton.Click += new System.EventHandler(this.voteButton_Click);
            // 
            // reportBtn
            // 
            this.reportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(34)))));
            this.reportBtn.FlatAppearance.BorderSize = 0;
            this.reportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.reportBtn.Image = global::Client.Properties.Resources.rsz_report;
            this.reportBtn.Location = new System.Drawing.Point(3, 186);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(55, 55);
            this.reportBtn.TabIndex = 4;
            this.reportBtn.UseVisualStyleBackColor = false;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(34)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Image = global::Client.Properties.Resources.logout_small;
            this.button3.Location = new System.Drawing.Point(3, 247);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 55);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1152, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.voteItemsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.editToolStripMenuItem.Text = "View";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.undoToolStripMenuItem.Text = "Users";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.redoToolStripMenuItem.Text = "Items";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cutToolStripMenuItem.Text = "Report";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // voteItemsToolStripMenuItem
            // 
            this.voteItemsToolStripMenuItem.Name = "voteItemsToolStripMenuItem";
            this.voteItemsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.voteItemsToolStripMenuItem.Text = "Vote Items";
            this.voteItemsToolStripMenuItem.Visible = false;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // welcomeMessage
            // 
            this.welcomeMessage.AutoSize = true;
            this.welcomeMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(34)))));
            this.welcomeMessage.Location = new System.Drawing.Point(854, 15);
            this.welcomeMessage.Name = "welcomeMessage";
            this.welcomeMessage.Size = new System.Drawing.Size(86, 21);
            this.welcomeMessage.TabIndex = 22;
            this.welcomeMessage.Text = "Welcome ";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 514);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.leftFlowPanel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Button clientsButton;
        private System.Windows.Forms.FlowLayoutPanel leftFlowPanel;
        private System.Windows.Forms.Button itemsButton;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.Button voteButton;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.ListView reportList;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader PointsColumn;
        private System.Windows.Forms.ColumnHeader VotesColumn;
        private System.Windows.Forms.ColumnHeader BudgetColumn;
        private System.Windows.Forms.Label bugdetLabel;
        private System.Windows.Forms.TextBox budgetTextBox;
        private System.Windows.Forms.Button getReportBtn;
        private System.Windows.Forms.RadioButton usdRadioBtn;
        private System.Windows.Forms.RadioButton euroRadioBtn;
        private System.Windows.Forms.RadioButton ronRadioBtn;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.Button chartBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voteItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label welcomeMessage;
    }
}

