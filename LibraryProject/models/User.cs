using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public List<Book> PurchasedBooks { get; set; }

        public User() { }

        public User(string login,string password)
        {
            Login = login;
            Password = password;
        }


    }
}
