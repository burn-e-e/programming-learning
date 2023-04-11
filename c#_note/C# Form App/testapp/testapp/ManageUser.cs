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
using CommonLibrary;
namespace testapp
{
    public partial class ManageUser : Form
    {
        public ManageUser()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text=="")
            {
                MessageBox.Show("хэрэглэгчийн төрлийг сонго");
            }
            else if(textBox1.Text.Trim()=="")
            {
                MessageBox.Show("хэрэглэгчийн нэр оруул");
            }
            else if(textBox2.Text.Trim()=="")
            {
                MessageBox.Show("нууц үгийг оруул");
            }
            else if(richTextBox1.Text.Trim().Length>100)
            {
                MessageBox.Show("100 тэмдэгтээс хэтрэхгүй урттай байна");
            }
            else if(pictureBox1.Image==null)
            {
                MessageBox.Show("зураг сонгоно уу");
            }
            else

            {
                //userdavhatsaliig end shalgana
                DataAccessLayer mylayer = new DataAccessLayer();
                int id = Int32.Parse(comboBox1.SelectedValue.ToString());
                string Username = textBox1.Text.Trim();
                DataTable mytable = mylayer.CheckUserTable(id, Username);
                if(mytable.Rows.Count==1)
                {
                    MessageBox.Show("бичлэг давхацаж байна");
                }
                else
                {
                    byte[] zurag = null;
                    //nemeh process yavagdna
                    //1. AppUser class aas object uusgene
                    AppUser shineuser = new AppUser();
                    shineuser.UserTypeID = Int32.Parse(comboBox1.SelectedValue.ToString());
                    shineuser.UserName = textBox1.Text.Trim();
                    shineuser.UserPassword = textBox2.Text.Trim();
                    shineuser.UserInfo = richTextBox1.Text.Trim();

                    FileStream FS = new FileStream(zuragzam, FileMode.Open, FileAccess.Read);
                    BinaryReader BR = new BinaryReader(FS);
                    zurag = BR.ReadBytes((int)FS.Length);
                    FS.Close();
                    BR.Close();
                    shineuser.UserImage = zurag;
                    shineuser.CDate = DateTime.Now;
                    shineuser.MDate = DateTime.Now;

                    //object belen bolson
                    //odoo deerh object iig nemeh method iig duudna;
                    DataMethods myobject = new DataMethods();
                    try
                    {
                        myobject.AddUser(shineuser);
                        MessageBox.Show("амжилттай нэмэгдлээ");
                    }
                    catch (Exception aldaa)
                    {
                        MessageBox.Show("aldaa:" + aldaa.Message);
                    }
                    finally
                    {
                        textBox1.Clear();
                        textBox2.Clear();
                        richTextBox1.Clear();
                        pictureBox1.Image = null;
                    }
                }
               
            }   

        }

        private void ManageUser_Load(object sender, EventArgs e)
        {
            Form1 myform = new Form1();
            comboBox1.DisplayMember = "UserTypeName";
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource = myform.GetAppusertypetable();

            DataMethods myobject = new DataMethods();
            dataGridView1.DataSource = myobject.GetAppUsers();
        }

        string zuragzam;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                zuragzam = openFileDialog1.FileName;
            }
        }
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            string usertypename = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            comboBox1.Text = usertypename;
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            richTextBox1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            byte[] zurag = new byte[1024];
                      
        }
    }
}
