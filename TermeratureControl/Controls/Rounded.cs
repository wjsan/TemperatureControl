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
    public partial class Rounded : UserControl
    {
        private int borderRadiusA = 0;
        private int borderRadiusB = 0;

        public int BorderRadiusA 
        { 
            get => borderRadiusA;
            set
            {
                borderRadiusA = value;
                UpdateBorders();
            } 
        }

        public int BorderRadiusB
        {
            get => borderRadiusB;
            set
            {
                borderRadiusB = value;
                UpdateBorders();
            }
        }

        [System.Runtime.InteropServices.DllImport("Gdi32")]
        protected static extern int CreateRoundRectRgn(int X1, int Y1, int X2, int Y2, int X3, int Y3);

        protected IntPtr regionHandle;

        public Rounded()
        {
            InitializeComponent();
        }

        private void Rounded_Paint(object sender, PaintEventArgs e)
        {
            UpdateBorders();
        }

        private void UpdateBorders()
        {
            regionHandle = new IntPtr(CreateRoundRectRgn(0, 0, Width, Height, borderRadiusA, borderRadiusB));
            Region = Region.FromHrgn(regionHandle);
            Region.ReleaseHrgn(regionHandle);
        }
    }
}
