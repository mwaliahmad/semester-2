using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using FireBuddy.UI;

namespace FireBuddy
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            setLevel(new Start());
            WindowState = FormWindowState.Maximized;
        }
        public void setForm(Form form)
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

        public void setLevel(Start form)
        {
            panel_main.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            panel_main.Tag = form;
            form.BringToFront();
            form.start_btn += Form_start_btn;
            form.Show();
        }

        private void Form_start_btn(object sender, EventArgs e)
        {
            if(((Start)sender).IsClick)
            {
                setForm(new Level1());
            }
        }
    }
}
