namespace Lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string postTitle = this.textBox1.Text;
            string desc = this.richTextBox1.Text;
            //Post post = new Post(postTitle, desc); 
           // myPosts.publish();
        }
    }
}