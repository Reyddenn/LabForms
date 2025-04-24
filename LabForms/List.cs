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
            l1z1 form2 = new l1z1();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            l1z2 form1 = new l1z2();
            form1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            l1z3 l1z3 = new l1z3();
            l1z3.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            l2z3 l2z3 = new l2z3();
            l2z3.ShowDialog();
        }
    }
}
