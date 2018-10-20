
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Entity;

namespace DAL
{
    public class UserDAO : DBContext
    {
        DataTable dt = new DataTable();
        

        public UserDAO(DataTable dt)
        {
          
           
        }

        public UserDAO()
        {
        }

        public DataTable GetTable(string query)
        {

            SqlConnection conn = DBContext.getConnection();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;


        }

        public void ExecuteNoneQuery(string query)
        {
            SqlConnection conn = DBContext.getConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            
        }

        public bool Insert(User user)
        {
            try
            {
                SqlConnection conn = DBContext.getConnection();
                string query = "select u.userID, u.fullName, u.tel, u.[address]  from [User] u";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataRow r = dt.NewRow();
                r["userID"] = user.UserID;
                r["fullName"] = user.FullName;
                r["tel"] = user.Tel;
                r["address"] = user.Address;
                dt.Rows.Add(r);

                SqlCommandBuilder cm = new SqlCommandBuilder(da);
                da.Update(dt);

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete(int userID)
        {
            try
            {
                SqlConnection conn = DBContext.getConnection();
                string str = "select u.userID, u.fullName, u.tel, u.[address]  from [User] u";
                SqlDataAdapter da = new SqlDataAdapter(str, conn);
                DataRow r = dt.Rows.Find(userID);
                if(r != null)
                {
                    r.Delete();
                }
                SqlCommandBuilder cm = new SqlCommandBuilder(da);
                da.Update(dt);

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        
    }
}
