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
    public partial class Test : Form
    {
        List<string> a = new List<string>();
        public Test()
        {
            InitializeComponent();
            a.Add("abc");
            a.Add("Def");
            /* DataGridViewComboBoxColumn colbox = new DataGridViewComboBoxColumn();
             DataGridViewComboBoxColumn colbox1 = new DataGridViewComboBoxColumn();
             colbox.DataSource = a.ToList();
             colbox.DisplayIndex = 0;
             colbox1.DataSource = a.ToList();
             colbox1.DisplayIndex = 0;
             dataGridView1.Columns.Add(colbox);
             dataGridView1.Columns.Add(colbox1);*/
            ((DataGridViewComboBoxCell)dataGridView1.Rows[0].Cells[0]).DataSource = a;
        }
    }
}
