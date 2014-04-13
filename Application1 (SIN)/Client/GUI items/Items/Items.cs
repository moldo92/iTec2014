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

namespace Client.GUI_items.Items
{
    public partial class Items : UserControl
    {
        private ClientController clientCtrl;
        private Item currentItem = null;
        public event EventHandler<SaveEventArgs> SaveCategories;
        public Items(List<Category> categories, ClientController clientCtrl)
        {
            InitializeComponent();
            //itemsList.
            this.clientCtrl = clientCtrl;
            categoryBox.DataSource = categories;
            this.ItemsView.ColumnWidthChanging += itemsList_ColumnWidthChanging;
            this.clientCtrl.updateEvent += clientCtrl_updateEvent;
        }

        protected virtual void OnSaveEvent(SaveEventArgs e)
        {
            if (SaveCategories == null || currentItem == null) return;
            SaveCategories(this, e);
        }

        void clientCtrl_updateEvent(object sender, GeneralEventArgs e)
        {
            if (e.GenEvent == GeneralEvents.ChangeCategory)
            {
                categoryBox.DataSource = e.Data as List<Category>;
            }
        }

        public void updateCategories(List<Category> newCategories)
        {
            ItemsView.Invoke(new UpdateCategoriesListCallback(this.updateCategoryList), new Object[] { newCategories });
            //categoryBox.DataSource = new List<Category>(newCategories);
        }

        public delegate void UpdateCategoriesListCallback(List<Category> newCategories);

        private void updateCategoryList(List<Category> newCategories)
        {
            categoryBox.DataSource = newCategories;
            //ItemsView.Invoke(new UpdateGroupsListCallback(this.updateGroupList), new Object[] { newCategories });
        }



        void itemsList_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            if (e.ColumnIndex == 0) e.NewWidth = 0;
            e.Cancel = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryBox.SelectedIndex < 0) return;
            Category category = categoryBox.SelectedItem as Category;
            ItemsView.Items.Clear();
            foreach (var item in category.Items)
            {
                ListViewItem lvi = new ListViewItem(new[] {item.Id.ToString(), item.Name, item.Price.ToString() });
                ItemsView.Items.Add(lvi);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void itemsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (ItemsView.SelectedItems.Count > 0)
            {
                var item = ItemsView.SelectedItems[0];
                rightPanel.Visible = true;
                rightPanel.BringToFront();
                addCategoryPanel.Visible = false;
                addCategoryPanel.SendToBack();
                int id = Convert.ToInt32(item.SubItems[0].Text);
                saveNameLine.Text = item.SubItems[1].Text;
                savePriceLine.Text = item.SubItems[2].Text;
                currentItem = new Item(id, saveNameLine.Text, float.Parse(savePriceLine.Text));
                if (categoryBox.SelectedIndex >= 0)
                {
                    List<Category> newCategory = new List<Category>();
                    foreach (var i in categoryBox.Items)
                    {
                        newCategory.Add(i as Category);
                    }
                    saveCategoryBox.DataSource = newCategory;
                    saveCategoryBox.SelectedIndex = categoryBox.SelectedIndex;
                }
            }
        }

        private void Items_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //ri
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void closeRightPanelBtn_Click(object sender, EventArgs e)
        {
            rightPanel.Visible = false;
            resetFields();
        }

        private void resetFields()
        {

        }

        private void usernameLine_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void ItemsView_Resize(object sender, EventArgs e)
        {
            NameColumn.Width = ItemsView.Width / 2;
            PriceColumn.Width = NameColumn.Width;
        }

        private void saveItemBtn_Click(object sender, EventArgs e)
        {
            currentItem = new Item(currentItem.Id, saveNameLine.Text, float.Parse(savePriceLine.Text));
            Item item = currentItem;
            Category category = saveCategoryBox.SelectedItem as Category;
            SaveEventArgs sea = new SaveEventArgs(item, category);
            OnSaveEvent(sea);
            this.rightPanel.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void addCategoryBtn_Click(object sender, EventArgs e)
        {
            if (newCategoryLine.Text.Length != 0)
            {
                var newCategory = new Category(newCategoryLine.Text);
                clientCtrl.addCategory(newCategory);
                addCategoryPanel.Visible = true;
            }
        }

        private void addCategoryOpenPanelBtn_Click(object sender, EventArgs e)
        {
            rightPanel.Visible = false;
            rightPanel.SendToBack();
            addCategoryPanel.Visible = true;
            addCategoryPanel.BringToFront();
        }

        private void closeAddCategoryPanel_Click(object sender, EventArgs e)
        {
            addCategoryPanel.Visible = false;
        }
    }

    public class SaveEventArgs : EventArgs
    {
        public Item item { get; set; }
        public Category category { get; set; }

        public SaveEventArgs(Item item, Category category)
        {
            this.item = item;
            this.category = category;
        }

        public SaveEventArgs(Category category) : this(null, category) { }
    }
}
