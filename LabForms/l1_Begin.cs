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
    public partial class l1_Begin : Form
    {


        string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\t.txt";


        public l1_Begin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FileStream fs = File.Create(path, 1024))
            {
                string message;
                if (radioButton1.Checked)  message = textBox1.Text.ToUpper();
                else message = textBox1.Text.ToLower();
                byte[] info = new UTF8Encoding(true).GetBytes(message);
                fs.Write(info, 0, info.Length);
                fs.Close();
                Close();
            }
        }

        private void l1_Begin_Load(object sender, EventArgs e)
        {

        }
    }
}
