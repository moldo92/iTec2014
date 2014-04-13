using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networking
{
    public interface Response
    {
    }

    public interface UpdateResponse : Response { }

    [Serializable]
    public class LoginResponse : Response
    {
        public Person User { get; set; }
        public LoginResponse(Person user)
        {
            User = user;
        }
    }

    [Serializable]
    public class GoodResponse : Response
    {
        public Person User { get; set; }
        public GoodResponse(Person user)
        {
            User = user;
        }
        public GoodResponse() { }
    }

    [Serializable]
    public class ErrorResponse : Response
    {
        public string Message { get; set; }
        public ErrorResponse(string message) { Message = message; }
    }

    [Serializable]
    public class VotedCategoriesResponse : Response
    {
        private VotedCategories[] items;

        public VotedCategories[] Items
        {
            get { return items; }
            set { items = value; }
        }

        public VotedCategoriesResponse(VotedCategories[] items)
        {
            this.items = items;
        }
    }

    [Serializable]
    public class CategoryResponse : Response
    {
        private Category[] categories;

        public Category[] Categories
        {
            get { return categories; }
            set { categories = value; }
        }

        public CategoryResponse(Category[] categories)
        {
            this.categories = categories;
        }
    }

    [Serializable]
    public class ChangeCategory : UpdateResponse
    {
        public Category[] newCategories { get; set; }

        public ChangeCategory(Category[] newCategories)
        {
            this.newCategories = newCategories;
        }
    }

    [Serializable]
    public class GetGroupsResponse : Response
    {
        public Group[] Groups { get; set; }
        public GetGroupsResponse(Group[] groups) { this.Groups = groups; }
    }

    [Serializable]
    public class UpdateUserResponse : Response
    {
        public Group[] Groups { get; set; }
        public Person User { get; set; }
        public UpdateUserResponse(Group[] groups, Person user) { this.Groups = groups; this.User = user; }
    }

    [Serializable]
    public class UpdateUserNotifyResponse : UpdateResponse
    {
        public Person User { get; set; }
        public UpdateUserNotifyResponse(Person user) { this.User = user; }
    }

    [Serializable]
    public class VoteItemResponse : Response
    {

    }
}
