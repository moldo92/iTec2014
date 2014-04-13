using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class Person
    {
        private string username, password, name;
        private Helper.Util.ROLE role;
        private int points;

        public int Points
        {
            get { return points; }
            set { points = value; }
        }

        public Helper.Util.ROLE Role
        {
            get { return role; }
            set { role = value; }
        }


        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Person(string username, string password, string name, int points, Helper.Util.ROLE role)
        {
            this.username = username;
            this.password = password;
            this.name = name;
            this.points = points;
            this.role = role;
        }

        public Person(string username, string password, string name, int points) :
            this(username, password, name, points, Helper.Util.ROLE.USER) { }
        public Person(string username, string password, string name) :
            this(username, password, name, 0) { }
        public Person(string username, string password, int points) :
            this(username, password, "", points) { }
        public Person(string username, string password) :
            this(username, password, "", 0) { }
    }
}
