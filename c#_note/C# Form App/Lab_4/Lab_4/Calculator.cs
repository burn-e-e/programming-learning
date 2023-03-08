namespace Lab_4
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }
        double cdblCurrTotal = 0.0;
        bool cblnReplace = false;
        string cstrLastOperation = " ";
        private void CreateValue(string strCurrNum)
        {
            if ((txtValue.Text == "0.") || (txtValue.Text == " ") || cblnReplace)
            {
                txtValue.Text = strCurrNum + ".";
            }
            else
            {
                txtValue.Text = txtValue.Text.Substring(0, txtValue.Text.Length - 1) + strCurrNum + ".";
                cblnReplace = false;
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            cdblCurrTotal /= Convert.ToDouble(txtValue.Text);
            cblnReplace = true;
            cstrLastOperation = "/";
        }

        private void btrnClear_Click(object sender, EventArgs e)
        {
            txtValue.Text = "0";
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            cdblCurrTotal += Convert.ToDouble(txtValue.Text);
            cblnReplace = true;
            cstrLastOperation = "+";
        }
        private void btnSubtrac_Click(object sender, EventArgs e)
        {
            cdblCurrTotal -= Convert.ToDouble(txtValue.Text);
            cblnReplace = true;
            cstrLastOperation = "-";
        }
        private void btnMultiple_Click(object sender, EventArgs e)
        {
            cdblCurrTotal *= Convert.ToDouble(txtValue.Text);
            cblnReplace = true;
            cstrLastOperation = "*";
        }
        private void btnEquals_Click(object sender, EventArgs e)
        {
            switch (cstrLastOperation)
            {
                case "+":
                    cdblCurrTotal += Convert.ToDouble(txtValue.Text);
                    txtValue.Text = cdblCurrTotal.ToString();
                    break;
                case "-":
                    cdblCurrTotal -= Convert.ToDouble(txtValue.Text);
                    txtValue.Text = cdblCurrTotal.ToString();
                    break;
                case "*":
                    cdblCurrTotal *= Convert.ToDouble(txtValue.Text);
                    txtValue.Text = cdblCurrTotal.ToString();
                    break;
                case "/":
                    cdblCurrTotal /= Convert.ToDouble(txtValue.Text);
                    txtValue.Text = cdblCurrTotal.ToString();
                    break;
            }

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            CreateValue("0");
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            CreateValue("1");
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            CreateValue("2");
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            CreateValue("3");
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            CreateValue("4");
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            CreateValue("5");
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            CreateValue("6");
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            CreateValue("7");
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            CreateValue("8");
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            CreateValue("9");
        }
    }
}