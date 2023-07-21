using BDMS.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDMS.DL;

namespace BDMS.UI
{
    public partial class SearchPerson : Form
    {
        private Employee E;
        private bool isDonor;
        private bool isAdmin;
        public SearchPerson(Employee E, bool isDonor)
        {
            this.E = E;
            this.isDonor = isDonor;
            InitializeComponent();
        }
        public SearchPerson(bool isDonor, bool isAdmin)
        {
            InitializeComponent();
            this.isDonor = isDonor;
            this.isAdmin = isAdmin;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (!isAdmin)
            {
                userBinding();
            }
            else
            {
                adminBinding();
            }
        }
        private void userBinding()
        {
            List<Person> people;
            if (isDonor)
            {
                people = E.SearchPersonByBG(cb_BG.Text, 'D');
            }
            else
            {
                people = E.SearchPersonByBG(cb_BG.Text, 'R');
            }
            databind(people);
        }
        private void adminBinding()
        {
            List<Person> people;
            if (isDonor)
            {
                people = PersonCRUD.SearchPersonByBG(cb_BG.Text, 'D');
            }
            else
            {
                people = PersonCRUD.SearchPersonByBG(cb_BG.Text, 'R');
            }
            databind(people);
        }
        private void databind(List<Person> people)
        {
            if (people == null)
            {
                MessageBox.Show("Not found");
            }
            else
            {
                GV.DataSource = null;
                /*foreach (Person person in people)
                {
                    GV.DataSource = people.Select(a => new { a.ID1, a.Name, a.Age, a.BG, a.Contact, a.City }).ToList();
                }*/
                GV.DataSource = people;
                GV.Columns[0].HeaderText = "ID";
                GV.Refresh();
            }
        }
        private void cb_BG_Click(object sender, EventArgs e)
        {
            cb_BG.DroppedDown = true;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
