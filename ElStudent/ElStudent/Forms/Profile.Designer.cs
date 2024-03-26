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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.mainNewsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.newsHeaderPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.bottomLinePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.newsHeaderLabel = new System.Windows.Forms.Label();
            this.someNewsFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.fullNamePanel.SuspendLayout();
            this.allInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPickture)).BeginInit();
            this.diaryPanel.SuspendLayout();
            this.notesPanel.SuspendLayout();
            this.mainNewsPanel.SuspendLayout();
            this.newsHeaderPanel.SuspendLayout();
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
            this.fullNamePanel.Size = new System.Drawing.Size(666, 1125);
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
            this.allInfoPanel.Location = new System.Drawing.Point(62, 546);
            this.allInfoPanel.Name = "allInfoPanel";
            this.allInfoPanel.Padding = new System.Windows.Forms.Padding(64, 0, 64, 0);
            this.allInfoPanel.Size = new System.Drawing.Size(569, 411);
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
            this.editBtn.Location = new System.Drawing.Point(165, 304);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(200, 50);
            this.editBtn.TabIndex = 10;
            this.editBtn.Text = "Редактировать";
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // emailTagLabel
            // 
            this.emailTagLabel.AutoSize = true;
            this.emailTagLabel.Location = new System.Drawing.Point(238, 227);
            this.emailTagLabel.Name = "emailTagLabel";
            this.emailTagLabel.Size = new System.Drawing.Size(82, 13);
            this.emailTagLabel.TabIndex = 9;
            this.emailTagLabel.Text = "test@gmail.com";
            // 
            // groupTagLabel
            // 
            this.groupTagLabel.AutoSize = true;
            this.groupTagLabel.Location = new System.Drawing.Point(238, 169);
            this.groupTagLabel.Name = "groupTagLabel";
            this.groupTagLabel.Size = new System.Drawing.Size(40, 13);
            this.groupTagLabel.TabIndex = 8;
            this.groupTagLabel.Text = "09-322";
            // 
            // loginTagLabel
            // 
            this.loginTagLabel.AutoSize = true;
            this.loginTagLabel.Location = new System.Drawing.Point(238, 111);
            this.loginTagLabel.Name = "loginTagLabel";
            this.loginTagLabel.Size = new System.Drawing.Size(51, 13);
            this.loginTagLabel.TabIndex = 7;
            this.loginTagLabel.Text = "Login123";
            // 
            // idTagLabel
            // 
            this.idTagLabel.AutoSize = true;
            this.idTagLabel.Location = new System.Drawing.Point(238, 53);
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
            this.userFullNameLabel.MaximumSize = new System.Drawing.Size(500, 0);
            this.userFullNameLabel.MinimumSize = new System.Drawing.Size(500, 0);
            this.userFullNameLabel.Name = "userFullNameLabel";
            this.userFullNameLabel.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.userFullNameLabel.Size = new System.Drawing.Size(500, 43);
            this.userFullNameLabel.TabIndex = 1;
            this.userFullNameLabel.Text = "Фамилия Имя Отчество";
            this.userFullNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainPickture
            // 
            this.mainPickture.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPickture.Image = global::ElStudent.Properties.Resources.user;
            this.mainPickture.InitialImage = global::ElStudent.Properties.Resources.user;
            this.mainPickture.Location = new System.Drawing.Point(61, 80);
            this.mainPickture.Name = "mainPickture";
            this.mainPickture.Padding = new System.Windows.Forms.Padding(64, 0, 64, 0);
            this.mainPickture.Size = new System.Drawing.Size(605, 370);
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
            this.diaryBtn.Click += new System.EventHandler(this.diaryBtn_Click);
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
            this.notesBtn.Click += new System.EventHandler(this.notesBtn_Click);
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
            // guna2Panel1
            // 
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(200, 100);
            this.guna2Panel1.TabIndex = 0;
            // 
            // mainNewsPanel
            // 
            this.mainNewsPanel.AutoSize = true;
            this.mainNewsPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.mainNewsPanel.BorderRadius = 5;
            this.mainNewsPanel.BorderThickness = 1;
            this.mainNewsPanel.Controls.Add(this.newsHeaderPanel);
            this.mainNewsPanel.Controls.Add(this.someNewsFlow);
            this.mainNewsPanel.Location = new System.Drawing.Point(727, 323);
            this.mainNewsPanel.Name = "mainNewsPanel";
            this.mainNewsPanel.Size = new System.Drawing.Size(1056, 802);
            this.mainNewsPanel.TabIndex = 5;
            // 
            // newsHeaderPanel
            // 
            this.newsHeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.newsHeaderPanel.BorderRadius = 5;
            this.newsHeaderPanel.BorderThickness = 1;
            this.newsHeaderPanel.Controls.Add(this.bottomLinePanel);
            this.newsHeaderPanel.Controls.Add(this.newsHeaderLabel);
            this.newsHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.newsHeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.newsHeaderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.newsHeaderPanel.Name = "newsHeaderPanel";
            this.newsHeaderPanel.Size = new System.Drawing.Size(1056, 64);
            this.newsHeaderPanel.TabIndex = 2;
            // 
            // bottomLinePanel
            // 
            this.bottomLinePanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bottomLinePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomLinePanel.Location = new System.Drawing.Point(0, 63);
            this.bottomLinePanel.Margin = new System.Windows.Forms.Padding(26, 3, 26, 3);
            this.bottomLinePanel.Name = "bottomLinePanel";
            this.bottomLinePanel.Size = new System.Drawing.Size(1056, 1);
            this.bottomLinePanel.TabIndex = 1;
            // 
            // newsHeaderLabel
            // 
            this.newsHeaderLabel.AutoSize = true;
            this.newsHeaderLabel.Location = new System.Drawing.Point(506, 11);
            this.newsHeaderLabel.Name = "newsHeaderLabel";
            this.newsHeaderLabel.Size = new System.Drawing.Size(50, 13);
            this.newsHeaderLabel.TabIndex = 0;
            this.newsHeaderLabel.Text = "Новости";
            // 
            // someNewsFlow
            // 
            this.someNewsFlow.AutoScroll = true;
            this.someNewsFlow.AutoSize = true;
            this.someNewsFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.someNewsFlow.Location = new System.Drawing.Point(26, 117);
            this.someNewsFlow.Name = "someNewsFlow";
            this.someNewsFlow.Size = new System.Drawing.Size(1000, 649);
            this.someNewsFlow.TabIndex = 1;
            this.someNewsFlow.WrapContents = false;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.mainNewsPanel);
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
            this.mainNewsPanel.ResumeLayout(false);
            this.mainNewsPanel.PerformLayout();
            this.newsHeaderPanel.ResumeLayout(false);
            this.newsHeaderPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel mainNewsPanel;
        private System.Windows.Forms.Label newsHeaderLabel;
        private System.Windows.Forms.FlowLayoutPanel someNewsFlow;
        private Guna.UI2.WinForms.Guna2Panel newsHeaderPanel;
        private Guna.UI2.WinForms.Guna2Panel bottomLinePanel;
    }
}