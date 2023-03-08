namespace Lab_4
{
    partial class frmCalculator
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
            txtValue = new TextBox();
            btnBackspace = new Button();
            btnCE = new Button();
            btrnClear = new Button();
            btnMemoryClear = new Button();
            btnMemoryRecall = new Button();
            btnMemorySave = new Button();
            btnMemoryPlus = new Button();
            btnDivide = new Button();
            btnMultiple = new Button();
            btnSubtrac = new Button();
            btnPlus = new Button();
            btnSqrt = new Button();
            btnPercent = new Button();
            btnOneOverX = new Button();
            btnEquals = new Button();
            btnPlusMinis = new Button();
            btnPeriod = new Button();
            btn0 = new Button();
            btn1 = new Button();
            btn4 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn5 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn6 = new Button();
            SuspendLayout();
            // 
            // txtValue
            // 
            txtValue.Location = new Point(12, 12);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(261, 27);
            txtValue.TabIndex = 0;
            txtValue.TabStop = false;
            txtValue.Text = "0.";
            txtValue.TextAlign = HorizontalAlignment.Right;
            // 
            // btnBackspace
            // 
            btnBackspace.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            btnBackspace.ForeColor = Color.Red;
            btnBackspace.Location = new Point(64, 53);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(74, 28);
            btnBackspace.TabIndex = 1;
            btnBackspace.Text = "Backspace";
            btnBackspace.UseVisualStyleBackColor = true;
            // 
            // btnCE
            // 
            btnCE.ForeColor = Color.Red;
            btnCE.Location = new Point(144, 53);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(58, 28);
            btnCE.TabIndex = 1;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            // 
            // btrnClear
            // 
            btrnClear.ForeColor = Color.Red;
            btrnClear.Location = new Point(208, 53);
            btrnClear.Name = "btrnClear";
            btrnClear.Size = new Size(65, 28);
            btrnClear.TabIndex = 1;
            btrnClear.Text = "C";
            btrnClear.UseVisualStyleBackColor = true;
            btrnClear.Click += btrnClear_Click;
            // 
            // btnMemoryClear
            // 
            btnMemoryClear.ForeColor = Color.Red;
            btnMemoryClear.Location = new Point(13, 87);
            btnMemoryClear.Name = "btnMemoryClear";
            btnMemoryClear.Size = new Size(41, 28);
            btnMemoryClear.TabIndex = 1;
            btnMemoryClear.Text = "MC";
            btnMemoryClear.UseVisualStyleBackColor = true;
            // 
            // btnMemoryRecall
            // 
            btnMemoryRecall.ForeColor = Color.Red;
            btnMemoryRecall.Location = new Point(13, 121);
            btnMemoryRecall.Name = "btnMemoryRecall";
            btnMemoryRecall.Size = new Size(41, 28);
            btnMemoryRecall.TabIndex = 1;
            btnMemoryRecall.Text = "MR";
            btnMemoryRecall.UseVisualStyleBackColor = true;
            // 
            // btnMemorySave
            // 
            btnMemorySave.ForeColor = Color.Red;
            btnMemorySave.Location = new Point(13, 155);
            btnMemorySave.Name = "btnMemorySave";
            btnMemorySave.Size = new Size(41, 28);
            btnMemorySave.TabIndex = 1;
            btnMemorySave.Text = "MS";
            btnMemorySave.UseVisualStyleBackColor = true;
            // 
            // btnMemoryPlus
            // 
            btnMemoryPlus.ForeColor = Color.Red;
            btnMemoryPlus.Location = new Point(12, 189);
            btnMemoryPlus.Name = "btnMemoryPlus";
            btnMemoryPlus.Size = new Size(42, 28);
            btnMemoryPlus.TabIndex = 1;
            btnMemoryPlus.Text = "+M";
            btnMemoryPlus.UseVisualStyleBackColor = true;
            // 
            // btnDivide
            // 
            btnDivide.ForeColor = Color.Red;
            btnDivide.Location = new Point(187, 87);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(35, 28);
            btnDivide.TabIndex = 1;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnMultiple
            // 
            btnMultiple.ForeColor = Color.Red;
            btnMultiple.Location = new Point(187, 121);
            btnMultiple.Name = "btnMultiple";
            btnMultiple.Size = new Size(35, 28);
            btnMultiple.TabIndex = 1;
            btnMultiple.Text = "*";
            btnMultiple.UseVisualStyleBackColor = true;
            btnMultiple.Click += btnMultiple_Click;
            // 
            // btnSubtrac
            // 
            btnSubtrac.ForeColor = Color.Red;
            btnSubtrac.Location = new Point(187, 155);
            btnSubtrac.Name = "btnSubtrac";
            btnSubtrac.Size = new Size(35, 28);
            btnSubtrac.TabIndex = 1;
            btnSubtrac.Text = "-";
            btnSubtrac.UseVisualStyleBackColor = true;
            btnSubtrac.Click += btnSubtrac_Click;
            // 
            // btnPlus
            // 
            btnPlus.ForeColor = Color.Red;
            btnPlus.Location = new Point(187, 189);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(35, 28);
            btnPlus.TabIndex = 1;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            btnSqrt.ForeColor = Color.Blue;
            btnSqrt.Location = new Point(228, 87);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(35, 28);
            btnSqrt.TabIndex = 1;
            btnSqrt.Text = "Sqrt";
            btnSqrt.UseVisualStyleBackColor = true;
            btnSqrt.Click += btnDivide_Click;
            // 
            // btnPercent
            // 
            btnPercent.ForeColor = Color.Blue;
            btnPercent.Location = new Point(228, 121);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(35, 28);
            btnPercent.TabIndex = 1;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = true;
            btnPercent.Click += btnDivide_Click;
            // 
            // btnOneOverX
            // 
            btnOneOverX.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            btnOneOverX.ForeColor = Color.Blue;
            btnOneOverX.Location = new Point(228, 155);
            btnOneOverX.Name = "btnOneOverX";
            btnOneOverX.Size = new Size(35, 28);
            btnOneOverX.TabIndex = 1;
            btnOneOverX.Text = "1/x";
            btnOneOverX.UseVisualStyleBackColor = true;
            btnOneOverX.Click += btnDivide_Click;
            // 
            // btnEquals
            // 
            btnEquals.ForeColor = Color.Blue;
            btnEquals.Location = new Point(228, 189);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(35, 28);
            btnEquals.TabIndex = 1;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnPlusMinis
            // 
            btnPlusMinis.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlusMinis.ForeColor = Color.Blue;
            btnPlusMinis.Location = new Point(103, 189);
            btnPlusMinis.Name = "btnPlusMinis";
            btnPlusMinis.Size = new Size(35, 28);
            btnPlusMinis.TabIndex = 1;
            btnPlusMinis.Text = "+/-";
            btnPlusMinis.UseVisualStyleBackColor = true;
            btnPlusMinis.Click += btnDivide_Click;
            // 
            // btnPeriod
            // 
            btnPeriod.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            btnPeriod.ForeColor = Color.Blue;
            btnPeriod.Location = new Point(144, 189);
            btnPeriod.Name = "btnPeriod";
            btnPeriod.Size = new Size(35, 28);
            btnPeriod.TabIndex = 1;
            btnPeriod.Text = ".";
            btnPeriod.UseVisualStyleBackColor = true;
            btnPeriod.Click += btnDivide_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            btn0.ForeColor = Color.Blue;
            btn0.Location = new Point(64, 191);
            btn0.Name = "btn0";
            btn0.Size = new Size(35, 28);
            btn0.TabIndex = 1;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.ForeColor = Color.Blue;
            btn1.Location = new Point(64, 157);
            btn1.Name = "btn1";
            btn1.Size = new Size(35, 28);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            btn4.ForeColor = Color.Blue;
            btn4.Location = new Point(64, 123);
            btn4.Name = "btn4";
            btn4.Size = new Size(35, 28);
            btn4.TabIndex = 1;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            btn7.ForeColor = Color.Blue;
            btn7.Location = new Point(64, 87);
            btn7.Name = "btn7";
            btn7.Size = new Size(35, 28);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            btn8.ForeColor = Color.Blue;
            btn8.Location = new Point(105, 87);
            btn8.Name = "btn8";
            btn8.Size = new Size(35, 28);
            btn8.TabIndex = 1;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            btn9.ForeColor = Color.Blue;
            btn9.Location = new Point(146, 87);
            btn9.Name = "btn9";
            btn9.Size = new Size(35, 28);
            btn9.TabIndex = 1;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            btn5.ForeColor = Color.Blue;
            btn5.Location = new Point(103, 123);
            btn5.Name = "btn5";
            btn5.Size = new Size(35, 28);
            btn5.TabIndex = 1;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            btn2.ForeColor = Color.Blue;
            btn2.Location = new Point(103, 157);
            btn2.Name = "btn2";
            btn2.Size = new Size(35, 28);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            btn3.ForeColor = Color.Blue;
            btn3.Location = new Point(144, 157);
            btn3.Name = "btn3";
            btn3.Size = new Size(35, 28);
            btn3.TabIndex = 1;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            btn6.ForeColor = Color.Blue;
            btn6.Location = new Point(144, 123);
            btn6.Name = "btn6";
            btn6.Size = new Size(35, 28);
            btn6.TabIndex = 1;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // frmCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 231);
            Controls.Add(btnMemoryPlus);
            Controls.Add(btnMemorySave);
            Controls.Add(btnMemoryRecall);
            Controls.Add(btnPlus);
            Controls.Add(btnSubtrac);
            Controls.Add(btnMultiple);
            Controls.Add(btn6);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn5);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn4);
            Controls.Add(btn1);
            Controls.Add(btn0);
            Controls.Add(btnPeriod);
            Controls.Add(btnPlusMinis);
            Controls.Add(btnEquals);
            Controls.Add(btnOneOverX);
            Controls.Add(btnPercent);
            Controls.Add(btnSqrt);
            Controls.Add(btnDivide);
            Controls.Add(btnMemoryClear);
            Controls.Add(btrnClear);
            Controls.Add(btnCE);
            Controls.Add(btnBackspace);
            Controls.Add(txtValue);
            Name = "frmCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValue;
        private Button btnBackspace;
        private Button btnCE;
        private Button btrnClear;
        private Button btnMemoryClear;
        private Button btnMemoryRecall;
        private Button btnMemorySave;
        private Button btnMemoryPlus;
        private Button btnDivide;
        private Button btnMultiple;
        private Button btnSubtrac;
        private Button btnPlus;
        private Button btnSqrt;
        private Button btnPercent;
        private Button btnOneOverX;
        private Button btnEquals;
        private Button btnPlusMinis;
        private Button btnPeriod;
        private Button btn0;
        private Button btn1;
        private Button btn4;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn5;
        private Button btn2;
        private Button btn3;
        private Button btn6;
    }
}