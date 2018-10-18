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
    public partial class ManageMovie : UserControl
    {
        private static ManageMovie _instance;

        public static ManageMovie Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ManageMovie();

                }
                return _instance;
            }
        }

        public ManageMovie()
        {
            InitializeComponent();
        }
    }
}
