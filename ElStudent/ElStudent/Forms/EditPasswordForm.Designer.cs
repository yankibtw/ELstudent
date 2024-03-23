namespace ElStudent.Forms
{
    partial class EditPasswordForm
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
            this.returnPassLabel = new System.Windows.Forms.Label();
            this.patronymicTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.newPassLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.oldPassLabel = new System.Windows.Forms.Label();
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
            this.mainEditPanel.Controls.Add(this.returnPassLabel);
            this.mainEditPanel.Controls.Add(this.patronymicTextBox);
            this.mainEditPanel.Controls.Add(this.newPassLabel);
            this.mainEditPanel.Controls.Add(this.usernameTextBox);
            this.mainEditPanel.Controls.Add(this.oldPassLabel);
            this.mainEditPanel.Controls.Add(this.surnameTextBox);
            this.mainEditPanel.Controls.Add(this.textInfoForUser);
            this.mainEditPanel.Controls.Add(this.guna2Panel1);
            this.mainEditPanel.Controls.Add(this.titleLabel);
            this.mainEditPanel.Location = new System.Drawing.Point(71, 137);
            this.mainEditPanel.Name = "mainEditPanel";
            this.mainEditPanel.Size = new System.Drawing.Size(980, 584);
            this.mainEditPanel.TabIndex = 2;
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
            this.saveBtn.Location = new System.Drawing.Point(415, 484);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(180, 45);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "Сохранить";
            // 
            // returnPassLabel
            // 
            this.returnPassLabel.AutoSize = true;
            this.returnPassLabel.Location = new System.Drawing.Point(55, 373);
            this.returnPassLabel.Name = "returnPassLabel";
            this.returnPassLabel.Size = new System.Drawing.Size(103, 13);
            this.returnPassLabel.TabIndex = 8;
            this.returnPassLabel.Text = "Повторите пароль:";
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.BorderRadius = 5;
            this.patronymicTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.patronymicTextBox.DefaultText = "";
            this.patronymicTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.patronymicTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.patronymicTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.patronymicTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.patronymicTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.patronymicTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.patronymicTextBox.ForeColor = System.Drawing.Color.Black;
            this.patronymicTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.patronymicTextBox.Location = new System.Drawing.Point(289, 365);
            this.patronymicTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 24);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.PasswordChar = '●';
            this.patronymicTextBox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.patronymicTextBox.PlaceholderText = "";
            this.patronymicTextBox.SelectedText = "";
            this.patronymicTextBox.Size = new System.Drawing.Size(565, 50);
            this.patronymicTextBox.TabIndex = 7;
            this.patronymicTextBox.TextOffset = new System.Drawing.Point(37, 0);
            this.patronymicTextBox.UseSystemPasswordChar = true;
            // 
            // newPassLabel
            // 
            this.newPassLabel.AutoSize = true;
            this.newPassLabel.Location = new System.Drawing.Point(55, 296);
            this.newPassLabel.Name = "newPassLabel";
            this.newPassLabel.Size = new System.Drawing.Size(83, 13);
            this.newPassLabel.TabIndex = 6;
            this.newPassLabel.Text = "Новый пароль:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BorderRadius = 5;
            this.usernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTextBox.DefaultText = "";
            this.usernameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usernameTextBox.ForeColor = System.Drawing.Color.Black;
            this.usernameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTextBox.Location = new System.Drawing.Point(289, 288);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 24);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PasswordChar = '●';
            this.usernameTextBox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.usernameTextBox.PlaceholderText = "";
            this.usernameTextBox.SelectedText = "";
            this.usernameTextBox.Size = new System.Drawing.Size(565, 50);
            this.usernameTextBox.TabIndex = 5;
            this.usernameTextBox.TextOffset = new System.Drawing.Point(37, 0);
            this.usernameTextBox.UseSystemPasswordChar = true;
            // 
            // oldPassLabel
            // 
            this.oldPassLabel.AutoSize = true;
            this.oldPassLabel.Location = new System.Drawing.Point(55, 219);
            this.oldPassLabel.Name = "oldPassLabel";
            this.oldPassLabel.Size = new System.Drawing.Size(87, 13);
            this.oldPassLabel.TabIndex = 4;
            this.oldPassLabel.Text = "Старый пароль:";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.BorderRadius = 5;
            this.surnameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.surnameTextBox.DefaultText = "";
            this.surnameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.surnameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.surnameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.surnameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.surnameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.surnameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.surnameTextBox.ForeColor = System.Drawing.Color.Black;
            this.surnameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.surnameTextBox.Location = new System.Drawing.Point(289, 211);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 24);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.PasswordChar = '●';
            this.surnameTextBox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.surnameTextBox.PlaceholderText = "";
            this.surnameTextBox.SelectedText = "";
            this.surnameTextBox.Size = new System.Drawing.Size(565, 50);
            this.surnameTextBox.TabIndex = 3;
            this.surnameTextBox.TextOffset = new System.Drawing.Point(37, 0);
            this.surnameTextBox.UseSystemPasswordChar = true;
            // 
            // textInfoForUser
            // 
            this.textInfoForUser.AutoSize = true;
            this.textInfoForUser.Location = new System.Drawing.Point(125, 116);
            this.textInfoForUser.Name = "textInfoForUser";
            this.textInfoForUser.Size = new System.Drawing.Size(357, 39);
            this.textInfoForUser.TabIndex = 2;
            this.textInfoForUser.Text = "Ваш пароль должен быть длиной минимум 8 символов и содержать \r\nлатинские буквы ве" +
    "рхнего и нижнего регистра, а также цифры\r\n\r\n";
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
            this.titleLabel.Size = new System.Drawing.Size(104, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Изменение пароля";
            // 
            // EditPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 710);
            this.Controls.Add(this.mainEditPanel);
            this.Name = "EditPasswordForm";
            this.Text = "EditPasswordForm";
            this.Load += new System.EventHandler(this.EditPasswordForm_Load);
            this.mainEditPanel.ResumeLayout(false);
            this.mainEditPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mainEditPanel;
        private Guna.UI2.WinForms.Guna2Button saveBtn;
        private System.Windows.Forms.Label returnPassLabel;
        private Guna.UI2.WinForms.Guna2TextBox patronymicTextBox;
        private System.Windows.Forms.Label newPassLabel;
        private Guna.UI2.WinForms.Guna2TextBox usernameTextBox;
        private System.Windows.Forms.Label oldPassLabel;
        private Guna.UI2.WinForms.Guna2TextBox surnameTextBox;
        private System.Windows.Forms.Label textInfoForUser;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label titleLabel;
    }
}