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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }   

        private void Head_lbl_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.User_txt.Text.Equals("admin"))
            {
                if (this.Pass_txt.Text.Equals("admin"))
                {
                    Power_converter my_obj = new Power_converter();
                    my_obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Your password is wrong!");
                }
            }
            else
            {
                MessageBox.Show("Your username is wrong!");
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}