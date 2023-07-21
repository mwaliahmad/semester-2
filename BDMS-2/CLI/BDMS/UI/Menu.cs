using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDMS.UI
{
    public class Menu
    {
        internal Program Program
        {
            get => default;
            set
            {
            }
        }

        public static void MenuAdmin()
        {
            Console.WriteLine();
            Console.WriteLine("1.  Add New Employee...");
            Console.WriteLine("2.  Delete Employee... ");
            Console.WriteLine("3.  Update Employee Details... ");
            Console.WriteLine("4.  Search For Employee... ");
            Console.WriteLine("5.  View all Employees... ");
            Console.WriteLine("6.  Search For Donor... ");
            Console.WriteLine("7.  View all Donors... ");
            Console.WriteLine("8.  Search For Recipient... ");
            Console.WriteLine("9.  View all Recipient... ");
            Console.WriteLine("10. View all Request... ");
            Console.WriteLine("11. Log out... ");
            Console.WriteLine();
            Console.Write("Enter Your Option: ");
        }
        public static void MenuEmployee()
        {
            Console.WriteLine();
            Console.WriteLine("1.  Add New Donor...");
            Console.WriteLine("2.  Delete Donor... ");
            Console.WriteLine("3.  Update Donor Details... ");
            Console.WriteLine("4.  Search For Donor... ");
            Console.WriteLine("5.  View all Donors... ");
            Console.WriteLine("6.  Add New Recipient...");
            Console.WriteLine("7.  Delete Recipient... ");
            Console.WriteLine("8.  Update Recipient.Details... ");
            Console.WriteLine("9.  Search For Recipient... ");
            Console.WriteLine("10.  View all Recipients... ");
            Console.WriteLine("11. Log out... ");
            Console.WriteLine();
            /*Console.Write("Enter Your Option: ");*/
        }
        public static void MenuGuest()
        {
            Console.WriteLine();
            Console.WriteLine("1.  Search For Donor... ");
            Console.WriteLine("2.  Search For Recipient... ");
            Console.WriteLine("3.  Request For Blood... ");
            Console.WriteLine("4. Log out... ");
            Console.WriteLine();
            Console.Write("Enter Your Option: ");
        }
    }
}
