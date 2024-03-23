using System.Drawing;
using System;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;
using ElStudent.DB;
using System.Collections.Generic;
using ElStudent.Properties;
using Guna.UI2.WinForms;

namespace ElStudent.Forms
{
    public partial class Profile : Form
    {
        FontFamily fontFamily;
        private MainForm parentForm;
        public Profile(MainForm parentForm)
        {
            InitializeComponent();
            string fontPath = Path.Combine(Directory.GetParent(Application.StartupPath)?.Parent?.FullName, "Resources", "Montserrat-VariableFont_wght.ttf");

            PrivateFontCollection privateFonts = new PrivateFontCollection();
            privateFonts.AddFontFile(fontPath);
            fontFamily = privateFonts.Families[0];
            this.parentForm = parentForm;
        }
        static private SelectNews allNews = new SelectNews();
        private List<News> selectedNews = allNews.SelectAllNews();
        private void Profile_Load(object sender, EventArgs e)
        {
            SessionManager manager = new SessionManager();      

            userFullNameLabel.Text = $"{manager.GetSessionData("lastname")} {manager.GetSessionData("firstname")} {manager.GetSessionData("patronumic")}";
            idTagLabel.Text = $"{manager.GetSessionData("id")}";
            loginTagLabel.Text = $"{manager.GetSessionData("login")}";
            emailTagLabel.Text = $"{manager.GetSessionData("email")}";
            groupTagLabel.Text = $"{manager.GetSessionData("group_number")}";

            userFullNameLabel.Font = new Font(fontFamily, 26);
            idLabel.Font = new Font(fontFamily, 20);
            loginLabel.Font = new Font(fontFamily, 20);
            groupLabel.Font = new Font(fontFamily, 20);
            emailLabel.Font = new Font(fontFamily, 20);
            idTagLabel.Font = new Font(fontFamily, 20, FontStyle.Bold);
            loginTagLabel.Font = new Font(fontFamily, 20, FontStyle.Bold);
            groupTagLabel.Font = new Font(fontFamily, 20);
            emailTagLabel.Font = new Font(fontFamily, 20);
            editBtn.Font = new Font(fontFamily, 14);
            diaryLabel.Font = new Font(fontFamily, 20);
            diaryBtn.Font = new Font(fontFamily, 14);
            notesLabel.Font = new Font(fontFamily, 20);
            notesBtn.Font = new Font(fontFamily, 14);
            newsHeaderLabel.Font = new Font(fontFamily, 20);

            foreach (var news in selectedNews)
            {
                AddNewsToForm(news);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            EditPersonInfoForm editPersonInfoForm = new EditPersonInfoForm(parentForm);
            Close();
            parentForm.OpenChildForm(editPersonInfoForm);
        }

        private void notesBtn_Click(object sender, EventArgs e)
        {
            NotesForm editPersonInfoForm = new NotesForm(this);
            Close();
            parentForm.OpenChildForm(editPersonInfoForm);
        }       
        
        private void AddNewsToForm(News news)
        {
            bool isNewsDropped = false;

            Guna2Panel someNewsPanel = new Guna2Panel();
            someNewsPanel.Size = new Size(1000, 160);
            someNewsPanel.FillColor = Color.FromArgb(233, 240, 245);
            someNewsPanel.BorderColor = Color.FromArgb(222, 226, 230);
            someNewsPanel.BorderThickness = 1;
            someNewsPanel.MaximumSize = new Size(1000, 405);
            someNewsPanel.MinimumSize = new Size(1000, 160);
            someNewsPanel.BorderRadius = 5;
            someNewsPanel.Padding = new Padding(0, 0, 0, 0);


            Label newsHeaderLabel = new Label();
            newsHeaderLabel.Font = new Font(fontFamily, 20);
            newsHeaderLabel.Location = new Point(33, 18);
            newsHeaderLabel.ForeColor = Color.FromArgb(55, 103, 165);
            newsHeaderLabel.Text = news.Title;
            newsHeaderLabel.BackColor = Color.Transparent;
            newsHeaderLabel.AutoSize = true;

            Label newsDescriptionLabel = new Label();
            newsDescriptionLabel.Font = new Font(fontFamily, 16);
            newsDescriptionLabel.Location = new Point(33, 58);
            newsDescriptionLabel.ForeColor = Color.Black;
            newsDescriptionLabel.Text = news.Description;
            newsDescriptionLabel.BackColor = Color.Transparent;
            newsDescriptionLabel.AutoSize = true;

            Label newsMainTextLabel = new Label();
            newsMainTextLabel.Font = new Font(fontFamily, 14);
            newsMainTextLabel.Location = new Point(33, 126);
            newsMainTextLabel.ForeColor = Color.Black;
            newsMainTextLabel.Text = news.Text;
            newsMainTextLabel.BackColor = Color.Transparent;
            newsMainTextLabel.AutoSize = true;
            newsMainTextLabel.MaximumSize = new Size(956, 168);
            newsMainTextLabel.Visible = false;

            Guna2Panel bottomPanel = new Guna2Panel();
            bottomPanel.Size = new Size(1000, 45);
            bottomPanel.FillColor = Color.FromArgb(233, 240, 245);
            bottomPanel.BorderColor = Color.FromArgb(222, 226, 230);
            bottomPanel.BorderRadius = 5;
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Margin = new Padding(2, 2, 2, 2);

            Label newsDateLabel = new Label();
            newsDateLabel.Font = new Font(fontFamily, 12);
            newsDateLabel.Location = new Point(33, 7);
            newsDateLabel.ForeColor = Color.Black;
            newsDateLabel.Text = news.Date.ToString().Split(' ')[0];
            newsDateLabel.BackColor = Color.Transparent;
            newsDateLabel.AutoSize = true;

            Guna2Button readBtn = new Guna2Button();
            readBtn.Size = new Size(120, 35);
            readBtn.Font = new Font(fontFamily, 12);
            readBtn.Text = "Читать";
            readBtn.FillColor = Color.White;
            readBtn.ForeColor = Color.Black;
            readBtn.Location = new Point(847, 0);
            readBtn.BorderRadius = 5;

            bottomPanel.Controls.Add(newsDateLabel);
            bottomPanel.Controls.Add(readBtn);

            someNewsPanel.Controls.Add(newsHeaderLabel);
            someNewsPanel.Controls.Add(newsDescriptionLabel);
            someNewsPanel.Controls.Add(newsMainTextLabel);
            someNewsPanel.Controls.Add(bottomPanel);

            someNewsFlow.Controls.Add(someNewsPanel);
            someNewsFlow.MinimumSize = new Size(1100, selectedNews.Count * someNewsPanel.MaximumSize.Height + 190);

            Timer newsTimer = new Timer();
            newsTimer.Interval = 1;
            newsTimer.Tick += new EventHandler(newsTimer_Tick);

            void newsTimer_Tick(object sender, EventArgs e)
            {
                if (!isNewsDropped)
                {
                    someNewsPanel.Height += 10;
                    if (someNewsPanel.Size == someNewsPanel.MaximumSize)
                    { 
                        newsTimer.Stop();
                        newsMainTextLabel.Visible = true;
                        readBtn.Text = "Скрыть";
                        isNewsDropped = true;
                    }
                }
                else
                {
                    someNewsPanel.Height -= 10;
                    if (someNewsPanel.Size == someNewsPanel.MinimumSize)
                    {
                        newsTimer.Stop();
                        newsMainTextLabel.Visible = false;
                        readBtn.Text = "Читать";
                        isNewsDropped = false;
                    }
                }
            }

            void readBtn_Click(object sender, EventArgs e)
            {
                newsTimer.Start();
            }
            readBtn.Click += new EventHandler(readBtn_Click);
        }
    }
}
