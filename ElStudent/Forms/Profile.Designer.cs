namespace ElStudent.Forms
{
    partial class Profile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.fullNamePanel = new System.Windows.Forms.Panel();
            this.allInfoPanel = new System.Windows.Forms.Panel();
            this.editBtn = new Guna.UI2.WinForms.Guna2Button();
            this.emailTagLabel = new System.Windows.Forms.Label();
            this.groupTagLabel = new System.Windows.Forms.Label();
            this.loginTagLabel = new System.Windows.Forms.Label();
            this.idTagLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.groupLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.userFullNameLabel = new System.Windows.Forms.Label();
            this.mainPickture = new System.Windows.Forms.PictureBox();
            this.diaryPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.diaryBtn = new Guna.UI2.WinForms.Guna2Button();
            this.lineUnderDiary = new System.Windows.Forms.Panel();
            this.diaryLabel = new System.Windows.Forms.Label();
            this.notesPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.notesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.lineUnderNotes = new System.Windows.Forms.Panel();
            this.notesLabel = new System.Windows.Forms.Label();
            this.newsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.someNewsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.helpPanel = new System.Windows.Forms.Panel();
            this.newsDateLabel = new System.Windows.Forms.Label();
            this.readNewsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.newsMainTextLabel = new System.Windows.Forms.Label();
            this.newsDescritionLabel = new System.Windows.Forms.Label();
            this.newsHeadingLabel = new System.Windows.Forms.Label();
            this.lineUnderNews = new System.Windows.Forms.Panel();
            this.newsLabel = new System.Windows.Forms.Label();
            this.newsTimer = new System.Windows.Forms.Timer(this.components);
            this.fullNamePanel.SuspendLayout();
            this.allInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPickture)).BeginInit();
            this.diaryPanel.SuspendLayout();
            this.notesPanel.SuspendLayout();
            this.newsPanel.SuspendLayout();
            this.someNewsPanel.SuspendLayout();
            this.helpPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // fullNamePanel
            // 
            this.fullNamePanel.Controls.Add(this.allInfoPanel);
            this.fullNamePanel.Controls.Add(this.userFullNameLabel);
            this.fullNamePanel.Controls.Add(this.mainPickture);
            this.fullNamePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.fullNamePanel.Location = new System.Drawing.Point(0, 0);
            this.fullNamePanel.Name = "fullNamePanel";
            this.fullNamePanel.Padding = new System.Windows.Forms.Padding(61, 80, 0, 0);
            this.fullNamePanel.Size = new System.Drawing.Size(530, 976);
            this.fullNamePanel.TabIndex = 0;
            // 
            // allInfoPanel
            // 
            this.allInfoPanel.Controls.Add(this.editBtn);
            this.allInfoPanel.Controls.Add(this.emailTagLabel);
            this.allInfoPanel.Controls.Add(this.groupTagLabel);
            this.allInfoPanel.Controls.Add(this.loginTagLabel);
            this.allInfoPanel.Controls.Add(this.idTagLabel);
            this.allInfoPanel.Controls.Add(this.emailLabel);
            this.allInfoPanel.Controls.Add(this.groupLabel);
            this.allInfoPanel.Controls.Add(this.loginLabel);
            this.allInfoPanel.Controls.Add(this.idLabel);
            this.allInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.allInfoPanel.Location = new System.Drawing.Point(61, 525);
            this.allInfoPanel.Name = "allInfoPanel";
            this.allInfoPanel.Padding = new System.Windows.Forms.Padding(64, 60, 64, 0);
            this.allInfoPanel.Size = new System.Drawing.Size(469, 411);
            this.allInfoPanel.TabIndex = 3;
            // 
            // editBtn
            // 
            this.editBtn.BorderRadius = 5;
            this.editBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.editBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.editBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.editBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.editBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(114)))));
            this.editBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.editBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.editBtn.Location = new System.Drawing.Point(119, 304);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(200, 50);
            this.editBtn.TabIndex = 10;
            this.editBtn.Text = "Редактировать";
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // emailTagLabel
            // 
            this.emailTagLabel.AutoSize = true;
            this.emailTagLabel.Location = new System.Drawing.Point(237, 227);
            this.emailTagLabel.Name = "emailTagLabel";
            this.emailTagLabel.Size = new System.Drawing.Size(82, 13);
            this.emailTagLabel.TabIndex = 9;
            this.emailTagLabel.Text = "test@gmail.com";
            // 
            // groupTagLabel
            // 
            this.groupTagLabel.AutoSize = true;
            this.groupTagLabel.Location = new System.Drawing.Point(237, 169);
            this.groupTagLabel.Name = "groupTagLabel";
            this.groupTagLabel.Size = new System.Drawing.Size(40, 13);
            this.groupTagLabel.TabIndex = 8;
            this.groupTagLabel.Text = "09-322";
            // 
            // loginTagLabel
            // 
            this.loginTagLabel.AutoSize = true;
            this.loginTagLabel.Location = new System.Drawing.Point(237, 111);
            this.loginTagLabel.Name = "loginTagLabel";
            this.loginTagLabel.Size = new System.Drawing.Size(51, 13);
            this.loginTagLabel.TabIndex = 7;
            this.loginTagLabel.Text = "Login123";
            // 
            // idTagLabel
            // 
            this.idTagLabel.AutoSize = true;
            this.idTagLabel.Location = new System.Drawing.Point(237, 53);
            this.idTagLabel.Name = "idTagLabel";
            this.idTagLabel.Size = new System.Drawing.Size(37, 13);
            this.idTagLabel.TabIndex = 6;
            this.idTagLabel.Text = "12332";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(67, 227);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 5;
            this.emailLabel.Text = "Email";
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Location = new System.Drawing.Point(67, 169);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(42, 13);
            this.groupLabel.TabIndex = 4;
            this.groupLabel.Text = "Группа";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(67, 111);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(38, 13);
            this.loginLabel.TabIndex = 3;
            this.loginLabel.Text = "Логин";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(67, 53);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "ID";
            // 
            // userFullNameLabel
            // 
            this.userFullNameLabel.AutoSize = true;
            this.userFullNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userFullNameLabel.Location = new System.Drawing.Point(61, 450);
            this.userFullNameLabel.MaximumSize = new System.Drawing.Size(470, 0);
            this.userFullNameLabel.Name = "userFullNameLabel";
            this.userFullNameLabel.Padding = new System.Windows.Forms.Padding(0, 62, 0, 0);
            this.userFullNameLabel.Size = new System.Drawing.Size(131, 75);
            this.userFullNameLabel.TabIndex = 1;
            this.userFullNameLabel.Text = "Фамилия Имя Отчество";
            // 
            // mainPickture
            // 
            this.mainPickture.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPickture.Image = global::ElStudent.Properties.Resources.user;
            this.mainPickture.InitialImage = global::ElStudent.Properties.Resources.user;
            this.mainPickture.Location = new System.Drawing.Point(61, 80);
            this.mainPickture.Name = "mainPickture";
            this.mainPickture.Padding = new System.Windows.Forms.Padding(64, 0, 64, 0);
            this.mainPickture.Size = new System.Drawing.Size(469, 370);
            this.mainPickture.TabIndex = 0;
            this.mainPickture.TabStop = false;
            // 
            // diaryPanel
            // 
            this.diaryPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.diaryPanel.BorderRadius = 10;
            this.diaryPanel.BorderThickness = 1;
            this.diaryPanel.Controls.Add(this.diaryBtn);
            this.diaryPanel.Controls.Add(this.lineUnderDiary);
            this.diaryPanel.Controls.Add(this.diaryLabel);
            this.diaryPanel.Location = new System.Drawing.Point(727, 80);
            this.diaryPanel.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.diaryPanel.Name = "diaryPanel";
            this.diaryPanel.Size = new System.Drawing.Size(490, 150);
            this.diaryPanel.TabIndex = 1;
            // 
            // diaryBtn
            // 
            this.diaryBtn.BorderRadius = 5;
            this.diaryBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.diaryBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.diaryBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.diaryBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.diaryBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(114)))));
            this.diaryBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diaryBtn.ForeColor = System.Drawing.Color.White;
            this.diaryBtn.Location = new System.Drawing.Point(157, 85);
            this.diaryBtn.Name = "diaryBtn";
            this.diaryBtn.Size = new System.Drawing.Size(196, 45);
            this.diaryBtn.TabIndex = 3;
            this.diaryBtn.Text = "Перейти";
            // 
            // lineUnderDiary
            // 
            this.lineUnderDiary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(114)))));
            this.lineUnderDiary.Location = new System.Drawing.Point(15, 70);
            this.lineUnderDiary.Name = "lineUnderDiary";
            this.lineUnderDiary.Size = new System.Drawing.Size(460, 1);
            this.lineUnderDiary.TabIndex = 2;
            // 
            // diaryLabel
            // 
            this.diaryLabel.AutoSize = true;
            this.diaryLabel.Location = new System.Drawing.Point(186, 22);
            this.diaryLabel.Name = "diaryLabel";
            this.diaryLabel.Size = new System.Drawing.Size(52, 13);
            this.diaryLabel.TabIndex = 0;
            this.diaryLabel.Text = "Дневник";
            // 
            // notesPanel
            // 
            this.notesPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.notesPanel.BorderRadius = 10;
            this.notesPanel.BorderThickness = 1;
            this.notesPanel.Controls.Add(this.notesBtn);
            this.notesPanel.Controls.Add(this.lineUnderNotes);
            this.notesPanel.Controls.Add(this.notesLabel);
            this.notesPanel.Location = new System.Drawing.Point(1290, 80);
            this.notesPanel.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.notesPanel.Name = "notesPanel";
            this.notesPanel.Size = new System.Drawing.Size(490, 150);
            this.notesPanel.TabIndex = 4;
            // 
            // notesBtn
            // 
            this.notesBtn.BorderRadius = 5;
            this.notesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.notesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.notesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.notesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.notesBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(114)))));
            this.notesBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notesBtn.ForeColor = System.Drawing.Color.White;
            this.notesBtn.Location = new System.Drawing.Point(157, 85);
            this.notesBtn.Name = "notesBtn";
            this.notesBtn.Size = new System.Drawing.Size(196, 45);
            this.notesBtn.TabIndex = 3;
            this.notesBtn.Text = "Перейти";
            // 
            // lineUnderNotes
            // 
            this.lineUnderNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(114)))));
            this.lineUnderNotes.Location = new System.Drawing.Point(15, 70);
            this.lineUnderNotes.Name = "lineUnderNotes";
            this.lineUnderNotes.Size = new System.Drawing.Size(460, 1);
            this.lineUnderNotes.TabIndex = 2;
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(186, 22);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(51, 13);
            this.notesLabel.TabIndex = 0;
            this.notesLabel.Text = "Заметки";
            // 
            // newsPanel
            // 
            this.newsPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.newsPanel.BorderRadius = 10;
            this.newsPanel.BorderThickness = 1;
            this.newsPanel.Controls.Add(this.someNewsPanel);
            this.newsPanel.Controls.Add(this.lineUnderNews);
            this.newsPanel.Controls.Add(this.newsLabel);
            this.newsPanel.Location = new System.Drawing.Point(727, 300);
            this.newsPanel.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.newsPanel.Name = "newsPanel";
            this.newsPanel.Size = new System.Drawing.Size(1051, 600);
            this.newsPanel.TabIndex = 4;
            // 
            // someNewsPanel
            // 
            this.someNewsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.someNewsPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.someNewsPanel.BorderRadius = 5;
            this.someNewsPanel.BorderThickness = 1;
            this.someNewsPanel.Controls.Add(this.helpPanel);
            this.someNewsPanel.Controls.Add(this.newsMainTextLabel);
            this.someNewsPanel.Controls.Add(this.newsDescritionLabel);
            this.someNewsPanel.Controls.Add(this.newsHeadingLabel);
            this.someNewsPanel.Location = new System.Drawing.Point(25, 117);
            this.someNewsPanel.MaximumSize = new System.Drawing.Size(1000, 400);
            this.someNewsPanel.MinimumSize = new System.Drawing.Size(1000, 174);
            this.someNewsPanel.Name = "someNewsPanel";
            this.someNewsPanel.Size = new System.Drawing.Size(1000, 174);
            this.someNewsPanel.TabIndex = 3;
            // 
            // helpPanel
            // 
            this.helpPanel.Controls.Add(this.newsDateLabel);
            this.helpPanel.Controls.Add(this.readNewsBtn);
            this.helpPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.helpPanel.Location = new System.Drawing.Point(0, 109);
            this.helpPanel.Name = "helpPanel";
            this.helpPanel.Size = new System.Drawing.Size(1000, 65);
            this.helpPanel.TabIndex = 5;
            // 
            // newsDateLabel
            // 
            this.newsDateLabel.AutoSize = true;
            this.newsDateLabel.Location = new System.Drawing.Point(33, 10);
            this.newsDateLabel.Name = "newsDateLabel";
            this.newsDateLabel.Size = new System.Drawing.Size(96, 13);
            this.newsDateLabel.TabIndex = 2;
            this.newsDateLabel.Text = "01 сентября 2024";
            // 
            // readNewsBtn
            // 
            this.readNewsBtn.BackColor = System.Drawing.Color.Transparent;
            this.readNewsBtn.BorderRadius = 5;
            this.readNewsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.readNewsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.readNewsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.readNewsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.readNewsBtn.FillColor = System.Drawing.Color.White;
            this.readNewsBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.readNewsBtn.ForeColor = System.Drawing.Color.Black;
            this.readNewsBtn.Location = new System.Drawing.Point(863, 0);
            this.readNewsBtn.Margin = new System.Windows.Forms.Padding(847, 3, 3, 3);
            this.readNewsBtn.MaximumSize = new System.Drawing.Size(120, 35);
            this.readNewsBtn.MinimumSize = new System.Drawing.Size(120, 35);
            this.readNewsBtn.Name = "readNewsBtn";
            this.readNewsBtn.Size = new System.Drawing.Size(120, 35);
            this.readNewsBtn.TabIndex = 3;
            this.readNewsBtn.Text = "Читать";
            this.readNewsBtn.Click += new System.EventHandler(this.readNewsBtn_Click);
            // 
            // newsMainTextLabel
            // 
            this.newsMainTextLabel.AutoSize = true;
            this.newsMainTextLabel.Location = new System.Drawing.Point(36, 108);
            this.newsMainTextLabel.MaximumSize = new System.Drawing.Size(956, 180);
            this.newsMainTextLabel.Name = "newsMainTextLabel";
            this.newsMainTextLabel.Size = new System.Drawing.Size(453, 91);
            this.newsMainTextLabel.TabIndex = 4;
            this.newsMainTextLabel.Text = resources.GetString("newsMainTextLabel.Text");
            this.newsMainTextLabel.Visible = false;
            // 
            // newsDescritionLabel
            // 
            this.newsDescritionLabel.AutoSize = true;
            this.newsDescritionLabel.Location = new System.Drawing.Point(33, 56);
            this.newsDescritionLabel.Name = "newsDescritionLabel";
            this.newsDescritionLabel.Size = new System.Drawing.Size(234, 26);
            this.newsDescritionLabel.TabIndex = 1;
            this.newsDescritionLabel.Text = "Очень кратенькое описание данной новости\r\n\r\n";
            // 
            // newsHeadingLabel
            // 
            this.newsHeadingLabel.AutoSize = true;
            this.newsHeadingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(103)))), ((int)(((byte)(165)))));
            this.newsHeadingLabel.Location = new System.Drawing.Point(33, 18);
            this.newsHeadingLabel.Name = "newsHeadingLabel";
            this.newsHeadingLabel.Size = new System.Drawing.Size(103, 13);
            this.newsHeadingLabel.TabIndex = 0;
            this.newsHeadingLabel.Text = "Какое-то название";
            // 
            // lineUnderNews
            // 
            this.lineUnderNews.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(114)))));
            this.lineUnderNews.Location = new System.Drawing.Point(25, 70);
            this.lineUnderNews.Name = "lineUnderNews";
            this.lineUnderNews.Size = new System.Drawing.Size(1001, 1);
            this.lineUnderNews.TabIndex = 2;
            // 
            // newsLabel
            // 
            this.newsLabel.AutoSize = true;
            this.newsLabel.Location = new System.Drawing.Point(470, 18);
            this.newsLabel.Name = "newsLabel";
            this.newsLabel.Size = new System.Drawing.Size(50, 13);
            this.newsLabel.TabIndex = 0;
            this.newsLabel.Text = "Новости";
            // 
            // newsTimer
            // 
            this.newsTimer.Interval = 1;
            this.newsTimer.Tick += new System.EventHandler(this.newsTimer_Tick);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 976);
            this.Controls.Add(this.newsPanel);
            this.Controls.Add(this.notesPanel);
            this.Controls.Add(this.diaryPanel);
            this.Controls.Add(this.fullNamePanel);
            this.MaximizeBox = false;
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.fullNamePanel.ResumeLayout(false);
            this.fullNamePanel.PerformLayout();
            this.allInfoPanel.ResumeLayout(false);
            this.allInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPickture)).EndInit();
            this.diaryPanel.ResumeLayout(false);
            this.diaryPanel.PerformLayout();
            this.notesPanel.ResumeLayout(false);
            this.notesPanel.PerformLayout();
            this.newsPanel.ResumeLayout(false);
            this.newsPanel.PerformLayout();
            this.someNewsPanel.ResumeLayout(false);
            this.someNewsPanel.PerformLayout();
            this.helpPanel.ResumeLayout(false);
            this.helpPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel fullNamePanel;
        private System.Windows.Forms.PictureBox mainPickture;
        private System.Windows.Forms.Label userFullNameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Panel allInfoPanel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label idTagLabel;
        private System.Windows.Forms.Label emailTagLabel;
        private System.Windows.Forms.Label groupTagLabel;
        private System.Windows.Forms.Label loginTagLabel;
        private Guna.UI2.WinForms.Guna2Button editBtn;
        private Guna.UI2.WinForms.Guna2Panel diaryPanel;
        private System.Windows.Forms.Label diaryLabel;
        private System.Windows.Forms.Panel lineUnderDiary;
        private Guna.UI2.WinForms.Guna2Button diaryBtn;
        private Guna.UI2.WinForms.Guna2Panel notesPanel;
        private Guna.UI2.WinForms.Guna2Button notesBtn;
        private System.Windows.Forms.Panel lineUnderNotes;
        private System.Windows.Forms.Label notesLabel;
        private Guna.UI2.WinForms.Guna2Panel newsPanel;
        private System.Windows.Forms.Panel lineUnderNews;
        private System.Windows.Forms.Label newsLabel;
        private Guna.UI2.WinForms.Guna2Panel someNewsPanel;
        private System.Windows.Forms.Label newsHeadingLabel;
        private System.Windows.Forms.Label newsDescritionLabel;
        private System.Windows.Forms.Label newsDateLabel;
        private Guna.UI2.WinForms.Guna2Button readNewsBtn;
        private System.Windows.Forms.Label newsMainTextLabel;
        private System.Windows.Forms.Timer newsTimer;
        private System.Windows.Forms.Panel helpPanel;
    }
}