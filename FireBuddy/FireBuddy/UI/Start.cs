using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireBuddy.UI
{
    public partial class Start : Form
    {
        public event EventHandler start_btn;
        
        private bool isClick;
        public bool IsClick 
        {
            get => isClick;
        }
        
        public Start()
        {
            InitializeComponent();
            setMusic();
            option_btns.Hide();
        }
         private void setMusic()
        {
            SoundPlayer snd = new SoundPlayer(Properties.Resources.background);
            snd.PlayLooping();
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            isClick = true;
            start_btn?.Invoke(this, e);
            this.Close();
        }

        private void btn_opt_Click(object sender, EventArgs e)
        {
            btns.Hide();
            option_btns.Show();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            sub_panel.Hide();
            option_btns.Hide();
            btns.Show();
        }
        public void setForm(Form form)
        {
            sub_panel.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            sub_panel.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            sub_panel.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void play_btn_Click(object sender, EventArgs e)
        {
            setForm(new HowtoPlay());
            sub_panel.Show();
        }

        private void instruction_btn_Click(object sender, EventArgs e)
        {
            setForm(new Instruction());
            sub_panel.Show();
        }

        private void credit_btn_Click(object sender, EventArgs e)
        {
            setForm(new Credits());
            sub_panel.Show();
        }
    }
}
