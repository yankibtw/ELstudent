namespace ElStudent.Forms
{
    partial class EditPersonInfoForm
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
            this.buttonsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.passwordEditBtn = new Guna.UI2.WinForms.Guna2Button();
            this.personalInfoBtn = new Guna.UI2.WinForms.Guna2Button();
            this.mainEditPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.passwordEditBtn);
            this.buttonsPanel.Controls.Add(this.personalInfoBtn);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonsPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Padding = new System.Windows.Forms.Padding(250, 137, 0, 0);
            this.buttonsPanel.Size = new System.Drawing.Size(670, 1041);
            this.buttonsPanel.TabIndex = 0;
            // 
            // passwordEditBtn
            // 
            this.passwordEditBtn.BorderRadius = 5;
            this.passwordEditBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.passwordEditBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.passwordEditBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.passwordEditBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.passwordEditBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.passwordEditBtn.FillColor = System.Drawing.Color.Transparent;
            this.passwordEditBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordEditBtn.ForeColor = System.Drawing.Color.Black;
            this.passwordEditBtn.Location = new System.Drawing.Point(250, 202);
            this.passwordEditBtn.Name = "passwordEditBtn";
            this.passwordEditBtn.Size = new System.Drawing.Size(420, 65);
            this.passwordEditBtn.TabIndex = 1;
            this.passwordEditBtn.Text = "Изменить пароль";
            this.passwordEditBtn.Click += new System.EventHandler(this.passwordEditBtn_Click);
            // 
            // personalInfoBtn
            // 
            this.personalInfoBtn.BorderRadius = 5;
            this.personalInfoBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.personalInfoBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.personalInfoBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.personalInfoBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.personalInfoBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.personalInfoBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(135)))), ((int)(((byte)(177)))));
            this.personalInfoBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.personalInfoBtn.ForeColor = System.Drawing.Color.White;
            this.personalInfoBtn.Location = new System.Drawing.Point(250, 137);
            this.personalInfoBtn.Name = "personalInfoBtn";
            this.personalInfoBtn.Size = new System.Drawing.Size(420, 65);
            this.personalInfoBtn.TabIndex = 0;
            this.personalInfoBtn.Text = "Личные данные";
            this.personalInfoBtn.Click += new System.EventHandler(this.personalInfoBtn_Click);
            // 
            // mainEditPanel
            // 
            this.mainEditPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainEditPanel.Location = new System.Drawing.Point(670, 0);
            this.mainEditPanel.Name = "mainEditPanel";
            this.mainEditPanel.Size = new System.Drawing.Size(1234, 1041);
            this.mainEditPanel.TabIndex = 1;
            // 
            // EditPersonInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.mainEditPanel);
            this.Controls.Add(this.buttonsPanel);
            this.Name = "EditPersonInfoForm";
            this.Text = "EditPersonInfoForm";
            this.Load += new System.EventHandler(this.EditPersonInfoForm_Load);
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel buttonsPanel;
        private Guna.UI2.WinForms.Guna2Button personalInfoBtn;
        private Guna.UI2.WinForms.Guna2Button passwordEditBtn;
        private Guna.UI2.WinForms.Guna2Panel mainEditPanel;
    }
}