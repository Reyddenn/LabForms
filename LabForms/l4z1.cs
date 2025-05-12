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
    public partial class l4z1 : Form
    {
        double x;
        double y;

        public l4z1()
        {
            InitializeComponent();
            
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "x";
            dataGridView1.Columns[1].Name = "y";
            dataGridView1.Columns[2].Name = "n";
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            double x1;
            double x2;
            double dx;
            double e1;

            try { x1 = double.Parse(textBox1.Text.Replace('.', ',')); }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); return; }

            try { x2 = double.Parse(textBox2.Text.Replace('.', ',')); }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); return; }

            try { dx = double.Parse(textBox3.Text.Replace('.', ',')); }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); return; }

            try { e1 = double.Parse(textBox4.Text.Replace('.', ',')); }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); return; }

            Talor(x1, x2 , dx , e1);
        }
    }
}
