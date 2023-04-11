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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            Form1 myform = new Form1();
            comboBox1.DisplayMember = "UserTypeName";
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource = myform.GetAppusertypetable();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text=="")
            {
                MessageBox.Show("хэрэглэгчийн төрлийг сонгоно уу");
            }
            else if(textBox1.Text.Trim()=="")
            {
                MessageBox.Show("хэрэглэгчийн нэрийг оруулна уу");
            }
            else if(textBox1.Text.Trim().Length>25)
            {
                MessageBox.Show("хэрэглэгчийн нэр 25 тэмдэгтээс уртгүй байна");
            }
            else if(textBox2.Text.Trim()=="")
            {
                MessageBox.Show("нууц үгийг оруулна уу");
            }
            else if(textBox2.Text.Trim().Length>25)
            {
                MessageBox.Show("нууц үг 25 тэмдэгтээс уртгүй байна");
            }
            else
            {
                //log hiine
                MyDataMethods myobject = new MyDataMethods();
                int UTypeID = Int32.Parse(comboBox1.SelectedValue.ToString());
                string UName = textBox1.Text.Trim();
                string Upass = textBox2.Text.Trim();
                string OK = myobject.CheckLogin(UTypeID, UName, Upass);
                if(OK=="YES")
                {
                    if(UTypeID==1)
                    {
                        //admin erhtei user gej uzne
                        AdminForm myform = new AdminForm();
                        myform.Show();
                        this.Hide();
                    }
                    else if(UTypeID==2)
                    {
                        UserForm myform = new UserForm();
                        myform.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("хэрэглэгчийн нэр болон нууц үг буруу байна");
                }
            }
        }
    }
}
