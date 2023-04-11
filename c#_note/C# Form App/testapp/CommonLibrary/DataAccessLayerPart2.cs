using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CommonLibrary
{
    partial class DataAccessLayer 
    {
       
        public void AddCategory(AppCategory shinecategory)
        {
            SqlConnection mycon = new SqlConnection();
            mycon.ConnectionString = constring;
            SqlCommand mycmd = new SqlCommand();
            mycmd.Connection = mycon;
            mycmd.CommandText = "InsertCategory";
            mycmd.CommandType = CommandType.StoredProcedure;
            mycmd.Parameters.AddWithValue("@CatName", shinecategory.CategoryName);
            mycmd.Parameters.AddWithValue("@CatInfo", shinecategory.CategoryInfo);
            mycmd.Parameters.AddWithValue("@CDate", shinecategory.CreatedDate);
            mycmd.Parameters.AddWithValue("@MDate", shinecategory.ModifiedDate);
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
        public  List<AppCategory> GetAppCategories()
        {
            SqlConnection mycon = new SqlConnection();
            mycon.ConnectionString = constring;
            SqlCommand mycmd = new SqlCommand();
            mycmd.Connection = mycon;
            mycmd.CommandText = "SelectAllCategories";
            mycmd.CommandType = CommandType.StoredProcedure;

            List<AppCategory> mylist = new List<AppCategory>();
            try
            {
                mycon.Open();
                SqlDataReader myreader = mycmd.ExecuteReader();
                while(myreader.Read())
                {
                    //list ruu nemegdeh object uusgej property -nuud ruu 
                    //table iin baganiin utguudiig hadgalna
                    AppCategory mycat = new AppCategory();
                    mycat.id = (int)myreader["ID"];
                    mycat.CategoryName = (string)myreader["CategoryName"];
                    mycat.CategoryInfo = (string)myreader["CategoryInfo"];
                    mycat.CreatedDate = (DateTime)myreader["CreatedDate"];
                    mycat.ModifiedDate = (DateTime)myreader["ModifiedDate"];

                    //deerh objectiig list ruu nemne
                    mylist.Add(mycat);
                    //bichlegeer duursen list iig return eer butsaana                  
               }
                return mylist;
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
}
