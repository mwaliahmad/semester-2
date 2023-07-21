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
    public partial class DeleteEmployee : Form
    {
        public DeleteEmployee()
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

        private void btn_Del_Click(object sender, EventArgs e)
        {
            Employee E = EmployeeCRUD.SearchEmployee(txt_find.Text);
            if (E != null)
            {
                EmployeeCRUD.DeleteEmployeeToList(E);
                EmployeeCRUD.updateEmployeeFile();
                this.Hide();
                MessageBox.Show("Deleted Successfully");
            }
        }

        private void txt_find_Click(object sender, EventArgs e)
        {
            txt_find.Clear();
        }
    }
}
