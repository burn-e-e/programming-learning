namespace Lab_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxAimag_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtBoxAimag, "Аймгийн нэр оруул!");
        }
    }
}