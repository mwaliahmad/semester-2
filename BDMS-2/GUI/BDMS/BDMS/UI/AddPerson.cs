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
    public partial class AddPerson : Form
    {
        private Employee E;
        private bool isDonor;
        public AddPerson(Employee E, bool isDonor)
        {
            this.E = E;
            this.isDonor = isDonor;
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string age = num_age.Value.ToString();
            string bg = cb_BG.Text;
            string contact = txt_contact.Text;
            string city = cb_city.Text;

            if (Validation())
            {
                if (isDonor)
                {
                    Donor D = new Donor(name, age, bg, contact, city);
                    D.SetID(PersonCRUD.CreateID(D));
                    E.AddPerson(D);
                    PersonCRUD.AddPersonToList(D);
                    PersonCRUD.PersonToFile(D);
                }
                else
                {
                    Recipient R = new Recipient(name, age, bg, contact, city);
                    R.SetID(PersonCRUD.CreateID(R));
                    E.AddPerson(R);
                    PersonCRUD.AddPersonToList(R);
                    PersonCRUD.PersonToFile(R);
                }


                EmployeeCRUD.updateEmployeeFile();
                this.Hide();
                MessageBox.Show("Added Successfully");
            }
            else
            {
                MessageBox.Show("Invalid or Incomplete Input");
            }
        }

        private void cb_BG_Click(object sender, EventArgs e)
        {
            cb_BG.DroppedDown = true;
        }

        private void cb_city_Click(object sender, EventArgs e)
        {
            cb_city.DroppedDown = true;
        }

        private void txt_contact_Click(object sender, EventArgs e)
        {
            if (txt_contact.Text == "    -")
                txt_contact.SelectionStart = 0;
            else
                txt_contact.SelectionStart = txt_contact.Text.Length;

        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
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
    }
}
