using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class Category
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private List<Item> items;

        public List<Item> Items
        {
            get { return items; }
            set { items = value; }
        }

        public Category(int id, string name)
        {
            this.id = id;
            this.name = name;
            this.Items = new List<Item>();
        }

        public Category(int id) : this(id, "") { }
        public Category(string name) : this(-1, name) { }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
