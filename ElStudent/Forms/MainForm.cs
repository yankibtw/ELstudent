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
            menuLabel.Font = new Font(fontFamily, 18);
            usernameHeaderLabel.Font = new Font(fontFamily, 18);
            OpenChildForm(new Forms.Profile());
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void OpenChildForm(Form childForm)
        {
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
