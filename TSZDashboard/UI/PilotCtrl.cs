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
using MySql.Data.MySqlClient;

namespace TSZDashboard.UI
{
    public partial class PilotCtrl : UserControl
    {
        private Pilot p;

        public int PilotID
        {
            get
            {
                return Convert.ToInt32(txtID.Text);
            }
        }

        public string PilotName
        {
            get { return txtName.Text; }
        }

        public PilotCtrl()
        {
            InitializeComponent();
        }

        #region ComboBoxs
        public void comboHubs()
        {
            MySqlConnection conn = new MySqlConnection(Program.ConnectionString);

            try
            {
                conn.Open();

                string sqlPilotHub = " SELECT hubs.id, hubs.icao FROM hubs left join utilizadores on utilizadores.hub = hubs.id WHERE utilizadores.callsign = @Callsign";

                MySqlCommand sqlCmd = new MySqlCommand(sqlPilotHub, conn);
                sqlCmd.Parameters.AddWithValue("@Callsign", txtCallsign.Text);

                MySqlDataAdapter mysqlDs = new MySqlDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                mysqlDs.Fill(ds);
                cboxHub.DataSource = ds.Tables[0];
                cboxHub.ValueMember = "id";
                cboxHub.DisplayMember = "icao";
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

        public void comboLeveiId()
        {
            MySqlConnection conn = new MySqlConnection(Program.ConnectionString);

            try
            {
                conn.Open();

                string sqlLevelId = "SELECT utilizadores.levelid, user_level.name FROM utilizadores left join user_level on utilizadores.levelid  = user_level.levelid WHERE utilizadores.callsign = @Callsign";

                MySqlCommand sqlCmd = new MySqlCommand(sqlLevelId, conn);
                sqlCmd.Parameters.AddWithValue("@Callsign", txtCallsign.Text);

                MySqlDataAdapter mysqlDs = new MySqlDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                mysqlDs.Fill(ds);
                cboxLevelId.DataSource = ds.Tables[0];
                cboxLevelId.ValueMember = "levelid";
                cboxLevelId.DisplayMember = "name";
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

        public void comboRate()
        {
            MySqlConnection conn = new MySqlConnection(Program.ConnectionString);

            try
            {
                conn.Open();

                string sqlRate = "SELECT utilizadores.rate, ratings.ratingname FROM utilizadores left join ratings on utilizadores.rate  = ratings.id WHERE utilizadores.callsign = @Callsign";

                MySqlCommand sqlCmd = new MySqlCommand(sqlRate, conn);
                sqlCmd.Parameters.AddWithValue("@Callsign", txtCallsign.Text);

                MySqlDataAdapter mysqlDs = new MySqlDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                mysqlDs.Fill(ds);
                cboxRate.DataSource = ds.Tables[0];
                cboxRate.ValueMember = "rate";
                cboxRate.DisplayMember = "ratingname";
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

        public void comboRank()
        {
            MySqlConnection conn = new MySqlConnection(Program.ConnectionString);

            try
            {
                conn.Open();

                string sqlRank = "SELECT utilizadores.rank, ranks.rank FROM utilizadores left join ranks on utilizadores.rank  = ranks.rankid WHERE utilizadores.callsign = @Callsign";

                MySqlCommand sqlCmd = new MySqlCommand(sqlRank, conn);
                sqlCmd.Parameters.AddWithValue("@Callsign", txtCallsign.Text);

                MySqlDataAdapter mysqlDs = new MySqlDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                mysqlDs.Fill(ds);
                cboxRank.DataSource = ds.Tables[0];
                cboxRank.ValueMember = "rank";
                cboxRank.DisplayMember = "rank";
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

        public void comboStaffLevel()
        {
            MySqlConnection conn = new MySqlConnection(Program.ConnectionString);

            try
            {
                conn.Open();

                string sqlStaffLevel = "SELECT utilizadores.stafflevel, adminlevel.name FROM utilizadores left join adminlevel on utilizadores.stafflevel  = adminlevel.level WHERE utilizadores.callsign = @Callsign";

                MySqlCommand sqlCmd = new MySqlCommand(sqlStaffLevel, conn);
                sqlCmd.Parameters.AddWithValue("@Callsign", txtCallsign.Text);

                MySqlDataAdapter mysqlDs = new MySqlDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                mysqlDs.Fill(ds);
                cboxStaffLevel.DataSource = ds.Tables[0];
                cboxStaffLevel.ValueMember = "stafflevel";
                cboxStaffLevel.DisplayMember = "name";
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

        #endregion ComboBoxs


        public void Update(Pilot p)
        {
            this.p = p;

            txtID.Text = p.ID.ToString();
            txtName.Text = p.Name;
            txtSurname.Text = p.Surname;
            txtAntique.Text = p.Antique.ToString();
            txtCallsign.Text = p.PilotCallsign.ToString();
            txtEmail.Text = p.Email.ToString();
            txtVatsimId.Text = p.VatsimId;
            if (p.ActiveAccount == 1)
            {
                lblActive.Text = String.Format("Account Active");
            }
            else
            {
                lblActive.Text = String.Format("Account Inactive");
            }
            txtHour.Text = p.PilotHours.ToString();
            txtEPS.Text = p.PilotEps.ToString();
            txtLocation.Text = p.Location;
            txtLastFlight.Text = p.LastFlight.ToString();
            comboHubs();
            comboLeveiId();
            comboRate();
            comboRank();
            comboStaffLevel();
        }

        public void Save()
        {
            p.Name = txtName.Text;
            p.Surname = txtSurname.Text;
            p.Update();
        }
    }
}
