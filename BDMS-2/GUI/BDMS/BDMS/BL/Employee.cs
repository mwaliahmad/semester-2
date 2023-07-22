using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BDMS.BL
{
    public class Employee : User
    {
        public Employee(string Username, string Password) : base(Username, Password)
        {

        }
        public Employee(string Name, string Age, string Contact, string Cnic, string Username, string Password) : this(Username, Password)
        {
            this.Name1 = Name;
            this.Age1 = Age;
            this.Cnic1 = Cnic;
            this.Contact1 = Contact;
            People = new List<Person>();
        }

        private string Name;
        private string Age;
        private string Contact;
        private string cnic;
        private List<Person> People;

        public string Name1 { get => Name; set => Name = value; }
        public string Age1 { get => Age; set => Age = value; }
        public string Contact1 { get => Contact; set => Contact = value; }
        public string Cnic1 { get => cnic; set => cnic = value; }

        public string GetName()
        {
            return Name1;
        }
        public void SetName(string Name)
        {
            this.Name1 = Name;
        }
        public string GetAge()
        {
            return Age1;
        }
        public void SetAge(string Age)
        {
            this.Age1 = Age;
        }
        public string GetCnic()
        {
            return Cnic1;
        }
        public void SetCnic(string Cnic)
        {
            this.Cnic1 = Cnic;
        }
        public string GetContact()
        {
            return Contact1;
        }
        public void SetContact(string Contact)
        {
            this.Contact1 = Contact;
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
