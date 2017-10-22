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

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {

            pilotCtrl1.Save();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            tabPilotList.SelectTab(1);
            tabProfile.SelectTab(0);
            pilotCtrl1.Update(new Pilot(txtFind.Text));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Pilot p;

            //dataGridView1.UpdateCellValue(columnIndex) = p.Callsign;

            //dataGridView1 row = dataGridView1.SelectedRow;
            //TextBox1.Text = row.RowIndex.ToString();
        }
    }
}
