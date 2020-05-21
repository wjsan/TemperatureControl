namespace TemperatureControl
{
    partial class StartScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.quitSelcted = new MetroFramework.Controls.MetroLabel();
            this.settingsSelected = new MetroFramework.Controls.MetroLabel();
            this.alarmsSelected = new MetroFramework.Controls.MetroLabel();
            this.homeSelected = new MetroFramework.Controls.MetroLabel();
            this.lQuit = new System.Windows.Forms.Label();
            this.lSettings = new System.Windows.Forms.Label();
            this.lAlarms = new System.Windows.Forms.Label();
            this.lHome = new System.Windows.Forms.Label();
            this.mainPanel = new MetroFramework.Controls.MetroPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAlarmCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.splitContainer1.Panel1.Controls.Add(this.labelAlarmCount);
            this.splitContainer1.Panel1.Controls.Add(this.quitSelcted);
            this.splitContainer1.Panel1.Controls.Add(this.settingsSelected);
            this.splitContainer1.Panel1.Controls.Add(this.alarmsSelected);
            this.splitContainer1.Panel1.Controls.Add(this.homeSelected);
            this.splitContainer1.Panel1.Controls.Add(this.lQuit);
            this.splitContainer1.Panel1.Controls.Add(this.lSettings);
            this.splitContainer1.Panel1.Controls.Add(this.lAlarms);
            this.splitContainer1.Panel1.Controls.Add(this.lHome);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.splitContainer1.Panel2.Controls.Add(this.mainPanel);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            // 
            // quitSelcted
            // 
            this.quitSelcted.BackColor = System.Drawing.SystemColors.HotTrack;
            resources.ApplyResources(this.quitSelcted, "quitSelcted");
            this.quitSelcted.Name = "quitSelcted";
            this.quitSelcted.UseCustomBackColor = true;
            // 
            // settingsSelected
            // 
            this.settingsSelected.BackColor = System.Drawing.SystemColors.HotTrack;
            resources.ApplyResources(this.settingsSelected, "settingsSelected");
            this.settingsSelected.Name = "settingsSelected";
            this.settingsSelected.UseCustomBackColor = true;
            // 
            // alarmsSelected
            // 
            this.alarmsSelected.BackColor = System.Drawing.SystemColors.HotTrack;
            resources.ApplyResources(this.alarmsSelected, "alarmsSelected");
            this.alarmsSelected.Name = "alarmsSelected";
            this.alarmsSelected.UseCustomBackColor = true;
            // 
            // homeSelected
            // 
            this.homeSelected.BackColor = System.Drawing.SystemColors.HotTrack;
            resources.ApplyResources(this.homeSelected, "homeSelected");
            this.homeSelected.Name = "homeSelected";
            this.homeSelected.UseCustomBackColor = true;
            // 
            // lQuit
            // 
            resources.ApplyResources(this.lQuit, "lQuit");
            this.lQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lQuit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lQuit.Image = global::TemperatureControl.Properties.Resources.exit;
            this.lQuit.Name = "lQuit";
            this.lQuit.Click += new System.EventHandler(this.lQuit_Click);
            this.lQuit.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.lQuit.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // lSettings
            // 
            resources.ApplyResources(this.lSettings, "lSettings");
            this.lSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lSettings.Image = global::TemperatureControl.Properties.Resources.seetings;
            this.lSettings.Name = "lSettings";
            this.lSettings.Click += new System.EventHandler(this.label_Click);
            this.lSettings.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.lSettings.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // lAlarms
            // 
            resources.ApplyResources(this.lAlarms, "lAlarms");
            this.lAlarms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lAlarms.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lAlarms.Image = global::TemperatureControl.Properties.Resources.alarm;
            this.lAlarms.Name = "lAlarms";
            this.lAlarms.Click += new System.EventHandler(this.label_Click);
            this.lAlarms.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.lAlarms.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // lHome
            // 
            resources.ApplyResources(this.lHome, "lHome");
            this.lHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lHome.Image = global::TemperatureControl.Properties.Resources.home;
            this.lHome.Name = "lHome";
            this.lHome.Click += new System.EventHandler(this.label_Click);
            this.lHome.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.lHome.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // mainPanel
            // 
            resources.ApplyResources(this.mainPanel, "mainPanel");
            this.mainPanel.HorizontalScrollbarBarColor = true;
            this.mainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mainPanel.HorizontalScrollbarSize = 10;
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mainPanel.VerticalScrollbarBarColor = true;
            this.mainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mainPanel.VerticalScrollbarSize = 10;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Name = "label1";
            // 
            // labelAlarmCount
            // 
            resources.ApplyResources(this.labelAlarmCount, "labelAlarmCount");
            this.labelAlarmCount.BackColor = System.Drawing.Color.Red;
            this.labelAlarmCount.ForeColor = System.Drawing.Color.White;
            this.labelAlarmCount.Name = "labelAlarmCount";
            // 
            // StartScreen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lHome;
        private System.Windows.Forms.Label lAlarms;
        private System.Windows.Forms.Label lSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lQuit;
        private MetroFramework.Controls.MetroPanel mainPanel;
        private MetroFramework.Controls.MetroLabel quitSelcted;
        private MetroFramework.Controls.MetroLabel settingsSelected;
        private MetroFramework.Controls.MetroLabel alarmsSelected;
        private MetroFramework.Controls.MetroLabel homeSelected;
        private System.Windows.Forms.Label labelAlarmCount;
    }
}