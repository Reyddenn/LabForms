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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LabForms
{

    public partial class l1 : Form
    {
        public string txt;
        string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\t.txt";
        public l1()
        {
            InitializeComponent();
            using (FileStream fs = File.Create(path, 1024))
            {
                byte[] info = new UTF8Encoding(true).GetBytes("");
                fs.Write(info, 0, info.Length);
                fs.Close();
            }
            
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

                string message = sr.ReadLine();
                if (message == null) MessageBox.Show("Сначала зайдите в Begin");
                else MessageBox.Show(message); 
                
                sr.Close();
            }
   
        }

        private void l1_Load(object sender, EventArgs e)
        {

        }
    }
}
