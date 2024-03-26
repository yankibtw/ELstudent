using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ElStudent.DB
{
    internal class Schedule
    {
        private DBConnect connect = new DBConnect("localhost", "root", "root", "elstudent");
        public List<SomeSchedule> allStudentSchedule = new List<SomeSchedule>();

        public List<SomeSchedule> SelectAllStudentShedule()
        {
            MySqlConnection connection = connect.GetConnection();
            string query = "SELECT * FROM schedule";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                try
                {
                    connection.Open();

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int id = reader.GetInt32("id");
                            int subjectId = reader.GetInt32("subject_id");
                            string startTime = reader.GetTimeSpan("start_time").ToString();
                            string endTime = reader.GetTimeSpan("end_time").ToString();

                            int groupNumber = reader.GetInt32("group_id");
                            string queryGroup = "SELECT * FROM groups WHERE id = @GroupNumber";
                            reader.Close();
                            using (MySqlCommand commandGroup = new MySqlCommand(queryGroup, connection))
                            {
                                commandGroup.Parameters.AddWithValue("@GroupNumber", groupNumber);

                                using (MySqlDataReader readerGroup = commandGroup.ExecuteReader())
                                {
                                    if (readerGroup.Read())
                                    {
                                        SessionManager sessionManager = new SessionManager();
                                        if (readerGroup.GetString("group_tag") == sessionManager.GetSessionData("group_number").Trim())
                                        {


                                            allStudentSchedule.Add(new SomeSchedule(id, subjectId.ToString(), readerGroup.GetString("group_tag"), startTime, endTime));
                                        }
                                    }
                                }
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
            return allStudentSchedule;
        }
    }

    public class SomeSchedule
    {
        public int ID { get; set; }
        public string Subject { get; set; }
        public string GroupID { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }

        public SomeSchedule(int id, string subject, string group, string start, string end)
        {
            ID = id;
            Subject = subject;
            GroupID = group;
            StartTime = start;
            EndTime = end;
        }
    }
}

