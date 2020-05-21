namespace TemperatureControl
{
    partial class Toggle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Toggle));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelText = new System.Windows.Forms.Label();
            this.switchToggle = new System.Windows.Forms.PictureBox();
            this.toggleImages = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.switchToggle)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelText, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.switchToggle, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 50);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelText
            // 
            this.labelText.BackColor = System.Drawing.Color.Transparent;
            this.labelText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelText.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelText.Location = new System.Drawing.Point(53, 0);
            this.labelText.Name = "labelText";
            this.labelText.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelText.Size = new System.Drawing.Size(204, 50);
            this.labelText.TabIndex = 8;
            this.labelText.Text = "Toogle";
            this.labelText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // switchToggle
            // 
            this.switchToggle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.switchToggle.Location = new System.Drawing.Point(3, 3);
            this.switchToggle.Name = "switchToggle";
            this.switchToggle.Size = new System.Drawing.Size(44, 44);
            this.switchToggle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.switchToggle.TabIndex = 7;
            this.switchToggle.TabStop = false;
            this.switchToggle.Click += new System.EventHandler(this.switchToggle_Click);
            this.switchToggle.MouseEnter += new System.EventHandler(this.switchToggle_MouseEnter);
            this.switchToggle.MouseLeave += new System.EventHandler(this.switchToggle_MouseLeave);
            // 
            // toogleImages
            // 
            this.toggleImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("toogleImages.ImageStream")));
            this.toggleImages.TransparentColor = System.Drawing.Color.Transparent;
            this.toggleImages.Images.SetKeyName(0, "switchOff.png");
            this.toggleImages.Images.SetKeyName(1, "switchMiddle.png");
            this.toggleImages.Images.SetKeyName(2, "switchOn.png");
            // 
            // Toogle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Toogle";
            this.Size = new System.Drawing.Size(260, 50);
            this.EnabledChanged += new System.EventHandler(this.Toogle_EnabledChanged);
            this.ForeColorChanged += new System.EventHandler(this.Toogle_ForeColorChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.switchToggle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.PictureBox switchToggle;
        private System.Windows.Forms.ImageList toggleImages;
    }
}
