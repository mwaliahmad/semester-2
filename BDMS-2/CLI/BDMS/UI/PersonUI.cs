using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDMS.BL;
using BDMS.DL;

namespace BDMS.UI
{
    public class PersonUI
    {
        public Person Person
        {
            get => default;
            set
            {
            }
        }

        public static void PersonHeading()
        {
            Console.WriteLine("ID".PadRight(20) + "Name".PadRight(20) + "Age".PadRight(20) + "BloodGroup".PadRight(20) + "Contact No.".PadRight(20) + "City".PadRight(20));
            Console.WriteLine();
        }
        public static void DisplayPerson(Person P)
        {
            Console.WriteLine(P.GetID().PadRight(20) + P.GetName().PadRight(20) + P.GetAge().PadRight(20) + P.GetBG().PadRight(20) + P.GetContact().PadRight(20) + P.GetCity().PadRight(20));
        }
        public static void DisplayList(List<Person> lst)
        {
            foreach(var P in lst)
            {
                DisplayPerson(P);
            }
        }
    }
}
