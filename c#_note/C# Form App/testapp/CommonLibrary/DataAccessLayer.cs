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
   public partial class DataAccessLayer
    {
        private string constring = ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString;
        #region энд AppUserTable -д хамаатай method -ууд байна
        public DataTable CheckUserTable(int UserTypeID, string UserName)
        {
            SqlConnection mycon = new SqlConnection();
            mycon.ConnectionString = constring;
            SqlCommand mycmd = new SqlCommand();
            mycmd.Connection = mycon;
            mycmd.CommandText = "CheckUserDavhatsal";
            mycmd.CommandType = CommandType.StoredProcedure;
            mycmd.Parameters.AddWithValue("@UserTypeID", UserTypeID);
            mycmd.Parameters.AddWithValue("@UserName", UserName);
            DataTable mytable = new DataTable();
            try
            {
                mycon.Open();
                SqlDataReader myreader = mycmd.ExecuteReader();
                mytable.Load(myreader);
            }
            catch(Exception aldaa)
            {
                throw new Exception(aldaa.Message);
            }
            finally
            {
                mycon.Close();
            }
            return mytable;
        }
        #endregion
    }
    public abstract class DataAccessLayerThree
    {
        public abstract DataTable Checklogin(int UTypeID, string Uname, string Upass);
       
    }

    public class DatatAccessLayerFour: DataAccessLayerThree
    {
        public override DataTable Checklogin(int UTypeID, string Uname, string Upass)
        {
            SqlConnection mycon = new SqlConnection();
            mycon.ConnectionString = ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString;
            SqlCommand mycmd = new SqlCommand();
            mycmd.Connection = mycon;
            mycmd.CommandText = "SelectLogin";
            mycmd.CommandType = CommandType.StoredProcedure;
            mycmd.Parameters.AddWithValue("@UserTypeID", UTypeID);
            mycmd.Parameters.AddWithValue("@UserName", Uname);
            mycmd.Parameters.AddWithValue("@UserPass", Upass);
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
    }
}
