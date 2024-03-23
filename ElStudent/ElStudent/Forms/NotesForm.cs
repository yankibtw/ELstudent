using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace ElStudent.Forms
{
    public partial class NotesForm : Form
    {
        FontFamily fontFamily;
        private Profile parentForm;
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
            notesBtn.Font = new Font(fontFamily, 16);
            someNotesBtn.Font = new Font(fontFamily, 16);
        }

        private void notesBtn_Click(object sender, EventArgs e)
        {
            changeNoteToActive((Guna2Button)sender);
        }
        private void changeNoteToActive(Guna2Button activeBtn)
        {
            activeBtn.BackColor = Color.FromArgb(4, 87, 114);
            activeBtn.ForeColor = Color.White;
        }
    }
}
