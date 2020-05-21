using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.CodeDom.Compiler;
using TemperatureControl.Properties;

namespace TemperatureControl
{
    public partial class FurnaceStatus : UserControl
    {
        private bool status = false;

        public bool Status 
        { 
            get => status;
            set 
            {
                status = value;
                BackgroundImage = status ? Resources.furnaceOn : Resources.furnaceOff;
            }  
        }


        public FurnaceStatus()
        {
            InitializeComponent();
        }

    }
}
