using Model;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.GUI_items.Login
{
    public class ClientController : IObserver
    {
        private IServer server;
        public Person CurrentUser;
        public event EventHandler<GeneralEventArgs> updateEvent;

        public ClientController(IServer server)
        {
            this.server = server;
        }

        public void Login(string username, string password)
        {
            CurrentUser = server.Login(username, password, this);
            if (CurrentUser == null) throw new Exception("Invalid login");
        }

        public void Logout()
        {
            if (CurrentUser == null)
            {
                return;
            }
            server.Logout(CurrentUser.Username);
            CurrentUser = null;
        }

        protected virtual void OnGeneralEvent(GeneralEventArgs e)
        {
            if (updateEvent == null) return;
            updateEvent(this, e);
        }

        public Category[] getCategories()
        {
            try
            {
                return server.getCategories();
            }
            catch (ServicesException e)
            {
                throw e;
            }
        }

        public VotedCategories[] getVotedItems()
        {
            try
            {
                return server.getVotedItems();
            }
            catch (ServicesException e)
            {
                throw e;
            }
        }

        public Group[] getGroups()
        {
            try
            {
                return server.getGroups();
            }
            catch (ServicesException e)
            {
                throw e;
            }
        }

        public void modifyCategory(Item item, Category newCategory)
        {
            server.changeCategory(item, newCategory);
        }

        public void ModifyCategory(Category[] newItems)
        {
            var ret = new List<Category>(newItems);
            var generalEvent = new GeneralEventArgs(GeneralEvents.ChangeCategory, ret);
            Console.WriteLine("New categories size: " + ret.Count.ToString());
            OnGeneralEvent(generalEvent);
        }

        public void addCategory(Category newCategory)
        {
            server.addCategory(newCategory);
        }


        public void ModifyUser(Group[] groups)
        {
            var ret = new List<Group>(groups);
            var generalEvent = new GeneralEventArgs(GeneralEvents.UpdateUser, ret);
            OnGeneralEvent(generalEvent);
        }

        public void modifyUser(Person user)
        {
            server.updateUser(user);
        }

        public void voteProduct(Item item)
        {
            server.voteItem(CurrentUser, item);
        }

        public event EventHandler<UpdateUserArgs> UpdateUser; 

        public void NotifyUser(Person user)
        {
            if (user.Username == CurrentUser.Username)
            {
                if (UpdateUser != null)
                {
                    UpdateUser(this, new UpdateUserArgs(user));
                }
            }
        }
    }

    public class UpdateUserArgs : EventArgs
    {
        public Person user { get; set; }
        public UpdateUserArgs(Person user) { this.user = user; }
    }
}
