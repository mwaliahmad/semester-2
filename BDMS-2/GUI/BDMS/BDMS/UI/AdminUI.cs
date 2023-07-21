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

namespace BDMS.UI
{
    public partial class AdminUI : Form
    {
        public AdminUI()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            panel_Emenu.Visible = false;
            panel_Dmenu.Visible = false;
            panel_Rmenu.Visible = false;
        }
        private void hideSubmenu()
        {
            if (panel_Emenu.Visible == true)
            {
                panel_Emenu.Visible = false;
            }
            if (panel_Dmenu.Visible == true)
            {
                panel_Dmenu.Visible = false;
            }
            if (panel_Rmenu.Visible == true)
            {
                panel_Rmenu.Visible = false;
            }
        }
        private void showSubmenu(Panel M)
        {
            if (M.Visible == false)
            {
                hideSubmenu();
                M.Visible = true;
            }
            else
            {
                M.Visible = false;
            }
        }



        private void btn_employee_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_Emenu);
        }
        private void btn_AddE_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            AddEmployee addEmployee = new AddEmployee();
            setForm(addEmployee);
        }

        private void btn_delE_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            DeleteEmployee deleteEmployee = new DeleteEmployee();
            setForm(deleteEmployee);
        }

        private void btn_uptE_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            UpdateEmployee updateEmployee = new UpdateEmployee();
            setForm(updateEmployee);
        }

        private void btn_searchE_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            SearchEmployee searchEmployee = new SearchEmployee();
            setForm(searchEmployee);
        }

        private void btn_viewE_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            ViewEmployee viewEmployee = new ViewEmployee();
            setForm(viewEmployee);
        }

        private void btn_donor_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_Dmenu);
        }
        private void btn_searchD_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            SearchPerson searchPerson = new SearchPerson(true, true);
            setForm(searchPerson);
        }

        private void btn_viewD_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            ViewPerson viewPerson = new ViewPerson(true, true);
            setForm(viewPerson);
        }

        private void btn_recipient_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_Rmenu);
        }
        private void btn_searchR_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            SearchPerson searchPerson = new SearchPerson(false, true);
            setForm(searchPerson);
        }

        private void btn_viewR_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            ViewPerson viewPerson = new ViewPerson(false, true);
            setForm(viewPerson);
        }
        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
        private void AdminUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        private void setForm(Form form)
        {
            panel_main.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            panel_main.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void btn_request_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            ViewRequest viewRequest = new ViewRequest();
            setForm(viewRequest);
        }
    }
}
