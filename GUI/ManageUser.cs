using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_BookingTicket
{
    public partial class ManageUser : UserControl
    {
       
        private static ManageUser _instance;
        
        public static ManageUser Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ManageUser();

                }
                return _instance;
            }
        }

        public ManageUser()
        {
            InitializeComponent();
        }
    }
}
