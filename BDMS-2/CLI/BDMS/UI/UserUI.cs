using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDMS.BL;

namespace BDMS.UI
{
    public class UserUI
    {
        public User User
        {
            get => default;
            set
            {
            }
        }

        public static User Login()
        {
            string username, password;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Welcome to Blood Donation Management System");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Enter Username: ");
            username = Console.ReadLine();
            Console.Write("Enter Password: ");
            password = Console.ReadLine();

            User user = new User(username, password);

            return user;
        }
    }
}
