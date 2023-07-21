using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDMS.BL;
using System.IO;

namespace BDMS.DL
{
    public class PersonCRUD
    {
        private static List<Person> People = new List<Person>();
        private static int count = 1;
        static string personFile = "Person.txt";
        public static Person SearchPerson(string ID)
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
        public static string SearchBGPerson(string BG)
        {
            for (int idx = 0; idx < People.Count; idx++)
            {
                if (BG == People[idx].GetBG())
                {
                    return People[idx].GetID();
                }
            }
            return null;
        }
        public static List<Person> SearchPersonByBG(string BG, char P)
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
        public static bool SearchBG(string BG)
        {
            for (int i = 0; i < People.Count; i++)
            {
                if (People[i].GetBG() == BG && People[i].GetID()[0] == 'D')
                {
                    return true;
                }
            }
            return false;
        }
        public static void PersonToFile(Person P)
        {
            StreamWriter personData = new StreamWriter(personFile, true);
            personData.WriteLine(P.GetID() + "," + P.GetName() + "," + P.GetAge() + "," + P.GetBG() + "," + P.GetContact() + "," + P.GetCity());
            personData.Flush();
            personData.Close();
        }
        public static void updatePersonFile()
        {
            StreamWriter personData = new StreamWriter(personFile);
            for (int i = 0; i < People.Count; i++)
            {
                if (People[i].GetID() != "")
                {
                    personData.WriteLine(People[i].GetID() + "," + People[i].GetName() + "," + People[i].GetAge() + "," + People[i].GetBG() + "," + People[i].GetContact() + "," + People[i].GetCity());
                }
            }
            personData.Flush();
            personData.Close();
        }
        public static bool LoadPerson()
        {
            StreamReader personData = new StreamReader(personFile);
            string record;
            if (File.Exists(personFile))
            {
                while ((record = personData.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string id = splittedRecord[0];
                    string name = splittedRecord[1];
                    string age = splittedRecord[2];
                    string BG = splittedRecord[3];
                    string contact = splittedRecord[4];
                    string city = splittedRecord[5];
                    if (id[0] == 'D')
                    {
                        Donor P = new Donor(name, age, BG, contact, city);
                        P.SetID(id);
                        AddPersonToList(P);
                    }
                    else
                    {
                        Recipient P = new Recipient(name, age, BG, contact, city);
                        P.SetID(id);
                        AddPersonToList(P);
                    }
                }
                personData.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void AddPersonToList(Person P)
        {
            People.Add(P);
        }
        public static void DeletePersonToList(Person P)
        {
            People.Remove(P);
        }
        public static void DeletePersonToListByID(string ID)
        {
            for (int i =0; i<People.Count;i++)
            {
                if (People[i].GetID() == ID)
                {
                    DeletePersonToList(People[i]);
                }
            }
        }
        public static void DeletePersonToEmployeeList(string ID)
        {
            for(int i =0; i< EmployeeCRUD.GetList().Count;i++)
            {
                for (int j = 0; j < EmployeeCRUD.GetList()[i].GetPeople().Count; j++)
                {
                    if(ID == EmployeeCRUD.GetList()[i].GetPeople()[j].GetID())
                    {
                        EmployeeCRUD.GetList()[i].DeletePerson(EmployeeCRUD.GetList()[i].GetPeople()[j]);
                    }
                }
            }
        }
        public static List<Person> GetList()
        {
            return People;
        }
        public static string CreateID(Person P)
        {
            string ID;
            do
            {
                int number = count;
                if (P is Donor D)
                {
                    ID = "D" + number.ToString("D4");
                }
                else
                {
                    ID = "R" + number.ToString("D4");
                }
                count++;
            }
            while (SearchPerson(ID) != null);
            return ID;
        }
    }
}
