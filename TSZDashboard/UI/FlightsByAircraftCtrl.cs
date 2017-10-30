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
    public partial class FlightsByAircraftCtrl : UserControl
    {
        public FlightsByAircraftCtrl()
        {
            InitializeComponent();
            FillAllTyperatings();
            FillAllQualifications();
            flightC172Ctrl.Hide();
            comboTyperatingsname();            
        }

        public string AircraftSelected
        {
            get { return cboxAircrafts.SelectedValue.ToString(); }
        }

        public void FillAllTyperatings()
        {
            MySqlConnection conn = new MySqlConnection(Program.ConnectionString);

            try
            {
                conn.Open();

                string sqlQualifications = " select `name`, `eps`, `ranks`.`rank`, img from typeratingsname left join ranks on typeratingsname.rank = ranks.rankid";

                MySqlCommand sqlCmd = new MySqlCommand(sqlQualifications, conn);

                MySqlDataAdapter mysqlDs = new MySqlDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                mysqlDs.Fill(ds);
                GridAllTyperatings.DataSource = ds.Tables[0];
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

        public void FillAllQualifications()
        {
            MySqlConnection conn = new MySqlConnection(Program.ConnectionString);

            try
            {
                conn.Open();

                string sqlQualifications = " select `name`, `eps`, `ranks`.`rank`, img from qualificationsname left join ranks on qualificationsname.rank = ranks.rankid";

                MySqlCommand sqlCmd = new MySqlCommand(sqlQualifications, conn);

                MySqlDataAdapter mysqlDs = new MySqlDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                mysqlDs.Fill(ds);
                GridAllQualifications.DataSource = ds.Tables[0];
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

        private void btnFlightC172_Click(object sender, EventArgs e)
        {
            flightC172Ctrl.Show(AircraftSelected);
        }

        private void comboTyperatingsname()
        {
            MySqlConnection conn = new MySqlConnection(Program.ConnectionString);

            try
            {
                conn.Open();

                string sqlTyperatingsname = " SELECT typeratingsname.id, typeratingsname.name FROM typeratingsname";

                MySqlCommand sqlCmd = new MySqlCommand(sqlTyperatingsname, conn);

                MySqlDataAdapter mysqlDs = new MySqlDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                mysqlDs.Fill(ds);
                cboxAircrafts.DataSource = ds.Tables[0];
                cboxAircrafts.ValueMember = "name";
                cboxAircrafts.DisplayMember = "name";
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
