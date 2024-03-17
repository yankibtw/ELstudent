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
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(114)))));
            this.headerPanel.Controls.Add(this.usernameHeaderLabel);
            this.headerPanel.Controls.Add(this.menuLabel);
            this.headerPanel.Controls.Add(this.guna2ImageButton1);
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
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Image = global::ElStudent.Properties.Resources.Vector;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Location = new System.Drawing.Point(20, 17);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 65);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1904, 976);
            this.mainPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.headerPanel);
            this.Name = "MainForm";
            this.Text = "elStudent";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label usernameHeaderLabel;
    }
}