using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CommonLibrary
{
    interface IDataMethods
    {
        string CheckLogin(int UTypeID,string UName,string Upass);
        void AddProduct(AppProduct shineProduct);
        void EditProduct(AppProduct EditedProduct);
        void DeleteProduct(AppProduct deleteProduct);
        List<AppProduct> GetProducts();
        DataTable GetInsertedProduct();
        DataTable getProductByID(int PID);
        void DeleteUserType(int id);
    }
    //deerh interface -ийн method -уудыг хэрэглэхийн тулд 
    //class uusgej interface eeree implement hiine
    public class MyDataMethods :IDataMethods
    {
    
        public void DeleteUserType(int id)
        {
            SqlConnection mycon = new SqlConnection();
            mycon.ConnectionString = ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString;
            SqlCommand mycmd = new SqlCommand();
            mycmd.Connection = mycon;
            mycmd.CommandText = "DeleteTest";
            mycmd.CommandType = CommandType.StoredProcedure;
            mycmd.Parameters.AddWithValue("@UserTypeID", id);
            try
            {
                mycon.Open();
                mycmd.ExecuteNonQuery();
            }
            catch(Exception aldaa)
            {
                throw new Exception(aldaa.Message);
            }
            finally
            {
                mycon.Close();
            }              
        }
           
     public DataTable getProductByID(int PID)
      {
            SqlConnection mycon = new SqlConnection();
            mycon.ConnectionString = ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString;
            SqlCommand mycmd = new SqlCommand();
            mycmd.Connection = mycon;
            mycmd.CommandText = "SelectInsertedProducts";
            mycmd.CommandType = CommandType.StoredProcedure;
            mycmd.Parameters.AddWithValue("@InsertedPID", PID);
            DataTable mytable = new DataTable();
            try
            {
                mycon.Open();
                SqlDataReader myreader = mycmd.ExecuteReader();
                mytable.Load(myreader);
                return mytable;
            }
            catch(Exception aldaa)
            {
                throw new Exception(aldaa.Message);
            }
            finally
            {
                mycon.Close();
            }
        }
       public string CheckLogin(int UTypeID, string UName, string Upass)
        {
            SqlConnection mycon = new SqlConnection();
            mycon.ConnectionString = ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString;
            SqlCommand mycmd = new SqlCommand();
            mycmd.Connection = mycon;
            mycmd.CommandText = "SelectLogin";
            mycmd.CommandType = CommandType.StoredProcedure;
            mycmd.Parameters.AddWithValue("@UserTypeID", UTypeID);
            mycmd.Parameters.AddWithValue("@UserName", UName);
            mycmd.Parameters.AddWithValue("@UserPass", Upass);
            DataTable mytable = new DataTable();
            try
            {
                mycon.Open();
                SqlDataReader myreader = mycmd.ExecuteReader();
                mytable.Load(myreader);
                if(mytable.Rows.Count==1)
                {
                    return "YES";
                }
                else
                {
                    return "NO";
                }
            }
            catch(Exception aldaa)
            {
                throw new Exception(aldaa.Message);
            }
            finally
            {
                mycon.Close();
            }            
        }
       public int insertedProductID;   
       public void AddProduct(AppProduct shineProduct)
        {
            SqlConnection mycon = new SqlConnection();
            mycon.ConnectionString = ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString;
            SqlCommand mycmd = new SqlCommand();
            mycmd.Connection = mycon;
            mycmd.CommandText = "InsertProduct";
            mycmd.CommandType = CommandType.StoredProcedure;
            mycmd.Parameters.AddWithValue("@CatID", shineProduct.CatID);
            mycmd.Parameters.AddWithValue("@PName", shineProduct.PName);
            mycmd.Parameters.AddWithValue("@Punit", shineProduct.PUnit);
            mycmd.Parameters.AddWithValue("@PSize", shineProduct.PSize);
            mycmd.Parameters.AddWithValue("@PPrice", shineProduct.PPrice);
            mycmd.Parameters.AddWithValue("@PInfo", shineProduct.Pinfo);
            mycmd.Parameters.AddWithValue("@PDate", shineProduct.PDate);
            mycmd.Parameters.AddWithValue("@PImagePath", shineProduct.PimagePath);
            mycmd.Parameters.AddWithValue("@CDate", shineProduct.CDate);
            mycmd.Parameters.AddWithValue("@MDate", shineProduct.MDate);
            mycmd.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output;
            try
            {
                mycon.Open();
                mycmd.ExecuteNonQuery();
                insertedProductID = Int32.Parse(mycmd.Parameters["@ID"].Value.ToString());
            }
            catch(Exception aldaa)
            {
                throw new Exception(aldaa.Message);
            }
            finally
            {
                mycon.Close();
            }
        }
       public DataTable GetInsertedProduct()
        {
            SqlConnection mycon = new SqlConnection();
            mycon.ConnectionString = ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString;
            SqlCommand mycmd = new SqlCommand();
            mycmd.Connection = mycon;
            mycmd.CommandText = "SelectInsertedProducts";
            mycmd.CommandType = CommandType.StoredProcedure;
            mycmd.Parameters.AddWithValue("@InsertedPID", insertedProductID);

            DataTable mytable = new DataTable();
            try
            {
                mycon.Open();
                SqlDataReader myreader = mycmd.ExecuteReader();
                mytable.Load(myreader);
                return mytable;
            }
            catch (Exception aldaa)
            {
                throw new Exception(aldaa.Message);
            }
            finally
            {
                mycon.Close();
            }

        }
       public void EditProduct(AppProduct EditedProduct)
        {

        }
       public void DeleteProduct(AppProduct deleteProduct)
        {

        }
      public List<AppProduct> GetProducts()
        {
            SqlConnection mycon = new SqlConnection();
            mycon.ConnectionString = ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString;
            SqlCommand mycmd = new SqlCommand();
            mycmd.Connection = mycon;
            mycmd.CommandText = "SelectProducts";
            mycmd.CommandType = CommandType.StoredProcedure;
            
            List<AppProduct> mylist = new List<AppProduct>();
            try
            {
                mycon.Open();
                SqlDataReader myreader = mycmd.ExecuteReader();
                while(myreader.Read())
                {
                    AppProduct myproduct = new AppProduct();
                    myproduct.id = (int)myreader["ID"];
                    myproduct.CatID = (int)myreader["CategoryID"];
                    myproduct.CatName = (string)myreader["CategoryName"];
                    myproduct.PName = (string)myreader["PName"];
                    myproduct.PUnit = (string)myreader["PUnit"];
                    myproduct.PSize = (float)myreader["PSize"];
                    myproduct.PPrice = (float)myreader["PPrice"];
                    myproduct.Pinfo = (string)myreader["PInfo"];
                    myproduct.PDate = (DateTime)myreader["PDate"];
                    myproduct.PimagePath = (string)myreader["PImage"];
                    myproduct.CDate = (DateTime)myreader["CDate"];
                    myproduct.MDate = (DateTime)myreader["MDate"];
                    //deerh objectiig list ruu nemne
                    mylist.Add(myproduct);
                }
                return mylist;//bichglegeer duursen listig butsaana
            }
            catch(Exception aldaa)
            {
                throw new Exception(aldaa.Message);
            }
            finally
            {
                mycon.Close();
            }           
        }
    }
    public class AppProduct
    {
        public int id { get; set; }
        public int CatID { get; set; }
        public string CatName { get; set; }
        public string PName { get; set; }
        public string PUnit { get; set; }
        public double PSize { get; set; }
        public double PPrice { get; set; }
        public string Pinfo { get; set; }
        public DateTime PDate { get; set; }
        public string PimagePath { get; set; }
        public DateTime CDate { get; set; }
        public DateTime MDate { get; set; }
        public  AppProduct()
        {
            id = 0;
            CatID = 0;
            CatName = "";
            PName = "";
            PUnit = "";
            PSize = 0;
            PPrice = 0;
            Pinfo = "";
            PDate = DateTime.Now;
            PimagePath = @"..\..\Pimages\NoImage.png";
            CDate = DateTime.Now;
            MDate = DateTime.Now;
        }
             
    }

}
