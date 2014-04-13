using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networking
{
    public interface Request
    {
    }

    [Serializable]
    public class LoginRequest : Request
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public LoginRequest(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }

    [Serializable]
    public class LogoutRequest : Request
    {
        public string Username { get; set; }
        public LogoutRequest(string username) { Username = username; }
    }

    [Serializable]
    public class CategoriesRequest : Request
    {

    }

    [Serializable]
    public class VotedCategoriesRequest : Request
    {

    }

    [Serializable]
    public class ChangeCategoryRequest : Request
    {
        public Item item { get; set; }
        public Category newCategory { get; set; }

        public ChangeCategoryRequest(Item item, Category newCategory)
        {
            this.item = item;
            this.newCategory = newCategory;
        }
    }

    [Serializable]
    public class AddCategoryRequest : Request
    {
        public Category newItem { get; set; }
        public AddCategoryRequest(Category newItem)
        {
            this.newItem = newItem;
        }
    }

    [Serializable]
    public class GetGroupsRequest : Request
    {

    }

    [Serializable]
    public class UpdateUserRequest : Request
    {
        public Person User { get; set; }
        public UpdateUserRequest(Person user) { this.User = user; }
    }

    [Serializable]
    public class VoteItemRequest : Request
    {
        public Person user { get; set; }
        public Item item { get; set; }
        public VoteItemRequest(Person user, Item item) { this.user = user; this.item = item; }
    }
}
