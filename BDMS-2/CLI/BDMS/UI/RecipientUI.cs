using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDMS.BL;
using BDMS.DL;
namespace BDMS.UI
{
    public class RecipientUI
    {
        public Recipient Recipient
        {
            get => default;
            set
            {
            }
        }

        public static Recipient AddRecipient(string menu, string submenu)
        {
            Common.Menu(menu, submenu);
            Console.WriteLine("Enter Details of the New Recipient:-");
            Console.WriteLine();
            string name = Common.AlphaInput("Enter Name: ");
            string age = Common.Age("Enter Age(+18): ");
            string BG = Common.BG("Enter Blood Group: ");
            string contact = Common.ContactCnic(11, "Enter Contact No(11 numbers): ");
            string city = Common.AlphaInput("Enter City: ");
            Recipient R1 = new Recipient(name, age, BG, contact, city);
            R1.SetID(PersonCRUD.CreateID(R1));
            return R1;
        }
        public static void UpdateRecipient(Person R)
        {
            Console.WriteLine("Enter Details of the Recipient:-");
            Console.WriteLine();
            R.SetName(Common.AlphaInput("Enter Name: "));
            R.SetAge(Common.Age("Enter Age(+18): "));
            R.SetBG(Common.BG("Enter Blood Group: "));
            R.SetContact(Common.ContactCnic(11, "Enter Contact No(11 numbers): "));
            R.SetCity(Common.AlphaInput("Enter City: "));
        }
        public static string SearchRecipient(string type, string menu, string submenu)
        {
            Common.Menu(menu, submenu);
            Console.Write("Enter " + type + " of the Recipient: ");
            string name = Console.ReadLine();
            Console.WriteLine();
            return name;
        }
    }
}
