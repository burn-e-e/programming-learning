using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Power_converter : Form
    {
        public Power_converter()
        {
            InitializeComponent();
        }
        private void convert_btn_Click(object sender, EventArgs e)
        {
            double i = double.Parse(amount_txt.Text); 
            if (fromcombo1.SelectedItem == "Watt" && tocombo2.SelectedItem=="Kilowatt")
            {
                double conver = i * 0.001;
                display_txt.Text = "Converted Amount: " + conver;
            }
            if (fromcombo1.SelectedItem == "Watt" && tocombo2.SelectedItem == "Megawatt")
            {
                double conver = i * 0.000001;
                display_txt.Text = "Converted Amount: " + conver;
            }
            if (fromcombo1.SelectedItem == "Watt" && tocombo2.SelectedItem == "Milliwatt")
            {
                double conver = i * 1000;
                display_txt.Text = "Converted Amount: " + conver;
            }
            if (fromcombo1.SelectedItem == "Watt" && tocombo2.SelectedItem == "Watt")
            {
                double conver = i;
                //display_txt.Text = "Converted Amount: " + conver;
                MessageBox.Show("Error Same convert", "Error");
            }
        }


        private void Power_converter_Load(object sender, EventArgs e)
        {

        }
    }
}
