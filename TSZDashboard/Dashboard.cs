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
using MySql.Data.MySqlClient;

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
            FillLogBookDataGrid();

        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FillLogBookDataGrid()
        {
            MySqlConnection conn = new MySqlConnection(Program.ConnectionString);

            try
            {
                conn.Open();

                string sqlLogbook = " select `date`, `departure`, `destination`, `pireps`.`flighttime`, `aircraft`, `ft/pm`, `sum`, `eps_granted`, `obs` from pireps left join flights on pireps.flightid = flights.idf left join utilizadores on pireps.pilotid = utilizadores.user_id where utilizadores.callsign = @Callsign";

                MySqlCommand sqlCmd = new MySqlCommand(sqlLogbook, conn);
                sqlCmd.Parameters.AddWithValue("@Callsign", txtFind.Text);

                MySqlDataAdapter mysqlDs = new MySqlDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                mysqlDs.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception crap)
            {
                MessageBox.Show(crap.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
