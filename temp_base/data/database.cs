using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace temp_base.data
{
    public class Database
    {
        private string loginToDb;
        private MySqlConnection connection;

        public Database()
        {
            loginToDb = @"server=localhost;userid=root;password=1234;database=temp_base";
            connection = new MySqlConnection(loginToDb);
        }

        public List<objects.Abonent> SelectAllData()
        {
            connection.Open();
            string query = "SELECT * FROM abonent";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            List<objects.Abonent> abonents = new List<objects.Abonent>();

            while (reader.Read())
            {
                int id = reader.GetInt32("id");
                string name = reader.GetString("FIO_SUBCRIBER");
                int REP = reader.GetInt32("REP");
                DateTime date = reader.GetDateTime("DATE_LAST_TRASACTION");
                double sum_amount = reader.GetDouble("SUM_AMOUTH");
                int money_fold = reader.GetInt32("money_fold");

                objects.Abonent abonent = new objects.Abonent(id, name, REP, date, sum_amount, money_fold);
                abonents.Add(abonent);
            }
            
            return abonents;
        }
    }
}
