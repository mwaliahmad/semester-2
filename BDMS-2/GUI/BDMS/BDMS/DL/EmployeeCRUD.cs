using BDMS.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDMS.DL
{
    public class EmployeeCRUD
    {
        private static List<Employee> Employees = new List<Employee>();
        static string employeeFile = "Employee.txt";

        public static List<Employee> GetList()
        {
            return Employees;
        }
        public static Employee SearchEmployee(string name)
        {
            for (int idx = 0; idx < Employees.Count; idx++)
            {
                if (name == Employees[idx].GetUsername())
                {
                    return Employees[idx];
                }
            }
            return null;
        }
        public static void AddEmployeeToList(Employee E1)
        {
            Employees.Add(E1);
        }
        public static void DeleteEmployeeToList(Employee E1)
        {
            Employees.Remove(E1);
        }

        public static void EmployeeToFile(Employee E)
        {
            StreamWriter employeeData = new StreamWriter(employeeFile, true);
            string IDs = "";
            employeeData.WriteLine(E.GetName() + "," + E.GetAge() + "," + E.GetCnic() + "," + E.GetContact() + "," + E.GetUsername() + "," + E.GetPassword() + "," + IDs);
            employeeData.Flush();
            employeeData.Close();
        }
        public static void updateEmployeeFile()
        {
            StreamWriter employeeData = new StreamWriter(employeeFile);
            for (int i = 0; i < Employees.Count; i++)
            {
                string IDs = "";
                if (Employees[i].GetUsername() != "")
                {
                    if (Employees[i].GetPeople().Count > 0)
                    {
                        for (int x = 0; x < Employees[i].GetPeople().Count - 1; x++)
                        {
                            IDs = IDs + Employees[i].GetPeople()[x].GetID() + ";";
                        }
                        IDs = IDs + Employees[i].GetPeople()[Employees[i].GetPeople().Count - 1].GetID();
                    }
                    employeeData.WriteLine(Employees[i].GetName() + "," + Employees[i].GetAge() + "," + Employees[i].GetCnic() + "," + Employees[i].GetContact() + "," + Employees[i].GetUsername() + "," + Employees[i].GetPassword() + "," + IDs);
                }
            }
            employeeData.Flush();
            employeeData.Close();
        }
        public static bool LoadEmployee()
        {
            StreamReader employeeData = new StreamReader(employeeFile);
            string record;
            if (File.Exists(employeeFile))
            {
                Employees.Clear();
                while ((record = employeeData.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    string age = splittedRecord[1];
                    string contact = splittedRecord[2];
                    string cnic = splittedRecord[3];
                    string username = splittedRecord[4];
                    string password = splittedRecord[5];
                    string[] IDs = splittedRecord[6].Split(';');
                    Employee E = new Employee(name, age, cnic, contact, username, password);
                    // if(E.GetPeople().Count > 0)
                    for (int x = 0; x < IDs.Length; x++)
                    {
                        Person P = PersonCRUD.SearchPerson(IDs[x]);
                        if (P != null)
                        {
                            E.AddPerson(P);
                        }
                    }
                    AddEmployeeToList(E);
                }
                employeeData.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
