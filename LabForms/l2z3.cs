using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabForms
{
    public partial class l2z3 : Form
    {
        double x;
        double y;
        double dx;
        double e;
        public l2z3()
        {
            InitializeComponent();
            
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "x";
            dataGridView1.Columns[1].Name = "y";
            dataGridView1.Columns[2].Name = "n";
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            MessageBox.Show(Talor(0.01, 2, 0.005, 1).ToString());
        }

        private void l2z3_Load(object sender, EventArgs e)
        {

        }
        
        private double Talor(double x1, double x2, double dx, double e)
        {

            double ex;
            x = x1;
            int c = 1;
            while  (x <= x2)
            {
                ex = ((Math.Pow(-1, c)) * (Math.Pow((x - 1), c + 1))) / (c + 1);
                y += ex;
                dataGridView1.Rows.Add(1);
                dataGridView1.Rows[c - 1].Cells[0].Value = x;
                dataGridView1.Rows[c - 1].Cells[1].Value = ex;
                dataGridView1.Rows[c - 1].Cells[2].Value = c;
                c++;
                x += dx;

            }
            return y;
        }
    }
}
