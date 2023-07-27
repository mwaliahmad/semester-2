using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireBuddy.UI
{
    public partial class Menu : Form
    {
        public event EventHandler resume_btn;

        private bool isClick;
        public bool IsClick
        {
            get => isClick;
        }
        public event EventHandler menu_btn;

        private bool isClick2;
        public bool IsClick2
        {
            get => isClick2;
        }

        public Menu()
        {
            InitializeComponent();
        }

        private void btn_resume_Click(object sender, EventArgs e)
        {
            isClick = true;
            resume_btn?.Invoke(this, e);
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Game Over");
            Environment.Exit(0);
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            isClick2 = true;
            menu_btn?.Invoke(this, e);
            this.Close();
        }
    }
}
