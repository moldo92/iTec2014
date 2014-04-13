using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Client.GUI_items.Login;

namespace Client.GUI_items.Users
{
    public partial class UserView : UserControl
    {
        private ClientController generalController;
        public UserView()
        {
            InitializeComponent();
            this.usersList.ColumnWidthChanging += usersList_ColumnWidthChanging;
            
        }

        public UserView(ClientController generalController)
        {
            InitializeComponent();
            this.generalController = generalController;
            this.usersList.ColumnWidthChanging += usersList_ColumnWidthChanging;
            this.groupsBox.DataSource = this.generalController.getGroups();
            this.generalController.updateEvent += generalController_updateEvent;
            this.generalController.UpdateUser += generalController_UpdateUser;
        }

        void generalController_UpdateUser(object sender, UpdateUserArgs e)
        {
            var user = e.user;

        }

        void generalController_updateEvent(object sender, GeneralEventArgs e)
        {
            if (e.GenEvent == GeneralEvents.UpdateUser)
            {
                usersList.Invoke(new UpdateGroupsListCallback(this.updateGroupList), new Object[] { e.Data as List<Group> });
                //categoryBox.DataSource = new List<Category>(newCategories);
            }
        }

        public delegate void UpdateGroupsListCallback(List<Group> groups);

        private void updateGroupList(List<Group> groups)
        {
            groupsBox.DataSource = groups;
            //ItemsView.Invoke(new UpdateGroupsListCallback(this.updateGroupList), new Object[] { newCategories });
        }



        void usersList_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            
        }

        private void categoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (groupsBox.SelectedIndex < 0) return;
            var group = groupsBox.SelectedItem as Group;
            usersList.Items.Clear();
            foreach (var item in group.Users)
            {
                ListViewItem lvi = new ListViewItem(new[] { item.Name, item.Points.ToString(), item.Username, item.Password });
                usersList.Items.Add(lvi);
            }
        }

        private void usersList_Resize(object sender, EventArgs e)
        {
            NameColumn.Width = usersList.Width / 4;
            UsernameColumn.Width = PasswordColumn.Width = PointsColumn.Width = NameColumn.Width;
        }


        private Person currentUser;
        private void usersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (usersList.SelectedItems.Count > 0)
            {
                var item = usersList.SelectedItems[0];
                rightPanel.Visible = true;
                rightPanel.BringToFront();
                //addCategoryPanel.Visible = false;
                //addCategoryPanel.SendToBack();
                string name = item.SubItems[0].Text,
                       username = item.SubItems[2].Text,
                       password = item.SubItems[3].Text;
                int points = int.Parse(item.SubItems[1].Text);
                currentUser = new Person(username, password, name, points, Helper.Util.ROLE.USER);
                saveNameLine.Text = name;
                savePointLine.Text = points.ToString();
                usernameLine.Text = username;
                savePasswordLine.Text = password;
                //currentItem = new Item(id, saveNameLine.Text, float.Parse(savePointLine.Text));
            }
        }

        private void closeRightPanelBtn_Click(object sender, EventArgs e)
        {
            rightPanel.Visible = false;
        }

        private void saveItemBtn_Click(object sender, EventArgs e)
        {
            currentUser = new Person(usernameLine.Text, savePasswordLine.Text, saveNameLine.Text, int.Parse(savePointLine.Text));
            generalController.modifyUser(currentUser);
            rightPanel.Visible = false;
        }
    }
}
