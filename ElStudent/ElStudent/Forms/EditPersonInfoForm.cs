using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace ElStudent.Forms
{
    public partial class EditPersonInfoForm : Form
    {
        private Form currentChildForm;
        FontFamily fontFamily;
        public EditPersonInfoForm(MainForm parentForm)
        {
            InitializeComponent();
            string fontPath = Path.Combine(Directory.GetParent(Application.StartupPath)?.Parent?.FullName, "Resources", "Montserrat-VariableFont_wght.ttf");

            PrivateFontCollection privateFonts = new PrivateFontCollection();
            privateFonts.AddFontFile(fontPath);
            fontFamily = privateFonts.Families[0];

        }

        private void EditPersonInfoForm_Load(object sender, EventArgs e)
        {
            personalInfoBtn.Font = new Font(fontFamily, 16);
            passwordEditBtn.Font = new Font(fontFamily, 16);
            OpenChildForm(new PersonalInfoEditForm());
        }
        private void OpenChildForm(Form childForm)
        {
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainEditPanel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void passwordEditBtn_Click(object sender, EventArgs e)
        {
            passwordEditBtn.FillColor = Color.FromArgb(6, 135, 177);
            personalInfoBtn.FillColor = Color.FromArgb(255, 255, 255);
            passwordEditBtn.ForeColor = Color.FromArgb(255, 255, 255);
            personalInfoBtn.ForeColor = Color.FromArgb(0, 0, 0);
            OpenChildForm(new EditPasswordForm());
        }

        private void personalInfoBtn_Click(object sender, EventArgs e)
        {
            personalInfoBtn.FillColor = Color.FromArgb(6, 135, 177);
            passwordEditBtn.FillColor = Color.FromArgb(255, 255, 255);
            personalInfoBtn.ForeColor = Color.FromArgb(255, 255, 255);
            passwordEditBtn.ForeColor = Color.FromArgb(0, 0, 0);
            OpenChildForm(new PersonalInfoEditForm());
        }
    }
}
