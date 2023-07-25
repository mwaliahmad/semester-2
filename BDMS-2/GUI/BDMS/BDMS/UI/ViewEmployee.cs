using BDMS.BL;
using BDMS.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDMS.UI
{
    public partial class ViewEmployee : Form
    {
        public ViewEmployee()
        {
            InitializeComponent();
            Databind();
        }

        public AdminUI AdminUI
        {
            get => default;
            set
            {
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Databind()
        {
            List<Employee> list = EmployeeCRUD.GetList();
            if (list.Count > 0)
            {
                GV.DataSource = null;
                GV.DataSource = list;

                GV.Columns[1].HeaderText = "Name";
                GV.Columns[2].HeaderText = "Age";
                GV.Columns[3].HeaderText = "Contact";
                GV.Columns[4].HeaderText = "CNIC";

                GV.Refresh();
            }

            else
            {
                MessageBox.Show("Not Found Add First to View");
            }
        }
        private void btn_pdf_Click(object sender, EventArgs e)
        {
            PdfGenerator.GeneratePdfReport(EmployeeCRUD.GetList());
            MessageBox.Show("Downloaded Successfully");
            this.Hide();
        }

        private void GV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GV.Columns["btn_view"].Index == e.ColumnIndex)
            {
                int row = e.RowIndex;
                Employee E = EmployeeCRUD.SearchEmployee(GV.Rows[row].Cells[5].Value.ToString());
                if (E.GetPeople().Count > 0)
                {
                    PdfGenerator.GeneratePdfReport(E.GetPeople());
                    MessageBox.Show("Downloaded Successfully");
                }
                else
                {
                    MessageBox.Show("This Employee has no DATA");
                }
            }
        }
    }
}
