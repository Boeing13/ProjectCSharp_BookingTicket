using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_BookingTicket.Entity
{
    class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Tel { get; set; }
        public string address { get; set; }

        public User()
        {

        }

        public User(int userID, string username, string password, 
                string fullName, string tel, string address)
        {
            UserID = userID;
            Username = username;
            Password = password;
            FullName = fullName;
            Tel = tel;
            this.address = address;
        }
    }
}
