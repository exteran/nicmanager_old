using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NICManager
{
    internal class DatabaseConnection
    {
        Authenticator authenticator = new Authenticator();

        public bool ConfigLoginDb()
        {
            // Checks if user has valid credentials, and then enables NICManager functionality if true
            //hashedPassword = authenticator.GetHash(password);
            MySqlConnection configConn = new MySqlConnection(Query.configConnect);
            try
            {
                configConn.Open();
                Console.WriteLine("Connection established.");
                configConn.Close();
                return true;
                /* MySqlCommand command = new MySqlCommand(Query.loginQuery, configConn);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", hashedPassword);
                Int32 match = (Int32) command.ExecuteScalar();
                if (match == 1) {
                    MessageBox.Show("Login Successful.");
                    configConn.Close();
                    return true;
                } else
                {
                    MessageBox.Show("Login Failed.");
                    configConn.Close();
                    return false;
                }*/
            }
            catch (Exception ex)
            {
                //lblStatusQuery.ForeColor = Color.Red;
                //lblStatusQuery.Text = "Could not connect to database: " + ex.Message + " Contact support.";
                //lblStatusQuery.Visible = true;
                Console.WriteLine("Connection failed.");
                return false;
            }
        }
        public bool UserLoginDb(string username, string password)
        {
            MySqlConnectionStringBuilder connectionString = new MySqlConnectionStringBuilder();
            connectionString.Server = Query.dbServer;
            connectionString.Database = Query.dbDatabase;
            connectionString.UserID = username;
            connectionString.Password = authenticator.GetHash(password);

            MySqlConnection conn = new MySqlConnection(connectionString.ToString());
            try
            {
                conn.Open();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
