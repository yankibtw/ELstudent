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
            this.titleMenuLabel = new System.Windows.Forms.Label();
            this.titleMenuPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.notesFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.someNotePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.someNoteTextPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.someTitleLabel = new System.Windows.Forms.Label();
            this.someNoteText = new System.Windows.Forms.RichTextBox();
            this.helpPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.saveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.titleMenuPanel.SuspendLayout();
            this.someNotePanel.SuspendLayout();
            this.someNoteTextPanel.SuspendLayout();
            this.helpPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.titleMenuPanel.BorderThickness = 1;
            this.titleMenuPanel.Controls.Add(this.titleMenuLabel);
            this.titleMenuPanel.Location = new System.Drawing.Point(250, 136);
            this.titleMenuPanel.Name = "titleMenuPanel";
            this.titleMenuPanel.Size = new System.Drawing.Size(420, 65);
            this.titleMenuPanel.TabIndex = 10;
            // 
            // notesFlowPanel
            // 
            this.notesFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.notesFlowPanel.Location = new System.Drawing.Point(250, 201);
            this.notesFlowPanel.Name = "notesFlowPanel";
            this.notesFlowPanel.Size = new System.Drawing.Size(420, 493);
            this.notesFlowPanel.TabIndex = 3;
            this.notesFlowPanel.WrapContents = false;
            // 
            // someNotePanel
            // 
            this.someNotePanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.someNotePanel.BorderRadius = 5;
            this.someNotePanel.BorderThickness = 1;
            this.someNotePanel.Controls.Add(this.helpPanel);
            this.someNotePanel.Controls.Add(this.someNoteTextPanel);
            this.someNotePanel.Controls.Add(this.someTitleLabel);
            this.someNotePanel.Location = new System.Drawing.Point(892, 136);
            this.someNotePanel.Name = "someNotePanel";
            this.someNotePanel.Padding = new System.Windows.Forms.Padding(3);
            this.someNotePanel.Size = new System.Drawing.Size(980, 590);
            this.someNotePanel.TabIndex = 11;
            // 
            // someNoteTextPanel
            // 
            this.someNoteTextPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.someNoteTextPanel.BorderRadius = 5;
            this.someNoteTextPanel.BorderThickness = 1;
            this.someNoteTextPanel.Controls.Add(this.someNoteText);
            this.someNoteTextPanel.Location = new System.Drawing.Point(30, 64);
            this.someNoteTextPanel.Name = "someNoteTextPanel";
            this.someNoteTextPanel.Padding = new System.Windows.Forms.Padding(3);
            this.someNoteTextPanel.Size = new System.Drawing.Size(920, 423);
            this.someNoteTextPanel.TabIndex = 12;
            // 
            // someTitleLabel
            // 
            this.someTitleLabel.AutoSize = true;
            this.someTitleLabel.Location = new System.Drawing.Point(396, 16);
            this.someTitleLabel.Name = "someTitleLabel";
            this.someTitleLabel.Size = new System.Drawing.Size(103, 13);
            this.someTitleLabel.TabIndex = 0;
            this.someTitleLabel.Text = "Название заметки";
            this.someTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // someNoteText
            // 
            this.someNoteText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.someNoteText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.someNoteText.Location = new System.Drawing.Point(3, 3);
            this.someNoteText.Name = "someNoteText";
            this.someNoteText.Size = new System.Drawing.Size(914, 417);
            this.someNoteText.TabIndex = 0;
            this.someNoteText.Text = "";
            // 
            // helpPanel
            // 
            this.helpPanel.Controls.Add(this.saveBtn);
            this.helpPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.helpPanel.Location = new System.Drawing.Point(3, 487);
            this.helpPanel.Name = "helpPanel";
            this.helpPanel.Size = new System.Drawing.Size(974, 100);
            this.helpPanel.TabIndex = 13;
            // 
            // saveBtn
            // 
            this.saveBtn.BorderRadius = 5;
            this.saveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(114)))));
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(430, 31);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(180, 50);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // NotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 741);
            this.Controls.Add(this.someNotePanel);
            this.Controls.Add(this.notesFlowPanel);
            this.Controls.Add(this.titleMenuPanel);
            this.Name = "NotesForm";
            this.Text = "NotesForm";
            this.Load += new System.EventHandler(this.NotesForm_Load);
            this.titleMenuPanel.ResumeLayout(false);
            this.titleMenuPanel.PerformLayout();
            this.someNotePanel.ResumeLayout(false);
            this.someNotePanel.PerformLayout();
            this.someNoteTextPanel.ResumeLayout(false);
            this.helpPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label titleMenuLabel;
        private Guna.UI2.WinForms.Guna2Panel titleMenuPanel;
        private System.Windows.Forms.FlowLayoutPanel notesFlowPanel;
        private Guna.UI2.WinForms.Guna2Panel someNotePanel;
        private System.Windows.Forms.Label someTitleLabel;
        private Guna.UI2.WinForms.Guna2Panel someNoteTextPanel;
        private System.Windows.Forms.RichTextBox someNoteText;
        private Guna.UI2.WinForms.Guna2Panel helpPanel;
        private Guna.UI2.WinForms.Guna2Button saveBtn;
    }
}