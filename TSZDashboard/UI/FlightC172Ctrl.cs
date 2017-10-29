using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace TSZDashboard.UI
{
    public partial class FlightC172Ctrl : UserControl
    {

        public void Show(string Aircraft)
        {
            Show();
            FillRoutes(Aircraft);
        }

        public FlightC172Ctrl()
        {
            InitializeComponent();
        }

        public void FillRoutes(string aircraft)
        {
            MySqlConnection conn = new MySqlConnection(Program.ConnectionString);

            try
            {
                conn.Open();

                string sqlFillRoutes = " SELECT `callsign`, `departure`, `destination`, `aircraft`, `flighttime`, `qualification_need`, `qualification_need1` FROM flights WHERE aircraft = @aircraft order by departure ";

                MySqlCommand sqlCmd = new MySqlCommand(sqlFillRoutes, conn);
                sqlCmd.Parameters.AddWithValue("@aircraft", aircraft);

                MySqlDataAdapter mysqlDs = new MySqlDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                mysqlDs.Fill(ds);
                GridRoutesC172.DataSource = ds.Tables[0];

                LBL1.Text = aircraft;
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

        private void btnCloseC172_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        public void FillRoutesByDep(string Aircraft)
        {
            MySqlConnection conn = new MySqlConnection(Program.ConnectionString);
            
            try
            {
                conn.Open();

                string sqlFillRoutesByDep = " SELECT `callsign`, `departure`, `destination`, `aircraft`, `flighttime`, `qualification_need`, `qualification_need1` FROM flights WHERE aircraft = @aircraft and departure = @departure order by departure ";

                MySqlCommand sqlCmd = new MySqlCommand(sqlFillRoutesByDep, conn);
                sqlCmd.Parameters.AddWithValue("@aircraft", LBL1.Text);
                sqlCmd.Parameters.AddWithValue("@departure", txtDepIcao.Text);

                MySqlDataAdapter mysqlDs = new MySqlDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                mysqlDs.Fill(ds);
                GridRoutesC172.DataSource = ds.Tables[0];
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
        public void btnFindByDeparture_Click(object sender, EventArgs e)
        {
            FillRoutesByDep(txtDepIcao.Text);
        }    
    }
}
