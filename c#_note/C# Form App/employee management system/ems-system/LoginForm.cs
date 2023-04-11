using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ems_system
{
    public partial class LoginForm : Form
    {
        public static string username;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void singin_btn_Click(object sender, EventArgs e)
        {
            string myconnectionString = @"server=localhost;database=ems_system;userid=root;password=;";
            MySqlConnection con = null;
            MySqlCommand cmd;
            MySqlDataReader dr;
            try
            {
                con = new MySqlConnection(myconnectionString);
                con.Open();
                cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM login_tb  WHERE Username='"+textBox1.Text+"'  AND Password='"+textBox2.Text+"' ";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Sucess");
                    this.Hide();
                    username = textBox1.Text;
                    HomeForm hf = new HomeForm();
                    hf.ShowDialog();
                }
                else
                {
                    MessageBox.Show("!Please EnterCorrect Username and password");
                }

            }
            finally
            {
                if(con!=null)
                {
                    con.Close();
                }
            }
        }
    }
}
