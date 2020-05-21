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
    public partial class TemperatureIndicator : UserControl
    {
        private int tempPercent = 0;
        private int tempMin = 0;
        private int tempMax = 100;
        private int temp = 0;

        public int TempMin 
        { 
            get => tempMin; 
            set
            {
                tempMin = value;
                labelMin.Text = tempMin.ToString() + "°C";
                calcTemp();
            }

        }

        public int TempMax
        {
            get => tempMax;
            set
            {
                tempMax = value;
                labelMax.Text = tempMax.ToString() + "°C";
                calcTemp();
            }

        }

        public int Temp
        {
            get => temp;
            set
            {
                temp = value;
                labelCurrent.Text = temp.ToString() + "°C";
                calcTemp();
            }

        }

        public int TempPercent 
        { 
            get => tempPercent; 
            set
            {
                tempPercent = value;
                picTempLow.Size = new Size(picTempLow.Width, 84 - Convert.ToInt32(value / (1.388)));
            }
        }


        public TemperatureIndicator()
        {
            InitializeComponent();
        }

        private void calcTemp()
        {
            if (temp <= tempMax && temp >= tempMin && tempMax > tempMin)
            {
                float initial = temp - tempMin;
                float interval = tempMax - tempMin;
                int value = Convert.ToInt32((initial / interval) * 100.0);
                TempPercent = value;
                picTempLow.Size = new Size(picTempLow.Width, 84 - Convert.ToInt32(value / (1.388)));
            }
            else
            {
               TempPercent = 0;
            }
}

        private void TemperatureIndicator_ForeColorChanged(object sender, EventArgs e)
        {
            labelMin.ForeColor = ForeColor;
            labelMax.ForeColor = ForeColor;
            labelCurrent.ForeColor = ForeColor;
        }
    }
}
