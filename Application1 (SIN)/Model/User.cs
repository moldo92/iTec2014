using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    [Serializable]
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }

        public User(string username, string password, string name, int points)
        {
            this.Username = username;
            this.Password = password;
            this.Name = name;
            this.Points = points;
        }

        public User() : this("", "", "", -1) { }
        public User(string username, string password) : this(username, password, "", -1) { }
        public User(string username, string password, string name) : this(username, password, name, -1) { }


    }
}
