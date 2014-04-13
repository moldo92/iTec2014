using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IServer
    {
        Person Login(string username, string password, IObserver client);
        void Logout(string username);

        void changeCategory(Item item, Category newCategory);

        void addCategory(Category newCategory);

        Category[] getCategories();

        Group[] getGroups();
        void addUser(Person user, Group group);

        Person updateUser(Person user);

        void voteItem(Person user, Item item);

        VotedCategories[] getVotedItems();
    }
}
