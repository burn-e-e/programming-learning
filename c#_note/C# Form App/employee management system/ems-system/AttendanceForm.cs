using AForge.Video.DirectShow;
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
using AForge.Video;
using ZXing;

namespace ems_system
{
    public partial class AttendanceForm : Form
    {
        public MySqlConnection con = new MySqlConnection();
        MySqlCommand coman = new MySqlCommand();
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        public AttendanceForm()
        {
            InitializeComponent();
            con.ConnectionString = @"server=localhost;database=ems_system;userid=root;password=;";
        }

        private void AttendanceForm_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
                comboBox1.Items.Add(Device.Name);
            comboBox1.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();

            //Date and Time
            label21.Text = DateTime.Now.ToLongDateString();
            label22.Text = DateTime.Now.ToLongTimeString();

        }

        private void opencamera_btn_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Image)eventArgs.Frame.Clone();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void AttendanceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning == true)
                FinalFrame.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*The function show employee data from database*/
            BarcodeReader reader = new BarcodeReader();
            Result result = reader.Decode((Bitmap)pictureBox1.Image);
            try
            {
                string decode = result.ToString().Trim();
                text_id.Text = decode;
                if (decode !=null)
                {
                    con.Open();
                    coman.Connection = con;
                    coman.CommandText = "SELECT * FROM employee_tb WHERE ID LIKE '%"+text_id.Text+"%' ";
                    MySqlDataReader dr = coman.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        text_name.Text = dr["Name"].ToString();
                        text_address.Text= dr["Address"].ToString();
                        text_dept.Text = dr["Department"].ToString();
                        text_phone.Text = dr["Phone"].ToString();
                        text_edu.Text = dr["Edu"].ToString();
                        text_gender.Text = dr["Gender"].ToString();
                        text_dob.Text = dr["DateOfBirth"].ToString();
                    }
                    con.Close();
                    timer2.Start();
                }
            }
            catch(Exception ex)
            {
                
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            /*The function  employee attendance  to database*/
            try
            {
                con.Open();
                MySqlCommand coman = new MySqlCommand();
                coman.Connection = con;
                //coman.CommandText = "INSERT INTO att_tbl(ID,Name,Address,Department,Phone,Edu,Gender,DateOfBirth,IN_Time,Out_Time,Status) Values ('" + text_id.Text + "','" + text_name.Text + "','" + text_address.Text + "','" + text_dept.Text + "','" + text_phone.Text + "','" + text_edu.Text + "','" + text_gender.Text + "','" + text_dob.Text + "','" + label22.Text + "',null,'1')";
                coman.CommandText = "select * from attendance_table where  ID Like'%" + text_id.Text + "%' and Status=1";
                //coman.ExecuteNonQuery();
                //con.Close();
                //MessageBox.Show("Data Save Successfull !");
                int record = Convert.ToInt32(coman.ExecuteScalar());
                if (record <= 0)
                {
                    coman.CommandText = "INSERT INTO attendance_table(ID,Name,Address,Department,Phone,Edu,Gender,DateOfBirth,IN_Time,Out_Time,Status) Values ('" + text_id.Text + "','" + text_name.Text + "','" + text_address.Text + "','" + text_dept.Text + "','" + text_phone.Text + "','" + text_edu.Text + "','" + text_gender.Text + "','" + text_dob.Text + "','" + label22.Text + "',null,'1')";
                    coman.ExecuteNonQuery();
                    MessageBox.Show("Employee IN-Time Successfull !");
                }
                else
                {
                    coman.CommandText = "UPDATE attendance_table SET Out_Time='" + label22.Text + "',Status=0 WHERE ID like '%" + text_id.Text + "%' and Status=1";
                    coman.ExecuteNonQuery();
                    MessageBox.Show("Employee Out-Time Successfull !");
                }
            }
            catch (Exception ex)
            {

            }

        }

              

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {            
            this.Hide();
            RecordForm rf = new RecordForm();
            rf.ShowDialog();
            
        }
    }
}
