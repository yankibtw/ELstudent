using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace ElStudent.Forms
{
    public partial class PersonalInfoEditForm : Form
    {
        FontFamily fontFamily;
        public PersonalInfoEditForm()
        {
            InitializeComponent();
            string fontPath = Path.Combine(Directory.GetParent(Application.StartupPath)?.Parent?.FullName, "Resources", "Montserrat-VariableFont_wght.ttf");

            PrivateFontCollection privateFonts = new PrivateFontCollection();
            privateFonts.AddFontFile(fontPath);
            fontFamily = privateFonts.Families[0];
        }

        private void PersonalInfoEditForm_Load(object sender, EventArgs e)
        {
            titleLabel.Font = new Font(fontFamily, 20);
            textInfoForUser.Font = new Font(fontFamily, 14);
            surnameLabel.Font = new Font(fontFamily, 16);
            surnameTextBox.Font = new Font(fontFamily, 14);
            usernameLabel.Font = new Font(fontFamily, 16);
            usernameTextBox.Font = new Font(fontFamily, 14);
            patronymicLabel.Font = new Font(fontFamily, 16);
            patronymicTextBox.Font = new Font(fontFamily, 14);
            loginLabel.Font = new Font(fontFamily, 16);
            loginTextBox.Font = new Font(fontFamily, 14);
            emailLabel.Font = new Font(fontFamily, 16);
            emailTextBox.Font = new Font(fontFamily, 14);
            saveBtn.Font = new Font(fontFamily, 15);
        }
    }
}
