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
        private Pilot p;

        public PilotCtrl()
        {
            InitializeComponent();           
        }

        public void Update(Pilot p)
        {
            this.p = p;

            txtID.Text = p.ID.ToString();
            txtName.Text = p.Name;
            txtSurname.Text = p.Surname;
        }

        public void Save()
        {
            p.Name = txtName.Text;
            p.Surname = txtSurname.Text;
            p.Update();
        }      
    }
}
