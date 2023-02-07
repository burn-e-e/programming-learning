namespace LoginForm
{
    partial class Power_converter
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
            this.Head_lbl = new System.Windows.Forms.Label();
            this.Watts_lbl = new System.Windows.Forms.Label();
            this.watt_lbl = new System.Windows.Forms.Label();
            this.Watt1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Watt2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Watt3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Head_lbl
            // 
            this.Head_lbl.AutoSize = true;
            this.Head_lbl.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Head_lbl.Location = new System.Drawing.Point(289, 9);
            this.Head_lbl.Name = "Head_lbl";
            this.Head_lbl.Size = new System.Drawing.Size(200, 29);
            this.Head_lbl.TabIndex = 1;
            this.Head_lbl.Text = "Power converter";
            // 
            // Watts_lbl
            // 
            this.Watts_lbl.AutoSize = true;
            this.Watts_lbl.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Watts_lbl.Location = new System.Drawing.Point(324, 120);
            this.Watts_lbl.Name = "Watts_lbl";
            this.Watts_lbl.Size = new System.Drawing.Size(80, 22);
            this.Watts_lbl.TabIndex = 2;
            this.Watts_lbl.Text = "Kilowatt ";
            // 
            // watt_lbl
            // 
            this.watt_lbl.AutoSize = true;
            this.watt_lbl.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.watt_lbl.Location = new System.Drawing.Point(167, 118);
            this.watt_lbl.Name = "watt_lbl";
            this.watt_lbl.Size = new System.Drawing.Size(48, 22);
            this.watt_lbl.TabIndex = 3;
            this.watt_lbl.Text = "Watt";
            this.watt_lbl.Click += new System.EventHandler(this.User_lbl_Click);
            // 
            // Watt1
            // 
            this.Watt1.Location = new System.Drawing.Point(51, 119);
            this.Watt1.Name = "Watt1";
            this.Watt1.Size = new System.Drawing.Size(100, 23);
            this.Watt1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(167, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Watt";
            this.label1.Click += new System.EventHandler(this.User_lbl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(324, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Megawatt ";
            // 
            // Watt2
            // 
            this.Watt2.Location = new System.Drawing.Point(51, 214);
            this.Watt2.Name = "Watt2";
            this.Watt2.Size = new System.Drawing.Size(100, 23);
            this.Watt2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(167, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Watt";
            this.label3.Click += new System.EventHandler(this.User_lbl_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(324, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Milliwatt ";
            // 
            // Watt3
            // 
            this.Watt3.Location = new System.Drawing.Point(42, 327);
            this.Watt3.Name = "Watt3";
            this.Watt3.Size = new System.Drawing.Size(100, 23);
            this.Watt3.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Convert";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(232, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Convert";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Power_converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Watt3);
            this.Controls.Add(this.Watt2);
            this.Controls.Add(this.Watt1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Watts_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.watt_lbl);
            this.Controls.Add(this.Head_lbl);
            this.Name = "Power_converter";
            this.Text = "Power converter";
            this.Load += new System.EventHandler(this.Power_converter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Head_lbl;
        private Label Watts_lbl;
        private Label watt_lbl;
        private TextBox Watt1;
        private Label label1;
        private Label label2;
        private TextBox Watt2;
        private Label label3;
        private Label label4;
        private TextBox Watt3;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}