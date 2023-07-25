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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string age = num_age.Value.ToString();
            string contact = txt_contact.Text;
            string cnic = txt_cnic.Text;
            string username = txt_user.Text;
            string password = txt_pass.Text;
            if (Validation())
            {
                if (EmployeeCRUD.SearchEmployee(username) == null)
                {
                    Employee E = new Employee(name, age, contact, cnic, username, password);
                    EmployeeCRUD.AddEmployeeToList(E);
                    EmployeeCRUD.EmployeeToFile(E);
                    this.Hide();
                    MessageBox.Show("Added Successfully");
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
        private bool Validation()
        {
            bool flag = true;
            if (txt_name.Text == null || txt_contact.Text.Length != 12 || txt_cnic.Text.Length != 15 || txt_user.Text.Length != 5 || txt_pass.Text.Length != 5)
            {
                flag = false;
            }

            return flag;
        }
    }
}
