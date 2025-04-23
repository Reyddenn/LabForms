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
    public partial class l1z3 : Form
    {
        double x = 0;
        double y = 0;
        double r = 0;
        public l1z3()
        {
            InitializeComponent();
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
        }

        private void l1z3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            x = 0; y = 0; r = 0;    
            try { x = double.Parse(textBox1.Text); }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); return; }

            try { y = double.Parse(textBox2.Text); }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); return; }

            try { r = double.Parse(textBox3.Text); }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); return; }

            circleCreator(x, y, r); 

            if (isinCircle(x, y, r))
            {
                label4.Text = $"Точка с координатами ({x},{y}) находится в закрашенной области";
                chart1.Series[1].Points.AddXY(x, y);
            }

            else
            {
                label4.Text = $"Точка с координатами ({x},{y}) НЕ находится в закрашенной области";
                chart1.Series[1].Points.AddXY(x, y);
            }

        }

        void circleCreator(double x, double y, double r)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            double step = r / 100;
            x = -r;
            while (x < r)
            {
                y = Math.Sqrt(-(x * x) + r * r);
                chart1.Series[0].Points.AddXY(x, y);
                x += step;
            }

            x = -r;
            while (x < r)
            {
                y = -(Math.Sqrt(-(x * x) + r * r));
                chart1.Series[0].Points.AddXY(x, y);
                x += step;
            }
            for (double a = 0; a <= 1; a += 0.01)
            {
                y = -r;
                x = 0;
                while (y < r)
                {
                    x = a * y;
                    if ((x * x + y * y) <= (r * r)) chart1.Series[0].Points.AddXY(x, y);
                    y += step;

                }
            }
        }

        bool isinCircle(double x, double y, double r)
        {
            bool inside = (x * x + y * y) <= (r * r);
            double angle = Math.Atan2(y, x) * (180.0 / Math.PI);
            if (angle < 0) angle += 360;
            bool inShadedArea = (angle >= 45 && angle <= 90) || (angle >= 225 && angle <= 270);
            if (inside && inShadedArea) return true;
            else return false;
        }
    }
}
