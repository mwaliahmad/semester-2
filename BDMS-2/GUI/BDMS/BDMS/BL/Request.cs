using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDMS.BL
{
    public class Request
    {
        private string value;
        private int count;
        public Request()
        {
        }
        public string Value { get => value; set => this.value = value; }
        public int Count { get => count; set => count = value; }

       
    }
}
