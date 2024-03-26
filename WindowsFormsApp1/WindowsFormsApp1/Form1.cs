using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=Database1.mdf;Initial Catalog=Table;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM Table", connection);
                    Console.WriteLine("Соединение установлено успешно!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка при подключении к базе данных: " + ex.Message);
                }
            }
        }
    }
}
