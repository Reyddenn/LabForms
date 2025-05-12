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
    public partial class l2z2 : Form
    {
        public l2z2()
        {

            InitializeComponent();
            int a = -7;
            int b = 3;
            double h = 0.01;

            double x = a;
            double y = 0;

            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

            while (x <= b)
            {
                chart1.Series[0].Points.AddXY(x, findybyx(x));
                x += h;
            }

            // L3

            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "x";
            dataGridView1.Columns[1].Name = "y";
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[1].Points.Clear();
            double numb = 0;
            try { numb = double.Parse(textBox1.Text.Replace('.', ',')); }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); return; }
            chart1.Series[1].Points.AddXY(numb, findybyx(numb));
            textBox2.Text = findybyx(numb).ToString();

        }

        private double findybyx(double x)
        {
            double r1 = 1;
            double r2 = 2.5;  
            double y = 0;
            if (x >= -7 && x < -6 && !(x >= -2 - r2 && x < -2 + r2) && !(x >= (1 - r1) && x < (1 + r1))) y = 1;
            else if (x >= -6 && x <= -4 && !(x >= -2 - r2 && x < -2 + r2) && !(x >= (1 - r1) && x < (1 + r1))) y = -0.5 * x - 2;
            else if (x >= -2 - r2 && x < -2 + r2 && !(x >= (1 - r1) && x < (1 + r1))) y = Math.Sqrt(r2*r2 - (x + 2) * (x + 2));         //Math.Sqrt(-4 * x - x * x);
            else if (x >= (1 - r1) && x < (1 + r1)) y = -Math.Sqrt(r1*r1 - (x - 1) * (x - 1));    //-(Math.Sqrt(2 * x - x * x));
            else if (x >= 2 && x <= 3 &&    !(x >= -2 - r2 && x < -2 + r2)  && !(x >= (1 - r1) && x < (1 + r1))) y = -x + 2;
            else if (x < -7 && x > 3) y = 0; 
            return y;
            }

        private void l1z2_Load(object sender, EventArgs e)
        {

        }

        private void create3rddia(double x1, double x2, double dx)
        {
            chart1.Series[2].Points.Clear();
            dataGridView1.Rows.Clear();
            double y = 0;
            double x = x1;

            for (int i = 0; x < x2; i++)
            {
                y = findybyx(x);
                dataGridView1.Rows.Add(1);
                dataGridView1.Rows[i].Cells[0].Value = x;
                dataGridView1.Rows[i].Cells[1].Value = y;
                chart1.Series[2].Points.AddXY(x, y);
                x += dx;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x1; double x2; double dx;
            try { x1 = double.Parse(textBox4.Text.Replace('.', ',')); }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); return; }
            try { x2 = double.Parse(textBox3.Text.Replace('.', ',')); }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); return; }
            try { dx = double.Parse(textBox5.Text.Replace('.', ',')); }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); return; }
            create3rddia(x1, x2, dx);
        }
    }
}
