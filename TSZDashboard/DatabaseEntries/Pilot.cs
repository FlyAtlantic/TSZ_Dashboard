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
        public string Surname
        {
            get; set;
        }
        #endregion propriedades

        #region SqlEntries
        string sqlRead = "SELECT user_nome, user_apelido, callsign FROM `utilizadores` WHERE user_id = @ID";
        string sqlReadCallsign = "SELECT user_id, user_nome, user_apelido FROM `utilizadores` WHERE callsign = @Callsign";
        string sqlUpdate = "UPDATE utilizadores set user_nome = @name, user_apelido = @surname WHERE user_id = @ID LIMIT 1";
        string sqlDelete = "DELETE FROM `utilizadores` WHERE `utilizadores`.`user_id` = @ID LIMIT 1";
        string sqlLogbook = "SELECT * FROM pireps WHERE pilot_id=@ID";
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
                        Name = (string)sqlCmdRes[0];
                        Surname = (string)sqlCmdRes[1];
                        Callsign = (string)sqlCmdRes[2];
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
                        Name = (string)sqlCmdRes[1];
                        Surname = (string)sqlCmdRes[2];
                    }
                else
                    throw new Exception("Não encontrado o Callsign " + Callsign.ToString());
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
                sqlCmd.Parameters.AddWithValue("@name", Name);
                sqlCmd.Parameters.AddWithValue("@surname", Surname);

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
