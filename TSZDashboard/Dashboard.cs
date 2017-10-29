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

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {

            pilotCtrl1.Save();
        }


        private void btnFind_Click(object sender, EventArgs e)
        {
            tabPilotList.SelectTab(1);
            tabProfile.SelectTab(0);
            pilotCtrl1.Update(new Pilot(txtFind.Text));
            comboTyperatingsname();
            FillLogBookDataGrid();
            FillTypeRatingskDataGrid();
            FillTypeQualificationskDataGrid();

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

        private void FillTypeRatingskDataGrid()
        {
            MySqlConnection conn = new MySqlConnection(Program.ConnectionString);

            try
            {
                conn.Open();

                string sqlTypeRatings = " select `name`, `user_nome`, `user_apelido`, `validity`, `expire` from typeratings left join typeratingsname on typeratings.typerating = typeratingsname.id left join utilizadores on typeratings.pilot = utilizadores.user_id where utilizadores.callsign = @Callsign";

                MySqlCommand sqlCmd = new MySqlCommand(sqlTypeRatings, conn);
                sqlCmd.Parameters.AddWithValue("@Callsign", txtFind.Text);

                MySqlDataAdapter mysqlDs = new MySqlDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                mysqlDs.Fill(ds);
                GridTypeRatings.DataSource = ds.Tables[0];
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

        private void FillTypeQualificationskDataGrid()
        {
            MySqlConnection conn = new MySqlConnection(Program.ConnectionString);

            try
            {
                conn.Open();

                string sqlQualifications = " select `name`, `user_nome`, `user_apelido`, `validity`, `expire` from qualifications left join qualificationsname on qualifications.qualification = qualificationsname.id left join utilizadores on qualifications.pilot = utilizadores.user_id where utilizadores.callsign = @Callsign";

                MySqlCommand sqlCmd = new MySqlCommand(sqlQualifications, conn);
                sqlCmd.Parameters.AddWithValue("@Callsign", txtFind.Text);

                MySqlDataAdapter mysqlDs = new MySqlDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                mysqlDs.Fill(ds);
                GridQualificatioms.DataSource = ds.Tables[0];
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

        private void comboTyperatingsname()
        {
            MySqlConnection conn = new MySqlConnection(Program.ConnectionString);

            try
            {
                conn.Open();

                string sqlTyperatingsname = " SELECT typeratingsname.id, typeratingsname.name FROM typeratingsname left join utilizadores on utilizadores.rate >= typeratingsname.rank left join typeratings on typeratings.typerating = typeratingsname.id and typeratings.pilot = utilizadores.user_id WHERE utilizadores.callsign = @Callsign and typeratings.id is null";

                MySqlCommand sqlCmd = new MySqlCommand(sqlTyperatingsname, conn);
                sqlCmd.Parameters.AddWithValue("@Callsign", txtFind.Text);

                MySqlDataAdapter mysqlDs = new MySqlDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                mysqlDs.Fill(ds);
                cboxTyperatingsname.DataSource = ds.Tables[0];
                cboxTyperatingsname.ValueMember = "id";
                cboxTyperatingsname.DisplayMember = "name";
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

        private void btnInsertTyperating_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(Program.ConnectionString);

            try
            {
                conn.Open();
                string sqlInsertTypeRating = "INSERT INTO `typeratings` ( `typerating` , `pilot` , `validity` , `expire` ) VALUES(@TypeRating, @ID, NOW() , NOW()+INTERVAL 3 MONTH)";
                MySqlCommand sqlCmd = new MySqlCommand(sqlInsertTypeRating, conn);

                sqlCmd.Parameters.AddWithValue("@TypeRating", (int)cboxTyperatingsname.SelectedValue);
                sqlCmd.Parameters.AddWithValue("@ID", pilotCtrl1.PilotID);
                sqlCmd.ExecuteNonQuery();
                pilotCtrl1.Update(new Pilot(txtFind.Text));
                comboTyperatingsname();
                FillLogBookDataGrid();
                FillTypeRatingskDataGrid();

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
