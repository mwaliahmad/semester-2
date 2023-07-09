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

namespace FireBuddy
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void start_Load(object sender, EventArgs e)
        {
            Stream str = Properties.Resources.alexander_nakarada_chase;
            SoundPlayer snd = new SoundPlayer(str);
            snd.Play();
        }
    }
}
