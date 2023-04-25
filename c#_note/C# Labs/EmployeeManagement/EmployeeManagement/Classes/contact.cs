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
        //дата баазаас утга авах
        public DataTable Select()
        {
            //1. Дата бааз холболт
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
        //Дата баазлуу дата оруулах
        public bool Insert(contact c)
        {
            //default буцаах утга үүсэж утгын false болгож байна
            bool isSuccess = false;
            //1. Дата бааз холбох
            SqlConnection conn = new SqlConnection(myconnectionstring);
            try
            {

            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close ();
            }
            return isSuccess;
        }
    }
}
