using BDMS.BL;
using BDMS.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDMS.UI
{
    public partial class ViewPerson : Form
    {
        private Employee E;
        private bool isDonor;
        private bool isAdmin;
        public ViewPerson(Employee E, bool isDonor, bool isAdmin)
        {
            this.E = E;
            this.isDonor = isDonor;
            this.isAdmin = isAdmin;
            InitializeComponent();

            databind();

        }
        public ViewPerson(bool isDonor, bool isAdmin)
        {
            this.isDonor = isDonor;
            this.isAdmin = isAdmin;
            InitializeComponent();

            AdminDatabind();

        }

        private void AdminDatabind()
        {
            List<Person> list = new List<Person>();
            List<Person> people = PersonCRUD.GetList();
            GV.DataSource = null;
            if (people.Count > 0)
            {
                for (int i = 0; i < people.Count; i++)
                {
                    if (isDonor)
                    {
                        if (people[i] is Donor D)
                        {
                            list.Add(people[i]);
                        }
                    }
                    else
                    {
                        if (people[i] is Recipient R)
                        {
                            list.Add(people[i]);
                        }
                    }

                }
                GV.DataSource = list;
                GV.Columns[0].HeaderText = "ID";
                GV.Refresh();
            }
            else
            {
                MessageBox.Show("Not Found Add First to View");
            }
        }

        private void databind()
        {
            List<Person> list = new List<Person>();
            GV.Rows.Clear();
            if (E.GetPeople().Count > 0)
            {
                foreach (Person person in E.GetPeople())
                {
                    if (isDonor)
                    {
                        if (person is Donor D)
                        {
                            list.Add(person);
                        }
                    }
                    else
                    {
                        if (person is Recipient R)
                        {
                            list.Add(person);
                        }
                    }
                }

                GV.DataSource = list;
                GV.Columns[0].HeaderText = "ID";
                GV.Refresh();
            }
            else
            {
                MessageBox.Show("Not Found Add First to View");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_pdf_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                List<Person> list = new List<Person>();
                List<Person> people = PersonCRUD.GetList();
                GV.DataSource = null;
                if (people.Count > 0)
                {
                    for (int i = 0; i < people.Count; i++)
                    {
                        if (isDonor)
                        {
                            if (people[i] is Donor D)
                            {
                                list.Add(people[i]);
                            }
                        }
                        else
                        {
                            if (people[i] is Recipient R)
                            {
                                list.Add(people[i]);
                            }
                        }

                    }
                    PdfGenerator.GeneratePdfReport(list);
                }
            }
            else
            {
                List<Person> list = new List<Person>();
                if (E.GetPeople().Count > 0)
                {
                    foreach (Person person in E.GetPeople())
                    {
                        if (isDonor)
                        {
                            if (person is Donor D)
                            {
                                list.Add(person);
                            }
                        }
                        else
                        {
                            if (person is Recipient R)
                            {
                                list.Add(person);
                            }
                        }
                    }
                    PdfGenerator.GeneratePdfReport(list);
                }
            }
            MessageBox.Show("Downloaded Successfully");
            this.Hide();
        }
    }
}
