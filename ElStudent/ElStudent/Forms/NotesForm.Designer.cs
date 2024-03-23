namespace ElStudent.Forms
{
    partial class NotesForm
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
            this.notesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.titleMenuLabel = new System.Windows.Forms.Label();
            this.titleMenuPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.someNotesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.titleMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // notesBtn
            // 
            this.notesBtn.BorderRadius = 5;
            this.notesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.notesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.notesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.notesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.notesBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(114)))));
            this.notesBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.notesBtn.ForeColor = System.Drawing.Color.White;
            this.notesBtn.Location = new System.Drawing.Point(250, 201);
            this.notesBtn.Margin = new System.Windows.Forms.Padding(0);
            this.notesBtn.Name = "notesBtn";
            this.notesBtn.Size = new System.Drawing.Size(420, 65);
            this.notesBtn.TabIndex = 1;
            this.notesBtn.Text = "Название заметки";
            this.notesBtn.Click += new System.EventHandler(this.notesBtn_Click);
            // 
            // titleMenuLabel
            // 
            this.titleMenuLabel.AutoSize = true;
            this.titleMenuLabel.Location = new System.Drawing.Point(156, 13);
            this.titleMenuLabel.Name = "titleMenuLabel";
            this.titleMenuLabel.Size = new System.Drawing.Size(51, 13);
            this.titleMenuLabel.TabIndex = 0;
            this.titleMenuLabel.Text = "Заметки";
            // 
            // titleMenuPanel
            // 
            this.titleMenuPanel.BorderColor = System.Drawing.Color.Black;
            this.titleMenuPanel.BorderRadius = 5;
            this.titleMenuPanel.Controls.Add(this.titleMenuLabel);
            this.titleMenuPanel.Location = new System.Drawing.Point(250, 136);
            this.titleMenuPanel.Name = "titleMenuPanel";
            this.titleMenuPanel.Size = new System.Drawing.Size(420, 65);
            this.titleMenuPanel.TabIndex = 0;
            // 
            // someNotesBtn
            // 
            this.someNotesBtn.BorderRadius = 5;
            this.someNotesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.someNotesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.someNotesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.someNotesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.someNotesBtn.FillColor = System.Drawing.Color.White;
            this.someNotesBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.someNotesBtn.ForeColor = System.Drawing.Color.Black;
            this.someNotesBtn.Location = new System.Drawing.Point(250, 266);
            this.someNotesBtn.Margin = new System.Windows.Forms.Padding(0);
            this.someNotesBtn.Name = "someNotesBtn";
            this.someNotesBtn.Size = new System.Drawing.Size(420, 65);
            this.someNotesBtn.TabIndex = 2;
            this.someNotesBtn.Text = "Название заметки";
            // 
            // NotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 741);
            this.Controls.Add(this.someNotesBtn);
            this.Controls.Add(this.notesBtn);
            this.Controls.Add(this.titleMenuPanel);
            this.Name = "NotesForm";
            this.Text = "NotesForm";
            this.Load += new System.EventHandler(this.NotesForm_Load);
            this.titleMenuPanel.ResumeLayout(false);
            this.titleMenuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button notesBtn;
        private System.Windows.Forms.Label titleMenuLabel;
        private Guna.UI2.WinForms.Guna2Panel titleMenuPanel;
        private Guna.UI2.WinForms.Guna2Button someNotesBtn;
    }
}