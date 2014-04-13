using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Person> Users { get; set; }
        public Group(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            this.Users = new List<Person>();
        }

        public Group(string name) : this(-1, name) { }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
