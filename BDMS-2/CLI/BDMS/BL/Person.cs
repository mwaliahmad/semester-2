using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDMS.DL;
namespace BDMS.BL
{
    public class Person
    {
        public Person(string Name, string Age, string BG, string Contact, string City)
        {
            this.Name = Name;
            this.Age = Age;
            this.BG = BG;
            this.Contact = Contact;
            this.City = City;
        }

        private string name;
        private string age;
        private string bG;
        private string contact;
        private string city;

        protected string Name { get => name; set => name = value; }
        protected string Age { get => age; set => age = value; }
        protected string BG { get => bG; set => bG = value; }
        protected string Contact { get => contact; set => contact = value; }
        protected string City { get => city; set => city = value; }

        public virtual string GetName()
        {
            return Name;
        }
        public virtual void SetName(string Name)
        {
            this.Name = Name;
        }
        public virtual string GetAge()
        {
            return Age;
        }
        public virtual void SetAge(string Age)
        {
            this.Age = Age;
        }
        public virtual string GetBG()
        {
            return BG;
        }
        public virtual void SetBG(string BG)
        {
            this.BG = BG;
        }
        public virtual string GetContact()
        {
            return Contact;
        }
        public virtual void SetContact(string Contact)
        {
            this.Contact = Contact;
        }
        public virtual string GetCity()
        {
            return City;
        }
        public virtual void SetCity(string City)
        {
            this.City = City;
        }
        public virtual void SetID(string ID)
        {
        }
        public virtual string GetID()
        {
            return "";
        }
    }
}
