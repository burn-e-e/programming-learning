namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var text = ((Button)sender).Text;
            txtInput.Text += text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
        }
    }
}