namespace LoginForm
{
    partial class LoginForm
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
            this.Head_lbl = new System.Windows.Forms.Label();
            this.User_lbl = new System.Windows.Forms.Label();
            this.Pass_lbl = new System.Windows.Forms.Label();
            this.User_txt = new System.Windows.Forms.TextBox();
            this.Pass_txt = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Head_lbl
            // 
            this.Head_lbl.AutoSize = true;
            this.Head_lbl.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Head_lbl.Location = new System.Drawing.Point(324, 73);
            this.Head_lbl.Name = "Head_lbl";
            this.Head_lbl.Size = new System.Drawing.Size(80, 29);
            this.Head_lbl.TabIndex = 0;
            this.Head_lbl.Text = "Login";
            this.Head_lbl.Click += new System.EventHandler(this.Head_lbl_Click);
            // 
            // User_lbl
            // 
            this.User_lbl.AutoSize = true;
            this.User_lbl.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.User_lbl.Location = new System.Drawing.Point(245, 141);
            this.User_lbl.Name = "User_lbl";
            this.User_lbl.Size = new System.Drawing.Size(102, 22);
            this.User_lbl.TabIndex = 0;
            this.User_lbl.Text = "Username:";
            this.User_lbl.Click += new System.EventHandler(this.Head_lbl_Click);
            // 
            // Pass_lbl
            // 
            this.Pass_lbl.AutoSize = true;
            this.Pass_lbl.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Pass_lbl.Location = new System.Drawing.Point(245, 177);
            this.Pass_lbl.Name = "Pass_lbl";
            this.Pass_lbl.Size = new System.Drawing.Size(99, 22);
            this.Pass_lbl.TabIndex = 0;
            this.Pass_lbl.Text = "Password:";
            this.Pass_lbl.Click += new System.EventHandler(this.Head_lbl_Click);
            // 
            // User_txt
            // 
            this.User_txt.Location = new System.Drawing.Point(375, 144);
            this.User_txt.Name = "User_txt";
            this.User_txt.Size = new System.Drawing.Size(112, 23);
            this.User_txt.TabIndex = 1;
            // 
            // Pass_txt
            // 
            this.Pass_txt.Location = new System.Drawing.Point(375, 180);
            this.Pass_txt.Name = "Pass_txt";
            this.Pass_txt.PasswordChar = '*';
            this.Pass_txt.Size = new System.Drawing.Size(112, 23);
            this.Pass_txt.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(269, 244);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "Login";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(389, 244);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.Pass_txt);
            this.Controls.Add(this.User_txt);
            this.Controls.Add(this.Pass_lbl);
            this.Controls.Add(this.User_lbl);
            this.Controls.Add(this.Head_lbl);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Head_lbl;
        private Label User_lbl;
        private Label Pass_lbl;
        private TextBox User_txt;
        private TextBox Pass_txt;
        private Button btnOK;
        private Button btnExit;
    }
}