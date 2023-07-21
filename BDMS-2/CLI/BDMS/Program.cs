using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDMS.BL;
using BDMS.DL;
using BDMS.UI;
using static System.Net.Mime.MediaTypeNames;

namespace BDMS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowPosition(0, 0);
            Console.SetWindowSize(125, 32);

            bool flag3 = RequestCRUD.LoadRequests();
            if (flag3)
            {
                Common.MessageBox("Request Loaded");
            }
            bool flag1 = PersonCRUD.LoadPerson();
            if (flag1)
            {
                Common.MessageBox("Person Loaded");
            }
            bool flag2 = EmployeeCRUD.LoadEmployee();
            if (flag2)
            {
                Common.MessageBox("Employee Loaded");
            }
            while (true)
            {
                Common.Header();
                User U = UserUI.Login();
                User opt = U.CheckRole();
                if (opt is Admin A)
                {
                    Common.Header();
                    AdminMenu();
                }
                else if (opt is Employee E)
                {
                    Common.Header();
                    EmployeeMenu(E);
                }
                else if (opt is Guest G)
                {
                    Common.Header();
                    GuestMenu();
                }
                else
                {
                    Common.MessageBox("Wrong Input");
                }
            }
        }
        static void AdminMenu()
        {
            int opt = 0;
            while (opt != 11)
            {
                Common.Header();
                Common.Menu("Login", "Admin Menu");
                Menu.MenuAdmin();
                opt = Common.Option(11, "Enter Option: ");
                if (opt == 1)
                {
                    Common.Header();
                    Employee E = EmployeeUI.AddEmployee("Admin Menu", "Add Employee");
                    EmployeeCRUD.AddEmployeeToList(E);
                    EmployeeCRUD.EmployeeToFile(E);
                    Common.Back("Employee Added Successfully...");
                }
                else if (opt == 2)
                {
                    Common.Header();
                    string name = EmployeeUI.SearchEmployee("Admin Menu", "Delete Employee");
                    Employee E = EmployeeCRUD.SearchEmployee(name);
                    if (E != null)
                    {
                        EmployeeUI.EmployeeHeading();
                        EmployeeUI.DisplayEmployee(E);
                        EmployeeCRUD.DeleteEmployeeToList(E);
                        EmployeeCRUD.updateEmployeeFile();
                        Common.Back("Employee Removed...");
                    }
                    else
                    {
                        Common.Back("Employee Not Found");
                    }
                }
                else if (opt == 3)
                {
                    Common.Header();
                    string name = EmployeeUI.SearchEmployee("Admin Menu", "Update Employee");
                    Employee E = EmployeeCRUD.SearchEmployee(name);
                    if (E != null)
                    {
                        EmployeeUI.EmployeeHeading();
                        EmployeeUI.DisplayEmployee(E);
                        EmployeeUI.UpdateEmployee(E);
                        EmployeeCRUD.updateEmployeeFile();
                        Common.Back("Employee Updated...");
                    }
                    else
                    {
                        Common.Back("Employee Not Found");
                    }
                }
                else if (opt == 4)
                {
                    Common.Header();
                    string name = EmployeeUI.SearchEmployee("Admin Menu", "Search Employee");
                    Employee E = EmployeeCRUD.SearchEmployee(name);
                    if (E != null)
                    {
                        EmployeeUI.EmployeeHeading();
                        EmployeeUI.DisplayEmployee(E);
                        Common.Back("");
                    }
                    else
                    {
                        Common.Back("Employee Not Found");
                    }
                }
                else if (opt == 5)
                {
                    Common.Header();
                    Common.Menu("Admin Menu", "View all Employees");
                    EmployeeUI.EmployeeHeading();
                    if (EmployeeCRUD.GetList().Count != 0)
                    {
                        foreach (var E in EmployeeCRUD.GetList())
                        {
                            EmployeeUI.DisplayEmployee(E);
                        }
                        Common.Back("");
                    }
                    else
                    {
                        Common.Back("Employees Not Found...Add First to View");
                    }
                }
                else if (opt == 6)
                {
                    Common.Header();
                    string BG = DonorUI.SearchDonor("Bloodgroup", "Admin Menu", "Search Donor");
                    List<Person> lst = PersonCRUD.SearchPersonByBG(BG, 'D');
                    if (lst.Count > 0)
                    {
                        PersonUI.PersonHeading();
                        PersonUI.DisplayList(lst);
                        Common.Back("");
                    }
                    else
                    {
                        Common.Back("Donor Not Found");
                    }
                }
                else if (opt == 7)
                {
                    int count = 0;
                    Common.Header();
                    Common.Menu("Admin Menu", "View all Donors");
                    PersonUI.PersonHeading();
                    if (PersonCRUD.GetList().Count != 0)
                    {
                        foreach (var P in PersonCRUD.GetList())
                        {
                            if (P is Donor D)
                            {
                                count++;
                                PersonUI.DisplayPerson(P);
                            }
                        }
                        if (count > 0)
                        {
                            Common.Back("");
                        }
                    }
                    if (count == 0)
                    {
                        Common.Back("Donor Not Found...Add First to View");
                    }
                }
                else if (opt == 8)
                {
                    Common.Header();
                    string BG = RecipientUI.SearchRecipient("Bloodgroup", "Admin Menu", "Search Recipient");
                    List<Person> lst = PersonCRUD.SearchPersonByBG(BG, 'R');
                    if (lst.Count > 0)
                    {
                        PersonUI.PersonHeading();
                        PersonUI.DisplayList(lst);
                        Common.Back("");
                    }
                    else
                    {
                        Common.Back("Recipient Not Found");
                    }
                }
                else if (opt == 9)
                {
                    int count = 0;
                    Common.Header();
                    Common.Menu("Admin Menu", "View all Recipients");
                    PersonUI.PersonHeading();
                    if (PersonCRUD.GetList().Count != 0)
                    {
                        foreach (var P in PersonCRUD.GetList())
                        {
                            if (P is Recipient R)
                            {
                                PersonUI.DisplayPerson(P);
                                count++;
                            }
                        }
                        if (count > 0)
                        {
                            Common.Back("");
                        }
                    }
                    if (count == 0)
                    {
                        Common.Back("Recipient Not Found...Add First to View");
                    }
                }
                else if (opt == 10)
                {
                    Common.Header();
                    Common.Menu("Admin Menu", "View all Requests");
                    RequestCRUD.CheckReq();
                    PersonCRUD.updatePersonFile();
                    EmployeeCRUD.updateEmployeeFile();
                    List<Request> requests=  RequestCRUD.CountRequest();
                    if(requests.Count!=0)
                    {
                        RequestUI.RequestTable(requests); 
                        Common.Back("");
                    }
                    else
                    {
                        Common.Back("We have NO Requests");
                    }
                }
                else if (opt > 11)
                {
                    Common.MessageBox("Wrong Input");
                }
            }
        }
        static void EmployeeMenu(Employee E)
        {
            int opt = 0;
            while (opt != 11)
            {
                Common.Header();
                Common.Menu("Login", "Employee Menu");
                Menu.MenuEmployee();
                opt = Common.Option(11, "Enter Option: ");
                if (opt == 1)
                {
                    Common.Header();
                    Donor D = DonorUI.AddDonor("Employee Menu", "Add Donor");
                    E.AddPerson(D);
                    PersonCRUD.AddPersonToList(D);
                    PersonCRUD.PersonToFile(D);
                    EmployeeCRUD.updateEmployeeFile();
                    Common.Back("Donor Added Successfully...");
                }
                else if (opt == 2)
                {
                    Common.Header();
                    string ID = DonorUI.SearchDonor("ID", "Employee Menu", "Delete Donor");
                    Person P = E.SearchPerson(ID);
                    if (P != null)
                    {
                        PersonUI.PersonHeading();
                        PersonUI.DisplayPerson(P);
                        E.DeletePerson(P);
                        PersonCRUD.DeletePersonToList(P);
                        PersonCRUD.updatePersonFile();
                        EmployeeCRUD.updateEmployeeFile();
                        Common.Back("Donor Removed...");
                    }
                    else
                    {
                        Common.Back("Donor Not Found");
                    }
                }
                else if (opt == 3)
                {
                    Common.Header();
                    string ID = DonorUI.SearchDonor("ID", "Employee Menu", "Update Donor");
                    Person P = E.SearchPerson(ID);
                    if (P != null)
                    {
                        PersonUI.PersonHeading();
                        PersonUI.DisplayPerson(P);
                        DonorUI.UpdateDonor(P);
                        PersonCRUD.updatePersonFile();
                        EmployeeCRUD.updateEmployeeFile();
                        Common.Back("Donor Updated...");
                    }
                    else
                    {
                        Common.Back("Donor Not Found");
                    }
                }
                else if (opt == 4)
                {
                    Common.Header();
                    string BG = DonorUI.SearchDonor("Bloodgroup", "Employee Menu", "Search Donor");
                    List<Person> lst = E.SearchPersonByBG(BG, 'D');
                    if (lst.Count > 0)
                    {
                        PersonUI.PersonHeading();
                        PersonUI.DisplayList(lst);
                        Common.Back("");
                    }
                    else
                    {
                        Common.Back("Donor Not Found");
                    }
                }
                else if (opt == 5)
                {
                    int count = 0;
                    Common.Header();
                    Common.Menu("Employee Menu", "View all Donors");
                    PersonUI.PersonHeading();
                    if (E.GetPeople().Count != 0)
                    {
                        foreach (var P in E.GetPeople())
                        {
                            if (P is Donor D)
                            {
                                count++;
                                PersonUI.DisplayPerson(P);
                            }
                        }
                        if (count > 0)
                        {
                            Common.Back("");
                        }
                    }
                    if (count == 0)
                    {
                        Common.Back("Donor Not Found...Add First to View");
                    }
                }
                else if (opt == 6)
                {
                    Common.Header();
                    Recipient R = RecipientUI.AddRecipient("Employee Menu", "Add Recipient");
                    E.AddPerson(R);
                    PersonCRUD.AddPersonToList(R);
                    PersonCRUD.PersonToFile(R);
                    EmployeeCRUD.updateEmployeeFile();
                    Common.Back("Recipient Added Successfully...");
                }
                else if (opt == 7)
                {
                    Common.Header();
                    string ID = RecipientUI.SearchRecipient("ID", "Employee Menu", "Delete Donor");
                    Person P = E.SearchPerson(ID);
                    if (P != null)
                    {
                        PersonUI.PersonHeading();
                        PersonUI.DisplayPerson(P);
                        E.DeletePerson(P);
                        PersonCRUD.DeletePersonToList(P);
                        PersonCRUD.updatePersonFile();
                        EmployeeCRUD.updateEmployeeFile();
                        Common.Back("Recipient Removed...");
                    }
                    else
                    {
                        Common.Back("Recipient Not Found");
                    }
                }
                else if (opt == 8)
                {
                    Common.Header();
                    string ID = RecipientUI.SearchRecipient("ID", "Employee Menu", "Update Recipient");
                    Person P = E.SearchPerson(ID);
                    if (P != null)
                    {
                        PersonUI.PersonHeading();
                        PersonUI.DisplayPerson(P);
                        RecipientUI.UpdateRecipient(P);
                        PersonCRUD.updatePersonFile();
                        EmployeeCRUD.updateEmployeeFile();
                        Common.Back("Recipient Updated...");
                    }
                    else
                    {
                        Common.Back("Recipient Not Found");
                    }
                }
                else if (opt == 9)
                {
                    Common.Header();
                    string BG = DonorUI.SearchDonor("Bloodgroup", "Employee Menu", "Search Recipient");
                    List<Person> lst = E.SearchPersonByBG(BG, 'R');
                    if (lst.Count > 0)
                    {
                        PersonUI.PersonHeading();
                        PersonUI.DisplayList(lst);
                        Common.Back("");
                    }
                    else
                    {
                        Common.Back("Recipient Not Found");
                    }
                }
                else if (opt == 10)
                {
                    int count = 0;
                    Common.Header();
                    Common.Menu("Employee Menu", "View all Recipients");
                    PersonUI.PersonHeading();
                    if (E.GetPeople().Count != 0)
                    {
                        foreach (var P in E.GetPeople())
                        {
                            if (P is Recipient R)
                            {
                                PersonUI.DisplayPerson(P);
                                count++;
                            }
                        }
                        if (count > 0)
                        {
                            Common.Back("");
                        }
                    }
                    if (count == 0)
                    {
                        Common.Back("Recipient Not Found...Add First to View");
                    }
                }
                else if (opt > 11)
                {
                    Common.MessageBox("Wrong Input");
                }
            }
        }
        static void GuestMenu()
        {
            int opt = 0;
            while (opt != 4)
            {
                Common.Header();
                Common.Menu("Login", "Guest Menu");
                Menu.MenuGuest();
                opt = Common.Option(4, "Enter Option: ");
                if (opt == 1)
                {
                    Common.Header();
                    string BG = DonorUI.SearchDonor("Bloodgroup", "Guest Menu", "Search Donor");
                    List<Person> lst = PersonCRUD.SearchPersonByBG(BG, 'D');
                    if (lst.Count > 0)
                    {
                        PersonUI.PersonHeading();
                        PersonUI.DisplayList(lst);
                        Common.Back("");
                    }
                    else
                    {
                        Common.Back("Donor Not Found");
                    }
                }
                else if (opt == 2)
                {
                    Common.Header();
                    string BG = RecipientUI.SearchRecipient("Bloodgroup", "Guest Menu", "Search Recipient");
                    List<Person> lst = PersonCRUD.SearchPersonByBG(BG, 'R');
                    if (lst.Count > 0)
                    {
                        PersonUI.PersonHeading();
                        PersonUI.DisplayList(lst);
                        Common.Back("");
                    }
                    else
                    {
                        Common.Back("Recipient Not Found");
                    }
                }
                else if (opt == 3)
                {
                    Common.Header();
                    Common.Menu("Guest Menu", "Request Blood");
                    string BG = Common.BG("Enter Required Bloodgroup: ");
                    if (PersonCRUD.SearchBG(BG))
                    {
                        Common.Back("Your Required BloodGroup is Present in our Bank You can get this");
                    }
                    else
                    {
                        RequestCRUD.AddRequest(BG);
                        Common.Back("Required Added");
                        RequestCRUD.RequestToFile(BG);
                    }
                }
                else if (opt > 4)
                {
                    Common.MessageBox("Wrong Input");
                }
            }
        }
    }
}
