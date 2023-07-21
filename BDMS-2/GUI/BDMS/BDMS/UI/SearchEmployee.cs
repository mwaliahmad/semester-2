using BDMS.BL;
using BDMS.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDMS.UI
{
    public partial class SearchEmployee : Form
    {
        public SearchEmployee()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            List<Employee> employee = new List<Employee>();
            Employee E = EmployeeCRUD.SearchEmployee(txt_search.Text);
            if (E != null)
                employee.Add(E);
            databind(employee);
        }

        private void databind(List<Employee> employee)
        {
            if (employee == null)
            {
                MessageBox.Show("Not found");
            }
            else
            {
                GV.DataSource = null;
                foreach (Employee person in employee)
                {
                    GV.DataSource = employee.Select(a => new { a.Name1, a.Age1, a.Contact1, a.Cnic1, a.Username, a.Password }).ToList();
                }
                GV.Columns[0].HeaderText = "Name";
                GV.Columns[1].HeaderText = "Age";
                GV.Columns[2].HeaderText = "Contact";
                GV.Columns[3].HeaderText = "CNIC";
                GV.Refresh();
            }
        }

        private void txt_search_Click(object sender, EventArgs e)
        {
            txt_search.Clear();
        }
    }
}
