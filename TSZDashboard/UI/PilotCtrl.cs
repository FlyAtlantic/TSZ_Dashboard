using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSZDashboard.DatabaseEntries;

namespace TSZDashboard.UI
{
    public partial class PilotCtrl : UserControl
    {
        public PilotCtrl()
        {
            InitializeComponent();           
        }
        public void Update(Pilot p)
        {
            txtID.Text = p.ID.ToString();
            txtName.Text = p.Name;
        }
    }
}
