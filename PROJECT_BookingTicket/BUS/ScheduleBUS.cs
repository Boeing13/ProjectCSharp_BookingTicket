using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace BUS
{
    public class ScheduleBUS
    {
        ScheduleDAO dao = new ScheduleDAO();

        public DataTable SelectAll()
        {
            string query = "select r.name, h.time, m.title, s.date, s.leftSeat  from Schedule s " +
                             " inner join Room r on s.roomID = r.roomID " +
                             " inner join Movie m on s.movieID = m.movieID " +
                             " inner join[Hour] h on s.hourID = h.hourID ";
            DataTable dt = new DataTable();
            dt = dao.GetTable(query);
            return dt;
        }
    }
}
