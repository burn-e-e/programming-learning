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
            if ((TxtDisplay1.Text == "0.") || (TxtDisplay1.Text == "") || cblnReplace)
            {
                TxtDisplay1.Text = currentNumber + ".";
            }
            else
            {
                TxtDisplay1.Text = TxtDisplay1.Text.Substring(0, TxtDisplay1.Text.Length - 1) + currentNumber + ".";
                cblnReplace = false;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            cdblCurrTotal += Convert.ToDouble(TxtDisplay1.Text);
            cblnReplace = true;
            cstrLastOperation = "+";
        }
    }
}