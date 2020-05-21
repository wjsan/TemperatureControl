using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TemperatureControl
{
    public partial class Status : UserControl
    {
        private int statusCode = 0;
        public int StatusCode 
        { 
            get => statusCode; 
            set
            {
                statusCode = value;
                if(ImageList != null)
                {
                    if(ImageList.Images.Count > statusCode)
                    {
                        imageStatus.Image = ImageList.Images[statusCode];
                    }
                }
                if (StatusTexts != null)
                {
                    if (StatusTexts.Length > statusCode)
                    {
                        labelText.Text = StatusTexts[statusCode];
                    }
                }
            }
        }

        public ImageList ImageList { get; set; }

        [Localizable(true)]
        public string[] StatusTexts { get ; set; }



        public Status()
        {
            InitializeComponent();
        }

        private void Status_ForeColorChanged(object sender, EventArgs e)
        {
            labelText.ForeColor = this.ForeColor;
        }
    }
}
