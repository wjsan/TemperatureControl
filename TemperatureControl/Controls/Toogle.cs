using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace TemperatureControl
{

    public partial class Toggle : UserControl
    {
        private Timer animation = new Timer();
        private Graphics g;
        private Rectangle r;
        private Image img;
        private bool toogleStatus;
        private bool forcedToggle = false;

        [Localizable(true)]
        public string LabelOff { get ; set; }

        [Localizable(true)]
        public string LabelOn { get; set; }

        public bool ToggleStatus 
        { 
            get => toogleStatus; 
            set
            {
                forcedToggle = true;
                toogleStatus = value;
                if(LabelOn != null && LabelOff != null)
                    labelText.Text = toogleStatus ? LabelOn : LabelOff;
                animation.Start();
            }
        }

        public delegate void ToggleEventHandler(object sender, EventArgs e);

        public event ToggleEventHandler OnToggle;

        public Toggle()
        {
            animation.Interval = 80;
            animation.Tick += Animation_Tick;
            ToggleStatus = false;
            InitializeComponent();
            switchToggle.Image = toggleImages.Images[0];
            img = toggleImages.Images[0];
            g = Graphics.FromImage(switchToggle.Image);
            r = new Rectangle(0, 0, switchToggle.Width, switchToggle.Height);
        }

        private void Toogle_ForeColorChanged(object sender, EventArgs e)
        {
            labelText.ForeColor = this.ForeColor;
        }

        private void switchToggle_Click(object sender, EventArgs e)
        {
            if (toggleImages == null) return;
            img = toggleImages.Images[1];
            setBrightness(0.5f);
            if (ToggleStatus)
            {
                ToggleStatus = false;
                animation.Start();
            }
            else
            {
                ToggleStatus = true;
                animation.Start();
            }
            OnToggle?.Invoke(this, e);
        }

        private void Animation_Tick(object sender, EventArgs e)
        {
            if (ToggleStatus)
            {
                img = toggleImages.Images[2];
            }
            else
            {
                img = toggleImages.Images[0];
            }
            setBrightness(forcedToggle ? 0.0f : 0.2f);
            forcedToggle = false;
            animation.Stop();
        }

        public void setBrightness(float Brightness)
        {
            g.Clear(Color.Transparent);

            float[][] colorMatrixVal = new[] 
            { 
                new float[] { 1, 0, 0, 0, 0 }, 
                new float[] { 0, 1, 0, 0, 0 }, 
                new float[] { 0, 0, 1, 0, 0 }, 
                new float[] { 0, 0, 0, 1, 0 }, 
                new float[] { Brightness, Brightness, Brightness, 0, 1 }
            };

            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixVal);
            ImageAttributes ia = new ImageAttributes();

            ia.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            g.DrawImage(img, r, 0, 0, switchToggle.Width, switchToggle.Height, GraphicsUnit.Pixel, ia);

            switchToggle.Refresh();
        }

        private void switchToggle_MouseEnter(object sender, EventArgs e)
        {
            setBrightness(0.2f);
        }

        private void switchToggle_MouseLeave(object sender, EventArgs e)
        {
            setBrightness(0.0f);
        }

        private void Toogle_EnabledChanged(object sender, EventArgs e)
        {
            if (Enabled)
            {
                setBrightness(0.0f);
            }
            else
            {
                setBrightness(-0.45f);
            }
        }
    }
}
