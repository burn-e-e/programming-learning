namespace Calculator_Stylish
{
    public partial class Form1 : Form
    {
        double cdblCurrTotal = 0.0;
        bool cblnReplace = false;
        string cstrLastOperation = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TxtDisplay1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void BtnNum_Click(object sender, EventArgs e)
        {

        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            TxtDisplay1.Text = "0";
        }
        private void CreateValue(String currentNumber)
        {
            if ((TxtDisplay1.Text == "0") || (TxtDisplay1.Text == "") || cblnReplace)
            {
                TxtDisplay1.Text = currentNumber;
            }
            else
            {
                TxtDisplay1.Text = TxtDisplay1.Text.Substring(0, TxtDisplay1.Text.Length - 1) + currentNumber;
                cblnReplace = false;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            cdblCurrTotal += Convert.ToDouble(TxtDisplay1.Text);
            cblnReplace = true;
            cstrLastOperation = "+";
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            switch (cstrLastOperation)
            {
                case "+":
                    cstrLastOperation += Convert.ToDouble(TxtDisplay1.Text);
                    TxtDisplay1.Text = cdblCurrTotal.ToString();
                    break;
            }
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            CreateValue("1");
        }
        private void Btn2_Click(object sender, EventArgs e)
        {
            CreateValue("2");
        }
        private void Btn3_Click(object sender, EventArgs e)
        {
            CreateValue("3");
        }
        private void Btn4_Click(object sender, EventArgs e)
        {
            CreateValue("4");
        }
        private void Btn5_Click(object sender, EventArgs e)
        {
            CreateValue("5");
        }
        private void Btn6_Click(object sender, EventArgs e)
        {
            CreateValue("6");
        }
        private void Btn7_Click(object sender, EventArgs e)
        {
            CreateValue("7");
        }
        private void Btn8_Click(object sender, EventArgs e)
        {
            CreateValue("8");
        }
        private void Btn9_Click(object sender, EventArgs e)
        {
            CreateValue("9");
        }
        private void Btn0_Click(object sender, EventArgs e)
        {
            CreateValue("0");
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}