using DGVPrinterHelper;
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
    public partial class RecordForm : Form
    {
        public MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        public RecordForm()
        {
            InitializeComponent();
            con.ConnectionString = @"server=localhost;database=ems_system;userid=root;password=;";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AttendanceForm af = new AttendanceForm();
            af.ShowDialog();
            
        }

        private void RecordForm_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                string query = "SELECT * FROM attendance_table";
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
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //this function attendance record print 
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "EMPLOYEE ATTENDANCE SYSTEM REPROT FORM";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Footer";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(dataGridView1);
        }
    }
}
