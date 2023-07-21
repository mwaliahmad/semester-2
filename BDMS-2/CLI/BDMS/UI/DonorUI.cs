using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDMS.BL;
using BDMS.DL;
namespace BDMS.UI
{
    public class DonorUI
    {
        public Donor Donor
        {
            get => default;
            set
            {
            }
        }

        public static Donor AddDonor(string menu, string submenu)
        {
            Common.Menu(menu, submenu);
            Console.WriteLine("Enter Details of the New Donor:-");
            Console.WriteLine();
            string name = Common.AlphaInput("Enter Name: ");
            string age = Common.Age("Enter Age(+18): ");
            string BG = Common.BG("Enter Blood Group: ");
            string contact = Common.ContactCnic(11, "Enter Contact No(11 numbers): ");
            string city = Common.AlphaInput("Enter City: ");

            Donor D1 = new Donor(name, age, BG, contact, city);
            D1.SetID(PersonCRUD.CreateID(D1));
            return D1;
        }
        public static void UpdateDonor(Person D)
        {
            Console.WriteLine("Enter Details of the Donor:-");
            Console.WriteLine();
            D.SetName(Common.AlphaInput("Enter Name: "));
            D.SetAge(Common.Age("Enter Age(+18): "));
            D.SetBG(Common.BG("Enter Blood Group: "));
            D.SetContact(Common.ContactCnic(11, "Enter Contact No(11 numbers): "));
            D.SetCity(Common.AlphaInput("Enter City: "));
        }
        public static string SearchDonor(string type, string menu, string submenu)
        {
            Common.Menu(menu, submenu);
            Console.Write("Enter " + type + " of the Donor: ");
            string name = Console.ReadLine();
            Console.WriteLine();
            return name;
        }

    }
}
