namespace ElStudent.Forms
{
    partial class PersonalInfoEditForm
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
            this.mainEditPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.saveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.patronymicLabel = new System.Windows.Forms.Label();
            this.patronymicTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.surnameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.textInfoForUser = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.mainEditPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainEditPanel
            // 
            this.mainEditPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(223)))));
            this.mainEditPanel.BorderRadius = 7;
            this.mainEditPanel.BorderThickness = 1;
            this.mainEditPanel.Controls.Add(this.saveBtn);
            this.mainEditPanel.Controls.Add(this.emailLabel);
            this.mainEditPanel.Controls.Add(this.emailTextBox);
            this.mainEditPanel.Controls.Add(this.loginLabel);
            this.mainEditPanel.Controls.Add(this.loginTextBox);
            this.mainEditPanel.Controls.Add(this.patronymicLabel);
            this.mainEditPanel.Controls.Add(this.patronymicTextBox);
            this.mainEditPanel.Controls.Add(this.usernameLabel);
            this.mainEditPanel.Controls.Add(this.usernameTextBox);
            this.mainEditPanel.Controls.Add(this.surnameLabel);
            this.mainEditPanel.Controls.Add(this.surnameTextBox);
            this.mainEditPanel.Controls.Add(this.textInfoForUser);
            this.mainEditPanel.Controls.Add(this.guna2Panel1);
            this.mainEditPanel.Controls.Add(this.titleLabel);
            this.mainEditPanel.Location = new System.Drawing.Point(71, 137);
            this.mainEditPanel.Name = "mainEditPanel";
            this.mainEditPanel.Size = new System.Drawing.Size(980, 702);
            this.mainEditPanel.TabIndex = 1;
            // 
            // saveBtn
            // 
            this.saveBtn.BorderRadius = 5;
            this.saveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(135)))), ((int)(((byte)(177)))));
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(415, 602);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(180, 45);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "Сохранить";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(150, 493);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 12;
            this.emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderRadius = 5;
            this.emailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTextBox.DefaultText = "Email";
            this.emailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailTextBox.ForeColor = System.Drawing.Color.Black;
            this.emailTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextBox.Location = new System.Drawing.Point(294, 485);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 24);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.emailTextBox.PlaceholderText = "";
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.Size = new System.Drawing.Size(565, 50);
            this.emailTextBox.TabIndex = 11;
            this.emailTextBox.TextOffset = new System.Drawing.Point(37, -3);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(150, 416);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(41, 13);
            this.loginLabel.TabIndex = 10;
            this.loginLabel.Text = "Логин:";
            // 
            // loginTextBox
            // 
            this.loginTextBox.BorderRadius = 5;
            this.loginTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginTextBox.DefaultText = "Логин";
            this.loginTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.loginTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.loginTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginTextBox.ForeColor = System.Drawing.Color.Black;
            this.loginTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginTextBox.Location = new System.Drawing.Point(294, 408);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 24);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.PasswordChar = '\0';
            this.loginTextBox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.loginTextBox.PlaceholderText = "";
            this.loginTextBox.SelectedText = "";
            this.loginTextBox.Size = new System.Drawing.Size(565, 50);
            this.loginTextBox.TabIndex = 9;
            this.loginTextBox.TextOffset = new System.Drawing.Point(37, -3);
            // 
            // patronymicLabel
            // 
            this.patronymicLabel.AutoSize = true;
            this.patronymicLabel.Location = new System.Drawing.Point(150, 339);
            this.patronymicLabel.Name = "patronymicLabel";
            this.patronymicLabel.Size = new System.Drawing.Size(57, 13);
            this.patronymicLabel.TabIndex = 8;
            this.patronymicLabel.Text = "Отчетсво:";
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.BorderRadius = 5;
            this.patronymicTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.patronymicTextBox.DefaultText = "Отчество";
            this.patronymicTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.patronymicTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.patronymicTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.patronymicTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.patronymicTextBox.Enabled = false;
            this.patronymicTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.patronymicTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.patronymicTextBox.ForeColor = System.Drawing.Color.Black;
            this.patronymicTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.patronymicTextBox.Location = new System.Drawing.Point(294, 331);
            this.patronymicTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 24);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.PasswordChar = '\0';
            this.patronymicTextBox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.patronymicTextBox.PlaceholderText = "";
            this.patronymicTextBox.SelectedText = "";
            this.patronymicTextBox.Size = new System.Drawing.Size(565, 50);
            this.patronymicTextBox.TabIndex = 7;
            this.patronymicTextBox.TextOffset = new System.Drawing.Point(37, -3);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(150, 262);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(32, 13);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "Имя:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BorderRadius = 5;
            this.usernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTextBox.DefaultText = "Имя";
            this.usernameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTextBox.Enabled = false;
            this.usernameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usernameTextBox.ForeColor = System.Drawing.Color.Black;
            this.usernameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTextBox.Location = new System.Drawing.Point(294, 254);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 24);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PasswordChar = '\0';
            this.usernameTextBox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.usernameTextBox.PlaceholderText = "";
            this.usernameTextBox.SelectedText = "";
            this.usernameTextBox.Size = new System.Drawing.Size(565, 50);
            this.usernameTextBox.TabIndex = 5;
            this.usernameTextBox.TextOffset = new System.Drawing.Point(37, -3);
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(150, 185);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(59, 13);
            this.surnameLabel.TabIndex = 4;
            this.surnameLabel.Text = "Фамилия:";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.BorderRadius = 5;
            this.surnameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.surnameTextBox.DefaultText = "Фамилия";
            this.surnameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.surnameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.surnameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.surnameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.surnameTextBox.Enabled = false;
            this.surnameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.surnameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.surnameTextBox.ForeColor = System.Drawing.Color.Black;
            this.surnameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.surnameTextBox.Location = new System.Drawing.Point(294, 177);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 24);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.PasswordChar = '\0';
            this.surnameTextBox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.surnameTextBox.PlaceholderText = "";
            this.surnameTextBox.SelectedText = "";
            this.surnameTextBox.Size = new System.Drawing.Size(565, 50);
            this.surnameTextBox.TabIndex = 3;
            this.surnameTextBox.TextOffset = new System.Drawing.Point(37, -3);
            // 
            // textInfoForUser
            // 
            this.textInfoForUser.AutoSize = true;
            this.textInfoForUser.Location = new System.Drawing.Point(125, 116);
            this.textInfoForUser.Name = "textInfoForUser";
            this.textInfoForUser.Size = new System.Drawing.Size(385, 26);
            this.textInfoForUser.TabIndex = 2;
            this.textInfoForUser.Text = "Если вы хотите изменить ФИО и дату рождения, то обратитесь в деканат\r\n\r\n";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Panel1.Location = new System.Drawing.Point(23, 90);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(920, 1);
            this.guna2Panel1.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(674, 25);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(87, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Личные данные";
            // 
            // PersonalInfoEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 1002);
            this.Controls.Add(this.mainEditPanel);
            this.Name = "PersonalInfoEditForm";
            this.Text = "PersonalInfoEditForm";
            this.Load += new System.EventHandler(this.PersonalInfoEditForm_Load);
            this.mainEditPanel.ResumeLayout(false);
            this.mainEditPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel mainEditPanel;
        private System.Windows.Forms.Label titleLabel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label textInfoForUser;
        private Guna.UI2.WinForms.Guna2TextBox surnameTextBox;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label patronymicLabel;
        private Guna.UI2.WinForms.Guna2TextBox patronymicTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private Guna.UI2.WinForms.Guna2TextBox usernameTextBox;
        private Guna.UI2.WinForms.Guna2Button saveBtn;
        private System.Windows.Forms.Label emailLabel;
        private Guna.UI2.WinForms.Guna2TextBox emailTextBox;
        private System.Windows.Forms.Label loginLabel;
        private Guna.UI2.WinForms.Guna2TextBox loginTextBox;
    }
}