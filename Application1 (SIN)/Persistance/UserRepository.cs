using Helper;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    public class UserRepository
    {
        private DbHandler db = new DbHandler();
        public Person verifyLogin(string username, string password)
        {
            string query = "select * from users where username = '" + username + "' and password = '" + password + "'";
            var reader = db.executeReader(query);
            Person user = null;
            if (reader != null && reader.HasRows)
            {
                reader.Read();
                user = new Person(reader["username"].ToString(), reader["password"].ToString(), reader["name"].ToString());
                int points = Convert.ToInt32(reader["points"]);
                int roleInt = Convert.ToInt32(reader["role"]);
                Util.ROLE role = (roleInt == 1) ? Util.ROLE.ADMIN : Util.ROLE.USER;
                user.Points = points;
                user.Role = role;
            }
            return user;
        }

        public Group[] getGroups()
        {
            string query = "select * from groups";
            var reader = db.executeReader(query);
            List<Group> groups = null;
            if (reader != null && reader.HasRows)
            {
                groups = new List<Group>();
                while (reader.Read())
                {
                    var group = new Group(Convert.ToInt32(reader["id"]), reader["name"].ToString());
                    string query2 = @"select u.role, u.username, u.password, u.name, u.points from users u
                                    inner join user_groups ug on ug.username = u.username
                                    where ug.groupid = " + group.Id.ToString() + " and u.role = 0 ";
                    try
                    {
                        var reader2 = db.executeReader(query2);
                        if (reader2 != null && reader2.HasRows)
                        {
                            while (reader2.Read())
                            {
                                string username = reader2["username"].ToString(),
                                    password = reader2["password"].ToString();
                                string name = reader2["name"].ToString();
                                int points = Convert.ToInt32(reader2["points"].ToString());
                                Util.ROLE role = Util.ROLE.USER;
                                var user = new Person(username, password, name, points, role);
                                group.Users.Add(user);
                            }
                        }
                    }
                    catch (Exception) { }
                    groups.Add(group);
                }
            }
            return (groups == null) ? null : groups.ToArray();
        }

        public Person getUserByUsername(string username)
        {
            string query = "select * from users where username = '" + username + "'";
            var reader = db.executeReader(query);
            Person user = null;
            if (reader != null && reader.HasRows)
            {
                reader.Read();
                user = new Person(username, reader["password"].ToString(), reader["name"].ToString(), int.Parse(reader["points"].ToString()), Util.ROLE.USER);
            }
            return user;
        }

        public Person updateUser(Person user)
        {
            string query = "update users set name = '" + user.Name + "', points = " + user.Points.ToString() + ", password = '" + user.Password + "' where username = '" + user.Username + "'";
            db.executeNonQuery(query);
            return getUserByUsername(user.Username);
        }

        public Person voteItem(Person user, Item item)
        {
            string insertQuery = "insert into points values (default, '" + user.Username + "', " + item.Id.ToString() + ", " + ((int)item.Price).ToString() + ")";
            db.executeNonQuery(insertQuery);
            string updateQuery = "update users set points = points - " + ((int)item.Price).ToString() + " where username = '" + user.Username + "'";
            db.executeNonQuery(updateQuery);
            return getUserByUsername(user.Username);
        }
    }
}
