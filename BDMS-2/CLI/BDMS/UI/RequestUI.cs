using BDMS.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDMS.UI
{
    public class RequestUI
    {
        public Request Request
        {
            get => default;
            set
            {
            }
        }

        public static void RequestTable(List<Request> requests)
        {
            foreach (var x in requests)
            {
                Console.WriteLine("Bloodgroup: " + x.Value + " has Request " + x.Count);
            }
        }
    }
}
