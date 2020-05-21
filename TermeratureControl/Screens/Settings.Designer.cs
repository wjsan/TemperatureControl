namespace TemperatureControl
{
    partial class Settings
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.lHome = new System.Windows.Forms.Label();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbPort = new MetroFramework.Controls.MetroComboBox();
            this.cbBaudRate = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cbLanguage = new MetroFramework.Controls.MetroComboBox();
            this.toggleSturtupConnect = new TemperatureControl.Toggle();
            this.toggleConnection = new TemperatureControl.Toggle();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lHome
            // 
            resources.ApplyResources(this.lHome, "lHome");
            this.lHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lHome.Name = "lHome";
            // 
            // metroLabel1
            // 
            resources.ApplyResources(this.metroLabel1, "metroLabel1");
            this.metroLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            resources.ApplyResources(this.metroLabel2, "metroLabel2");
            this.metroLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // cbPort
            // 
            resources.ApplyResources(this.cbPort, "cbPort");
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Name = "cbPort";
            this.cbPort.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbPort.UseSelectable = true;
            this.cbPort.SelectedIndexChanged += new System.EventHandler(this.cbPort_SelectedIndexChanged);
            this.cbPort.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbPort_MouseClick);
            // 
            // cbBaudRate
            // 
            resources.ApplyResources(this.cbBaudRate, "cbBaudRate");
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            resources.GetString("cbBaudRate.Items"),
            resources.GetString("cbBaudRate.Items1"),
            resources.GetString("cbBaudRate.Items2"),
            resources.GetString("cbBaudRate.Items3"),
            resources.GetString("cbBaudRate.Items4"),
            resources.GetString("cbBaudRate.Items5"),
            resources.GetString("cbBaudRate.Items6"),
            resources.GetString("cbBaudRate.Items7"),
            resources.GetString("cbBaudRate.Items8"),
            resources.GetString("cbBaudRate.Items9"),
            resources.GetString("cbBaudRate.Items10"),
            resources.GetString("cbBaudRate.Items11"),
            resources.GetString("cbBaudRate.Items12"),
            resources.GetString("cbBaudRate.Items13")});
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbBaudRate.UseSelectable = true;
            this.cbBaudRate.SelectedIndexChanged += new System.EventHandler(this.cbBaudRate_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            resources.ApplyResources(this.metroLabel3, "metroLabel3");
            this.metroLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // cbLanguage
            // 
            resources.ApplyResources(this.cbLanguage, "cbLanguage");
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Items.AddRange(new object[] {
            resources.GetString("cbLanguage.Items"),
            resources.GetString("cbLanguage.Items1")});
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbLanguage.UseSelectable = true;
            this.cbLanguage.SelectedIndexChanged += new System.EventHandler(this.cbLanguage_SelectedIndexChanged);
            // 
            // toggleSturtupConnect
            // 
            resources.ApplyResources(this.toggleSturtupConnect, "toggleSturtupConnect");
            this.toggleSturtupConnect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toggleSturtupConnect.Name = "toggleSturtupConnect";
            this.toggleSturtupConnect.ToggleStatus = false;
            this.toggleSturtupConnect.OnToggle += new TemperatureControl.Toggle.ToggleEventHandler(this.toogleSturtupConnect_OnToggle);
            // 
            // toggleConnection
            // 
            resources.ApplyResources(this.toggleConnection, "toggleConnection");
            this.toggleConnection.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toggleConnection.Name = "toggleConnection";
            this.toggleConnection.ToggleStatus = false;
            this.toggleConnection.OnToggle += new TemperatureControl.Toggle.ToggleEventHandler(this.toogleConnection_OnToggle);
            // 
            // metroLabel4
            // 
            resources.ApplyResources(this.metroLabel4, "metroLabel4");
            this.metroLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // Settings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.cbBaudRate);
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.cbPort);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.toggleConnection);
            this.Controls.Add(this.toggleSturtupConnect);
            this.Controls.Add(this.lHome);
            this.Name = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lHome;
        private Toggle toggleSturtupConnect;
        private Toggle toggleConnection;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cbPort;
        private MetroFramework.Controls.MetroComboBox cbBaudRate;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cbLanguage;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}
