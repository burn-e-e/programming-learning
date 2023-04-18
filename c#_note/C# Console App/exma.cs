using System;
using System.Windows.Forms;

namespace CalculateWeight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the height and weight from the textboxes.
            double height = double.Parse(textBox1.Text);
            double weight = double.Parse(textBox2.Text);

            // Calculate the BMI.
            double bmi = weight / (height * height / 10000);

            // Determine the BMI category.
            string category;
            if (bmi < 18.5)
            {
                category = "Underweight";
            }
            else if (bmi < 24.9)
            {
                category = "Normal";
            }
            else if (bmi < 29.9)
            {
                category = "Overweight";
            }
            else if (bmi < 34.9)
            {
                category = "Obese";
            }
            else
            {
                category = "Morbidly Obese";
            }

            // Display the BMI and category in the labels.
            label1.Text = bmi.ToString();
            label2.Text = category;

            // If the BMI is normal, show a smile picture. Otherwise, show an angry picture.
            if (category == "Normal")
            {
                label3.Image = Properties.Resources.Smile;
            }
            else
            {
                label3.Image = Properties.Resources.Angry;
            }
        }
    }
}