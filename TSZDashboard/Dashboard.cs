using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSZDashboard.DatabaseEntries;

namespace TSZDashboard
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void pilotCtrl1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            pilotCtrl1.Save();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            pilotCtrl1.Update(new Pilot(txtFind.Text));
        }
    }
}
