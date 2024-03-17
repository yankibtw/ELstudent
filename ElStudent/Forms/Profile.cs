using System.Drawing;
using System;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;

namespace ElStudent.Forms
{
    public partial class Profile : Form
    {
        FontFamily fontFamily;
        private bool isNewsDropped = false; 
        public Profile()
        {
            InitializeComponent();
            string fontPath = Path.Combine(Directory.GetParent(Application.StartupPath)?.Parent?.FullName, "Resources", "Montserrat-VariableFont_wght.ttf");

            PrivateFontCollection privateFonts = new PrivateFontCollection();
            privateFonts.AddFontFile(fontPath);
            fontFamily = privateFonts.Families[0];
        }
        private void Profile_Load(object sender, EventArgs e)
        {
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
            newsLabel.Font = new Font(fontFamily, 20);
            newsHeadingLabel.Font = new Font(fontFamily, 16);
            newsDescritionLabel.Font = new Font(fontFamily, 12);
            newsDateLabel.Font = new Font(fontFamily, 10);
            readNewsBtn.Font = new Font(fontFamily, 10);
            newsMainTextLabel.Font = new Font(fontFamily, 14);
        }
        private void newsTimer_Tick(object sender, EventArgs e)
        {
            if (!isNewsDropped)
            {
                someNewsPanel.Height += 10;
                if (someNewsPanel.Size == someNewsPanel.MaximumSize)
                {
                    newsTimer.Stop();
                    newsMainTextLabel.Visible = true;
                    readNewsBtn.Text = "Скрыть";
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
                    readNewsBtn.Text = "Читать";
                    isNewsDropped = false;
                }
            }

        }
        private void readNewsBtn_Click(object sender, EventArgs e)
        {
            newsTimer.Start();
        }

        //Еще надо будет добавить автоматическое изменение размера newsPanel когда уже будут подгружаться новости из БД.
    }
}
