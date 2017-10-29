using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using TSZDashboard;
using System.Data;
using System.Windows.Forms;


namespace TSZDashboard.DatabaseEntries
{
    public class Pilots
    {
        public Pilots()
        {

        }
    }

    /// <summary>
    /// Database wrapper for table utilizadores
    /// </summary>
    public class Pilot
    {

        #region propriedades
        public int ID
        {
            get;
            private set;
        }
        public string Callsign
        {
            get;
            private set;
        }
        public string Name
        {
            get;set;
        }
        public string TypeRatingName
        {
            get; set;
        }
        public DateTime Antique
        {
            get; private set;
        }
        public int PilotCallsign
        {
            get; set;
        }
        public string Email
        {
            get; set;
        }
        public int LevelId
        {
            get; set;
        }
        public string Rate
        {
            get; set;
        }
        public int Rank
        {
            get; set;
        }
        public string VatsimId
        {
            get; set;
        }
        public int ActiveAccount
        {
            get; set;
        }
        public int PilotHours
        {
            get; set;
        }
        public int PilotEps
        {
            get; set;
        }
        public int StaffLevel
        {
            get; set;
        }
        public int Hub
        {
            get; set;
        }
        public string Location
        {
            get; set;
        }
        public DateTime LastFlight
        {
            get; set;
        }
        #endregion propriedades

        #region SqlEntries
        string sqlRead = "SELECT user_id, user_nome, user_apelido, user_dataregisto, callsign, user_email, levelid, rate, rank, idvatsim, active, pilot_hours, eps, stafflevel, hub, location, date FROM `utilizadores` left join pireps on utilizadores.user_id = pireps.pilotid WHERE user_id = @ID order by date desc limit 1";
        string sqlReadCallsign = "SELECT user_id, user_nome, user_apelido, user_dataregisto, callsign, user_email, levelid, rate, rank, idvatsim, active, pilot_hours, eps, stafflevel, hub, location, date FROM `utilizadores` left join pireps on utilizadores.user_id = pireps.pilotid WHERE callsign = @Callsign order by date desc limit 1";
        string sqlUpdate = "UPDATE utilizadores set user_nome = @name, user_apelido = @surname WHERE user_id = @ID LIMIT 1";
        string sqlDelete = "DELETE FROM `utilizadores` WHERE `utilizadores`.`user_id` = @ID LIMIT 1";
        #endregion region SqlEntries

        MySqlConnection conn = new MySqlConnection(Program.ConnectionString);



        public Pilot(int ID)
        {
            this.ID = ID;       

            try
            {
                conn.Open();


                // GET FLIGHT DATA
                MySqlCommand sqlCmd = new MySqlCommand(sqlRead, conn);
                sqlCmd.Parameters.AddWithValue("@ID", ID);

                MySqlDataReader sqlCmdRes = sqlCmd.ExecuteReader();
                if (sqlCmdRes.HasRows)
                    while (sqlCmdRes.Read())
                    {
                        ID = (int)sqlCmdRes[0];
                        Name = (string)sqlCmdRes[1] +" "+ (string)sqlCmdRes[2];
                        Antique = (DateTime)sqlCmdRes[3];
                        PilotCallsign = (int)sqlCmdRes[4];
                        Email = (string)sqlCmdRes[5];
                        LevelId = (int)sqlCmdRes[6];
                        Rate = (string)sqlCmdRes[7];
                        Rank = (int)sqlCmdRes[8];
                        VatsimId = (string)sqlCmdRes[9];
                        ActiveAccount = (int)sqlCmdRes[10];
                        PilotHours = (int)sqlCmdRes[11];
                        PilotEps = (int)sqlCmdRes[12];
                        StaffLevel = (int)sqlCmdRes[13];
                        Hub = (int)sqlCmdRes[14];
                        Location = (string)sqlCmdRes[15];
                        LastFlight = (DateTime)sqlCmdRes[16];
                    }
                else
                    throw new Exception("Não encontrado o ID " + ID.ToString());
            }
            catch (Exception crap)
            {               
                // pass the exception to the caller with an usefull message
                throw new Exception("Falhou a ler o ID "+ ID.ToString(), crap);
            }
            finally
            {
                conn.Close();
            }
        }

        public Pilot(string Callsign)
        {
            this.Callsign = Callsign;

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlReadCallsign, conn);
                sqlCmd.Parameters.AddWithValue("@Callsign", Callsign);

                MySqlDataReader sqlCmdRes = sqlCmd.ExecuteReader();
                if (sqlCmdRes.HasRows)
                    while (sqlCmdRes.Read())
                    {
                        ID = (int)sqlCmdRes[0];
                        Name = (string)sqlCmdRes[1] +" "+ (string)sqlCmdRes[2];
                        Antique = (DateTime)sqlCmdRes[3];
                        PilotCallsign = (int)sqlCmdRes[4];
                        Email = (string)sqlCmdRes[5];
                        LevelId = (int)sqlCmdRes[6];
                        Rate = (string)sqlCmdRes[7];
                        Rank = (int)sqlCmdRes[8];
                        VatsimId = (string)sqlCmdRes[9];
                        ActiveAccount = (int)sqlCmdRes[10];
                        PilotHours = (int)sqlCmdRes[11];
                        PilotEps = (int)sqlCmdRes[12];
                        StaffLevel = (int)sqlCmdRes[13];
                        Hub = (int)sqlCmdRes[14];
                        Location = (string)sqlCmdRes[15];
                        LastFlight = (DateTime)sqlCmdRes[16];

                    }
                else
                    throw new Exception("Não encontrado o Callsign " + Callsign.ToString());
            }
            catch (InvalidCastException crap)
            {
                // known issue with line 194
            }
            catch (Exception crap)
            {
                // pass the exception to the caller with an usefull message

                throw new Exception("Falhou a ler o Callsign " + Callsign.ToString(), crap);
            }
            finally
            {
                conn.Close();
            }
        }



        public void Update()
        {
            //todo gravar base de dados
            try
            {
                conn.Open();
                MySqlCommand sqlCmd = new MySqlCommand(sqlUpdate, conn);
                sqlCmd.Parameters.AddWithValue("@ID", ID);

                sqlCmd.ExecuteNonQuery();
            }
            catch (Exception crap)
            {
                // pass the exception to the caller with an usefull message
                throw new Exception("Erro ao actualizar o Pilot ID " + ID, crap);
            }
            finally
            {
                conn.Close();
            }
        }
        
        public void Delete()
        {
            try
            {
                conn.Open();
                MySqlCommand sqlCmd = new MySqlCommand(sqlDelete, conn);
                sqlCmd.Parameters.AddWithValue("@ID", ID);

                sqlCmd.ExecuteNonQuery();
            }
            catch (Exception crap)
            {
                // pass the exception to the caller with an usefull message
                throw new Exception("Erro on eliminar Pilot ID " + ID, crap);
            }
            finally
            {
                conn.Close();
            }

        }

       
    }
}
