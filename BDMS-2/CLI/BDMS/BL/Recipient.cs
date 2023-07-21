using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDMS.BL
{
    public class Recipient : Person
    {
        public Recipient(string Name, string Age, string BG, string Contact, string City) : base(Name, Age, BG, Contact, City)
        {
        }
        private string id;
        public override string GetName()
        {
            return Name;
        }
        public override void SetName(string Name)
        {
            this.Name = Name;
        }
        public override string GetAge()
        {
            return Age;
        }
        public override void SetAge(string Age)
        {
            this.Age = Age;
        }
        public override string GetBG()
        {
            return BG;
        }
        public override void SetBG(string BG)
        {
            this.BG = BG;
        }
        public override string GetContact()
        {
            return Contact;
        }
        public override void SetContact(string Contact)
        {
            this.Contact = Contact;
        }
        public override string GetCity()
        {
            return City;
        }
        public override void SetCity(string City)
        {
            this.City = City;
        }
        public override string GetID()
        {
            return ID;
        }
        public override void SetID(string ID)
        {
            this.ID = ID;
        }
    }
}
