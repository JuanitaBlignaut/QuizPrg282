using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuizPrg282
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Juani\Desktop\2nd_Year\QuizPrg282\QuizPrg282\bin\Debug\Users.txt";
            if (File.Exists(path))
            {
            using (StreamReader reader = new StreamReader(path))
            {
                string txt;
                while((txt = reader.ReadLine())!= null)
                {
                    listBox1.Items.Add(txt);
                }
            }
            }
        }
    }
}
