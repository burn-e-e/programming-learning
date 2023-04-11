using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace testapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("хэрэглэгчийн төрлийг оруул");
            }
            else if (textBox1.Text.Trim().Length > 25)
            {
                MessageBox.Show(" Төрлийн нэр 25 тэмдэгтээс уртгүй байна");
            }
            else if (richTextBox1.Text.Trim().Length > 50)
            {
                MessageBox.Show("Төрлийн нэр 50 тэмдэгтээс уртгүй байна");
            }
            else
            {

                string urdun = CheckUserTypeDavhatsal(textBox1.Text.Trim());
                if (urdun =="YES")
                {
                    MessageBox.Show("бичлэг давхацаж байна");
                }
                else
                {
                    //1. sql servert holbogdno
                    SqlConnection mycon = new SqlConnection();
                    mycon.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=true";
                    //2. insert statementiig zarlana
                    SqlCommand mycmd = new SqlCommand();
                    mycmd.Connection = mycon;
                    mycmd.CommandText = "INSERT AppUserType(UserTypeName,UserTypeInfo,CreatedDate,ModifiedDate)" +
                                        "VALUES(@UtypeName,@UtypeInfo,@Cdate,@Mdate)";
                    mycmd.Parameters.AddWithValue("@UtypeName", textBox1.Text.Trim());
                    mycmd.Parameters.AddWithValue("@UtypeInfo", richTextBox1.Text.Trim());
                    mycmd.Parameters.AddWithValue("@Cdate", DateTime.Now);
                    mycmd.Parameters.AddWithValue("@Mdate", DateTime.Now);
                    try
                    {
                        //3.sqlcommand class -ын commandText -д бичигдсэн INSERT statement
                        //-ийг ажиллуулна
                        //holboltiig neene
                        mycon.Open();
                        mycmd.ExecuteNonQuery();// ene method insert query -г ажиллуулна
                        MessageBox.Show("амжилттай");
                        DataTable apputypetable = GetAppusertypetable();
                        dataGridView1.DataSource = apputypetable;

                    }
                    catch (Exception aldaa)
                    {
                        MessageBox.Show("aldaa:" + aldaa.Message);
                    }
                    finally
                    {
                        //4. holboltiig haana
                        mycon.Close();
                        textBox1.Clear();
                        richTextBox1.Clear();
                    }
                }             
            }
        }

        string CheckUserTypeDavhatsal(string UserTypeName)
        {
            SqlConnection mycon = new SqlConnection();
            mycon.ConnectionString = @"Data Source=.\SQLExpress;Initial Catalog=UserDB;Integrated Security=true";
            SqlCommand mycmd = new SqlCommand();
            mycmd.Connection = mycon;
            mycmd.CommandText = "Select * from AppUserType WHERE UserTypeName=@UserTypeName";
            mycmd.Parameters.AddWithValue("@UserTypeName", UserTypeName);

            SqlDataAdapter myadapter = new SqlDataAdapter();
            myadapter.SelectCommand = mycmd;

            DataTable mytable = new DataTable();
            myadapter.Fill(mytable);
            if(mytable.Rows.Count==1)
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
        }

       public DataTable GetAppusertypetable()
        {
            SqlConnection mycon = new SqlConnection();
            mycon.ConnectionString = @"Data Source=.\SQLExpress;Initial Catalog=UserDB;Integrated Security=true";
            SqlCommand mycmd = new SqlCommand();
            mycmd.Connection = mycon;
            mycmd.CommandText = "Select * from AppUserType";
            //sqlDataAdapter sqlcommandiin commandtext deerh select query -eer uussen ur dung
            //unshaad sanah oid bairshuulna
            SqlDataAdapter myadapter = new SqlDataAdapter();
            myadapter.SelectCommand = mycmd;
            //sanah oid datatable ig uusgne
            DataTable appusertypetable = new DataTable();
            //DataAdapteriin unshsan bichlegiig datatable -d bairshuulba
            myadapter.Fill(appusertypetable);
            //bichlegeer duursen datatable -iig return eer butsaana
            return appusertypetable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable apputypetable = GetAppusertypetable();
            dataGridView1.DataSource = apputypetable;
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            richTextBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("хэрэглэгчийн төрлийг оруул");
            }
            else if (textBox1.Text.Trim().Length > 25)
            {
                MessageBox.Show(" Төрлийн нэр 25 тэмдэгтээс уртгүй байна");
            }
            else if (richTextBox1.Text.Trim().Length > 50)
            {
                MessageBox.Show("Төрлийн нэр 50 тэмдэгтээс уртгүй байна");
            }
            else
            {
                //1.bichlegiin davhatsal shalgana
                //2.bichleg update hiigdne
                string urdun = CheckUserTypeDavhatsal(textBox1.Text.Trim());
                if(urdun=="YES")
                {
                    //zuvhun nemel medeelliig update hiine
                    int id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    string UserTypeInfo = richTextBox1.Text.Trim();
                    DateTime ModifiedDate = DateTime.Now;

                    DataMethods mydata = new DataMethods();
                    try
                    {
                        mydata.UpdateAppUserType(id,UserTypeInfo,ModifiedDate);
                        MessageBox.Show("амжилттай шинэчлэгдлээ");
                        dataGridView1.DataSource = GetAppusertypetable();
                    }
                    catch(Exception aldaa)
                    {
                        MessageBox.Show("aldaa:"+ aldaa.Message);
                    }
                    finally
                    {
                        richTextBox1.Clear();
                        textBox1.Clear();
                        button3.Enabled = false;
                    }
                }
                else
                {
                    //usertypename bolon nemelt medeellig 2 uulang ne update hiine
                    int id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    string UserTypeInfo = richTextBox1.Text.Trim();
                    DateTime ModifiedDate = DateTime.Now;
                    string UserTypeName = textBox1.Text.Trim();

                    try
                    {
                        DataMethods mydata = new DataMethods();
                        mydata.UpdateAppUserType(id, UserTypeName, UserTypeInfo, ModifiedDate);
                        MessageBox.Show("амжилттай шинэчлэгдлээ");
                        dataGridView1.DataSource = GetAppusertypetable();
                        button3.Enabled = false;
                    }
                    catch(Exception aldaa)
                    {
                        System.Windows.Forms.MessageBox.Show("aldaa:"+aldaa.Message);
                    }
                    finally
                    {
                        textBox1.Clear();
                        richTextBox1.Clear();
                    }
                }

            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                CommonLibrary.MyDataMethods myobj = new CommonLibrary.MyDataMethods();
                myobj.DeleteUserType(id);
                MessageBox.Show("амжилттай устгагдлаа.Төрөлд хамааралтай бүх хэрэглэгч давхар устгагдана");

            }
            catch (Exception aldaa)
            {
                MessageBox.Show(aldaa.Message);
            }

        }
    }
}
