using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            int age = int.Parse(textBox5.Text);        
            String studentCode = textBox2.Text;        
            String gender = textBox4.Text;
            double studentGrade = double.Parse(textBox3.Text);
            Student student1 = new Student();
            student1.setName(name);
            student1.setAge(age);
            student1.setStudentCode(studentCode);
            student1.setGender(gender);
            student1.setStudentGrade(studentGrade);
            nameLabel.Text = student1.getName();
            ageLabel.Text = student1.getAge().ToString();            
            studentCodeLabel.Text = student1.getStudentCode();
            genderLabel.Text = student1.getGender();
            studentGradeLabel.Text = student1.getStudentGrade().ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student student1 = new Student();
            student1.setName(nameLabel.Text);
            student1.setAge(int.Parse(ageLabel.Text));
            student1.setStudentCode(studentCodeLabel.Text);
            student1.setGender(genderLabel.Text);
            student1.setStudentGrade(double.Parse(studentGradeLabel.Text));
            addGrade(student1);
        }
        private void addGrade(Student student1)
        {
            double currentGrade = student1.getStudentGrade();
            currentGrade+= 1.0;
            student1.setStudentGrade(currentGrade);
            studentGradeLabel.Text = student1.getStudentGrade().ToString();
        }
    }
    public class Student
    {
        private String name;
        private int age;
        private String gender;
        private String studentCode;
        private double studentGrade;
        public void setName(String name)
        {
            this.name = name;
        }
        public String getName()
        {
            return name;
        }   
        public void setAge(int age)
        {
            this.age = age;
        }
        public int getAge()
        {
            return age;
        }
        public void setGender(String g)
        {
            this.gender = g;
        }
        public String getGender()
        {
            return gender;
        }
        public void setStudentCode(String studentCode)
        {
            this.studentCode = studentCode;
        }
        public String getStudentCode()
        {
            return studentCode;
        }
        public void setStudentGrade(double grade)
        {
            studentGrade = grade;
        }
        public double getStudentGrade()
        {
            return studentGrade;
        }
    }
}
