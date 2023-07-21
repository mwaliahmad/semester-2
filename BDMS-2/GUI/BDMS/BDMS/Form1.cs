using BDMS.BL;
using BDMS.UI;
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

namespace BDMS
{
    public partial class Login : Form
    {
        public Employee CurrentEmployee;
        public Login()
        {
            InitializeComponent();
        }
        private void CheckLoginUser(User U)
        {
            User loginUser = U.CheckRole();
            if (loginUser is Admin A)
            {
                AdminUI admin = new AdminUI();
                this.Hide();
                admin.Show();

            }
            else if (loginUser is Employee E)
            {
                CurrentEmployee = E;
                EmployeeUI employee = new EmployeeUI(CurrentEmployee);
                this.Hide();
                employee.Show();
            }
            else if (loginUser is Guest G)
            {
                GuestUI guest = new GuestUI();
                this.Hide();
                guest.Show();
            }
            else
            {
                MessageBox.Show("Wrong Input");
                txt_user.Clear();
                txt_pass.Clear();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string user = txt_user.Text;
            string pass = txt_pass.Text;
            User U = new User(user, pass);
            CheckLoginUser(U);
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            bool flag1 = PersonCRUD.LoadPerson();
            bool flag2 = EmployeeCRUD.LoadEmployee();
            bool flag3 = RequestCRUD.LoadRequests();
            if (!(flag1 && flag2 && flag3))
            {
                MessageBox.Show("Data Not Loaded");
            }
        }
    }
}
