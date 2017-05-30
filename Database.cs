/* 
 * Database.cs
 * Deals with anything related to the database, such as connecting, sending and receivinng queries.
 * 
 */
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System;
using System.Data;
using System.Linq;

namespace FinalProject
{
    static class Database
    {

        private static MySqlConnection databaseConnection;

        // Connect to database - the datasource is my home computer's local database with a portforwarded to 3306
        public static void ConnectToDatabase()
        {
            string sConnect;
            sConnect = "datasource=[REMOVED];port=[REMOVED];username=[REMOVED];password=[REMOVED];database=clients;";
            databaseConnection = new MySqlConnection(sConnect);
            databaseConnection.Open();  

        }

        public static void CloseDatabase()
        {
            databaseConnection.Close();

        }

        // Everytime we launch the project, we have a general overview of all the data. This function deals with updating the overview when the program is launched
        public static void UpdateOverview(ref LinkLabel latestClients, ref Label clientAmount)
        {
            string sql = "SELECT * FROM clients WHERE id=(SELECT MAX(id) FROM clients)";
            MySqlCommand commandDatabase;
            MySqlDataReader overviewReader;

            commandDatabase = new MySqlCommand(sql, databaseConnection);
            overviewReader = commandDatabase.ExecuteReader();

            // In case we want to get more than one result when calling the database, we use ExecuteReader() in a loop (it will only go inside the loop if overviewReader is not null)
            while (overviewReader.Read())
            {
                latestClients.Text = overviewReader.GetString("first_name") + " " + overviewReader.GetString("last_name");
            }
            // We must close this reader to be able to open up a new reader in the same function
            overviewReader.Close();

           clientAmount.Text = GetQuery("SELECT COUNT(*) FROM clients");

        }
        // Get string when sending a query for data to the database
        public static string GetQuery(string query)
        {
            // We use the using() method because it clears any data about the command we just used after usage
            // ExecuteScalar will return one result unless specified otherwise
            string queryReader;
            using (MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection))
            {
                queryReader = commandDatabase.ExecuteScalar().ToString();
            }
            
            return queryReader;

        }
        //Get multiple queries as array
        public static DataRow[] GetQueries(string query)
        {
            // DataTable stores columns and rows of data (giving us a 2d array)
            DataTable dt = new DataTable();
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            var queryReader = commandDatabase.ExecuteReader();
            // Using LINQ, we can turn the Enumerable to an array
            dt.Load(queryReader);

            queryReader.Close();
            return dt.AsEnumerable().ToArray();
        }

        // Send a query to the database
        public static void SendQuery(string query)
        {
            using (MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection))
            {
                commandDatabase.ExecuteNonQuery();
            }
        }

        //Check if the provided ID can be found in the database
        public static Boolean DoesIDExist(int id)
        {
            string query = "SELECT * FROM clients WHERE id=\"" + id + "\"";
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            using (var reader = commandDatabase.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    return true;
                }
            }
            return false;
        }

        public static Boolean TableContainsData()
        {
            string sql = "SELECT 1 FROM clients LIMIT 1";
            MySqlCommand commandDatabase;
            MySqlDataReader overviewReader;

            commandDatabase = new MySqlCommand(sql, databaseConnection);
            overviewReader = commandDatabase.ExecuteReader();

            // If it's reading something, then the table is not empty
            while (overviewReader.Read())
            {
                overviewReader.Close();
                return true;
            }
            overviewReader.Close();
            return false;
        }

        public static bool ClearDatabase()
        {
            DialogResult result = MessageBox.Show("You are about to clear ALL Database data, are you sure?", "Clear Database", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Database.ConnectToDatabase();
                Database.SendQuery("TRUNCATE TABLE clients");
                Database.CloseDatabase();
                return true;
            }
            return false;
        }

        internal static bool DoesIDExist(bool v)
        {
            throw new NotImplementedException();
        }
    }
}
