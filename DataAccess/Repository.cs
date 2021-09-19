using Holism.Contacts.Models;
using Holism.DataAccess;

namespace Holism.Contacts.DataAccess
{
    public class Repository
    {
        public static Repository<User> User
        {
            get
            {
                return new Holism.DataAccess.Repository<User
                >(new ContactsContext());
            }
        }

        public static Repository<UserView> UserView
        {
            get
            {
                return new Holism.DataAccess.Repository<UserView
                >(new ContactsContext());
            }
        }
    }
}
