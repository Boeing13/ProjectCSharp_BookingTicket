using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;
using System.Data.SqlClient;
using System.Data;

namespace BUS
{
    
    public class UserBUS
    {
        UserDAO dao = new UserDAO();


        public DataTable ShowUser()
        {
            string query = "select u.userID, u.fullName, u.tel, u.address  from [User] u";
            DataTable dt = new DataTable();
            dt = dao.GetTable(query);
            return dt;
        }


    }
}
