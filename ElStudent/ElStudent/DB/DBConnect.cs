using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElStudent.DB
{
    internal class DBConnect
    {
        private string connectionString;
        private MySqlConnection connection;

        public DBConnect(string server, string login, string password, string database)
        {
            connectionString = $"server={server};user={login};password={password};database={database}";
            connection = new MySqlConnection(connectionString);
        }
        
        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public void OpenConnection()
        {
            try
            {
                connection.Open();
            }
            catch(MySqlException e)
            {
                MessageBox.Show($"Ошибка подключения к базе данных: {e.Message}");
            }
        }
        public void CloseConnection()
        {
            try
            {
                connection.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show($"Ошибка закрытии к базе данных: {e.Message}");
            }
        }
    }
}
