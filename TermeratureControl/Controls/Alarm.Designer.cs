namespace TemperatureControl
{
    partial class Alarm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alarm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelMessage = new System.Windows.Forms.Label();
            this.pictureBoxAlarmStatus = new System.Windows.Forms.PictureBox();
            this.labelData = new System.Windows.Forms.Label();
            this.pictureBoxDelete = new System.Windows.Forms.PictureBox();
            this.pictureBoxAck = new System.Windows.Forms.PictureBox();
            this.imageListAlarmStatus = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlarmStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAck)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Controls.Add(this.labelMessage, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxAlarmStatus, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelData, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxDelete, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxAck, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 45);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelMessage
            // 
            this.labelMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelMessage.Location = new System.Drawing.Point(248, 0);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelMessage.Size = new System.Drawing.Size(243, 45);
            this.labelMessage.TabIndex = 2;
            this.labelMessage.Text = "Alarm Message";
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxAlarmStatus
            // 
            this.pictureBoxAlarmStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxAlarmStatus.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxAlarmStatus.Name = "pictureBoxAlarmStatus";
            this.pictureBoxAlarmStatus.Size = new System.Drawing.Size(39, 39);
            this.pictureBoxAlarmStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAlarmStatus.TabIndex = 0;
            this.pictureBoxAlarmStatus.TabStop = false;
            // 
            // labelData
            // 
            this.labelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelData.Location = new System.Drawing.Point(48, 0);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(194, 45);
            this.labelData.TabIndex = 1;
            this.labelData.Text = "xx/xx/xx - xx:xx:xx";
            this.labelData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxDelete
            // 
            this.pictureBoxDelete.Location = new System.Drawing.Point(542, 3);
            this.pictureBoxDelete.Name = "pictureBoxDelete";
            this.pictureBoxDelete.Size = new System.Drawing.Size(39, 39);
            this.pictureBoxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDelete.TabIndex = 4;
            this.pictureBoxDelete.TabStop = false;
            this.pictureBoxDelete.Click += new System.EventHandler(this.pictureBoxDelete_Click);
            // 
            // pictureBoxAck
            // 
            this.pictureBoxAck.Location = new System.Drawing.Point(497, 3);
            this.pictureBoxAck.Name = "pictureBoxAck";
            this.pictureBoxAck.Size = new System.Drawing.Size(39, 39);
            this.pictureBoxAck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAck.TabIndex = 4;
            this.pictureBoxAck.TabStop = false;
            this.pictureBoxAck.Click += new System.EventHandler(this.pictureBoxAck_Click);
            // 
            // imageListAlarmStatus
            // 
            this.imageListAlarmStatus.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListAlarmStatus.ImageStream")));
            this.imageListAlarmStatus.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListAlarmStatus.Images.SetKeyName(0, "alarmConfigure.png");
            this.imageListAlarmStatus.Images.SetKeyName(1, "error.png");
            this.imageListAlarmStatus.Images.SetKeyName(2, "enabled.png");
            this.imageListAlarmStatus.Images.SetKeyName(3, "delete.png");
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Alarm";
            this.Size = new System.Drawing.Size(584, 45);
            this.ForeColorChanged += new System.EventHandler(this.Alarm_ForeColorChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlarmStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBoxAlarmStatus;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.ImageList imageListAlarmStatus;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.PictureBox pictureBoxDelete;
        private System.Windows.Forms.PictureBox pictureBoxAck;
    }
}
