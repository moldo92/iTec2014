using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class Item
    {
        private int id;
        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }
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

        public Item(int id, string name, float price)
            : this(id, name)
        {
            this.price = price;
        }

        public Item(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public Item(string name) : this(-1, name) { }
        public Item(int id) : this(id, "") { }

        public override bool Equals(object obj)
        {
            return (obj as Item).Id == this.id;
        }
    }
}
