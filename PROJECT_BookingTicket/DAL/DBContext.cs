using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace PROJECT_BookingTicket
{
    class DBContext
    {
        public static SqlConnection getConnection()
        {
            return new SqlConnection(
                ConfigurationManager.ConnectionStrings["BookingTicket"].ConnectionString);
        }
    }
}
