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
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            l2z1 form2 = new l2z1();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            l2z2 form1 = new l2z2();
            form1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            l2z3 l1z3 = new l2z3();
            l1z3.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            l3z3 l2z3 = new l3z3();
            l2z3.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            l1 l1 = new l1();
            l1.ShowDialog();
        }
    }
}
