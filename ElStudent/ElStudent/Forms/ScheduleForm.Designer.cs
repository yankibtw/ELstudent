namespace ElStudent.Forms
{
    partial class ScheduleForm
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
            this.navigationPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.navResultLabel = new System.Windows.Forms.Label();
            this.navDiaryLabel = new System.Windows.Forms.Label();
            this.userFullNameLabel = new System.Windows.Forms.Label();
            this.navRightBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.navLeftBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.mainSchedulePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.mainSchedulaFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.tableHeaderPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.markTextLabel = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.hwTextLabel = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.subjectTextLabel = new System.Windows.Forms.Label();
            this.datePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.dateTextLabel = new System.Windows.Forms.Label();
            this.dayOfWeekPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.dayOfWeekLabel = new System.Windows.Forms.Label();
            this.currentDateText = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.navigationPanel.SuspendLayout();
            this.mainSchedulePanel.SuspendLayout();
            this.tableHeaderPanel.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.datePanel.SuspendLayout();
            this.dayOfWeekPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.SystemColors.Control;
            this.navigationPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.navigationPanel.BorderThickness = 1;
            this.navigationPanel.Controls.Add(this.navResultLabel);
            this.navigationPanel.Controls.Add(this.navDiaryLabel);
            this.navigationPanel.Controls.Add(this.userFullNameLabel);
            this.navigationPanel.Controls.Add(this.navRightBtn);
            this.navigationPanel.Controls.Add(this.navLeftBtn);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationPanel.Location = new System.Drawing.Point(0, 35);
            this.navigationPanel.Margin = new System.Windows.Forms.Padding(0);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(1904, 100);
            this.navigationPanel.TabIndex = 0;
            // 
            // navResultLabel
            // 
            this.navResultLabel.AutoSize = true;
            this.navResultLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(114)))));
            this.navResultLabel.Location = new System.Drawing.Point(1270, 32);
            this.navResultLabel.Name = "navResultLabel";
            this.navResultLabel.Size = new System.Drawing.Size(98, 13);
            this.navResultLabel.TabIndex = 4;
            this.navResultLabel.Text = "Итоги за семестр";
            // 
            // navDiaryLabel
            // 
            this.navDiaryLabel.AutoSize = true;
            this.navDiaryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(114)))));
            this.navDiaryLabel.Location = new System.Drawing.Point(1027, 32);
            this.navDiaryLabel.Name = "navDiaryLabel";
            this.navDiaryLabel.Size = new System.Drawing.Size(52, 13);
            this.navDiaryLabel.TabIndex = 3;
            this.navDiaryLabel.Text = "Дневник";
            // 
            // userFullNameLabel
            // 
            this.userFullNameLabel.AutoSize = true;
            this.userFullNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(114)))));
            this.userFullNameLabel.Location = new System.Drawing.Point(343, 32);
            this.userFullNameLabel.Name = "userFullNameLabel";
            this.userFullNameLabel.Size = new System.Drawing.Size(34, 13);
            this.userFullNameLabel.TabIndex = 2;
            this.userFullNameLabel.Text = "ФИО";
            // 
            // navRightBtn
            // 
            this.navRightBtn.BackColor = System.Drawing.Color.Transparent;
            this.navRightBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.navRightBtn.CheckedState.ImageSize = new System.Drawing.Size(38, 38);
            this.navRightBtn.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.navRightBtn.Image = global::ElStudent.Properties.Resources.navigationArrow1;
            this.navRightBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.navRightBtn.ImageRotate = 0F;
            this.navRightBtn.ImageSize = new System.Drawing.Size(38, 38);
            this.navRightBtn.Location = new System.Drawing.Point(1804, 31);
            this.navRightBtn.Name = "navRightBtn";
            this.navRightBtn.PressedState.ImageSize = new System.Drawing.Size(38, 38);
            this.navRightBtn.Size = new System.Drawing.Size(40, 40);
            this.navRightBtn.TabIndex = 1;
            // 
            // navLeftBtn
            // 
            this.navLeftBtn.BackColor = System.Drawing.Color.Transparent;
            this.navLeftBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.navLeftBtn.CheckedState.ImageSize = new System.Drawing.Size(38, 38);
            this.navLeftBtn.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.navLeftBtn.Image = global::ElStudent.Properties.Resources.navigationArrow;
            this.navLeftBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.navLeftBtn.ImageRotate = 0F;
            this.navLeftBtn.ImageSize = new System.Drawing.Size(38, 38);
            this.navLeftBtn.Location = new System.Drawing.Point(43, 31);
            this.navLeftBtn.Name = "navLeftBtn";
            this.navLeftBtn.PressedState.ImageSize = new System.Drawing.Size(38, 38);
            this.navLeftBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.navLeftBtn.Size = new System.Drawing.Size(40, 40);
            this.navLeftBtn.TabIndex = 0;
            // 
            // mainSchedulePanel
            // 
            this.mainSchedulePanel.Controls.Add(this.mainSchedulaFlow);
            this.mainSchedulePanel.Controls.Add(this.tableHeaderPanel);
            this.mainSchedulePanel.Controls.Add(this.dayOfWeekPanel);
            this.mainSchedulePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSchedulePanel.Location = new System.Drawing.Point(0, 135);
            this.mainSchedulePanel.Name = "mainSchedulePanel";
            this.mainSchedulePanel.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.mainSchedulePanel.Size = new System.Drawing.Size(1904, 906);
            this.mainSchedulePanel.TabIndex = 1;
            // 
            // mainSchedulaFlow
            // 
            this.mainSchedulaFlow.Location = new System.Drawing.Point(46, 114);
            this.mainSchedulaFlow.Margin = new System.Windows.Forms.Padding(0);
            this.mainSchedulaFlow.Name = "mainSchedulaFlow";
            this.mainSchedulaFlow.Size = new System.Drawing.Size(889, 419);
            this.mainSchedulaFlow.TabIndex = 3;
            // 
            // tableHeaderPanel
            // 
            this.tableHeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.tableHeaderPanel.BorderColor = System.Drawing.Color.Black;
            this.tableHeaderPanel.BorderThickness = 1;
            this.tableHeaderPanel.Controls.Add(this.markTextLabel);
            this.tableHeaderPanel.Controls.Add(this.guna2Panel2);
            this.tableHeaderPanel.Controls.Add(this.guna2Panel1);
            this.tableHeaderPanel.Controls.Add(this.datePanel);
            this.tableHeaderPanel.Location = new System.Drawing.Point(0, 35);
            this.tableHeaderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableHeaderPanel.Name = "tableHeaderPanel";
            this.tableHeaderPanel.Size = new System.Drawing.Size(935, 79);
            this.tableHeaderPanel.TabIndex = 1;
            // 
            // markTextLabel
            // 
            this.markTextLabel.AutoSize = true;
            this.markTextLabel.Location = new System.Drawing.Point(859, 22);
            this.markTextLabel.Name = "markTextLabel";
            this.markTextLabel.Size = new System.Drawing.Size(32, 13);
            this.markTextLabel.TabIndex = 1;
            this.markTextLabel.Text = "Балл";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.hwTextLabel);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(405, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(445, 79);
            this.guna2Panel2.TabIndex = 2;
            // 
            // hwTextLabel
            // 
            this.hwTextLabel.AutoSize = true;
            this.hwTextLabel.Location = new System.Drawing.Point(128, 22);
            this.hwTextLabel.Name = "hwTextLabel";
            this.hwTextLabel.Size = new System.Drawing.Size(107, 13);
            this.hwTextLabel.TabIndex = 0;
            this.hwTextLabel.Text = "Домашнее задание";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.subjectTextLabel);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(46, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(359, 79);
            this.guna2Panel1.TabIndex = 1;
            // 
            // subjectTextLabel
            // 
            this.subjectTextLabel.AutoSize = true;
            this.subjectTextLabel.Location = new System.Drawing.Point(100, 22);
            this.subjectTextLabel.Name = "subjectTextLabel";
            this.subjectTextLabel.Size = new System.Drawing.Size(52, 13);
            this.subjectTextLabel.TabIndex = 0;
            this.subjectTextLabel.Text = "Предмет";
            // 
            // datePanel
            // 
            this.datePanel.BorderColor = System.Drawing.Color.Black;
            this.datePanel.BorderThickness = 1;
            this.datePanel.Controls.Add(this.dateTextLabel);
            this.datePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.datePanel.Location = new System.Drawing.Point(0, 0);
            this.datePanel.Margin = new System.Windows.Forms.Padding(0);
            this.datePanel.Name = "datePanel";
            this.datePanel.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.datePanel.Size = new System.Drawing.Size(46, 79);
            this.datePanel.TabIndex = 0;
            // 
            // dateTextLabel
            // 
            this.dateTextLabel.AutoSize = true;
            this.dateTextLabel.Location = new System.Drawing.Point(11, 10);
            this.dateTextLabel.Name = "dateTextLabel";
            this.dateTextLabel.Size = new System.Drawing.Size(16, 52);
            this.dateTextLabel.TabIndex = 0;
            this.dateTextLabel.Text = "Д\r\nа\r\nт\r\nа";
            this.dateTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayOfWeekPanel
            // 
            this.dayOfWeekPanel.BorderColor = System.Drawing.Color.Black;
            this.dayOfWeekPanel.BorderThickness = 1;
            this.dayOfWeekPanel.Controls.Add(this.dayOfWeekLabel);
            this.dayOfWeekPanel.Controls.Add(this.currentDateText);
            this.dayOfWeekPanel.Location = new System.Drawing.Point(0, 114);
            this.dayOfWeekPanel.Margin = new System.Windows.Forms.Padding(0);
            this.dayOfWeekPanel.Name = "dayOfWeekPanel";
            this.dayOfWeekPanel.Size = new System.Drawing.Size(46, 333);
            this.dayOfWeekPanel.TabIndex = 2;
            // 
            // dayOfWeekLabel
            // 
            this.dayOfWeekLabel.AutoSize = true;
            this.dayOfWeekLabel.Location = new System.Drawing.Point(14, 86);
            this.dayOfWeekLabel.Name = "dayOfWeekLabel";
            this.dayOfWeekLabel.Size = new System.Drawing.Size(15, 143);
            this.dayOfWeekLabel.TabIndex = 1;
            this.dayOfWeekLabel.Text = "П\r\nо\r\nн\r\nе\r\nд\r\nе\r\nл\r\nь\r\nн\r\nи\r\nк";
            // 
            // currentDateText
            // 
            this.currentDateText.AutoSize = true;
            this.currentDateText.Location = new System.Drawing.Point(14, 38);
            this.currentDateText.Name = "currentDateText";
            this.currentDateText.Size = new System.Drawing.Size(13, 26);
            this.currentDateText.TabIndex = 0;
            this.currentDateText.Text = "1\r\n3";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(3, 3);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(923, 366);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.mainSchedulePanel);
            this.Controls.Add(this.navigationPanel);
            this.Name = "ScheduleForm";
            this.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.Text = "ScheduleForm";
            this.Load += new System.EventHandler(this.ScheduleForm_Load);
            this.navigationPanel.ResumeLayout(false);
            this.navigationPanel.PerformLayout();
            this.mainSchedulePanel.ResumeLayout(false);
            this.tableHeaderPanel.ResumeLayout(false);
            this.tableHeaderPanel.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.datePanel.ResumeLayout(false);
            this.datePanel.PerformLayout();
            this.dayOfWeekPanel.ResumeLayout(false);
            this.dayOfWeekPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel navigationPanel;
        private Guna.UI2.WinForms.Guna2ImageButton navLeftBtn;
        private Guna.UI2.WinForms.Guna2ImageButton navRightBtn;
        private System.Windows.Forms.Label userFullNameLabel;
        private System.Windows.Forms.Label navResultLabel;
        private System.Windows.Forms.Label navDiaryLabel;
        private Guna.UI2.WinForms.Guna2Panel mainSchedulePanel;
        private Guna.UI2.WinForms.Guna2Panel tableHeaderPanel;
        private Guna.UI2.WinForms.Guna2Panel datePanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label dateTextLabel;
        private System.Windows.Forms.Label markTextLabel;
        private System.Windows.Forms.Label hwTextLabel;
        private System.Windows.Forms.Label subjectTextLabel;
        private Guna.UI2.WinForms.Guna2Panel dayOfWeekPanel;
        private System.Windows.Forms.Label currentDateText;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label dayOfWeekLabel;
        private System.Windows.Forms.FlowLayoutPanel mainSchedulaFlow;
    }
}