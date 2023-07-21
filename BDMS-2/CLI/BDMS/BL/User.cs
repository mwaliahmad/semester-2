using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDMS.DL;

namespace BDMS.BL
{
    public class User
    {
        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }
        protected string Username;
        protected string Password;

        public User CheckRole()
        {
            if (Username == "admin" && Password == "admin")
            {
                return new Admin();
            }
            else if (Username == "guest" && Password == "guest")
            {
                return new Guest();
            }
            else
            {
                for (int i = 0; i < EmployeeCRUD.GetList().Count; i++)
                {
                    if (Username == EmployeeCRUD.GetList()[i].GetUsername() && Password == EmployeeCRUD.GetList()[i].GetPassword())
                    {
                        return EmployeeCRUD.GetList()[i]; // for employee
                    }
                }
            }
            return null;
        }
    }
}
