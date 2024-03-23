using ElStudent.DB;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace ElStudent.Forms
{
    public partial class MainForm : Form
    {
        private elStudentForm elStudentForm;
        FontFamily fontFamily;
        private Form currentChildForm;
        private bool isMenuOpened = false;
        public MainForm(elStudentForm elStudentForm)
        {
            InitializeComponent();
            this.elStudentForm = elStudentForm;

            string fontPath = Path.Combine(Directory.GetParent(Application.StartupPath)?.Parent?.FullName, "Resources", "Montserrat-VariableFont_wght.ttf");

            PrivateFontCollection privateFonts = new PrivateFontCollection();
            privateFonts.AddFontFile(fontPath);
            fontFamily = privateFonts.Families[0];
        }

        private void Main_Load(object sender, EventArgs e)
        {
            SessionManager manager = new SessionManager();
            usernameHeaderLabel.Text = $"{manager.GetSessionData("firstname")} {manager.GetSessionData("lastname")}";
            menuLabel.Font = new Font(fontFamily, 18);
            usernameHeaderLabel.Font = new Font(fontFamily, 18);
            personalKabinetBtn.Font = new Font(fontFamily, 14);
            diaryBtn.Font = new Font(fontFamily, 14);
            notesBtn.Font = new Font(fontFamily, 14);
            messageBtn.Font = new Font(fontFamily, 14);
            exitBtn.Font = new Font(fontFamily, 14);
            OpenChildForm(new Profile(this));
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public void OpenChildForm(Form childForm)
        {
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            CheckIsMenuOpened();
        }
        private void CheckIsMenuOpened()
        {
            if (!isMenuOpened)
            {
                mainMenuBtn.Image = Properties.Resources.closeIcon;
                menuLabel.Text = "Закрыть";
                menuPanel.Visible = true;
                isMenuOpened = true;
            }
            else
            {
                mainMenuBtn.Image = Properties.Resources.menu;
                menuLabel.Text = "Меню";
                menuPanel.Visible = false;
                isMenuOpened = false;

            }
        }

        private void personalKabinetBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Profile(this));
            CheckIsMenuOpened();
        }
    }
}
