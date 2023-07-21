using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDMS.BL
{
    public class Guest : User
    {
        public Guest() : base("guest", "guest")
        {

        }

        public DL.RequestCRUD RequestCRUD
        {
            get => default;
            set
            {
            }
        }
    }
}
