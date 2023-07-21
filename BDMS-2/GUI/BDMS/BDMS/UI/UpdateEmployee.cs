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
    public partial class UpdateEmployee : Form
    {
        public UpdateEmployee()
        {
            InitializeComponent();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            if (txt_find.Text != null)
            {
                Employee E = EmployeeCRUD.SearchEmployee(txt_find.Text);
                if (E != null)
                {
                    txt_name.Text = E.GetName();
                    num_age.Text = E.GetAge();
                    txt_contact.Text = E.GetContact();
                    txt_cnic.Text = E.GetCnic();
                    txt_user.Text = E.GetUsername();
                    txt_pass.Text = E.GetPassword();
                }
                else
                {
                    MessageBox.Show("Not Found");
                }
            }
        }

        private void txt_find_Click(object sender, EventArgs e)
        {
            txt_find.Clear();
        }

        private void btn_upt_Click(object sender, EventArgs e)
        {
            Employee E = EmployeeCRUD.SearchEmployee(txt_find.Text);
            if (E != null && Validation())
            {
                if (EmployeeCRUD.SearchEmployee(txt_user.Text) == null)
                {
                    E.SetName(txt_name.Text);
                    E.SetAge(num_age.Text);
                    E.SetContact(txt_contact.Text);
                    E.SetCnic(txt_cnic.Text);
                    E.SetUsername(txt_user.Text);
                    E.SetPassword(txt_pass.Text);

                    EmployeeCRUD.updateEmployeeFile();
                    this.Hide();
                    MessageBox.Show("Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Username Already Exists");
                }
            }
            else
            {
                MessageBox.Show("Invalid or Incomplete Input");
            }
        }
        private bool Validation()
        {
            bool flag = true;
            if (txt_name.Text == null || txt_contact.Text.Length != 12 || txt_cnic.Text.Length != 15 || txt_user.Text.Length != 5 || txt_pass.Text.Length != 5)
            {
                flag = false;
            }

            return flag;
        }

        private void txt_contact_Click(object sender, EventArgs e)
        {
            if (txt_contact.Text == "    -")
                txt_contact.SelectionStart = 0;
            else
                txt_contact.SelectionStart = txt_contact.Text.Length;

        }

        private void txt_cnic_Click(object sender, EventArgs e)
        {

            if (txt_contact.Text == "     -       -")
                txt_contact.SelectionStart = 0;
            else
                txt_contact.SelectionStart = txt_contact.Text.Length;


        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}
