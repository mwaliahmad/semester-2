using BDMS.DL;
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
    public partial class AddRequest : Form
    {
        public AddRequest()
        {
            InitializeComponent();
        }

        private void cb_BG_Click(object sender, EventArgs e)
        {
            cb_BG.DroppedDown = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (cb_BG.Text != null)
            {
                if (PersonCRUD.SearchBG(cb_BG.Text))
                {
                    MessageBox.Show("Your Required BloodGroup is Present in our Bank You can get this");
                }
                else
                {
                    RequestCRUD.AddRequest(cb_BG.Text);
                    RequestCRUD.RequestToFile(cb_BG.Text);
                    this.Hide();
                    MessageBox.Show("Request Added");
                }
            }
            else
            {
                MessageBox.Show("Please Select the Bloodgroup");
            }
        }
    }
}
