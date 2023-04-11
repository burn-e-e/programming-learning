using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonLibrary;

namespace testapp
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim()=="" || textBox2.Text.Trim()=="")
            {
                MessageBox.Show("toonuudiig oruul");
            }
            else
            {
                SecondClass myobject = new SecondClass();
                myobject.x= double.Parse(textBox1.Text.Trim());        
                double y = double.Parse(textBox2.Text.Trim());
                double urjver = SecondClass.Urjikh(myobject.x, y);
                button1.Text = urjver.ToString();
                textBox1.Clear();
                textBox2.Clear();
                    
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox3.Text.Trim()=="" || textBox4.Text.Trim()=="")
            {
                MessageBox.Show("toonuudiig oruul");
            }
            else
            {
                fourthclass myobject = new fourthclass();
                myobject.x = double.Parse(textBox3.Text.Trim());
                double y = double.Parse(textBox4.Text.Trim());
                double noogdvor = myobject.huvaah(myobject.x, y);
                button2.Text = noogdvor.ToString();
                textBox3.Clear();
                textBox4.Clear();
            }
        }
    }
}
