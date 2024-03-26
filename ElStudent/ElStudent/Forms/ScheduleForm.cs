using ElStudent.DB;
using Guna.UI2.WinForms;
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
    public partial class ScheduleForm : Form
    {
        FontFamily fontFamily;
        private Profile parentForm;
        private SessionManager manager = new SessionManager();
        public ScheduleForm(Profile parentForm)
        {
            InitializeComponent();
            string fontPath = Path.Combine(Directory.GetParent(Application.StartupPath)?.Parent?.FullName, "Resources", "Montserrat-VariableFont_wght.ttf");

            PrivateFontCollection privateFonts = new PrivateFontCollection();
            privateFonts.AddFontFile(fontPath);
            fontFamily = privateFonts.Families[0];
            this.parentForm = parentForm;
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            userFullNameLabel.Font = new Font(fontFamily, 18);
            navDiaryLabel.Font = new Font(fontFamily, 18);
            navResultLabel.Font = new Font(fontFamily, 18);
            userFullNameLabel.Text = $"{manager.GetSessionData("lastname")} {manager.GetSessionData("firstname")} {manager.GetSessionData("patronumic")}";
            dateTextLabel.Font = new Font(fontFamily, 8);
            subjectTextLabel.Font = new Font(fontFamily, 16);
            hwTextLabel.Font = new Font(fontFamily, 16);
            markTextLabel.Font = new Font(fontFamily, 16);

            Schedule schedule = new Schedule();
            List<SomeSchedule> allStudentSchedule = schedule.SelectAllStudentShedule();

            foreach (var someSchedule in allStudentSchedule)
            {
                AddToForm(someSchedule);
            }
        }
        private void AddToForm(SomeSchedule schedule)
        {
            Guna2Panel currentSchedulePanel = new Guna2Panel();
            currentSchedulePanel.Size = new Size(359, 90);
            currentSchedulePanel.BorderColor = Color.Black;
            currentSchedulePanel.BorderThickness = 1;
            currentSchedulePanel.Margin = new Padding(0);
            currentSchedulePanel.Location = new Point(0, 0);

            Label currentScheduleLabel = new Label();
            currentScheduleLabel.Font = new Font(fontFamily, 16);
            currentScheduleLabel.AutoSize = true;
            currentScheduleLabel.Location = new Point(56, 26);
            currentScheduleLabel.Text = schedule.Subject;

            currentSchedulePanel.Controls.Add(currentScheduleLabel);
            mainSchedulaFlow.Controls.Add(currentSchedulePanel);
        }
    }
}
