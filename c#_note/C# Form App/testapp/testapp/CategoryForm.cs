using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonLibrary;

namespace testapp
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("категорын нэр оруулна уу");
            }
            else if (textBox1.Text.Trim().Length > 100)
            {
                MessageBox.Show("категорын нэр 100 тэмдэгтээс бага байх хэрэгтэй");
            }
            else if (richTextBox1.Text.Trim().Length > 150)
            {
                MessageBox.Show("150 тэмдэгтээс бага байх хэрэгтэй");
            }
            else
            {
                //table - object bolon nemegdeh objectiig uusgene
                AppCategory shinecategory = new AppCategory();
                shinecategory.CategoryName = textBox1.Text.Trim();
                shinecategory.CategoryInfo = richTextBox1.Text.Trim();

                //deerh objectiig nemeh method iig DataAccessLayer deerees duudna
                DataAccessLayer mylayer = new DataAccessLayer();
                try
                {
                    mylayer.AddCategory(shinecategory);
                    MessageBox.Show("амжилттай нэмэгдлээ");
                    mylayer.GetAppCategories();
                }
                catch(Exception aldaa)
                {
                    MessageBox.Show("aldaa:"+aldaa.Message);
                }
                finally
                {
                    textBox1.Clear();
                    richTextBox1.Clear();
                }
            }
        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            DataAccessLayer mylayer = new DataAccessLayer();
            dataGridView1.DataSource = mylayer.GetAppCategories();
        }
    }
}
