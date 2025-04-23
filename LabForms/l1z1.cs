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
    public partial class l1z1 : Form
    {
        public l1z1()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = textBox1.Text;
            int inp;
            int ost;
            try {
                inp = Int32.Parse(txt) % 100;
                ost = inp % 10;
                }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); return; }

            if (ost == 1 && !(inp > 10 && inp < 20)) label1.Text = "Рубль";
            else if (ost >= 2 && ost <= 4 && !(inp > 10 && inp < 20)) label1.Text = "Рубля";
            else label1.Text = "Рублей";

        }
    }
}
