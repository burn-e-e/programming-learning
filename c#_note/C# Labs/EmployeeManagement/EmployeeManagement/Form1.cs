using EmployeeManagement.Classes;

namespace EmployeeManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        contact c = new contact();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            c.FirstName = textBox1.Text;
            c.LastName = textBox2.Text;
            c.ContactNo = textBox3.Text;
            c.Address = textBox4.Text;
            c.Gender = cmbGender.Text;

            bool success = c.Insert(c);
            if (success == true)
            {
                MessageBox.Show("New Contact Successfully Inserted");
            }
            else
            {
                MessageBox.Show("Failed to add new content");
            }
        }
    }
}