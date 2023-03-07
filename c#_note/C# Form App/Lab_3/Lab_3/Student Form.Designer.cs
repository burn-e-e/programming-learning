namespace Lab_3
{
    partial class Student_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Form));
            Title = new Label();
            panel1 = new Panel();
            publish_btn = new Button();
            clear_btn = new Button();
            female_radiobtn = new RadioButton();
            male_radiobtn = new RadioButton();
            phoneNumber_txtbox = new TextBox();
            mail_txtbox = new TextBox();
            studentCode_txtbox = new TextBox();
            firstName_txtbox = new TextBox();
            surName_txtbox = new TextBox();
            phoneNumber_txt = new Label();
            mail_txt = new Label();
            studentCode_txt = new Label();
            Age_txt = new Label();
            Gender_txt = new Label();
            Firstname_txt = new Label();
            Surname_txt = new Label();
            name_show = new Label();
            genderShow = new Label();
            panel2 = new Panel();
            phoneShow = new Label();
            showEmail = new Label();
            codeShow = new Label();
            age_show = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Arial", 13F, FontStyle.Regular, GraphicsUnit.Point);
            Title.Location = new Point(112, 16);
            Title.Name = "Title";
            Title.Size = new Size(85, 25);
            Title.TabIndex = 0;
            Title.Text = "Student";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(publish_btn);
            panel1.Controls.Add(clear_btn);
            panel1.Controls.Add(female_radiobtn);
            panel1.Controls.Add(male_radiobtn);
            panel1.Controls.Add(phoneNumber_txtbox);
            panel1.Controls.Add(mail_txtbox);
            panel1.Controls.Add(studentCode_txtbox);
            panel1.Controls.Add(firstName_txtbox);
            panel1.Controls.Add(surName_txtbox);
            panel1.Controls.Add(phoneNumber_txt);
            panel1.Controls.Add(mail_txt);
            panel1.Controls.Add(studentCode_txt);
            panel1.Controls.Add(Age_txt);
            panel1.Controls.Add(Gender_txt);
            panel1.Controls.Add(Firstname_txt);
            panel1.Controls.Add(Surname_txt);
            panel1.Controls.Add(Title);
            panel1.Location = new Point(11, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 427);
            panel1.TabIndex = 1;
            // 
            // publish_btn
            // 
            publish_btn.Location = new Point(159, 363);
            publish_btn.Name = "publish_btn";
            publish_btn.Size = new Size(94, 29);
            publish_btn.TabIndex = 9;
            publish_btn.Text = "Publish";
            publish_btn.UseVisualStyleBackColor = true;
            publish_btn.Click += publish_btn_Click;
            // 
            // clear_btn
            // 
            clear_btn.BackColor = Color.Gainsboro;
            clear_btn.Location = new Point(46, 363);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(94, 29);
            clear_btn.TabIndex = 9;
            clear_btn.Text = "Clear";
            clear_btn.UseVisualStyleBackColor = false;
            clear_btn.Click += clear_btn_Click;
            // 
            // female_radiobtn
            // 
            female_radiobtn.AutoSize = true;
            female_radiobtn.Location = new Point(159, 143);
            female_radiobtn.Name = "female_radiobtn";
            female_radiobtn.Size = new Size(78, 24);
            female_radiobtn.TabIndex = 8;
            female_radiobtn.TabStop = true;
            female_radiobtn.Text = "Female";
            female_radiobtn.UseVisualStyleBackColor = true;
            // 
            // male_radiobtn
            // 
            male_radiobtn.AutoSize = true;
            male_radiobtn.Location = new Point(90, 143);
            male_radiobtn.Name = "male_radiobtn";
            male_radiobtn.Size = new Size(63, 24);
            male_radiobtn.TabIndex = 7;
            male_radiobtn.TabStop = true;
            male_radiobtn.Text = "Male";
            male_radiobtn.UseVisualStyleBackColor = true;
            // 
            // phoneNumber_txtbox
            // 
            phoneNumber_txtbox.Location = new Point(144, 291);
            phoneNumber_txtbox.Name = "phoneNumber_txtbox";
            phoneNumber_txtbox.Size = new Size(127, 27);
            phoneNumber_txtbox.TabIndex = 6;
            // 
            // mail_txtbox
            // 
            mail_txtbox.Location = new Point(90, 255);
            mail_txtbox.Name = "mail_txtbox";
            mail_txtbox.Size = new Size(181, 27);
            mail_txtbox.TabIndex = 6;
            // 
            // studentCode_txtbox
            // 
            studentCode_txtbox.Location = new Point(146, 217);
            studentCode_txtbox.Name = "studentCode_txtbox";
            studentCode_txtbox.Size = new Size(125, 27);
            studentCode_txtbox.TabIndex = 6;
            // 
            // firstName_txtbox
            // 
            firstName_txtbox.Location = new Point(78, 104);
            firstName_txtbox.Name = "firstName_txtbox";
            firstName_txtbox.Size = new Size(159, 27);
            firstName_txtbox.TabIndex = 6;
            // 
            // surName_txtbox
            // 
            surName_txtbox.Location = new Point(78, 72);
            surName_txtbox.Name = "surName_txtbox";
            surName_txtbox.Size = new Size(159, 27);
            surName_txtbox.TabIndex = 6;
            // 
            // phoneNumber_txt
            // 
            phoneNumber_txt.AutoSize = true;
            phoneNumber_txt.Location = new Point(26, 293);
            phoneNumber_txt.Name = "phoneNumber_txt";
            phoneNumber_txt.Size = new Size(112, 20);
            phoneNumber_txt.TabIndex = 5;
            phoneNumber_txt.Text = "Утасны дугаар:";
            // 
            // mail_txt
            // 
            mail_txt.AutoSize = true;
            mail_txt.Location = new Point(26, 259);
            mail_txt.Name = "mail_txt";
            mail_txt.Size = new Size(58, 20);
            mail_txt.TabIndex = 5;
            mail_txt.Text = "Имэйл:";
            // 
            // studentCode_txt
            // 
            studentCode_txt.AutoSize = true;
            studentCode_txt.Location = new Point(26, 220);
            studentCode_txt.Name = "studentCode_txt";
            studentCode_txt.Size = new Size(114, 20);
            studentCode_txt.TabIndex = 5;
            studentCode_txt.Text = "Сурагчийн код:";
            // 
            // Age_txt
            // 
            Age_txt.AutoSize = true;
            Age_txt.Location = new Point(26, 181);
            Age_txt.Name = "Age_txt";
            Age_txt.Size = new Size(106, 20);
            Age_txt.TabIndex = 4;
            Age_txt.Text = " Төрсөн өдөр:";
            // 
            // Gender_txt
            // 
            Gender_txt.AutoSize = true;
            Gender_txt.Location = new Point(27, 145);
            Gender_txt.Name = "Gender_txt";
            Gender_txt.Size = new Size(44, 20);
            Gender_txt.TabIndex = 3;
            Gender_txt.Text = "Хүйс:";
            // 
            // Firstname_txt
            // 
            Firstname_txt.AutoSize = true;
            Firstname_txt.Location = new Point(33, 107);
            Firstname_txt.Name = "Firstname_txt";
            Firstname_txt.Size = new Size(39, 20);
            Firstname_txt.TabIndex = 2;
            Firstname_txt.Text = "Нэр:";
            // 
            // Surname_txt
            // 
            Surname_txt.AutoSize = true;
            Surname_txt.Location = new Point(26, 75);
            Surname_txt.Name = "Surname_txt";
            Surname_txt.Size = new Size(46, 20);
            Surname_txt.TabIndex = 1;
            Surname_txt.Text = "Овог:";
            // 
            // name_show
            // 
            name_show.AutoSize = true;
            name_show.Location = new Point(140, 74);
            name_show.Name = "name_show";
            name_show.Size = new Size(83, 20);
            name_show.TabIndex = 2;
            name_show.Text = "Nameshow";
            // 
            // genderShow
            // 
            genderShow.AutoSize = true;
            genderShow.Location = new Point(140, 142);
            genderShow.Name = "genderShow";
            genderShow.Size = new Size(91, 20);
            genderShow.TabIndex = 3;
            genderShow.Text = "Gendershow";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(phoneShow);
            panel2.Controls.Add(showEmail);
            panel2.Controls.Add(codeShow);
            panel2.Controls.Add(age_show);
            panel2.Controls.Add(name_show);
            panel2.Controls.Add(genderShow);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(431, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(340, 424);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // phoneShow
            // 
            phoneShow.AutoSize = true;
            phoneShow.Location = new Point(141, 254);
            phoneShow.Name = "phoneShow";
            phoneShow.Size = new Size(86, 20);
            phoneShow.TabIndex = 8;
            phoneShow.Text = "PhoneShow";
            // 
            // showEmail
            // 
            showEmail.AutoSize = true;
            showEmail.Location = new Point(141, 219);
            showEmail.Name = "showEmail";
            showEmail.Size = new Size(82, 20);
            showEmail.TabIndex = 7;
            showEmail.Text = "EmailShow";
            // 
            // codeShow
            // 
            codeShow.AutoSize = true;
            codeShow.Location = new Point(140, 181);
            codeShow.Name = "codeShow";
            codeShow.Size = new Size(80, 20);
            codeShow.TabIndex = 6;
            codeShow.Text = "ShowCode";
            // 
            // age_show
            // 
            age_show.AutoSize = true;
            age_show.Location = new Point(140, 106);
            age_show.Name = "age_show";
            age_show.Size = new Size(70, 20);
            age_show.TabIndex = 4;
            age_show.Text = "Ageshow";
            age_show.Click += age_show_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 74);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 1;
            label1.Text = "Овог Нэр:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 106);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 4;
            label2.Text = " Нас:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 142);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 3;
            label3.Text = "Хүйс:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 180);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 5;
            label4.Text = "Сурагчийн код:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 219);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 5;
            label5.Text = "Имэйл:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 254);
            label6.Name = "label6";
            label6.Size = new Size(112, 20);
            label6.TabIndex = 5;
            label6.Text = "Утасны дугаар:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(138, 181);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // Student_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Student_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label Title;
        private Panel panel1;
        private Label Surname_txt;
        private Label Firstname_txt;
        private RadioButton female_radiobtn;
        private RadioButton male_radiobtn;
        private TextBox firstName_txtbox;
        private TextBox surName_txtbox;
        private Label phoneNumber_txt;
        private Label mail_txt;
        private Label studentCode_txt;
        private Label Age_txt;
        private Label Gender_txt;
        private Button publish_btn;
        private Button clear_btn;
        private TextBox phoneNumber_txtbox;
        private TextBox mail_txtbox;
        private TextBox studentCode_txtbox;
        private Label name_show;
        private Label genderShow;
        private Panel panel2;
        private Label age_show;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label codeShow;
        private Label label4;
        private Label showEmail;
        private Label label5;
        private Label phoneShow;
        private Label label6;
        private DateTimePicker dateTimePicker1;
    }
}