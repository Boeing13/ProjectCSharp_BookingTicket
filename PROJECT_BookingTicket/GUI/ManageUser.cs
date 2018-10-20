using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using Entity;


namespace GUI
{
    public partial class ManageUser : UserControl
    {
        UserBUS ub = new UserBUS();

        public ManageUser()
        {
            InitializeComponent();
            
            
        }

        private void ManageUser_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            ub.ShowUser();
            dgvUsers.DataSource = dt;
            
        }
    }
}
