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
    public partial class GuestUI : Form
    {
        public GuestUI()
        {
            InitializeComponent();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void GuestUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_donor_Click(object sender, EventArgs e)
        {
            SearchPerson viewPerson = new SearchPerson(true, true);
            setForm(viewPerson);
        }

        private void btn_recipient_Click(object sender, EventArgs e)
        {
            SearchPerson searchPerson = new SearchPerson(false, true);
            setForm(searchPerson);
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
            AddRequest addRequest = new AddRequest();
            setForm(addRequest);
        }
    }
}
