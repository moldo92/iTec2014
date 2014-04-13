using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.GUI_items.Login;
using Model;
using Client.GUI_items.Items;
using Client.GUI_items.Controls;
using Client.GUI_items.Users;
using Client.GUI_items.Vote;
using Client.GUI_items.Report;
using System.Configuration;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace Client
{
    public partial class MainWindow : Form
    {
        private ClientController generalController;
        private Dictionary<string, Control> openedControlls;
        private string currentView = "";
        public MainWindow()
        {
            InitializeComponent();
            var panel = new Panel();
            panel.Name = "LoginPanel";
            var login = new Login();
            panel.Dock = DockStyle.Fill;
            this.Controls.Add(panel);
            panel.BringToFront();
            panel.BackColor = login.BackColor;
            panel.Controls.Add(login);
            login.Location = new Point((panel.Width - login.Width) / 2, (panel.Height - login.Height - 50) / 2);
            login.Anchor = AnchorStyles.None;
            HideShowReport(false);

        }

        public MainWindow(Login login, ClientController cc)
        {
            InitializeComponent();
            openedControlls = new Dictionary<string, Control>();
            this.generalController = cc;
            var panel = new Panel();
            panel.Name = "LoginPanel";
            login.LoginSuccesfull += login_LoginSuccesfull;
            panel.Dock = DockStyle.Fill;
            this.Controls.Add(panel);
            panel.BringToFront();
            panel.BackColor = login.BackColor;
            panel.Controls.Add(login);
            login.Location = new Point((panel.Width - login.Width) / 2, (panel.Height - login.Height - 50) / 2);
            login.Anchor = AnchorStyles.None;
            generalController.updateEvent += cc_updateEvent;
            HideShowReport(false);
        }

        void cc_updateEvent(object sender, GeneralEventArgs e)
        {
            if (e.GenEvent == GeneralEvents.ChangeCategory)
            {
                List<Category> newCategories = e.Data as List<Category>;
                string key = "itemsViewPanel";
                if (openedControlls.ContainsKey(key))
                {
                    (openedControlls[key] as Items).updateCategories(newCategories);
                }
            }
        }

        void login_LoginSuccesfull(object sender, EventArgs e)
        {
            foreach (var i in leftFlowPanel.Controls) (i as Button).Visible = true;
            var panel = this.Controls.Find("LoginPanel", true)[0];
            panel.Dispose();
            if (generalController.CurrentUser.Role == Helper.Util.ROLE.ADMIN)
            {
                voteItemsToolStripMenuItem.Visible = false;
                voteButton.Visible = false;
                cutToolStripMenuItem.Visible = true;
                redoToolStripMenuItem.Visible = true;
                undoToolStripMenuItem.Visible = true;
            }
            if (generalController.CurrentUser.Role == Helper.Util.ROLE.USER)
            {
                voteItemsToolStripMenuItem.Visible = true;
                cutToolStripMenuItem.Visible = false;
                redoToolStripMenuItem.Visible = false;
                undoToolStripMenuItem.Visible = false;
                clientsButton.Visible = itemsButton.Visible = reportBtn.Visible = false;
            }
            welcomeMessage.Text = "Welcome " + generalController.CurrentUser.Name + "!";
        }


        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (generalController.CurrentUser != null)
            {
                generalController.Logout();
                openedControlls = new Dictionary<string, Control>();
            }
            this.Dispose();
            openedControlls = new Dictionary<string, Control>();

        }

        private void toolStripContainer1_LeftToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloseLastView();
            string key = "usersViewPanel";
            UserView users = null;
            if (!openedControlls.ContainsKey(key))
            {
                //try
                //{
                //    //var cat = generalController.getCategories();
                //    //if (cat == null) cat = generalController.getCategories();
                //    //categories = new List<Category>(cat);
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Something went wrong: on the server\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    //return;
                //}
                if (!openedControlls.ContainsKey(key))
                {
                    users = new UserView(generalController);
                    users.Name = key;
                    openedControlls[key] = users;
                    contentPanel.Controls.Add(users);
                }
            }
            else users = openedControlls[key] as UserView;
            users.Dock = DockStyle.Fill;
            users.BringToFront();
            users.Visible = true;
            currentView = key;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CloseLastView();
            List<Category> categories = null;
            Items itemsView = null;
            string key = "itemsViewPanel";
            if (!openedControlls.ContainsKey(key))
            {
                try
                {
                    var cat = generalController.getCategories();
                    categories = new List<Category>(cat);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Oups, something went wrong:\n" + ex.Message + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!openedControlls.ContainsKey(key))
                {
                    itemsView = new Items(categories, generalController);
                    itemsView.Name = key;
                    openedControlls[key] = itemsView;
                    contentPanel.Controls.Add(itemsView);
                }
            }
            else itemsView = openedControlls[key] as Items;
            itemsView.SaveCategories += itemsView_SaveCategories;
            itemsView.Dock = DockStyle.Fill;
            itemsView.BringToFront();
            itemsView.Visible = true;
            currentView = key;
        }

        void itemsView_SaveCategories(object sender, SaveEventArgs e)
        {
            Item item = e.item;
            Category category = e.category;
            generalController.modifyCategory(item, category);
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Title_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void voteButton_Click(object sender, EventArgs e)
        {
            CloseLastView();
            string key = "voteViewPanel";
            VoteView votes = null;
            if (!openedControlls.ContainsKey(key))
            {
                //try
                //{
                //    //var cat = generalController.getCategories();
                //    //if (cat == null) cat = generalController.getCategories();
                //    //categories = new List<Category>(cat);
                //}
                //catch (Exception ex)
                //{
                //    //MessageBox.Show("Oups, something went wrong:\n" + ex.Message + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    //return;
                //}
                if (!openedControlls.ContainsKey(key))
                {
                    votes = new VoteView(generalController);
                    votes.Name = key;
                    openedControlls[key] = votes;
                    contentPanel.Controls.Add(votes);
                }
            }
            else votes = openedControlls[key] as VoteView;
            votes.Dock = DockStyle.Fill;
            votes.BringToFront();
            votes.Visible = true;
            currentView = key;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.generalController.Logout();
            var panel = new Panel();
            var login = new Login(this.generalController);
            panel.Name = "LoginPanel";
            //var login = new Login();
            login.LoginSuccesfull += login_LoginSuccesfull;
            panel.Dock = DockStyle.Fill;
            this.Controls.Add(panel);
            panel.BringToFront();
            panel.BackColor = login.BackColor;
            panel.Controls.Add(login);
            login.Location = new Point((panel.Width - login.Width) / 2, (panel.Height - login.Height - 50) / 2);
            login.Anchor = AnchorStyles.None;
            openedControlls = new Dictionary<string, Control>();
            var panelToClose = this.Controls.Find("voteViewPanel", true);
            HideShowReport(false);
            CloseLastView();

        }

        private void reportBtn_Click(object sender, EventArgs e)
        {

            CloseLastView();
            currentView = "";
            HideShowReport(true);
            chart.Visible = false;

        }

        private void CloseLastView()
        {
            if (!string.IsNullOrEmpty(currentView))
            {
                Control[] tbxs = this.Controls.Find(currentView, true);
                if (tbxs != null && tbxs.Length > 0)
                {
                    tbxs[0].Visible = false;
                }
            }
        }

        private void contentPanel_Resize(object sender, EventArgs e)
        {

        }

        private void reportList_Resize(object sender, EventArgs e)
        {
            NameColumn.Width = reportList.Width / 4;
            VotesColumn.Width = BudgetColumn.Width = PointsColumn.Width = NameColumn.Width;
        }

        private void HideShowReport(bool show)
        {
            reportList.Visible = show;
            euroRadioBtn.Visible = show;
            ronRadioBtn.Visible = show;
            usdRadioBtn.Visible = show;
            budgetTextBox.Visible = show;
            bugdetLabel.Visible = show;
            getReportBtn.Visible = show;
            exportBtn.Visible = show;
            chartBtn.Visible = show;
            chart.Visible = show;
        }

        private void leftFlowPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void getReportBtn_Click(object sender, EventArgs e)
        {
            chart.Visible = false;
            VotedCategories[] items = generalController.getVotedItems();
            reportList.Items.Clear();
            if (!string.IsNullOrEmpty(budgetTextBox.Text))
            {
                string currency = GetSelectedCurrency();
                int budget = int.Parse(budgetTextBox.Text);
                string rate = ConfigurationManager.AppSettings[currency];
                int total = items.Sum(x => x.Votes);
                foreach (var item in items)
                {
                    float percentage = (item.Votes * 100) / (float)total;
                    ListViewItem lvi = new ListViewItem(new[] { item.Name, (item.Points * item.Votes * float.Parse(rate)).ToString(), item.Votes.ToString(), ((percentage * budget) / 100).ToString() });
                    reportList.Items.Add(lvi);
                }
                string[] seriesArray = items.Select(x => x.Name).ToArray();
                int[] pointsArray = items.Select(x => x.Points * x.Votes).ToArray();
                this.chart.Titles.Clear();
                this.chart.Titles.Add("Items");
                foreach (var series in chart.Series)
                {
                    series.Points.Clear();
                }
                chart.Series.Clear();
                for (int i = 0; i < seriesArray.Length; i++)
                {
                    // Add series.
                    Series series = this.chart.Series.Add(seriesArray[i]);

                    // Add point.
                    series.Points.Add(pointsArray[i]);
                }
                chartBtn.Enabled = true;
            }

        }

        private string GetSelectedCurrency()
        {
            if (euroRadioBtn.Checked == true)
                return "euro";
            if (ronRadioBtn.Checked == true)
                return "ron";
            return "usd";
        }

        private void currencyBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "csv files (*.csv)|*.csv";
            saveFileDialog1.FileName = "logs";
            saveFileDialog1.Title = "Export to Excel";
            StringBuilder sb = new StringBuilder();
            foreach (ColumnHeader ch in reportList.Columns)
            {
                sb.Append(ch.Text + ",");
            }
            sb.AppendLine();
            foreach (ListViewItem lvi in reportList.Items)
            {
                foreach (ListViewItem.ListViewSubItem lvs in lvi.SubItems)
                {
                    if (lvs.Text.Trim() == string.Empty)
                        sb.Append(" ,");
                    else
                        sb.Append(lvs.Text + ",");
                }
                sb.AppendLine();
            }
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.Write(sb.ToString());
                sw.Close();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            chart.Visible = true;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientsButton.PerformClick();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            itemsButton.PerformClick();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportBtn.PerformClick();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3.PerformClick();
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application made by 'Segmentation Fault' team.");
        }
    }
}
