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
namespace GUI
{
    public partial class ManageSchedule : UserControl
    {
        ScheduleBUS sb = new ScheduleBUS();

        public ManageSchedule()
        {
            InitializeComponent();
        }

        private void ManageSchedule_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = sb.SelectAll();
                dgvSchedule.DataSource = dt;
            }
            catch (Exception)
            {

            }
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            AddSchedule add = new AddSchedule();
            add.Show();
        }
    }
}
