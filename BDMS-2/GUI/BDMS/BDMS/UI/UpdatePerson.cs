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
    public partial class UpdatePerson : Form
    {
        private Employee E;
        private bool isDonor;
        public UpdatePerson(Employee E, bool isDonor)
        {
            this.E = E;
            this.isDonor = isDonor;
            InitializeComponent();
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
                    num_age.Text = P.GetAge();
                    cb_BG.Text = P.GetBG();
                    txt_contact.Text = P.GetContact();
                    cb_city.Text = P.GetCity();
                }
                else if (P is Recipient && !isDonor)
                {
                    txt_name.Text = P.GetName();
                    num_age.Text = P.GetAge();
                    cb_BG.Text = P.GetBG();
                    txt_contact.Text = P.GetContact();
                    cb_city.Text = P.GetCity();
                }
                else
                {
                    MessageBox.Show("Not Found");
                }
            }
        }
        private void btn_upt_Click(object sender, EventArgs e)
        {
            Person P = E.SearchPerson(txt_search.Text);
            if (P != null && Validation())
            {
                P.SetName(txt_name.Text);
                P.SetAge(num_age.Value.ToString());
                P.SetBG(cb_BG.Text);
                P.SetContact(txt_contact.Text);
                P.SetCity(cb_city.Text);

                PersonCRUD.updatePersonFile();
                EmployeeCRUD.updateEmployeeFile();

                this.Hide();
                MessageBox.Show("Updated Successfully");
            }
            else
            {
                MessageBox.Show("Invalid or Incomplete Input");
            }
        }
        private bool Validation()
        {
            bool flag = true;
            if (txt_name.Text == null || txt_contact.Text.Length != 12 || cb_BG.SelectedIndex == -1 || cb_city.SelectedIndex == -1)
            {
                flag = false;
            }

            return flag;
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txt_contact_Click(object sender, EventArgs e)
        {
            if (txt_contact.Text == "    -")
                txt_contact.SelectionStart = 0;
            else
                txt_contact.SelectionStart = txt_contact.Text.Length;
        }
    }
}
