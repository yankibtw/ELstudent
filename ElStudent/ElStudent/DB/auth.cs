using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ElStudent.DB
{
    internal class auth
    {
        private DBConnect connect = new DBConnect("localhost", "root", "root", "elstudent");

        public bool AuthentiticateUser(string inputLogin, string inputPassword)
        {
            MySqlConnection connection = connect.GetConnection();
            string query = "SELECT * FROM students";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    SessionManager manager = new SessionManager();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string login = reader.GetString("login").Trim();
                            string password = reader.GetString("password").Trim();

                            if (inputLogin == login && inputPassword == password)                          
                            {
                                manager.SetSessionData("id", reader.GetInt32("id").ToString().Trim());
                                manager.SetSessionData("login", login);
                                manager.SetSessionData("firstname", reader.GetString("first_name").Trim());
                                manager.SetSessionData("lastname", reader.GetString("last_name").Trim());
                                manager.SetSessionData("patronumic", reader.GetString("patronumic").Trim());
                                manager.SetSessionData("email", reader.GetString("email").Trim());
                                manager.SetSessionData("group_number", reader.GetString("group_number").Trim());
                                return true;
                            }
                        }
                        return false;
                    }
                }
                catch (MySqlException ex) {
                    MessageBox.Show("Ошибка при выполнении запроса к базе данных: " + ex.Message);
                    return false;
                }
                finally { connection.Close(); }
            }
        }
    }
}
