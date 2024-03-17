using Guna.UI2.WinForms;
using System.Drawing;

namespace ElStudent
{
    partial class elStudentForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerPanel = new System.Windows.Forms.Panel();
            this.panelDownText = new System.Windows.Forms.Panel();
            this.elStudentLabel = new System.Windows.Forms.Label();
            this.panelUpText = new System.Windows.Forms.Panel();
            this.registerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.readyBtn = new Guna.UI2.WinForms.Guna2Button();
            this.passwordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.loginTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.regHeaderText = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.registerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(114)))));
            this.headerPanel.Controls.Add(this.panelDownText);
            this.headerPanel.Controls.Add(this.elStudentLabel);
            this.headerPanel.Controls.Add(this.panelUpText);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1904, 75);
            this.headerPanel.TabIndex = 0;
            // 
            // panelDownText
            // 
            this.panelDownText.BackColor = System.Drawing.Color.White;
            this.panelDownText.Location = new System.Drawing.Point(340, 62);
            this.panelDownText.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelDownText.Name = "panelDownText";
            this.panelDownText.Size = new System.Drawing.Size(160, 2);
            this.panelDownText.TabIndex = 2;
            // 
            // elStudentLabel
            // 
            this.elStudentLabel.AutoSize = true;
            this.elStudentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.elStudentLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.elStudentLabel.Location = new System.Drawing.Point(334, 20);
            this.elStudentLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.elStudentLabel.Name = "elStudentLabel";
            this.elStudentLabel.Size = new System.Drawing.Size(177, 31);
            this.elStudentLabel.TabIndex = 1;
            this.elStudentLabel.Text = "ELSTUDENT";
            // 
            // panelUpText
            // 
            this.panelUpText.BackColor = System.Drawing.Color.White;
            this.panelUpText.Location = new System.Drawing.Point(340, 14);
            this.panelUpText.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelUpText.Name = "panelUpText";
            this.panelUpText.Size = new System.Drawing.Size(160, 2);
            this.panelUpText.TabIndex = 1;
            // 
            // registerPanel
            // 
            this.registerPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.registerPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.registerPanel.BorderRadius = 5;
            this.registerPanel.BorderThickness = 2;
            this.registerPanel.Controls.Add(this.readyBtn);
            this.registerPanel.Controls.Add(this.passwordTextBox);
            this.registerPanel.Controls.Add(this.loginTextBox);
            this.registerPanel.Controls.Add(this.passwordLabel);
            this.registerPanel.Controls.Add(this.loginLabel);
            this.registerPanel.Controls.Add(this.regHeaderText);
            this.registerPanel.Location = new System.Drawing.Point(666, 263);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Size = new System.Drawing.Size(600, 500);
            this.registerPanel.TabIndex = 1;
            // 
            // readyBtn
            // 
            this.readyBtn.BorderRadius = 5;
            this.readyBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.readyBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.readyBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.readyBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.readyBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(114)))));
            this.readyBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.readyBtn.ForeColor = System.Drawing.Color.White;
            this.readyBtn.Location = new System.Drawing.Point(58, 409);
            this.readyBtn.Name = "readyBtn";
            this.readyBtn.Size = new System.Drawing.Size(492, 54);
            this.readyBtn.TabIndex = 10;
            this.readyBtn.Text = "Войти";
            this.readyBtn.Click += new System.EventHandler(this.readyBtn_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderRadius = 5;
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.DefaultText = "";
            this.passwordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextBox.Location = new System.Drawing.Point(58, 291);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '●';
            this.passwordTextBox.PlaceholderText = "";
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.Size = new System.Drawing.Size(492, 53);
            this.passwordTextBox.TabIndex = 6;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // loginTextBox
            // 
            this.loginTextBox.BorderRadius = 5;
            this.loginTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginTextBox.DefaultText = "";
            this.loginTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.loginTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.loginTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginTextBox.Location = new System.Drawing.Point(58, 148);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.PasswordChar = '\0';
            this.loginTextBox.PlaceholderText = "";
            this.loginTextBox.SelectedText = "";
            this.loginTextBox.Size = new System.Drawing.Size(492, 53);
            this.loginTextBox.TabIndex = 5;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Candara Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(54, 242);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(70, 23);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Пароль";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Candara Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(54, 101);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(60, 23);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Логин";
            // 
            // regHeaderText
            // 
            this.regHeaderText.AutoSize = true;
            this.regHeaderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.regHeaderText.Location = new System.Drawing.Point(170, 25);
            this.regHeaderText.Name = "regHeaderText";
            this.regHeaderText.Size = new System.Drawing.Size(261, 39);
            this.regHeaderText.TabIndex = 0;
            this.regHeaderText.Text = "Вход в систему";
            // 
            // elStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.registerPanel);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "elStudentForm";
            this.Text = "ElStudent";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.elStudentForm_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.registerPanel.ResumeLayout(false);
            this.registerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel panelUpText;
        private System.Windows.Forms.Label elStudentLabel;
        private System.Windows.Forms.Panel panelDownText;
        private Guna2Panel registerPanel;
        private System.Windows.Forms.Label regHeaderText;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private Guna2TextBox loginTextBox;
        private Guna2TextBox passwordTextBox;
        private Guna2Button readyBtn;
    }
}

