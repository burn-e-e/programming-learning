using System.Security.Policy;
using static Lab_3.Student_Form;

namespace Lab_3
{
    public partial class Student_Form : Form
    {
        public Student_Form()
        {
            InitializeComponent();
        }

        public class Suragch
        {
            public String surname = "";
            public String firstname = "";
            public DateTime birthday = new DateTime();
            public String code = "";
            public String email = "";
            public String phone = "";
            public int calcAge(DateTime tursun)
            {
                int nas;
                DateTime today = DateTime.Now;
                return nas = today.Year - tursun.Year;
            }
        }
        String gender = "";
        public void publish_btn_Click(object sender, EventArgs e)
        {

            Suragch suragch1 = new Suragch();
            suragch1.surname = surName_txtbox.Text;
            suragch1.firstname = firstName_txtbox.Text;
            //suragch1.birthday = dateTimePicker1.Value;

            suragch1.calcAge(dateTimePicker1.Value);

            //suragch1.tursunognoo = age_txtbox.Text;
            suragch1.code = studentCode_txtbox.Text;
            suragch1.email = mail_txtbox.Text;
            suragch1.phone = phoneNumber_txtbox.Text;
            age_show.Text = suragch1.calcAge(dateTimePicker1.Value).ToString();
            name_show.Text = suragch1.surname + " " + suragch1.firstname;
            codeShow.Text = suragch1.code;
            showEmail.Text = suragch1.email;
            phoneShow.Text = suragch1.phone;
            /*
            if (Int32.Parse(suragch1.age) < 18)
            {
                DialogResult res = MessageBox.Show("Таны нас 18 аас доош байна.", "Анхааруулга", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (suragch1.age == null)
            {
                DialogResult res = MessageBox.Show("Та зарим мэдээллээ оруулаагүй байна.", "Анхааруулга", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                age_show.Text = suragch1.age + " настай";
            }
            */
            if (male_radiobtn.Checked)
            {
                gender = "Эрэгтэй";
                genderShow.Text = gender;
            }
            else
            {
                gender = "Эмэгтэй";
                genderShow.Text = gender;
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void age_show_Click(object sender, EventArgs e)
        {

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            surName_txtbox.Clear();
            firstName_txtbox.Clear();
            //age_txtbox.Clear();
            studentCode_txtbox.Clear();
            mail_txtbox.Clear();
            phoneNumber_txtbox.Clear();
            male_radiobtn.Checked = false;
        }
    }
}