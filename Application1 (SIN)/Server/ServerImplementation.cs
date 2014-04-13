using Model;
using Persistance;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Server
{
    public class ServerImplementation : IServer
    {
        private ItemsRepository itemRepository;
        private UserRepository userRepository;
        private IDictionary<string, IObserver> loggedUsers;
        public ServerImplementation(UserRepository userRepository, ItemsRepository itemsRepository)
        {
            this.userRepository = userRepository;
            this.itemRepository = itemsRepository;
            loggedUsers = new Dictionary<string, IObserver>();
        }

        public Person Login(string username, string password, IObserver client)
        {
            var user = userRepository.verifyLogin(username, password);
            if (user != null)
            {
                if (loggedUsers.ContainsKey(user.Username))
                {
                    string userType = (user.Role == Helper.Util.ROLE.ADMIN) ? ConfigurationManager.AppSettings["admin"] : ConfigurationManager.AppSettings["user"];
                    throw new ServicesException(userType + ConfigurationManager.AppSettings["aliMessage"]);
                }
                loggedUsers[user.Username] = client;
            }
            return user;
        }

        public void Logout(string username)
        {
            if (loggedUsers[username] == null)
            {
                Console.WriteLine(ConfigurationManager.AppSettings["invalidLogout"]);
                throw new ServicesException(ConfigurationManager.AppSettings["invalidLogout"]);
            }
            Console.WriteLine(username + ConfigurationManager.AppSettings["logoutMessage"]);
            loggedUsers.Remove(username);
        }


        public Category[] getCategories()
        {
            return itemRepository.getCategories();
        }



        public void changeCategory(Item item, Category newCategory)
        {
            try
            {
                itemRepository.changeCategory(item, newCategory);
                var newCategories = itemRepository.getCategories();
                foreach (var i in loggedUsers)
                {
                    i.Value.ModifyCategory(newCategories);
                }
            }
            catch (Exception e)
            {
                throw new ServicesException(e.Message, e);
            }
        }


        public void addCategory(Category newCategory)
        {
            try
            {
                itemRepository.addNewCategory(newCategory);
                var newCategories = itemRepository.getCategories();
                foreach (var i in loggedUsers)
                {
                    i.Value.ModifyCategory(newCategories);
                }
            }
            catch (Exception e)
            {
                throw new ServicesException(e.Message, e);
            }
        }


        public void addUser(Person user, Group group)
        {
            throw new NotImplementedException();
        }

        public Person updateUser(Person user)
        {
            Person newUser = null;
            try
            {
                newUser = userRepository.updateUser(user);
                foreach (var i in loggedUsers)
                {
                    i.Value.NotifyUser(newUser);
                }
            }
            catch (Exception e)
            {
                throw new ServicesException(e.Message, e);
            }
            return newUser;
        }


        public Group[] getGroups()
        {
            return userRepository.getGroups();
        }

        public VotedCategories[] getVotedItems()
        {
            return itemRepository.getVotes();
        }

        public void voteItem(Person user, Item item)
        {
            Person newUser = null;
            try
            {
                newUser = userRepository.voteItem(user, item);
                foreach (var i in loggedUsers)
                {
                    i.Value.NotifyUser(newUser);
                }
            }
            catch (Exception e)
            {
                throw new ServicesException(e.Message, e);
            }
        }
    }
}
