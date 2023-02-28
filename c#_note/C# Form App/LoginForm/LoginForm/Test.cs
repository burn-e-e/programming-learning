using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open a  Text file";
            ofd.Filter = "Text Files (*.txt) | *.txt | All Files(*.*) | *.*";
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            StreamReader sr = new StreamReader(ofd.FileName);
            //txtEx.Text = sr.ReadToEnd();
            sr.Close();
        }
    }
}
