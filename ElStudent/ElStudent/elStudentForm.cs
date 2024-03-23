using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
using ElStudent.DB;
using ElStudent.Forms;

namespace ElStudent
{
    public partial class elStudentForm : Form
    {
        FontFamily fontFamily;
        public elStudentForm()
        {
            InitializeComponent();

            string fontPath = Path.Combine(Directory.GetParent(Application.StartupPath)?.Parent?.FullName, "Resources", "Montserrat-VariableFont_wght.ttf");

            PrivateFontCollection privateFonts = new PrivateFontCollection();
            privateFonts.AddFontFile(fontPath);
            fontFamily = privateFonts.Families[0];
        }

        private void elStudentForm_Load(object sender, EventArgs e)
        {
            elStudentLabel.Font = new Font(fontFamily, 20);
            regHeaderText.Font = new Font(fontFamily, 25);
            loginLabel.Font = new Font(fontFamily, 14);
            passwordLabel.Font = new Font(fontFamily, 14);
            loginTextBox.Font = new Font(fontFamily, 18);
            passwordTextBox.Font = new Font(fontFamily, 18);
            readyBtn.Font = new Font(fontFamily, 14, FontStyle.Bold);
            errorTextLabel.Font = new Font(fontFamily, 14);
        }

        private void readyBtn_Click(object sender, EventArgs e)
        {
            auth auth = new auth();
            bool isAuth = auth.AuthentiticateUser(loginTextBox.Text, passwordTextBox.Text);
            
            // Если пользователь успешно аутентифицирован, переходим на основную страницу
            if (isAuth)
            { 
                MainForm mainForm = new MainForm(this);
                mainForm.Show();
                Hide();
            }
            else
            {
                errorTextLabel.Visible = true;
            }
        }

    }
}
