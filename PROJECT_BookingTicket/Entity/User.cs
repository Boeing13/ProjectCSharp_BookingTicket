using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class User
    {
   
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }

        public User()
        {

        }

        public User(int userID, string username, string password, 
                string fullName, string tel, string address)
        {
            this.UserID = userID;
            this.Username = username;
            this.Password = password;
            this.FullName = fullName;
            this.Tel = tel;
            this.Address = address;
        }
    }
}
