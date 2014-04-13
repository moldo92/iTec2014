using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.GUI_items.Login;
using Model;

namespace Client.GUI_items.Vote
{
    public partial class VoteView : UserControl
    {
        public VoteView()
        {
            InitializeComponent();
        }

        public VoteView(ClientController generalController)
        {
            InitializeComponent();
            this.generalController = generalController;
            this.generalController.updateEvent += generalController_updateEvent;
            this.generalController.UpdateUser += generalController_UpdateUser;
            categoryBox.DataSource = generalController.getCategories();
            pointsLabel.Text = "Points: " + generalController.CurrentUser.Points.ToString();
        }

        void generalController_UpdateUser(object sender, UpdateUserArgs e)
        {
            var user = e.user;
            pointsLabel.Text = "Points: " + user.Points.ToString();
        }

        void generalController_updateEvent(object sender, GeneralEventArgs e)
        {
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private ClientController generalController;
        private Item currentItem;

        private void itemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemList.SelectedItems.Count > 0)
            {
                var item = itemList.SelectedItems[0];
                rightPanel.Visible = true;
                rightPanel.BringToFront();
                int id = Convert.ToInt32(item.SubItems[0].Text);
                voteNameLine.Text = item.SubItems[1].Text;
                votePriceLine.Text = item.SubItems[2].Text;
                currentItem = new Item(id, voteNameLine.Text, float.Parse(votePriceLine.Text));
            }
        }

        private void closeRightPanelBtn_Click(object sender, EventArgs e)
        {
            rightPanel.Visible = false;
        }

        private void categoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryBox.SelectedIndex < 0) return;
            Category category = categoryBox.SelectedItem as Category;
            itemList.Items.Clear();
            foreach (var item in category.Items)
            {
                ListViewItem lvi = new ListViewItem(new[] { item.Id.ToString(), item.Name, item.Price.ToString() });
                itemList.Items.Add(lvi);
            }
        }

        private void voteItemBtn_Click(object sender, EventArgs e)
        {
            if (currentItem != null)
            {
                generalController.voteProduct(currentItem);
                var user = generalController.CurrentUser;
                user.Points -= (int)currentItem.Price;
                generalController.CurrentUser = user;
                pointsLabel.Text = "Points: " + user.Points.ToString();
            }
        }

        private void itemList_Resize(object sender, EventArgs e)
        {
            NameColumn.Width = itemList.Width / 2;
            PriceColumn.Width = NameColumn.Width;
        }
    }
}
