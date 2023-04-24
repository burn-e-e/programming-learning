namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        double cdblCurrTotal = 0.0;
        bool cblnReplace = false;
        string cstrLastOperation = "";

        public CalculatorForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            txtInput.Text = "0.";
        }
        private void CreateValue(string strCurrNum)
        {
            if ((txtInput.Text == "0.") || (txtInput.Text == "") || cblnReplace)
            {
                txtInput.Text = strCurrNum + ".";
            }
            else
            {
                txtInput.Text = txtInput.Text.Substring(0, txtInput.Text.Length - 1) + strCurrNum + ".";
            }
            cblnReplace = false;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            cdblCurrTotal += Convert.ToDouble(txtInput.Text);
            cblnReplace = true;
            cstrLastOperation = "+";
        }

        private void subtract_btn_Click(object sender, EventArgs e)
        {
            cdblCurrTotal -= Convert.ToDouble(txtInput.Text);
            cblnReplace = true;
            cstrLastOperation = "-";
        }

        private void equal_btn_Click(object sender, EventArgs e)
        {
            switch (cstrLastOperation)
            {
                case "+":
                        
                    break;
            }
        }
    }
}