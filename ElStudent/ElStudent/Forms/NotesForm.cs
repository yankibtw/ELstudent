using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using ElStudent.DB;
using MySql.Data.MySqlClient;

namespace ElStudent.Forms
{
    public partial class NotesForm : Form
    {
        FontFamily fontFamily;
        private Profile parentForm;
        private bool isActive = true;
        private int currentNoteId;

        public NotesForm(Profile parentForm)
        {
            InitializeComponent();
            string fontPath = Path.Combine(Directory.GetParent(Application.StartupPath)?.Parent?.FullName, "Resources", "Montserrat-VariableFont_wght.ttf");

            PrivateFontCollection privateFonts = new PrivateFontCollection();
            privateFonts.AddFontFile(fontPath);
            fontFamily = privateFonts.Families[0];
            this.parentForm = parentForm;
        }
        private void NotesForm_Load(object sender, EventArgs e)
        {
            titleMenuLabel.Font = new Font(fontFamily, 18);
            someTitleLabel.Font = new Font(fontFamily, 18);
            someNoteText.Font = new Font(fontFamily, 14);
            saveBtn.Font = new Font(fontFamily, 16);

            List<Note> selectedNotes = new SelectNotes().SelectAllStudentNotes();
            foreach (var note in selectedNotes)
            {
                AddNoteToForm(note);
            }
        }
        private void AddNoteToForm(Note note)
        {
            if (isActive)
            {
                someTitleLabel.Text = note.Title;
                someNoteText.Text = note.Text;
            }

            Guna2Button notePanel = new Guna2Button();
            notePanel.Size = new Size(420, 65);
            notePanel.FillColor = isActive ? Color.FromArgb(4, 87, 114) : Color.FromArgb(255, 255, 255); ;
            notePanel.ForeColor = isActive ? Color.FromArgb(255, 255, 255) : Color.FromArgb(0, 0, 0); ;
            notePanel.Text = note.Title;
            notePanel.Font = new Font(fontFamily, 14);
            notePanel.BorderRadius = 5;
            notePanel.Margin = new Padding(0, 0, 0, 0);
            notePanel.Click += new EventHandler(notesBtn_Click);
            isActive = false;

            void notesBtn_Click(object sender, EventArgs e)
            {
                Guna2Button activeBtn = (Guna2Button)sender;
                someTitleLabel.Text = note.Title;
                someNoteText.Text = note.Text;

                isActive = !isActive;

                foreach (Control control in notesFlowPanel.Controls)
                {
                    if (control is Guna2Button button)
                    {
                        if (button == activeBtn)
                        {
                            button.FillColor = Color.FromArgb(4, 87, 114);
                            button.ForeColor = Color.White;
                            currentNoteId = note.Id;
                        }
                        else
                        {
                            button.FillColor = Color.FromArgb(255, 255, 255);
                            button.ForeColor = Color.Black;
                        }
                        
                    }
                }
            }
            notesFlowPanel.Controls.Add(notePanel);
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            UpdateInDatabase(new SessionManager().GetSessionData("id"), someNoteText.Text, currentNoteId);
        }   
        private void UpdateInDatabase(string user_id, string newText, int id)
        {
            // Строка подключения к вашей базе данных MySQL
            string connectionString = "server=localhost;database=elstudent;uid=root;password=root";

            // SQL-запрос для обновления данных
            string query = "UPDATE student_notes SET note_text = @RichTextData WHERE student_id = @user_id AND id = @id";

            // Создание подключения к базе данных
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Открытие соединения
                connection.Open();

                // Создание команды с параметрами
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Добавление параметров для данных из RichTextBox и идентификатора записи
                    command.Parameters.AddWithValue("@RichTextData", newText);
                    command.Parameters.AddWithValue("@user_id", user_id);
                    command.Parameters.AddWithValue("@Id", id);

                    try
                    {
                        // Выполнение команды на обновление данных
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Данные успешно обновлены в базе данных.");
                        }
                        else
                        {
                            MessageBox.Show("Ошибка при обновлении данных: запись с указанным идентификатором не найдена.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при обновлении данных в базе данных: " + ex.Message);
                    }
                }
            }
        }
    }
}
