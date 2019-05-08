using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotitieApp
{
    public partial class Frm_NotitieApp : Form
    {
        public Frm_NotitieApp()
        {
            InitializeComponent();
        }

        private void Frm_NotitieApp_Load(object sender, EventArgs e)
        {
            var to = new object[] { "one", "two" };
            cmb_Employee.Items.AddRange(to);
            cmb_Employee.SelectedIndex = 0;
        }
    }
}
