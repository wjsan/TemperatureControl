namespace TemperatureControl
{
    partial class TemperatureIndicator
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
            this.picTempLow = new System.Windows.Forms.PictureBox();
            this.picTempHigh = new System.Windows.Forms.PictureBox();
            this.labelMax = new MetroFramework.Controls.MetroLabel();
            this.labelMin = new MetroFramework.Controls.MetroLabel();
            this.labelCurrent = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picTempLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTempHigh)).BeginInit();
            this.SuspendLayout();
            // 
            // picTempLow
            // 
            this.picTempLow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picTempLow.Image = global::TemperatureControl.Properties.Resources.temperatureLow;
            this.picTempLow.InitialImage = null;
            this.picTempLow.Location = new System.Drawing.Point(3, 3);
            this.picTempLow.Name = "picTempLow";
            this.picTempLow.Size = new System.Drawing.Size(74, 95);
            this.picTempLow.TabIndex = 0;
            this.picTempLow.TabStop = false;
            // 
            // picTempHigh
            // 
            this.picTempHigh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picTempHigh.Image = global::TemperatureControl.Properties.Resources.temperatureHigh;
            this.picTempHigh.InitialImage = null;
            this.picTempHigh.Location = new System.Drawing.Point(3, 3);
            this.picTempHigh.Name = "picTempHigh";
            this.picTempHigh.Size = new System.Drawing.Size(74, 95);
            this.picTempHigh.TabIndex = 1;
            this.picTempHigh.TabStop = false;
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.BackColor = System.Drawing.Color.Transparent;
            this.labelMax.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMax.Location = new System.Drawing.Point(40, 10);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(33, 19);
            this.labelMax.TabIndex = 2;
            this.labelMax.Text = "100°";
            this.labelMax.UseCustomBackColor = true;
            this.labelMax.UseCustomForeColor = true;
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.BackColor = System.Drawing.Color.Transparent;
            this.labelMin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMin.Location = new System.Drawing.Point(43, 72);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(22, 19);
            this.labelMin.TabIndex = 3;
            this.labelMin.Text = "0º";
            this.labelMin.UseCustomBackColor = true;
            this.labelMin.UseCustomForeColor = true;
            // 
            // labelCurrent
            // 
            this.labelCurrent.AutoSize = true;
            this.labelCurrent.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelCurrent.Location = new System.Drawing.Point(43, 40);
            this.labelCurrent.Name = "labelCurrent";
            this.labelCurrent.Size = new System.Drawing.Size(22, 19);
            this.labelCurrent.TabIndex = 4;
            this.labelCurrent.Text = "0º";
            this.labelCurrent.UseCustomBackColor = true;
            this.labelCurrent.UseCustomForeColor = true;
            // 
            // TemperatureIndicator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelCurrent);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.picTempLow);
            this.Controls.Add(this.picTempHigh);
            this.Name = "TemperatureIndicator";
            this.Size = new System.Drawing.Size(79, 100);
            this.ForeColorChanged += new System.EventHandler(this.TemperatureIndicator_ForeColorChanged);
            ((System.ComponentModel.ISupportInitialize)(this.picTempLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTempHigh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTempLow;
        private System.Windows.Forms.PictureBox picTempHigh;
        private MetroFramework.Controls.MetroLabel labelMax;
        private MetroFramework.Controls.MetroLabel labelMin;
        private MetroFramework.Controls.MetroLabel labelCurrent;
    }
}
