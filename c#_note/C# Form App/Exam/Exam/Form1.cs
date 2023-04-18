using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }  
        private void button1_Click(object sender, EventArgs e)
        {
            float height = float.Parse(textBox1.Text);
            float weight = float.Parse(textBox2.Text);
            float bmi = weight / (height * height / 10000);
            label5.Text = bmi.ToString();
            string status;
            if (bmi < 18.5)
            {
                status = "Туранхай";
            }
            else if (bmi < 24.9)
            {
                status = "Хэвийн";
            }
            else if (bmi < 29.9)    
            {
                status = "Махлаг";
            }
            else if (bmi < 34.9)
            {
                status = "Тарган";
            }
            else
            {
                status = "Хэт тарган";
            }
            label6.Text = status;
            if (status == "Хэвийн")
            {
                label7.Image = Properties.Resources.smile;
            }
            else
            {
                label7.Image = Properties.Resources.angry;
            }
        }
    }
}
