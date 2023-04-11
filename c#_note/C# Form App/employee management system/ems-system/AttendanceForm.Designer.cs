namespace ems_system
{
    partial class AttendanceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.text_dob = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.text_gender = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.text_edu = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.text_phone = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.text_address = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.text_dept = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.text_id = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.opencamera_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.text_name = new System.Windows.Forms.TextBox();
            this.attendant_panel = new System.Windows.Forms.Panel();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.attendant_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(869, 6);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(31, 27);
            this.button6.TabIndex = 68;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label22.Location = new System.Drawing.Point(656, 54);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(40, 20);
            this.label22.TabIndex = 128;
            this.label22.Text = "Time";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label21.Location = new System.Drawing.Point(348, 58);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 20);
            this.label21.TabIndex = 127;
            this.label21.Text = "Date";
            // 
            // text_dob
            // 
            this.text_dob.Location = new System.Drawing.Point(646, 279);
            this.text_dob.Multiline = true;
            this.text_dob.Name = "text_dob";
            this.text_dob.Size = new System.Drawing.Size(120, 20);
            this.text_dob.TabIndex = 126;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label17.Location = new System.Drawing.Point(545, 279);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 20);
            this.label17.TabIndex = 125;
            this.label17.Text = "DateOfBirth";
            // 
            // text_gender
            // 
            this.text_gender.Location = new System.Drawing.Point(646, 228);
            this.text_gender.Multiline = true;
            this.text_gender.Name = "text_gender";
            this.text_gender.Size = new System.Drawing.Size(120, 20);
            this.text_gender.TabIndex = 124;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label18.Location = new System.Drawing.Point(545, 228);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 20);
            this.label18.TabIndex = 123;
            this.label18.Text = "Gender";
            // 
            // text_edu
            // 
            this.text_edu.Location = new System.Drawing.Point(646, 178);
            this.text_edu.Multiline = true;
            this.text_edu.Name = "text_edu";
            this.text_edu.Size = new System.Drawing.Size(120, 20);
            this.text_edu.TabIndex = 122;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label19.Location = new System.Drawing.Point(545, 178);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(83, 20);
            this.label19.TabIndex = 121;
            this.label19.Text = "Education";
            // 
            // text_phone
            // 
            this.text_phone.Location = new System.Drawing.Point(646, 123);
            this.text_phone.Multiline = true;
            this.text_phone.Name = "text_phone";
            this.text_phone.Size = new System.Drawing.Size(120, 20);
            this.text_phone.TabIndex = 120;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label20.Location = new System.Drawing.Point(545, 123);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 20);
            this.label20.TabIndex = 119;
            this.label20.Text = "Phone";
            // 
            // text_address
            // 
            this.text_address.Location = new System.Drawing.Point(352, 237);
            this.text_address.Multiline = true;
            this.text_address.Name = "text_address";
            this.text_address.Size = new System.Drawing.Size(120, 20);
            this.text_address.TabIndex = 118;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label15.Location = new System.Drawing.Point(240, 286);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 20);
            this.label15.TabIndex = 117;
            this.label15.Text = "Department";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.button6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(903, 35);
            this.panel2.TabIndex = 111;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(454, 33);
            this.label2.TabIndex = 110;
            this.label2.Text = "Employee Management System";
            // 
            // text_dept
            // 
            this.text_dept.Location = new System.Drawing.Point(352, 287);
            this.text_dept.Multiline = true;
            this.text_dept.Name = "text_dept";
            this.text_dept.Size = new System.Drawing.Size(120, 20);
            this.text_dept.TabIndex = 116;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label16.Location = new System.Drawing.Point(249, 237);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 20);
            this.label16.TabIndex = 115;
            this.label16.Text = "Address";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label14.Location = new System.Drawing.Point(251, 181);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 20);
            this.label14.TabIndex = 113;
            this.label14.Text = "Name";
            // 
            // text_id
            // 
            this.text_id.Location = new System.Drawing.Point(352, 125);
            this.text_id.Multiline = true;
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(120, 20);
            this.text_id.TabIndex = 112;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label13.Location = new System.Drawing.Point(251, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 20);
            this.label13.TabIndex = 111;
            this.label13.Text = "ID";
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Scan";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(436, 331);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(64, 37);
            this.bunifuThinButton21.TabIndex = 110;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // opencamera_btn
            // 
            this.opencamera_btn.ActiveBorderThickness = 1;
            this.opencamera_btn.ActiveCornerRadius = 20;
            this.opencamera_btn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.opencamera_btn.ActiveForecolor = System.Drawing.Color.White;
            this.opencamera_btn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.opencamera_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.opencamera_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("opencamera_btn.BackgroundImage")));
            this.opencamera_btn.ButtonText = "Open";
            this.opencamera_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.opencamera_btn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.opencamera_btn.ForeColor = System.Drawing.Color.SeaGreen;
            this.opencamera_btn.IdleBorderThickness = 1;
            this.opencamera_btn.IdleCornerRadius = 20;
            this.opencamera_btn.IdleFillColor = System.Drawing.Color.White;
            this.opencamera_btn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.opencamera_btn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.opencamera_btn.Location = new System.Drawing.Point(336, 331);
            this.opencamera_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.opencamera_btn.Name = "opencamera_btn";
            this.opencamera_btn.Size = new System.Drawing.Size(64, 37);
            this.opencamera_btn.TabIndex = 109;
            this.opencamera_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.opencamera_btn.Click += new System.EventHandler(this.opencamera_btn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(23, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 21);
            this.comboBox1.TabIndex = 101;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(23, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 187);
            this.pictureBox1.TabIndex = 100;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(26, 13);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(214, 18);
            this.label12.TabIndex = 99;
            this.label12.Text = "Employee Attendance Form";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(352, 181);
            this.text_name.Multiline = true;
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(120, 20);
            this.text_name.TabIndex = 114;
            // 
            // attendant_panel
            // 
            this.attendant_panel.Controls.Add(this.bunifuThinButton22);
            this.attendant_panel.Controls.Add(this.label22);
            this.attendant_panel.Controls.Add(this.label21);
            this.attendant_panel.Controls.Add(this.text_dob);
            this.attendant_panel.Controls.Add(this.label17);
            this.attendant_panel.Controls.Add(this.text_gender);
            this.attendant_panel.Controls.Add(this.label18);
            this.attendant_panel.Controls.Add(this.text_edu);
            this.attendant_panel.Controls.Add(this.label19);
            this.attendant_panel.Controls.Add(this.text_phone);
            this.attendant_panel.Controls.Add(this.label20);
            this.attendant_panel.Controls.Add(this.text_address);
            this.attendant_panel.Controls.Add(this.label15);
            this.attendant_panel.Controls.Add(this.text_dept);
            this.attendant_panel.Controls.Add(this.label16);
            this.attendant_panel.Controls.Add(this.text_name);
            this.attendant_panel.Controls.Add(this.label14);
            this.attendant_panel.Controls.Add(this.text_id);
            this.attendant_panel.Controls.Add(this.label13);
            this.attendant_panel.Controls.Add(this.bunifuThinButton21);
            this.attendant_panel.Controls.Add(this.opencamera_btn);
            this.attendant_panel.Controls.Add(this.comboBox1);
            this.attendant_panel.Controls.Add(this.pictureBox1);
            this.attendant_panel.Controls.Add(this.label12);
            this.attendant_panel.Location = new System.Drawing.Point(11, 104);
            this.attendant_panel.Margin = new System.Windows.Forms.Padding(2);
            this.attendant_panel.Name = "attendant_panel";
            this.attendant_panel.Size = new System.Drawing.Size(881, 395);
            this.attendant_panel.TabIndex = 109;
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "View Record";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.Location = new System.Drawing.Point(548, 331);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(83, 37);
            this.bunifuThinButton22.TabIndex = 129;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // AttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(903, 505);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.attendant_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AttendanceForm";
            this.Text = "AttendanceForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AttendanceForm_FormClosing);
            this.Load += new System.EventHandler(this.AttendanceForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.attendant_panel.ResumeLayout(false);
            this.attendant_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel attendant_panel;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox text_dob;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox text_gender;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox text_edu;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox text_phone;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox text_address;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox text_dept;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 opencamera_btn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
    }
}