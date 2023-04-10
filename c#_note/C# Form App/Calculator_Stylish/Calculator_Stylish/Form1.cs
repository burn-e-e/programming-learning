namespace Calculator_Stylish
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Double result = 0;
        String operation = String.Empty;
        String fstNum, secNum;
        bool enterValue = false;

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
            if (TxtDisplay1.Text == "O" || enterValue) TxtDisplay1.Text = String.Empty;
            enterValue = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!TxtDisplay1.Text.Contains("."))
                {
                    TxtDisplay1.Text = TxtDisplay1.Text + button.Text;
                }
            }
            else TxtDisplay1.Text = TxtDisplay1.Text + button.Text;
        }
    }
}