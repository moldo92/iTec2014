using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IObserver
    {
        void ModifyCategory(Category[] newItems);

        void ModifyUser(Group[] groups);

        void NotifyUser(Person user);
    }
}
