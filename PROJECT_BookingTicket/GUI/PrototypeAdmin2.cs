using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class PrototypeAdmin2 : Form
    {
        public PrototypeAdmin2()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnCustomer.Height;
            SidePanel.Top = btnCustomer.Top;
            manageUser1.BringToFront();
        }

        private void btnMovie_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnMovie.Height;
            SidePanel.Top = btnMovie.Top;
            manageMovie1.BringToFront();
        }
    }
}
