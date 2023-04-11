using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace testapp
{
    class DataMethods
    {
        string constring = @"Data Source=.\SQLExpress;Initial Catalog=UserDB;Integrated Security=true";
        public void UpdateAppUserType(int id,string UserTypeInfo,DateTime MDate)
         {
            SqlConnection mycon = new SqlConnection();
            mycon.ConnectionString = constring;
            SqlCommand mycmd = new SqlCommand();
            mycmd.Connection = mycon;
            mycmd.CommandText = "UPDATE AppUserType SET UserTypeInfo=@UserTypeInfo , ModifiedDate=@MDate WHERE id=@ID";                       
            mycmd.Parameters.AddWithValue("@UserTypeInfo", UserTypeInfo);
            mycmd.Parameters.AddWithValue("@MDate", MDate);
            mycmd.Parameters.AddWithValue("@ID", id);
            try
            {
                mycon.Open();
                mycmd.ExecuteNonQuery();
            }
            catch(Exception aldaa)
            {
                System.Windows.Forms.MessageBox.Show("aldaa"+aldaa.Message);
            }
            finally
            {
                mycon.Close();
            }
         }
        public void UpdateAppUserType(int id,string UTypeName,string UTypeInfo,DateTime Mdate)
        {
            SqlConnection mycon = new SqlConnection();
            mycon.ConnectionString = constring;
            SqlCommand mycmd = new SqlCommand();
            mycmd.Connection = mycon;
            mycmd.CommandText = "UPDATE AppUserType SET UserTypeName=@UTypeName ,UserTypeInfo=@UserTypeInfo , ModifiedDate=@MDate WHERE id=@ID";

            mycmd.Parameters.AddWithValue("@UTypeName", UTypeName);
            mycmd.Parameters.AddWithValue("@UserTypeInfo", UTypeInfo);
            mycmd.Parameters.AddWithValue("@MDate", Mdate);
            mycmd.Parameters.AddWithValue("@ID", id);
            try
            {
                mycon.Open();
                mycmd.ExecuteNonQuery();
            }
            catch (Exception aldaa)
            {
                System.Windows.Forms.MessageBox.Show("aldaa" + aldaa.Message);
            }
            finally
            {
                mycon.Close();
            }
        }
        public void AddUser(AppUser shineUser)
        {
            SqlConnection mycon = new SqlConnection();
            mycon.ConnectionString = constring;
            SqlCommand mycmd = new SqlCommand();
            mycmd.Connection = mycon;
            mycmd.CommandText = "INSERT AppUser(UserTypeID,UserName,UserPassword,UserInfo,UserImage,CreatedDate,ModifiedDate)" +
                                "VALUES(@UtypeID,@UName,@Upass,@Uinfo,@Uimage,@CDate,@MDate)";
            mycmd.Parameters.AddWithValue("@UtypeID", shineUser.UserTypeID);
            mycmd.Parameters.AddWithValue("@UName", shineUser.UserName);
            mycmd.Parameters.AddWithValue("@Upass", shineUser.UserPassword);
            mycmd.Parameters.AddWithValue("@Uinfo", shineUser.UserInfo);
            mycmd.Parameters.AddWithValue("@Uimage", shineUser.UserImage);
            mycmd.Parameters.AddWithValue("@CDate", shineUser.CDate);
            mycmd.Parameters.AddWithValue("@MDate", shineUser.MDate);
            try
            {
                mycon.Open();
                mycmd.ExecuteNonQuery();
            }
            catch(Exception aldaa)
            {
                System.Windows.Forms.MessageBox.Show(aldaa.Message);
            }
            finally
            {
                mycon.Close();
            }

        }
        public DataTable GetAppUsers()
        {
            SqlConnection mycon = new SqlConnection();
            mycon.ConnectionString = constring;
            SqlCommand mycmd = new SqlCommand();
            mycmd.Connection = mycon;
            mycmd.CommandText = "SelectAllUsers";
            mycmd.CommandType = CommandType.StoredProcedure;
            //bichleg unshihad sqldataReader classiig hereglene
            DataTable mytable = new DataTable();
            try
            {
                mycon.Open();//holboltiig neene
                //sqlDataReader нь бичлэгийг уншиж байна 
                SqlDataReader myreader = mycmd.ExecuteReader();
                //sanah oid DataTable -ийг үүсгэнэ
              
                //sanah oid uussen dataTable нь Load() method ooroo
                // sqldatareaderiin unshsan bichlegiig uurtuu achaalna
                mytable.Load(myreader);
                //bicheleguudiig achaalsan datatable iig return eer butsana        
            }
            catch(Exception aldaa)
            {
                 MessageBox.Show(aldaa.Message);
            }
            finally
            {             
                mycon.Close();
            }

            return mytable;
        }
    }
}
