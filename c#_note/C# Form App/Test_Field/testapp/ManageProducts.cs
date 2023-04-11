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
using System.IO;

namespace testapp
{
    public partial class ManageProducts : Form
    {
        public ManageProducts()
        {
            InitializeComponent();
        }
        string zuragzam;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                zuragzam = openFileDialog1.FileName;
            }
        }
        private void ManageProducts_Load(object sender, EventArgs e)
        {
            try
            {
                DataAccessLayer mylayer = new DataAccessLayer();
                comboBox1.DataSource = mylayer.GetAppCategories();
                comboBox1.DisplayMember = "CategoryName";
                comboBox1.ValueMember = "ID";

                MyDataMethods myobj = new MyDataMethods();
                dataGridView2.DataSource = myobj.GetProducts();
                DisplayProductImages();
            }
            catch(Exception aldaa)
            {
                MessageBox.Show("aldaa:"+aldaa.Message);
            }         
        }
        int ProductID;
        void DisplayProductImages()
        {
            DataGridViewImageColumn myimagecolumn = new DataGridViewImageColumn();
            myimagecolumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            myimagecolumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            myimagecolumn.HeaderText = "Барааны зураг";
            myimagecolumn.Width = 140;
            dataGridView2.Columns.Add(myimagecolumn);
            int i = 0;
            MyDataMethods myobj = new MyDataMethods();
            List<AppProduct> mylist = myobj.GetProducts();          
            foreach (AppProduct myproduct in mylist)
            {                                            
                 string zuragniizam = @"" + myproduct.PimagePath;
                 using (FileStream FS = File.Open(zuragniizam, FileMode.Open))
                 {
                    Bitmap zurag = new Bitmap(FS);
                    myimagecolumn.Image = zurag;
                    dataGridView2.Rows[5].Cells[12].Value = zurag;
                    dataGridView2.RowTemplate.Height = 120;
                    i = i + 1;
                }
            }
        }
        void DisplayProductImage()
        {
            DataGridViewImageColumn myimagecolumn = new DataGridViewImageColumn();
            myimagecolumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            myimagecolumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            myimagecolumn.HeaderText = "Барааны зураг";
            myimagecolumn.Width = 140;
            dataGridView1.Columns.Add(myimagecolumn);
            //odoo buh bichleguudiig unshdag method duudna
            MyDataMethods myobject = new MyDataMethods();
            DataTable myproductTable = myobject.getProductByID(ProductID);
            foreach(DataRow murbichleg in myproductTable.Rows)
            {
                int i = 0;
                string zuragniizam = @"" + murbichleg["PImage"].ToString();
                using (FileStream FS = File.Open(zuragniizam, FileMode.Open))
                {
                    Bitmap zurag = new Bitmap(FS);
                    myimagecolumn.Image = zurag;
                    //odoo deerh imagecolumn iig gridview ruu nemne
                    dataGridView1.Rows[i].Cells[11].Value = zurag;
                    dataGridView1.RowTemplate.Height = 120;
                    i = i + 1;
                }
            }
        }    
        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text=="")
            {
                MessageBox.Show("барааны нэр категорыг сонго");
            }
            else if(textBox1.Text.Trim()=="")
            {
                MessageBox.Show("барааны нэр сонго");
            }
            else  if(textBox1.Text.Trim().Length>100)
            {
                MessageBox.Show("барааны нэр 100 тэмдэгтээс хэтрэхгүй байна");
            }
            else if(comboBox2.Text=="")
            {
                MessageBox.Show("хэмжих  нэгжийг сонго");
            }
            else if(maskedTextBox1.Text.Trim()=="")
            {
                MessageBox.Show("хэмжээг оруулна уу");
            }
            else if(richTextBox1.Text.Trim().Length>150)
            {
                MessageBox.Show("нэмэлт тайлбар 150 тэмдэгтээс хэтрэхгүй байна");
            }
            else if(maskedTextBox2.Text.Trim()=="")
            {
                MessageBox.Show("үнэ оруул");
            }
            else if(dateTimePicker1.Value>DateTime.Now)
            {
                MessageBox.Show("Үйлдвэрлэгдсэн огноог зөв оруулна уу");
            }
            else
            {
                //table - inset hiigdeh object iig uusgene
                AppProduct myproduct = new AppProduct();
                myproduct.CatID = Int32.Parse(comboBox1.SelectedValue.ToString());
                myproduct.PName = textBox1.Text.Trim();
                myproduct.PUnit = comboBox2.Text;
                myproduct.PSize = double.Parse(maskedTextBox1.Text.Trim());
                myproduct.Pinfo = richTextBox1.Text.Trim();
                myproduct.PPrice = double.Parse(maskedTextBox2.Text.Trim());
                myproduct.PDate = dateTimePicker1.Value;
                string zuragfolder;
                if (pictureBox1.Image !=null)
                {
                     zuragfolder = @"..\..\PImages\" + Path.GetFileName(zuragzam);
                     myproduct.PimagePath = zuragfolder;
                }
                myproduct.CDate = DateTime.Now;
                myproduct.MDate = DateTime.Now;

                //odoo DB ruu save hiine
                try
                {
                    MyDataMethods DB = new MyDataMethods();
                    DB.AddProduct(myproduct);//bichlegiig nemne
                    ProductID = DB.insertedProductID;
               
                    //odoo zurgiig foldert hadgalna
                    if(zuragzam !=null)
                    {
                        zuragfolder = @"..\..\PImages\" + Path.GetFileName(zuragzam);
                        File.Copy(zuragzam, zuragfolder); //zurgiig foldert hadgalna
                        MessageBox.Show("амжилттай");
                        dataGridView1.DataSource = DB.GetInsertedProduct();
                        DisplayProductImage();
                       
                    }
                    else
                    {
                        //Baraa zuraggui uyed nemeh method
                        DB.AddProduct(myproduct);
                        MessageBox.Show("амжилттай");
                        dataGridView1.DataSource = DB.GetInsertedProduct();
                        ProductID = DB.insertedProductID;
                        DisplayProductImage();
                    }                              
                }
                catch(Exception aldaa)
                {
                    MessageBox.Show("aldaa:" + aldaa.Message);
                }
                finally
                {
                    textBox1.Clear();
                    maskedTextBox1.Clear();
                    maskedTextBox2.Clear();
                    richTextBox1.Clear();
                    comboBox2.Text = "";
                    dateTimePicker1.Value = DateTime.Now;
                    pictureBox1.Image = null;
                }             
            }
        }
    }
}
