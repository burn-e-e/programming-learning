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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.amount_txt = new System.Windows.Forms.TextBox();
            this.fromcombo1 = new System.Windows.Forms.ComboBox();
            this.tocombo2 = new System.Windows.Forms.ComboBox();
            this.display_txt = new System.Windows.Forms.Label();
            this.convert_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Head_lbl
            // 
            this.Head_lbl.AutoSize = true;
            this.Head_lbl.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Head_lbl.Location = new System.Drawing.Point(177, 9);
            this.Head_lbl.Name = "Head_lbl";
            this.Head_lbl.Size = new System.Drawing.Size(200, 29);
            this.Head_lbl.TabIndex = 1;
            this.Head_lbl.Text = "Power converter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Convert From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Convert To";
            // 
            // amount_txt
            // 
            this.amount_txt.Location = new System.Drawing.Point(278, 104);
            this.amount_txt.Name = "amount_txt";
            this.amount_txt.Size = new System.Drawing.Size(136, 23);
            this.amount_txt.TabIndex = 3;
            // 
            // fromcombo1
            // 
            this.fromcombo1.FormattingEnabled = true;
            this.fromcombo1.Items.AddRange(new object[] {
            "Watt",
            "Kilowatt",
            "Megawatt",
            "Milliwatt"});
            this.fromcombo1.Location = new System.Drawing.Point(278, 156);
            this.fromcombo1.Name = "fromcombo1";
            this.fromcombo1.Size = new System.Drawing.Size(110, 23);
            this.fromcombo1.TabIndex = 4;
            // 
            // tocombo2
            // 
            this.tocombo2.FormattingEnabled = true;
            this.tocombo2.Items.AddRange(new object[] {
            "Watt",
            "Kilowatt",
            "Megawatt",
            "Milliwatt"});
            this.tocombo2.Location = new System.Drawing.Point(278, 214);
            this.tocombo2.Name = "tocombo2";
            this.tocombo2.Size = new System.Drawing.Size(110, 23);
            this.tocombo2.TabIndex = 4;
            // 
            // display_txt
            // 
            this.display_txt.AutoSize = true;
            this.display_txt.Location = new System.Drawing.Point(227, 289);
            this.display_txt.Name = "display_txt";
            this.display_txt.Size = new System.Drawing.Size(115, 15);
            this.display_txt.TabIndex = 2;
            this.display_txt.Text = "Converted Amount: ";
            // 
            // convert_btn
            // 
            this.convert_btn.Location = new System.Drawing.Point(420, 103);
            this.convert_btn.Name = "convert_btn";
            this.convert_btn.Size = new System.Drawing.Size(75, 23);
            this.convert_btn.TabIndex = 5;
            this.convert_btn.Text = "Convert";
            this.convert_btn.UseVisualStyleBackColor = true;
            this.convert_btn.Click += new System.EventHandler(this.convert_btn_Click);
            // 
            // Power_converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(589, 385);
            this.Controls.Add(this.convert_btn);
            this.Controls.Add(this.tocombo2);
            this.Controls.Add(this.fromcombo1);
            this.Controls.Add(this.amount_txt);
            this.Controls.Add(this.display_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Head_lbl);
            this.Name = "Power_converter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Power converter";
            this.Load += new System.EventHandler(this.Power_converter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Head_lbl;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox amount_txt;
        private ComboBox fromcombo1;
        private ComboBox tocombo2;
        private Label display_txt;
        private Button convert_btn;
    }
}