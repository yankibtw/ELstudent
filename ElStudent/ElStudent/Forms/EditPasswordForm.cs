using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElStudent.Forms
{
    public partial class EditPasswordForm : Form
    {
        private FontFamily fontFamily;
        public EditPasswordForm()
        {
            InitializeComponent();
            string fontPath = Path.Combine(Directory.GetParent(Application.StartupPath)?.Parent?.FullName, "Resources", "Montserrat-VariableFont_wght.ttf");

            PrivateFontCollection privateFonts = new PrivateFontCollection();
            privateFonts.AddFontFile(fontPath);
            fontFamily = privateFonts.Families[0];
        }

        private void EditPasswordForm_Load(object sender, EventArgs e)
        {
            titleLabel.Font = new Font(fontFamily, 20);
            textInfoForUser.Font = new Font(fontFamily, 14);
            oldPassLabel.Font = new Font(fontFamily, 16);
            newPassLabel.Font = new Font(fontFamily, 16);
            returnPassLabel.Font = new Font(fontFamily, 16);
            saveBtn.Font = new Font(fontFamily, 16);
        }
    }
}
