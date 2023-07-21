using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDMS.BL;
using BDMS.DL;
namespace BDMS.UI
{
    public partial class ViewRequest : Form
    {
        public ViewRequest()
        {
            InitializeComponent();
            databind();
        }

        private void databind()
        {
            List<Request> list = RequestCRUD.CountRequest();
            GV.DataSource = null;
            GV.DataSource = list;
            GV.Columns[0].HeaderText = "Bloodgroup";
            GV.Columns[1].HeaderText = "Requests";
            GV.Refresh();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_fullfil_Click(object sender, EventArgs e)
        {
            RequestCRUD.CheckReq();
            PersonCRUD.updatePersonFile();
            EmployeeCRUD.updateEmployeeFile();
            databind();
        }

    }
}
