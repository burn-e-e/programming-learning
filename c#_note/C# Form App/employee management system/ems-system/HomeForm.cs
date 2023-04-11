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
    public partial class HomeForm : Form
    {
        private MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        public HomeForm()
        {
            InitializeComponent();
            con.ConnectionString = @"server=localhost;database=ems_system;userid=root;password=;";
            slide_panel.Height = button1.Height;
            admin_panel.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            slide_panel.Height = button1.Height;
            slide_panel.Top = button1.Top;
            admin_panel.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            slide_panel.Height = button2.Height;
            slide_panel.Top = button2.Top;
            Employee_panel.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            slide_panel.Height = button3.Height;
            slide_panel.Top = button3.Top;
            this.Hide();
            AttendanceForm atf = new AttendanceForm();
            atf.ShowDialog();
            atf = null;
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            slide_panel.Height = button4.Height;
            slide_panel.Top = button4.Top;
            salary_panel.BringToFront();
            //Show attendance data in datagridview 
            try
            {
                con.Open();
                cmd.Connection = con;
                string query = "SELECT * FROM attendance_table";
                cmd.CommandText = query;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            //Total employee
            label1.Text = LoginForm.username;
            string query_total = "SELECT COUNT(*) FROM employee_tb";
            con.Open();
            cmd = new MySqlCommand(query_total, con);
            Int32 fuc = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            con.Close();
            label8.Text = "Total Number=" + fuc.ToString();

            //HR employee
            
            string query_hr = "SELECT COUNT(*) FROM employee_tb WHERE Department='"+label3.Text+"' ";
            con.Open();
            cmd = new MySqlCommand(query_hr, con);
            Int32 fuc1 = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            con.Close();
            label3.Text = "HR Number=" + fuc1.ToString();

            //IT employee
            
            string query_IT = "SELECT COUNT(*) FROM employee_tb WHERE Department='" + label4.Text + "' ";
            con.Open();
            cmd = new MySqlCommand(query_IT, con);
            Int32 fuc2 = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            con.Close();
            label4.Text = "IT Number=" + fuc2.ToString();

            //Accountant employee

            string query_AC = "SELECT COUNT(*) FROM employee_tb WHERE Department='" + label5.Text + "' ";
            con.Open();
            cmd = new MySqlCommand(query_AC, con);
            Int32 fuc3 = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            con.Close();
            label5.Text = "Accountant Number=" + fuc3.ToString();

            //Security employee

            string query_SC = "SELECT COUNT(*) FROM employee_tb WHERE Department='" + label6.Text + "' ";
            con.Open();
            cmd = new MySqlCommand(query_SC, con);
            Int32 fuc4 = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            con.Close();
            label6.Text = "Security Number=" + fuc4.ToString();

            //Cleaner employee

            string query_CN = "SELECT COUNT(*) FROM employee_tb WHERE Department='" + label7.Text + "' ";
            con.Open();
            cmd = new MySqlCommand(query_CN, con);
            Int32 fuc5 = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            con.Close();
            label7.Text = "Cleaner Number=" + fuc5.ToString();

            /*The function show data on employee_tb datagridview from database*/
            try
            {
                con.Open();
                cmd.Connection = con;
                string query = "SELECT * FROM employee_tb";
                cmd.CommandText = query;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            timer1.Start();

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            //For qrcode generator
            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
            var MyData = QG.CreateQrCode(idtext.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(MyData);
            pictureBox7.Image = code.GetGraphic(50);

            //Data insert into database
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO employee_tb(ID,Name,Address,Department,Phone,Edu,DateOfBirth,Gender) Values ('"+idtext.Text+"','"+nametext.Text+"','"+addresstext.Text+"','"+ dptext.Text+ "','"+ptext.Text+"','"+edutext.Text+"','"+dateTimePicker1.Text+"','"+gtext.Text+"')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Save Data");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            //For Save generate qrcode image in folder
            string initialDIR = @"C:\Users\acer\Desktop\QRfiles";
            var dialog = new SaveFileDialog();
            dialog.InitialDirectory = initialDIR;
            dialog.Filter = "PNG|*.png|JPEG|*jpeg|BMP|*.bmp|GIF|*.gif";
            if(dialog.ShowDialog()==DialogResult.OK)
            {
                pictureBox7.Image.Save(dialog.FileName);
            }
            idtext.Text = "";
            nametext.Text = "";
            addresstext.Text = "";
            dptext.Text = "";
            edutext.Text = "";
            ptext.Text = "";
            gtext.Text = "";
            dateTimePicker1.Text = "";
            pictureBox7.Image = null;
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE employee_tb SET ID ='" + idtext.Text + "',Name='" + nametext.Text + "',Address='" + addresstext.Text + "',Department='" + dptext.Text + "',Phone='" + ptext.Text + "',Edu='" + edutext.Text + "',DateOfBirth='" + dateTimePicker1.Text + "',Gender='" + gtext.Text + "'  WHERE ID = '" + idtext.Text + "' ";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Update Data");
                idtext.Text = "";
                nametext.Text = "";
                addresstext.Text = "";
                dptext.Text = "";
                edutext.Text = "";
                ptext.Text = "";
                gtext.Text = "";
                dateTimePicker1.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM employee_tb  WHERE ID = '" + idtext.Text + "'  ";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Delete Data");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            idtext.Text = "";
            nametext.Text = "";
            addresstext.Text = "";
            dptext.Text = "";
            edutext.Text = "";
            ptext.Text = "";
            gtext.Text = "";
            dateTimePicker1.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            refresh();
            timer1.Start();
        }

        private void refresh()
        {
            con.Open();
            cmd.Connection = con;
            string query = "SELECT * FROM employee_tb";
            cmd.CommandText = query;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                idtext.Text = row.Cells[0].Value.ToString();
                nametext.Text = row.Cells[1].Value.ToString();
                addresstext.Text = row.Cells[2].Value.ToString();
                dptext.Text = row.Cells[3].Value.ToString();
                edutext.Text = row.Cells[5].Value.ToString();
                ptext.Text = row.Cells[4].Value.ToString();
                gtext.Text = row.Cells[7].Value.ToString();
                dateTimePicker1.Text = row.Cells[6].Value.ToString();

            }
               
            
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            //this function search employee data from database
            con.Open();
            MySqlCommand coman = new MySqlCommand();
            coman.Connection = con;
            coman.CommandText = "SELECT * FROM attendance_table WHERE ID LIKE'%" + textBox1.Text + "%' ";
            MySqlDataReader dr = coman.ExecuteReader();
            dr.Read();
            if(dr.HasRows)
            {
                textBox2.Text = dr["Name"].ToString();
                textBox3.Text = dr["Department"].ToString();
            }
            con.Close();
            //this function count employee work days
            richTextBox1.Text = "";

            string query = "Select Count(*) From attendance_table WHERE Name= '" + textBox2.Text + "'";
            con.Open();
            cmd = new MySqlCommand(query, con);
            Int32 fuc3 = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            con.Close();
            textBox5.Text = fuc3.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if(textBox5.Text.Length > 0)
            {
                textBox6.Text = (Convert.ToInt16(textBox4.Text) * Convert.ToInt16(textBox5.Text)).ToString();
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //This function show employee detail data in richbox
            richTextBox1.Text = "Salay details " + "\n" + "\n" + "Employee ID  =" + textBox1.Text + "\n" + "Name               = " + textBox2.Text + "\n" + "Department     = " + textBox3.Text + "\n" + "Daily Salary    = " + textBox4.Text + "\n" + "Work Days      = " + textBox5.Text + "\n" + "Total Salary     = " + textBox6.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //this function define employee salary
            if (textBox3.Text =="IT")
            {
                textBox4.Text = "1200";
            }
            else if(textBox3.Text == "HR")
            {
                textBox4.Text = "1000";
            }
            else if (textBox3.Text == "Accountant")
            {
                textBox4.Text = "1100";
            }
            else if (textBox3.Text == "Security")
            {
                textBox4.Text = "500";
            }
            else if (textBox3.Text == "Cleaner")
            {
                textBox4.Text = "400";
            }
            else
            {
                textBox4.Text = "0";
            }
        }

        
    }
}
