﻿using System;
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
using TSZDashboard.UI;

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
            tabPilotList.SelectTab(0);
            tabProfile.SelectTab(0);
            pilotCtrl1.Update(new Pilot(txtFind.Text));
            comboTyperatingsname();
            FillLogBookDataGrid();
            FillTypeRatingskDataGrid();
            FillTypeQualificationskDataGrid();
            FillTeoricalExams();
            FillPraticalExams();
            FillTeoricalExamsAvaialable();
            btnBasicQualification_Disable();
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

        public void FillTypeQualificationskDataGrid()
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

        private void FillTeoricalExams()
        {
            MySqlConnection conn = new MySqlConnection(Program.ConnectionString);

            try
            {
                conn.Open();

                string sqlTeoricalExams = "select `ranks`.`rank`, `user_nome`, `user_apelido`, `date`, `state`, `result` from exam_results left join utilizadores on exam_results.pilotid = utilizadores.user_id LEFT JOIN exam_assigns ON exam_results.examassigned = exam_assigns.assign_id LEFT JOIN ranks ON ranks.rankid = exam_assigns.exam_id where utilizadores.callsign = @Callsign";

                MySqlCommand sqlCmd = new MySqlCommand(sqlTeoricalExams, conn);
                sqlCmd.Parameters.AddWithValue("@Callsign", txtFind.Text);

                MySqlDataAdapter mysqlDs = new MySqlDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                mysqlDs.Fill(ds);
                GridTeoricalExams.DataSource = ds.Tables[0];
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

        private void FillPraticalExams()
        {
            MySqlConnection conn = new MySqlConnection(Program.ConnectionString);

            try
            {
                conn.Open();

                string sqlPraticalExams = "select `ranks`.`rank`, `user_nome`, `user_apelido`, `date`, `name`, `result` from pratical_exams left join ranks on pratical_exams.rank = ranks.rankid left join utilizadores on pratical_exams.user_id = utilizadores.user_id left join instructors on pratical_exams.instructor = instructors.id where utilizadores.callsign = @Callsign";

                MySqlCommand sqlCmd = new MySqlCommand(sqlPraticalExams, conn);
                sqlCmd.Parameters.AddWithValue("@Callsign", txtFind.Text);

                MySqlDataAdapter mysqlDs = new MySqlDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                mysqlDs.Fill(ds);
                GridPraticalExams.DataSource = ds.Tables[0];
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

        private void FillTeoricalExamsAvaialable()
        {
            MySqlConnection conn = new MySqlConnection(Program.ConnectionString);

            try
            {
                conn.Open();

                string sqlPraticalExams = "select `ranks`.`rank`, `dateassign` from exam_assigns left join utilizadores on exam_assigns.idpilot = utilizadores.user_id left join ranks on exam_assigns.exam_id = ranks.rankid where callsign = @Callsign and avaiable = 1";

                MySqlCommand sqlCmd = new MySqlCommand(sqlPraticalExams, conn);
                sqlCmd.Parameters.AddWithValue("@Callsign", txtFind.Text);

                MySqlDataAdapter mysqlDs = new MySqlDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                mysqlDs.Fill(ds);
                GridAvaialbleTExams.DataSource = ds.Tables[0];
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

                string sqlTyperatingsname = " SELECT typeratingsname.id, typeratingsname.name FROM typeratingsname left join utilizadores on utilizadores.rank >= typeratingsname.rank left join typeratings on typeratings.typerating = typeratingsname.id and typeratings.pilot = utilizadores.user_id WHERE utilizadores.callsign = @Callsign and typeratings.id is null";

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
                FillTypeQualificationskDataGrid();
                FillTeoricalExams();
                FillPraticalExams();

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

        private void btnBasicQualification_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(Program.ConnectionString);

            try
            {
                conn.Open();
                string sqlInsertTypeRating = "INSERT INTO `qualifications` ( `qualification` , `pilot` , `validity` , `expire` ) VALUES(0, @ID, NOW() , NOW()+INTERVAL 100 YEAR)";
                MySqlCommand sqlCmd = new MySqlCommand(sqlInsertTypeRating, conn);

                sqlCmd.Parameters.AddWithValue("@ID", pilotCtrl1.PilotID);
                sqlCmd.ExecuteNonQuery();
                pilotCtrl1.Update(new Pilot(txtFind.Text));
                comboTyperatingsname();
                FillLogBookDataGrid();
                FillTypeRatingskDataGrid();
                FillTypeQualificationskDataGrid();
                FillTeoricalExams();
                FillPraticalExams();
                btnBasicQualification_Disable();

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

        private void btnBasicQualification_Disable()
        {
            string sqlCountQualification = "select Count(*) from qualifications left join utilizadores on qualifications.pilot = utilizadores.user_id where callsign = @Callsign";
            MySqlConnection conn = new MySqlConnection(Program.ConnectionString);

            try
            {
                conn.Open();
                MySqlCommand sqlCmd = new MySqlCommand(sqlCountQualification, conn);
                sqlCmd.Parameters.AddWithValue("@Callsign", txtFind.Text);

                btnBasicQualification.Enabled = (Convert.ToInt32(sqlCmd.ExecuteScalar()) == 0);

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

        public string generateID(string url_add)
        {
            long i = 1;

            foreach (byte b in Guid.NewGuid().ToByteArray())
            {
                i *= ((int)b + 1);
            }

            string number = String.Format("{0:d9}", (DateTime.Now.Ticks / 10) % 1000000000);

            return number;
        }

        private void btnFGenerateTeoricalExam_Click(object sender, EventArgs e)
        {
            object rankID = pilotCtrl1.RankId;
            int IntRankID = int.Parse(string.Format("{0}", rankID));
            int NextRating = IntRankID + 1;

            MySqlConnection conn = new MySqlConnection(Program.ConnectionString);

            try
            {
                conn.Open();
                string sqlInsertTypeRating = "INSERT INTO `exam_assigns` (`idpilot`, `exam_id`, `uid1`, `dateassign`) VALUES (@ID, @NextRating, @UID, NOW())";
                MySqlCommand sqlCmd = new MySqlCommand(sqlInsertTypeRating, conn);

                sqlCmd.Parameters.AddWithValue("@ID", pilotCtrl1.PilotID);
                sqlCmd.Parameters.AddWithValue("@NextRating", NextRating);
                sqlCmd.Parameters.AddWithValue("@UID", generateID(txtFind.Text));
                sqlCmd.ExecuteNonQuery();
                pilotCtrl1.Update(new Pilot(txtFind.Text));
                comboTyperatingsname();
                FillLogBookDataGrid();
                FillTypeRatingskDataGrid();
                FillTypeQualificationskDataGrid();
                FillTeoricalExams();
                FillPraticalExams();
                FillTeoricalExamsAvaialable();

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
