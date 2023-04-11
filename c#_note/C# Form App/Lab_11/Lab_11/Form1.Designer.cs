namespace Lab_11
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            txtBoxAimag = new TextBox();
            toolTip1 = new ToolTip(components);
            sortOption = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 7);
            label1.Name = "label1";
            label1.Size = new Size(235, 21);
            label1.TabIndex = 0;
            label1.Text = "Бүх мэдээллийг харуулбал...";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 40);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(372, 275);
            dataGridView1.TabIndex = 1;
            // 
            // txtBoxAimag
            // 
            txtBoxAimag.BorderStyle = BorderStyle.FixedSingle;
            txtBoxAimag.Location = new Point(437, 253);
            txtBoxAimag.Margin = new Padding(3, 2, 3, 2);
            txtBoxAimag.Name = "txtBoxAimag";
            txtBoxAimag.Size = new Size(103, 23);
            txtBoxAimag.TabIndex = 2;
            txtBoxAimag.MouseHover += txtBoxAimag_MouseHover;
            // 
            // sortOption
            // 
            sortOption.FormattingEnabled = true;
            sortOption.Items.AddRange(new object[] { " Шинэ гарсан өвчлөлийн тоогоор", "Нийт өвчлөлийн тоогоор ", "Хуучин өвчлөлийн тоогоор" });
            sortOption.Location = new Point(28, 40);
            sortOption.Name = "sortOption";
            sortOption.Size = new Size(372, 23);
            sortOption.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(546, 253);
            button1.Name = "button1";
            button1.Size = new Size(138, 23);
            button1.TabIndex = 4;
            button1.Text = " Аймгаар шүүж харах";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(437, 170);
            button2.Name = "button2";
            button2.Size = new Size(247, 23);
            button2.TabIndex = 4;
            button2.Text = "Өвчлөлийг бүсчлэлээр ";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(437, 141);
            button3.Name = "button3";
            button3.Size = new Size(247, 23);
            button3.TabIndex = 4;
            button3.Text = "Буурахаар эрэмбэлэх /Нийт ";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(437, 112);
            button4.Name = "button4";
            button4.Size = new Size(247, 23);
            button4.TabIndex = 4;
            button4.Text = "Өсөхөөр эрэмбэлэх /Шинэ ";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(437, 83);
            button5.Name = "button5";
            button5.Size = new Size(247, 23);
            button5.TabIndex = 4;
            button5.Text = " Өвчлөлийн тоог харуулах";
            button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 338);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(sortOption);
            Controls.Add(txtBoxAimag);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Коронавирус халдварын үзүүлэлт";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private TextBox txtBoxAimag;
        private ToolTip toolTip1;
        private ComboBox sortOption;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}