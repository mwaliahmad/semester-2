using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDMS.BL
{
    public class Employee : User
    {
        public Employee(string Username, string Password) : base(Username, Password)
        {

        }
        public Employee(string Name, string Age, string Contact, string Cnic, string Username, string Password) : this(Username, Password)
        {
            this.Name = Name;
            this.Age = Age;
            this.Contact = Contact;
            this.Cnic = Cnic;
            People = new List<Person>();
        }

        public Person Person
        {
            get => default;
            set
            {
            }
        }

        public DL.EmployeeCRUD EmployeeCRUD
        {
            get => default;
            set
            {
            }
        }

        private string Name;
        private string Age;
        private string Contact;
        private string Cnic;
        private List<Person> People;
        public string GetName()
        {
            return Name;
        }
        public void SetName(string Name)
        {
            this.Name = Name;
        }
        public string GetAge()
        {
            return Age;
        }
        public void SetAge(string Age)
        {
            this.Age = Age;
        }
        public string GetCnic()
        {
            return Cnic;
        }
        public void SetCnic(string Cnic)
        {
            this.Cnic = Cnic;
        }
        public string GetContact()
        {
            return Contact;
        }
        public void SetContact(string Contact)
        {
            this.Contact = Contact;
        }
        public string GetUsername()
        {
            return Username;
        }
        public void SetUsername(string Username)
        {
            this.Username = Username;
        }
        public string GetPassword()
        {
            return Password;
        }
        public void SetPassword(string Password)
        {
            this.Password = Password;
        }
        public List<Person> GetPeople()
        {
            return People;
        }
        public void AddPerson(Person P)
        {
            People.Add(P);
        }
        public void DeletePerson(Person P)
        {
            People.Remove(P);
        }
        public Person SearchPerson(string ID)
        {
            for (int idx = 0; idx < People.Count; idx++)
            {
                if (ID == People[idx].GetID())
                {
                    return People[idx];
                }
            }
            return null;
        }
        public List<Person> SearchPersonByBG(string BG, char P)
        {
            List<Person> lst = new List<Person>();
            for (int i = 0; i < People.Count; i++)
            {
                if (People[i].GetBG() == BG && People[i].GetID()[0] == P)
                {
                    lst.Add(People[i]);
                }
            }
            return lst;
        }
    }
}
