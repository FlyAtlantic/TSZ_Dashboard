using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using TSZDashboard;

namespace TSZDashboard.DatabaseEntries
{
    public class Pilot
    {

        #region propriedades
        public int ID
        {
            get;
            private set;
        }
        public string Name
        {
            get;set;
        }
        #endregion propriedades

        private static string ConnectionString
        {
            get
            {
                return String.Format(
                    "server={0};uid={1};pwd={2};database={3};;Connection Timeout=60",
                    Properties.Settings.Default.Server,
                    Properties.Settings.Default.Dbuser,
                    Properties.Settings.Default.Dbpass,
                    Properties.Settings.Default.Database);
            }
        }

        string sqlRead = "SELECT user_nome FROM `utilizadores` WHERE user_id = @ID";

        public Pilot(int ID)
        {
            this.ID = ID;
          
            MySqlConnection conn = new MySqlConnection(ConnectionString);

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

        public void Update()
        {
            //todo gravar base de dados
        }
        
        public void Delete()
        {
            // todo apagar da base de dados
        }
        
    }
}
