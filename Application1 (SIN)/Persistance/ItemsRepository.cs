using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    public class ItemsRepository
    {
        private DbHandler db = new DbHandler();

        public VotedCategories[] getVotes()
        {
            List<VotedCategories> votedItems = new List<VotedCategories>();
            string query = "SELECT points.points, name, count(*) as votes FROM points inner join items on items.id=points.itemid group by name";
            var reader = db.executeReader(query);
            if (reader != null && reader.HasRows)
            {
                while (reader.Read())
                {
                    int votes = Convert.ToInt32(reader["votes"]);
                    string name = reader["name"].ToString();
                    float points = float.Parse(reader["points"].ToString());
                    int intPoints = (int)Math.Floor(points);
                    var item = new VotedCategories(intPoints,votes, name);
                    votedItems.Add(item);
                }
            }
            return votedItems.ToArray();
        }

        public Category[] getCategories()
        {
            string query = "select * from categories";
            var reader = db.executeReader(query);
            List<Category> categories = null;
            if (reader != null && reader.HasRows)
            {
                categories = new List<Category>();
                while (reader.Read())
                {
                    var category = new Category(Convert.ToInt32(reader["id"]), reader["name"].ToString());
                    string query2 = "select * from items where categoryid =" + category.Id.ToString();
                    try
                    {
                        var reader2 = db.executeReader(query2);
                        if (reader2 != null && reader2.HasRows)
                        {
                            while (reader2.Read())
                            {
                                int id = Convert.ToInt32(reader2["id"]);
                                string name = reader2["name"].ToString();
                                float price = float.Parse(reader2["price"].ToString());
                                var item = new Item(id, name, price);
                                category.Items.Add(item);
                            }
                        }
                    }
                    catch (Exception) { }
                    categories.Add(category);
                }
            }
            return (categories == null) ? null : categories.ToArray();
        }

        public void changeCategory(Item item, Category newCategory)
        {
            string query = "update items set categoryid = " + newCategory.Id.ToString() + ", price = " + item.Price.ToString() + " where id = " + item.Id.ToString();
            db.executeNonQuery(query);
        }

        public void addNewCategory(Category newCategory)
        {
            string query = "insert into categories values(default, '" + newCategory.Name + "')";
            db.executeNonQuery(query);
        }
    }
}
