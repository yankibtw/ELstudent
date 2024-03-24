using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElStudent.DB
{
    internal class SelectNotes
    {
        private DBConnect connect = new DBConnect("localhost", "root", "root", "elstudent");
        public List<Note> allStudentNote = new List<Note>();

        public List<Note> SelectAllStudentNotes()
        {
            MySqlConnection connection = connect.GetConnection();
            string query = "SELECT * FROM student_notes";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                try
                {
                    connection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("id");
                            int studentId = reader.GetInt32("student_id"); 
                            string noteTitle = reader.GetString("note_title").Trim();
                            string noteText = reader.GetString("note_text").Trim();
                            DateTime noteDate = reader.GetDateTime("note_date");
                            SessionManager sessionManager = new SessionManager();
                            if (studentId.ToString() == sessionManager.GetSessionData("id").Trim())
                            {
                                allStudentNote.Add(new Note(id, noteTitle, noteText, noteDate));
                            }
                        }

                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Ошибка при выполнении запроса к базе данных: " + ex.Message);
                }
                finally { connection.Close(); }
            }
            return allStudentNote;
        }
    }

    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public Note(int id, string title, string text, DateTime date)
        {
            Id = id;
            Title = title;
            Text = text;
            Date = date;
        }
    }
}

