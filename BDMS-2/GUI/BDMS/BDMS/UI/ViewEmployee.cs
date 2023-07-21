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
            cbBinding();
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


                // GV.Columns[0].HeaderText = "Person";
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
        List<string> a = new List<string>();
        private void cbBinding()
        {
            DataGridViewComboBoxColumn dataGridViewComboBoxColumn = new DataGridViewComboBoxColumn();
            foreach (DataGridViewRow row in GV.Rows)
            {
                Employee e = EmployeeCRUD.SearchEmployee(row.Cells[5].Value.ToString());
                //    persons.DataSource = e.GetPeople().Select(x => x.ID1).ToList();
                DataGridViewComboBoxCell comboBoxCell = new DataGridViewComboBoxCell();
                comboBoxCell.DataSource = e.GetIDs();
                comboBoxCell.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
                row.Cells[0] = comboBoxCell;
            }
            //dataGridViewComboBoxColumn.DataSource = a;
            //GV.Columns.Add(dataGridViewComboBoxColumn);
        }
        private void btn_pdf_Click(object sender, EventArgs e)
        {
            PdfGenerator.GeneratePdfReport(EmployeeCRUD.GetList());
            MessageBox.Show("Downloaded Successfully");
            this.Hide();
        }
    }
}
