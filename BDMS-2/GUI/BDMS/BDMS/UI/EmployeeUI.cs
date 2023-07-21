using BDMS.BL;
using BDMS.DL;
using Google.Protobuf.WellKnownTypes;
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
    public partial class EmployeeUI : Form
    {
        private Employee E;
        public EmployeeUI(Employee E)
        {
            this.E = E;
            InitializeComponent();
            customizeDesign();
            setCredentials();
        }
        private void setCredentials()
        {
            user.Text = E.GetUsername();
            pass.Text = E.GetPassword();
        }
        private void btn_change_Click(object sender, EventArgs e)
        {
            string input = "";
            if (changePass("Dialog Box", "Enter New Password", ref input) == DialogResult.OK)
            {
                E.SetPassword(input);
                EmployeeCRUD.updateEmployeeFile();
                setCredentials();
            }
        }
        private DialogResult changePass(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();
            form.Text = title;
            label.Text = promptText;
            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;
            label.SetBounds(36, 36, 200, 13);
            textBox.SetBounds(36, 86, 200, 20);
            buttonOk.SetBounds(50, 160, 100, 60);
            buttonCancel.SetBounds(150, 160, 100, 60);
            label.AutoSize = true;
            form.ClientSize = new Size(300, 300);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;
            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }
        private void customizeDesign()
        {
            panel_Dmenu.Visible = false;
            panel_Rmenu.Visible = false;
        }
        private void hideSubmenu()
        {
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

        private void btn_donor_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_Dmenu);
        }
        private void btn_AddD_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            AddPerson addPerson = new AddPerson(E, true);
            setForm(addPerson);
        }

        private void btn_delD_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            DeletePerson deletePerson = new DeletePerson(E, true);
            setForm(deletePerson);
        }

        private void btn_uptD_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            UpdatePerson updatePerson = new UpdatePerson(E, true);
            setForm(updatePerson);
        }

        private void btn_searchD_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            SearchPerson searchPerson = new SearchPerson(E, true);
            setForm(searchPerson);
        }

        private void btn_viewD_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            ViewPerson viewPerson = new ViewPerson(E, true, false);
            setForm(viewPerson);
        }

        private void btn_recipient_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_Rmenu);
        }

        private void btn_addR_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            AddPerson addPerson = new AddPerson(E, false);
            setForm(addPerson);
        }

        private void btn_delR_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            DeletePerson deletePerson = new DeletePerson(E, false);
            setForm(deletePerson);
        }

        private void btn_uptR_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            UpdatePerson updatePerson = new UpdatePerson(E, false);
            setForm(updatePerson);
        }

        private void btn_searchR_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            SearchPerson searchPerson = new SearchPerson(E, false);
            setForm(searchPerson);
        }

        private void btn_viewR_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            ViewPerson viewPerson = new ViewPerson(E, false, false);
            setForm(viewPerson);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void EmployeeUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        private void setForm(Form form)
        {
            panel_main.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel_main.Controls.Add(form);
            panel_main.Tag = form;
            form.BringToFront();
            form.Show();
        }

    }
}
