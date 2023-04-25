using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using Microsoft.Data.SqlClient;

namespace EmployeeManagement.Classes
{
    internal class contact
    {
        public int contactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }

        static string myconnectionstring = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
        //------------------------------------------------------------------------дата баазаас ДАТА сонгох
        public DataTable Select()
        {
            //1. Дата баазын холболт
            SqlConnection conn = new SqlConnection(myconnectionstring);
            DataTable dt = new DataTable();
            try
            {
                //2. SQL query 
                string sql = "SELECT * FROM tbl_management";
                //sql болон conn ашиглан cmd үүсгэж байна
                SqlCommand cmd = new SqlCommand(sql, conn);
                //cmd ашиглан SQLтохируулагч үүсгэж байна 
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        //-------------------------------------------------------------------Дата баазлуу дата оруулах
        public bool Insert(contact c)
        {
            //default буцаах утга үүсэж утгын false болгож байна
            bool isSuccess = false;
            //1. Дата бааз холбох
            SqlConnection conn = new SqlConnection(myconnectionstring);
            try
            {
                //2. Датаг оруулахын тулд SQL QUERY үүсгэх
                string sql = "INSERT INTO tbl_management (FirstName, LastName, ContactNo, Address, Gender) VALUES (@FirstName, @LastName, @CaontactNo, @Address, @Gender)";
                //sql болон conn ашиглан cmd үүсгэж байна
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Датагаа нэмэхийн тулд parameter үүсгэж байна
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                //Холболтоо нээх
                conn.Open() ;
                int rows = cmd.ExecuteNonQuery();
                //Query амжилттай уншсаны дараа мөрийн(row) утга 0 ээс их байна үгүй бол 0 байна
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess=false;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        //-----------------------------------------------Windows form оос ДАТА баазын утгыг өөрчлөх method()
        public bool Update(contact c)
        {
            //default буцаах утга үүсэж утгын false болгож байна
            bool isSuccess = false;
            //1. Дата бааз холбох
            SqlConnection conn = new SqlConnection(myconnectionstring);
            try
            {
                //ДАТА баазаас датаг өөрчлөх SQL
                string sql = "UPDATE tbl_management SET FirstName=@FirstName, LastName=@LastName, ContactNo=@ContactNo, Address=@Address, Gender=@Gender WHERE contactID=@contactID";
                //sql болон conn ашиглан cmd үүсгэж байна
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Датагаа нэмэхийн тулд parameter үүсгэж байна
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("ContactID", c.contactID);
                //Холболтоо нээх
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //Query амжилттай уншсаны дараа мөрийн(row) утга 0 ээс их байна үгүй бол 0 байна
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception e)
            {

            }
            finally
            {
                conn.Close() ;
            }
            return isSuccess;
        }
        //-----------------------------------------------------------Датабаазаас Датаг устгах функц
        public bool Delete(contact c)
        {
            //default буцаах утга үүсэж утгын false болгож байна
            bool isSuccess = false;
            //1. Дата бааз холбох
            SqlConnection conn = new SqlConnection(myconnectionstring);
            try
            {
                //ДАТА баазаас датаг устгах SQL
                string sql = "DELETE FROM tbl_management WHERE contactID=@contactID";
                //sql болон conn ашиглан cmd үүсгэж байна
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Датагаа нэмэхийн тулд parameter үүсгэж байна
                cmd.Parameters.AddWithValue("ContactID", c.contactID);
                //Холболтоо нээх
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //Query амжилттай уншсаны дараа мөрийн(row) утга 0 ээс их байна үгүй бол 0 байна
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;

        }
    }
}
