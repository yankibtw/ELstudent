using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ElStudent.DB
{
    internal class auth
    {
        private DBConnect connect = new DBConnect("localhost", "root", "root", "elstudent");

        public bool AuthenticateUser(string inputLogin, string inputPassword)
        {
            MySqlConnection connection = connect.GetConnection();
            string query = "SELECT * FROM students WHERE login = @Login AND password = @Password";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Login", inputLogin);
                command.Parameters.AddWithValue("@Password", inputPassword);

                try
                {
                    connection.Open();
                    SessionManager manager = new SessionManager();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            manager.SetSessionData("id", reader.GetInt32("id").ToString().Trim());
                            manager.SetSessionData("login", inputLogin);
                            manager.SetSessionData("firstname", reader.GetString("first_name").Trim());
                            manager.SetSessionData("lastname", reader.GetString("last_name").Trim());
                            manager.SetSessionData("patronymic", reader.GetString("patronymic").Trim());
                            manager.SetSessionData("email", reader.GetString("email").Trim());

                            int groupNumber = reader.GetInt32("group_number");
                            string queryGroup = "SELECT * FROM groups WHERE id = @GroupNumber";
                            reader.Close();
                            using (MySqlCommand commandGroup = new MySqlCommand(queryGroup, connection))
                            {
                                commandGroup.Parameters.AddWithValue("@GroupNumber", groupNumber);

                                using (MySqlDataReader readerGroup = commandGroup.ExecuteReader())
                                {
                                    if (readerGroup.Read())
                                    {
                                        manager.SetSessionData("group_number", readerGroup.GetString("group_tag"));
                                    }
                                }
                            }

                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Ошибка при выполнении запроса к базе данных: " + ex.Message);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
