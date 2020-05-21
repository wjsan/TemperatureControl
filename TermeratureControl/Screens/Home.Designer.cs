namespace TemperatureControl
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.lHome = new System.Windows.Forms.Label();
            this.imageStatusList = new System.Windows.Forms.ImageList(this.components);
            this.tbSetPoint = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbHisteresis = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.tbAlarmHigh = new MetroFramework.Controls.MetroTextBox();
            this.tbAlarmLow = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.temperatureIndicator = new TemperatureControl.TemperatureIndicator();
            this.toggleFurnace = new TemperatureControl.Toggle();
            this.toggleAutomatic = new TemperatureControl.Toggle();
            this.statusFurnace = new TemperatureControl.Status();
            this.rounded1 = new TemperatureControl.Rounded();
            this.picFurnaceStatus = new TemperatureControl.FurnaceStatus();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lHome
            // 
            resources.ApplyResources(this.lHome, "lHome");
            this.lHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lHome.Name = "lHome";
            // 
            // imageStatusList
            // 
            this.imageStatusList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageStatusList.ImageStream")));
            this.imageStatusList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageStatusList.Images.SetKeyName(0, "disabled.png");
            this.imageStatusList.Images.SetKeyName(1, "enabled.png");
            this.imageStatusList.Images.SetKeyName(2, "error.png");
            // 
            // tbSetPoint
            // 
            resources.ApplyResources(this.tbSetPoint, "tbSetPoint");
            // 
            // 
            // 
            this.tbSetPoint.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription");
            this.tbSetPoint.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName");
            this.tbSetPoint.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("resource.Anchor")));
            this.tbSetPoint.CustomButton.AutoSize = ((bool)(resources.GetObject("resource.AutoSize")));
            this.tbSetPoint.CustomButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("resource.AutoSizeMode")));
            this.tbSetPoint.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage")));
            this.tbSetPoint.CustomButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("resource.BackgroundImageLayout")));
            this.tbSetPoint.CustomButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock")));
            this.tbSetPoint.CustomButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("resource.FlatStyle")));
            this.tbSetPoint.CustomButton.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font")));
            this.tbSetPoint.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.tbSetPoint.CustomButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.ImageAlign")));
            this.tbSetPoint.CustomButton.ImageIndex = ((int)(resources.GetObject("resource.ImageIndex")));
            this.tbSetPoint.CustomButton.ImageKey = resources.GetString("resource.ImageKey");
            this.tbSetPoint.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.tbSetPoint.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.tbSetPoint.CustomButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("resource.MaximumSize")));
            this.tbSetPoint.CustomButton.Name = "";
            this.tbSetPoint.CustomButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("resource.RightToLeft")));
            this.tbSetPoint.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.tbSetPoint.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSetPoint.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.tbSetPoint.CustomButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlign")));
            this.tbSetPoint.CustomButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("resource.TextImageRelation")));
            this.tbSetPoint.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSetPoint.CustomButton.UseSelectable = true;
            this.tbSetPoint.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.tbSetPoint.Lines = new string[0];
            this.tbSetPoint.MaxLength = 32767;
            this.tbSetPoint.Name = "tbSetPoint";
            this.tbSetPoint.PasswordChar = '\0';
            this.tbSetPoint.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSetPoint.SelectedText = "";
            this.tbSetPoint.SelectionLength = 0;
            this.tbSetPoint.SelectionStart = 0;
            this.tbSetPoint.ShortcutsEnabled = true;
            this.tbSetPoint.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbSetPoint.UseSelectable = true;
            this.tbSetPoint.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSetPoint.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbSetPoint.TextChanged += new System.EventHandler(this.tbSetPoint_TextChanged);
            // 
            // metroLabel1
            // 
            resources.ApplyResources(this.metroLabel1, "metroLabel1");
            this.metroLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // tbHisteresis
            // 
            resources.ApplyResources(this.tbHisteresis, "tbHisteresis");
            // 
            // 
            // 
            this.tbHisteresis.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription1");
            this.tbHisteresis.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName1");
            this.tbHisteresis.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("resource.Anchor1")));
            this.tbHisteresis.CustomButton.AutoSize = ((bool)(resources.GetObject("resource.AutoSize1")));
            this.tbHisteresis.CustomButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("resource.AutoSizeMode1")));
            this.tbHisteresis.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage1")));
            this.tbHisteresis.CustomButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("resource.BackgroundImageLayout1")));
            this.tbHisteresis.CustomButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock1")));
            this.tbHisteresis.CustomButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("resource.FlatStyle1")));
            this.tbHisteresis.CustomButton.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font1")));
            this.tbHisteresis.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.tbHisteresis.CustomButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.ImageAlign1")));
            this.tbHisteresis.CustomButton.ImageIndex = ((int)(resources.GetObject("resource.ImageIndex1")));
            this.tbHisteresis.CustomButton.ImageKey = resources.GetString("resource.ImageKey1");
            this.tbHisteresis.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode1")));
            this.tbHisteresis.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.tbHisteresis.CustomButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("resource.MaximumSize1")));
            this.tbHisteresis.CustomButton.Name = "";
            this.tbHisteresis.CustomButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("resource.RightToLeft1")));
            this.tbHisteresis.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.tbHisteresis.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbHisteresis.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.tbHisteresis.CustomButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlign1")));
            this.tbHisteresis.CustomButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("resource.TextImageRelation1")));
            this.tbHisteresis.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbHisteresis.CustomButton.UseSelectable = true;
            this.tbHisteresis.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            this.tbHisteresis.Lines = new string[0];
            this.tbHisteresis.MaxLength = 32767;
            this.tbHisteresis.Name = "tbHisteresis";
            this.tbHisteresis.PasswordChar = '\0';
            this.tbHisteresis.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbHisteresis.SelectedText = "";
            this.tbHisteresis.SelectionLength = 0;
            this.tbHisteresis.SelectionStart = 0;
            this.tbHisteresis.ShortcutsEnabled = true;
            this.tbHisteresis.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbHisteresis.UseSelectable = true;
            this.tbHisteresis.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbHisteresis.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbHisteresis.TextChanged += new System.EventHandler(this.tbHisteresis_TextChanged);
            // 
            // metroLabel2
            // 
            resources.ApplyResources(this.metroLabel2, "metroLabel2");
            this.metroLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            resources.ApplyResources(this.metroLabel3, "metroLabel3");
            this.metroLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            resources.ApplyResources(this.metroLabel4, "metroLabel4");
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel5
            // 
            resources.ApplyResources(this.metroLabel5, "metroLabel5");
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // tbAlarmHigh
            // 
            resources.ApplyResources(this.tbAlarmHigh, "tbAlarmHigh");
            // 
            // 
            // 
            this.tbAlarmHigh.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription2");
            this.tbAlarmHigh.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName2");
            this.tbAlarmHigh.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("resource.Anchor2")));
            this.tbAlarmHigh.CustomButton.AutoSize = ((bool)(resources.GetObject("resource.AutoSize2")));
            this.tbAlarmHigh.CustomButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("resource.AutoSizeMode2")));
            this.tbAlarmHigh.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage2")));
            this.tbAlarmHigh.CustomButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("resource.BackgroundImageLayout2")));
            this.tbAlarmHigh.CustomButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock2")));
            this.tbAlarmHigh.CustomButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("resource.FlatStyle2")));
            this.tbAlarmHigh.CustomButton.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font2")));
            this.tbAlarmHigh.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.tbAlarmHigh.CustomButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.ImageAlign2")));
            this.tbAlarmHigh.CustomButton.ImageIndex = ((int)(resources.GetObject("resource.ImageIndex2")));
            this.tbAlarmHigh.CustomButton.ImageKey = resources.GetString("resource.ImageKey2");
            this.tbAlarmHigh.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode2")));
            this.tbAlarmHigh.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location2")));
            this.tbAlarmHigh.CustomButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("resource.MaximumSize2")));
            this.tbAlarmHigh.CustomButton.Name = "";
            this.tbAlarmHigh.CustomButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("resource.RightToLeft2")));
            this.tbAlarmHigh.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size2")));
            this.tbAlarmHigh.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbAlarmHigh.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex2")));
            this.tbAlarmHigh.CustomButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlign2")));
            this.tbAlarmHigh.CustomButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("resource.TextImageRelation2")));
            this.tbAlarmHigh.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAlarmHigh.CustomButton.UseSelectable = true;
            this.tbAlarmHigh.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible2")));
            this.tbAlarmHigh.Lines = new string[0];
            this.tbAlarmHigh.MaxLength = 32767;
            this.tbAlarmHigh.Name = "tbAlarmHigh";
            this.tbAlarmHigh.PasswordChar = '\0';
            this.tbAlarmHigh.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAlarmHigh.SelectedText = "";
            this.tbAlarmHigh.SelectionLength = 0;
            this.tbAlarmHigh.SelectionStart = 0;
            this.tbAlarmHigh.ShortcutsEnabled = true;
            this.tbAlarmHigh.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbAlarmHigh.UseSelectable = true;
            this.tbAlarmHigh.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbAlarmHigh.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbAlarmHigh.TextChanged += new System.EventHandler(this.tbAlarmHigh_TextChanged);
            // 
            // tbAlarmLow
            // 
            resources.ApplyResources(this.tbAlarmLow, "tbAlarmLow");
            // 
            // 
            // 
            this.tbAlarmLow.CustomButton.AccessibleDescription = resources.GetString("resource.AccessibleDescription3");
            this.tbAlarmLow.CustomButton.AccessibleName = resources.GetString("resource.AccessibleName3");
            this.tbAlarmLow.CustomButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("resource.Anchor3")));
            this.tbAlarmLow.CustomButton.AutoSize = ((bool)(resources.GetObject("resource.AutoSize3")));
            this.tbAlarmLow.CustomButton.AutoSizeMode = ((System.Windows.Forms.AutoSizeMode)(resources.GetObject("resource.AutoSizeMode3")));
            this.tbAlarmLow.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage3")));
            this.tbAlarmLow.CustomButton.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("resource.BackgroundImageLayout3")));
            this.tbAlarmLow.CustomButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("resource.Dock3")));
            this.tbAlarmLow.CustomButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("resource.FlatStyle3")));
            this.tbAlarmLow.CustomButton.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font3")));
            this.tbAlarmLow.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.tbAlarmLow.CustomButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.ImageAlign3")));
            this.tbAlarmLow.CustomButton.ImageIndex = ((int)(resources.GetObject("resource.ImageIndex3")));
            this.tbAlarmLow.CustomButton.ImageKey = resources.GetString("resource.ImageKey3");
            this.tbAlarmLow.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode3")));
            this.tbAlarmLow.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location3")));
            this.tbAlarmLow.CustomButton.MaximumSize = ((System.Drawing.Size)(resources.GetObject("resource.MaximumSize3")));
            this.tbAlarmLow.CustomButton.Name = "";
            this.tbAlarmLow.CustomButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("resource.RightToLeft3")));
            this.tbAlarmLow.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size3")));
            this.tbAlarmLow.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbAlarmLow.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex3")));
            this.tbAlarmLow.CustomButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.TextAlign3")));
            this.tbAlarmLow.CustomButton.TextImageRelation = ((System.Windows.Forms.TextImageRelation)(resources.GetObject("resource.TextImageRelation3")));
            this.tbAlarmLow.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAlarmLow.CustomButton.UseSelectable = true;
            this.tbAlarmLow.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible3")));
            this.tbAlarmLow.Lines = new string[0];
            this.tbAlarmLow.MaxLength = 32767;
            this.tbAlarmLow.Name = "tbAlarmLow";
            this.tbAlarmLow.PasswordChar = '\0';
            this.tbAlarmLow.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAlarmLow.SelectedText = "";
            this.tbAlarmLow.SelectionLength = 0;
            this.tbAlarmLow.SelectionStart = 0;
            this.tbAlarmLow.ShortcutsEnabled = true;
            this.tbAlarmLow.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbAlarmLow.UseSelectable = true;
            this.tbAlarmLow.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbAlarmLow.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbAlarmLow.TextChanged += new System.EventHandler(this.tbAlarmLow_TextChanged);
            // 
            // metroLabel6
            // 
            resources.ApplyResources(this.metroLabel6, "metroLabel6");
            this.metroLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.metroLabel6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // metroLabel7
            // 
            resources.ApplyResources(this.metroLabel7, "metroLabel7");
            this.metroLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.metroLabel7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // temperatureIndicator
            // 
            resources.ApplyResources(this.temperatureIndicator, "temperatureIndicator");
            this.temperatureIndicator.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.temperatureIndicator.Name = "temperatureIndicator";
            this.temperatureIndicator.Temp = 0;
            this.temperatureIndicator.TempMax = 1024;
            this.temperatureIndicator.TempMin = 0;
            this.temperatureIndicator.TempPercent = 0;
            // 
            // toggleFurnace
            // 
            resources.ApplyResources(this.toggleFurnace, "toggleFurnace");
            this.toggleFurnace.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toggleFurnace.Name = "toggleFurnace";
            this.toggleFurnace.ToggleStatus = false;
            this.toggleFurnace.OnToggle += new TemperatureControl.Toggle.ToggleEventHandler(this.toogleFurnace_OnToggle);
            // 
            // toggleAutomatic
            // 
            resources.ApplyResources(this.toggleAutomatic, "toggleAutomatic");
            this.toggleAutomatic.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toggleAutomatic.Name = "toggleAutomatic";
            this.toggleAutomatic.ToggleStatus = false;
            this.toggleAutomatic.OnToggle += new TemperatureControl.Toggle.ToggleEventHandler(this.toogleAutomatic_OnToggle);
            // 
            // statusFurnace
            // 
            resources.ApplyResources(this.statusFurnace, "statusFurnace");
            this.statusFurnace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.statusFurnace.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statusFurnace.ImageList = this.imageStatusList;
            this.statusFurnace.Name = "statusFurnace";
            this.statusFurnace.StatusCode = 0;
            // 
            // rounded1
            // 
            resources.ApplyResources(this.rounded1, "rounded1");
            this.rounded1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.rounded1.BorderRadiusA = 300;
            this.rounded1.BorderRadiusB = 300;
            this.rounded1.Name = "rounded1";
            // 
            // picFurnaceStatus
            // 
            resources.ApplyResources(this.picFurnaceStatus, "picFurnaceStatus");
            this.picFurnaceStatus.BackColor = System.Drawing.Color.Transparent;
            this.picFurnaceStatus.Name = "picFurnaceStatus";
            this.picFurnaceStatus.Status = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pictureBox1.Image = global::TemperatureControl.Properties.Resources.temperature;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pictureBox2.Image = global::TemperatureControl.Properties.Resources.alarmConfigure;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // Home
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.temperatureIndicator);
            this.Controls.Add(this.toggleFurnace);
            this.Controls.Add(this.toggleAutomatic);
            this.Controls.Add(this.picFurnaceStatus);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tbAlarmLow);
            this.Controls.Add(this.tbHisteresis);
            this.Controls.Add(this.tbAlarmHigh);
            this.Controls.Add(this.tbSetPoint);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusFurnace);
            this.Controls.Add(this.rounded1);
            this.Controls.Add(this.lHome);
            this.Name = "Home";
            this.ParentChanged += new System.EventHandler(this.Home_ParentChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lHome;
        private FurnaceStatus picFurnaceStatus;
        private Rounded rounded1;
        private Status statusFurnace;
        private System.Windows.Forms.ImageList imageStatusList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox tbSetPoint;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbHisteresis;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private Toggle toggleAutomatic;
        private Toggle toggleFurnace;
        private TemperatureIndicator temperatureIndicator;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTextBox tbAlarmHigh;
        private MetroFramework.Controls.MetroTextBox tbAlarmLow;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}
