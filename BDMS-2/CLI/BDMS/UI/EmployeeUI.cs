using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDMS.BL;

namespace BDMS.UI
{
    public class EmployeeUI
    {
        public Employee Employee
        {
            get => default;
            set
            {
            }
        }

        public static Employee AddEmployee(string menu, string submenu)
        {
            Common.Menu(menu, submenu);
            Console.WriteLine("Enter Details of the New Employee:-");
            Console.WriteLine();
            string name = Common.AlphaInput("Enter Name: ");
            string age = Common.Age("Enter Age(+18): ");
            string contact = Common.ContactCnic(11, "Enter Contact No(11 numbers): ");
            string cnic = Common.ContactCnic(13, "Enter CNIC(13 numbers): ");
            string username = Common.Username("Enter Username: ");
            string password = Common.Password("Enter Password (8 length): ");

            Employee E1 = new Employee(name, age, contact, cnic, username, password);
            return E1;
        }
        public static void UpdateEmployee(Employee E)
        {
            Console.WriteLine("Enter Details of the Employee:-");
            Console.WriteLine();

            Console.Write("Enter Name: ");
            E.SetName(Common.AlphaInput("Enter Name: "));
            E.SetAge(Common.Age("Enter Age(+18): "));
            E.SetContact(Common.ContactCnic(11, "Enter Contact No(11 numbers): "));
            E.SetCnic(Common.ContactCnic(13, "Enter CNIC(13 numbers): "));
            E.SetUsername(Common.Username("Enter Username: "));
            E.SetPassword(Common.Password("Enter Password (8 length): "));
        }
        public static string SearchEmployee(string menu, string submenu)
        {
            Common.Menu(menu, submenu);
            Console.Write("Enter Username of the Employee: ");
            string name = Console.ReadLine();
            Console.WriteLine();
            return name;
        }
        public static void EmployeeHeading()
        {
            Console.WriteLine("Name".PadRight(20) + "Age".PadRight(20) + "CNIC".PadRight(20) + "Contact No.".PadRight(20) + "Username".PadRight(20) + "Password".PadRight(20));
            Console.WriteLine();
        }
        public static void DisplayEmployee(Employee E)
        {
            Console.WriteLine(E.GetName().PadRight(20) + E.GetAge().PadRight(20) + E.GetCnic().PadRight(20) + E.GetContact().PadRight(20) + E.GetUsername().PadRight(20) + E.GetPassword().PadRight(20));
        }
    }
}
