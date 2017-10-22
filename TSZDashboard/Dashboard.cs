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

            Pilot p = new Pilot(5);

            pilotCtrl1.Update(p);

        }

        private void pilotCtrl1_Load(object sender, EventArgs e)
        {

        }
    }
}
