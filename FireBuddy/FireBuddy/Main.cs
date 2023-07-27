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
            setStart(new Start());
            WindowState = FormWindowState.Maximized;
        }
        public void setLevel(Level1 form)
        {
            panel_main.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            panel_main.Tag = form;
            form.menu_btn += Form_menu_btn;
            form.nextlvl_btn += Form_nextlvl_btn;
            form.BringToFront();
            form.Show();
        }
        public void setLevel2(Level2 form)
        {
            panel_main.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            panel_main.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            panel_main.Tag = form;
            form.menu_btn += Form_menu_btn1;
            form.BringToFront();
            form.Show();
        }

        private void Form_menu_btn1(object sender, EventArgs e)
        {

            panel_main.Controls.Clear();
            setStart(new Start());
        }

        private void Form_nextlvl_btn()
        {
            setLevel2(new Level2());
        }

        private void Form_menu_btn(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            setStart(new Start());

        }

        public void setStart(Start form)
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
            if (((Start)sender).IsClick)
            {
                setLevel(new Level1());
            }
        }
    }
}
