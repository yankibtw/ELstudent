namespace ElStudent.Forms
{
    partial class MainForm
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
            this.headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.usernameHeaderLabel = new System.Windows.Forms.Label();
            this.menuLabel = new System.Windows.Forms.Label();
            this.mainMenuBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.menuPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.exitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.messageBtn = new Guna.UI2.WinForms.Guna2Button();
            this.notesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.diaryBtn = new Guna.UI2.WinForms.Guna2Button();
            this.personalKabinetBtn = new Guna.UI2.WinForms.Guna2Button();
            this.headerPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(114)))));
            this.headerPanel.Controls.Add(this.usernameHeaderLabel);
            this.headerPanel.Controls.Add(this.menuLabel);
            this.headerPanel.Controls.Add(this.mainMenuBtn);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1904, 65);
            this.headerPanel.TabIndex = 0;
            // 
            // usernameHeaderLabel
            // 
            this.usernameHeaderLabel.AutoSize = true;
            this.usernameHeaderLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.usernameHeaderLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.usernameHeaderLabel.Location = new System.Drawing.Point(1803, 0);
            this.usernameHeaderLabel.Name = "usernameHeaderLabel";
            this.usernameHeaderLabel.Padding = new System.Windows.Forms.Padding(0, 13, 20, 0);
            this.usernameHeaderLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.usernameHeaderLabel.Size = new System.Drawing.Size(101, 26);
            this.usernameHeaderLabel.TabIndex = 2;
            this.usernameHeaderLabel.Text = "Фамилия Имя";
            this.usernameHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.menuLabel.Location = new System.Drawing.Point(60, 13);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(36, 13);
            this.menuLabel.TabIndex = 1;
            this.menuLabel.Text = "Меню";
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.mainMenuBtn.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.mainMenuBtn.Image = global::ElStudent.Properties.Resources.menu;
            this.mainMenuBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.mainMenuBtn.ImageRotate = 0F;
            this.mainMenuBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.mainMenuBtn.Location = new System.Drawing.Point(20, 17);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.mainMenuBtn.Size = new System.Drawing.Size(30, 30);
            this.mainMenuBtn.TabIndex = 0;
            this.mainMenuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 65);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.mainPanel.Size = new System.Drawing.Size(1904, 976);
            this.mainPanel.TabIndex = 0;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(114)))));
            this.menuPanel.Controls.Add(this.exitBtn);
            this.menuPanel.Controls.Add(this.messageBtn);
            this.menuPanel.Controls.Add(this.notesBtn);
            this.menuPanel.Controls.Add(this.diaryBtn);
            this.menuPanel.Controls.Add(this.personalKabinetBtn);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 65);
            this.menuPanel.MinimumSize = new System.Drawing.Size(400, 1000);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(400, 1000);
            this.menuPanel.TabIndex = 0;
            this.menuPanel.Visible = false;
            // 
            // exitBtn
            // 
            this.exitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exitBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.exitBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Image = global::ElStudent.Properties.Resources.exitIcon;
            this.exitBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.exitBtn.ImageOffset = new System.Drawing.Point(20, 0);
            this.exitBtn.ImageSize = new System.Drawing.Size(24, 24);
            this.exitBtn.Location = new System.Drawing.Point(0, 200);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exitBtn.Size = new System.Drawing.Size(400, 50);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Выйти";
            this.exitBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.exitBtn.TextOffset = new System.Drawing.Point(42, 0);
            // 
            // messageBtn
            // 
            this.messageBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.messageBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.messageBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.messageBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.messageBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.messageBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(114)))));
            this.messageBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.messageBtn.ForeColor = System.Drawing.Color.White;
            this.messageBtn.Image = global::ElStudent.Properties.Resources.messageIcon;
            this.messageBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.messageBtn.ImageOffset = new System.Drawing.Point(20, 0);
            this.messageBtn.ImageSize = new System.Drawing.Size(24, 24);
            this.messageBtn.Location = new System.Drawing.Point(0, 150);
            this.messageBtn.Name = "messageBtn";
            this.messageBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.messageBtn.Size = new System.Drawing.Size(400, 50);
            this.messageBtn.TabIndex = 3;
            this.messageBtn.Text = "Уведомлять об экзаменах";
            this.messageBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.messageBtn.TextOffset = new System.Drawing.Point(42, 0);
            // 
            // notesBtn
            // 
            this.notesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.notesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.notesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.notesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.notesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.notesBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(114)))));
            this.notesBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.notesBtn.ForeColor = System.Drawing.Color.White;
            this.notesBtn.Image = global::ElStudent.Properties.Resources.notesIcon;
            this.notesBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.notesBtn.ImageOffset = new System.Drawing.Point(20, 0);
            this.notesBtn.ImageSize = new System.Drawing.Size(24, 24);
            this.notesBtn.Location = new System.Drawing.Point(0, 100);
            this.notesBtn.Name = "notesBtn";
            this.notesBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.notesBtn.Size = new System.Drawing.Size(400, 50);
            this.notesBtn.TabIndex = 2;
            this.notesBtn.Text = "Заметки";
            this.notesBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.notesBtn.TextOffset = new System.Drawing.Point(42, 0);
            // 
            // diaryBtn
            // 
            this.diaryBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.diaryBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.diaryBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.diaryBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.diaryBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.diaryBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(114)))));
            this.diaryBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.diaryBtn.ForeColor = System.Drawing.Color.White;
            this.diaryBtn.Image = global::ElStudent.Properties.Resources.diaryIcon;
            this.diaryBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.diaryBtn.ImageOffset = new System.Drawing.Point(20, 0);
            this.diaryBtn.ImageSize = new System.Drawing.Size(24, 24);
            this.diaryBtn.Location = new System.Drawing.Point(0, 50);
            this.diaryBtn.Name = "diaryBtn";
            this.diaryBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.diaryBtn.Size = new System.Drawing.Size(400, 50);
            this.diaryBtn.TabIndex = 1;
            this.diaryBtn.Text = "Дневник";
            this.diaryBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.diaryBtn.TextOffset = new System.Drawing.Point(42, 0);
            // 
            // personalKabinetBtn
            // 
            this.personalKabinetBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.personalKabinetBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.personalKabinetBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.personalKabinetBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.personalKabinetBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.personalKabinetBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(114)))));
            this.personalKabinetBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.personalKabinetBtn.ForeColor = System.Drawing.Color.White;
            this.personalKabinetBtn.Image = global::ElStudent.Properties.Resources.LK;
            this.personalKabinetBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.personalKabinetBtn.ImageOffset = new System.Drawing.Point(20, 0);
            this.personalKabinetBtn.ImageSize = new System.Drawing.Size(24, 24);
            this.personalKabinetBtn.Location = new System.Drawing.Point(0, 0);
            this.personalKabinetBtn.Name = "personalKabinetBtn";
            this.personalKabinetBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.personalKabinetBtn.Size = new System.Drawing.Size(400, 50);
            this.personalKabinetBtn.TabIndex = 0;
            this.personalKabinetBtn.Text = "Личный кабинет";
            this.personalKabinetBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.personalKabinetBtn.TextOffset = new System.Drawing.Point(42, 0);
            this.personalKabinetBtn.Click += new System.EventHandler(this.personalKabinetBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.headerPanel);
            this.Name = "MainForm";
            this.Text = "elStudent";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private Guna.UI2.WinForms.Guna2ImageButton mainMenuBtn;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label usernameHeaderLabel;
        private Guna.UI2.WinForms.Guna2Panel menuPanel;
        private Guna.UI2.WinForms.Guna2Button personalKabinetBtn;
        private Guna.UI2.WinForms.Guna2Button exitBtn;
        private Guna.UI2.WinForms.Guna2Button messageBtn;
        private Guna.UI2.WinForms.Guna2Button notesBtn;
        private Guna.UI2.WinForms.Guna2Button diaryBtn;
    }
}