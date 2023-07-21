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
    public partial class DeletePerson : Form
    {
        private Employee E;
        private bool isDonor;
        public DeletePerson(Employee E, bool isDonor)
        {
            this.E = E;
            this.isDonor = isDonor;
            InitializeComponent();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            Person P = E.SearchPerson(txt_search.Text);
            E.DeletePerson(P);
            PersonCRUD.DeletePersonToList(P);
            PersonCRUD.updatePersonFile();
            EmployeeCRUD.updateEmployeeFile();

            this.Hide();
            MessageBox.Show("Deleted Successfully");
        }

        private void txt_search_Click(object sender, EventArgs e)
        {
            txt_search.Clear();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_search.Text != null)
            {
                Person P = E.SearchPerson(txt_search.Text);
                if (P is Donor && isDonor)
                {
                    txt_name.Text = P.GetName();
                    txt_age.Text = P.GetAge();
                    txt_BG.Text = P.GetBG();
                    txt_contact.Text = P.GetContact();
                    txt_city.Text = P.GetCity();
                }
                else if (P is Recipient && !isDonor)
                {
                    txt_name.Text = P.GetName();
                    txt_age.Text = P.GetAge();
                    txt_BG.Text = P.GetBG();
                    txt_contact.Text = P.GetContact();
                    txt_city.Text = P.GetCity();
                }
                else
                {
                    MessageBox.Show("Not Found");
                }
            }
        }
    }
}
