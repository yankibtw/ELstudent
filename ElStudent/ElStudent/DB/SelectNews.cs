using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ElStudent.DB
{
    internal class SelectNews
    {
        private DBConnect connect = new DBConnect("localhost", "root", "root", "elstudent");
        public List<News> allNews = new List<News>();

        public List<News> SelectAllNews()
        {
            MySqlConnection connection = connect.GetConnection();
            string query = "SELECT * FROM news";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                try
                {
                    connection.Open();
                    
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string newsTitle = reader.GetString("title").Trim();
                            string description = reader.GetString("description").Trim();
                            string news_text = reader.GetString("news_text").Trim();
                            DateTime news_date = reader.GetDateTime("news_date");
                            allNews.Add(new News(newsTitle, description, news_text, news_date));
                        }
    
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Ошибка при выполнении запроса к базе данных: " + ex.Message);
                }
                finally { connection.Close(); }
            }
            return allNews;
        }
    }

    public class News
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public News(string title, string desctription, string text, DateTime date)
        {
            Title = title;
            Description = desctription;
            Text = text;
            Date = date;
        }
    }

}
