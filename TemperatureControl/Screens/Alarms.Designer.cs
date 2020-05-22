namespace TemperatureControl
{
    partial class Alarms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alarms));
            this.lHome = new System.Windows.Forms.Label();
            this.alarmSheet = new TemperatureControl.AlarmSheet();
            this.buttonAckAll = new System.Windows.Forms.Label();
            this.imageListButtons = new System.Windows.Forms.ImageList(this.components);
            this.buttonDelete = new System.Windows.Forms.Label();
            this.buttonSaveAlarms = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lHome
            // 
            this.lHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            resources.ApplyResources(this.lHome, "lHome");
            this.lHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lHome.Name = "lHome";
            // 
            // alarmSheet
            // 
            resources.ApplyResources(this.alarmSheet, "alarmSheet");
            this.alarmSheet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.alarmSheet.Name = "alarmSheet";
            this.alarmSheet.OnAlarm += new TemperatureControl.AlarmSheet.AlarmEventHandler(this.alarmSheet_OnAlarm);
            this.alarmSheet.OnNormalize += new TemperatureControl.AlarmSheet.AlarmEventHandler(this.alarmSheet_OnNormalize);
            // 
            // buttonAckAll
            // 
            this.buttonAckAll.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.buttonAckAll, "buttonAckAll");
            this.buttonAckAll.ImageList = this.imageListButtons;
            this.buttonAckAll.Name = "buttonAckAll";
            this.buttonAckAll.Click += new System.EventHandler(this.buttonAckAll_Click);
            this.buttonAckAll.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonMouseDown);
            this.buttonAckAll.MouseEnter += new System.EventHandler(this.buttonMouseEnter);
            this.buttonAckAll.MouseLeave += new System.EventHandler(this.buttonMouseLeave);
            this.buttonAckAll.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonMouseUp);
            // 
            // imageListButtons
            // 
            this.imageListButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListButtons.ImageStream")));
            this.imageListButtons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListButtons.Images.SetKeyName(0, "delete.png");
            this.imageListButtons.Images.SetKeyName(1, "enabled.png");
            this.imageListButtons.Images.SetKeyName(2, "save.png");
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.buttonDelete, "buttonDelete");
            this.buttonDelete.ImageList = this.imageListButtons;
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            this.buttonDelete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonMouseDown);
            this.buttonDelete.MouseEnter += new System.EventHandler(this.buttonMouseEnter);
            this.buttonDelete.MouseLeave += new System.EventHandler(this.buttonMouseLeave);
            this.buttonDelete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonMouseUp);
            // 
            // buttonSaveAlarms
            // 
            this.buttonSaveAlarms.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.buttonSaveAlarms, "buttonSaveAlarms");
            this.buttonSaveAlarms.ImageList = this.imageListButtons;
            this.buttonSaveAlarms.Name = "buttonSaveAlarms";
            this.buttonSaveAlarms.Click += new System.EventHandler(this.buttonSaveAlarms_Click);
            this.buttonSaveAlarms.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonMouseDown);
            this.buttonSaveAlarms.MouseEnter += new System.EventHandler(this.buttonMouseEnter);
            this.buttonSaveAlarms.MouseLeave += new System.EventHandler(this.buttonMouseLeave);
            this.buttonSaveAlarms.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonMouseUp);
            // 
            // Alarms
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.buttonSaveAlarms);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAckAll);
            this.Controls.Add(this.alarmSheet);
            this.Controls.Add(this.lHome);
            this.Name = "Alarms";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lHome;
        private System.Windows.Forms.Label buttonAckAll;
        private System.Windows.Forms.ImageList imageListButtons;
        private System.Windows.Forms.Label buttonDelete;
        private System.Windows.Forms.Label buttonSaveAlarms;
        private AlarmSheet alarmSheet;
    }
}
