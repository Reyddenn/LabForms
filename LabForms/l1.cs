using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabForms
{

    public partial class l1 : Form
    {
        public string txt;
        string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\t.txt";
        public l1()
        {
            InitializeComponent();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            l1_About l1_A = new l1_About();
            l1_A.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            l1_Begin l1_B = new l1_Begin();
            l1_B.Show();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = File.OpenText(path))
            {
                MessageBox.Show(sr.ReadLine());
                sr.Close();
            }
   
        }
    }
}
