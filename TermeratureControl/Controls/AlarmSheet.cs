using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using System.Runtime.InteropServices;

namespace TemperatureControl
{
    public partial class AlarmSheet : UserControl
    {
        public delegate void AlarmEventHandler(object sender, EventArgs e);
        private Timer timerCheckAlarmStatus = new Timer();

        public event AlarmEventHandler OnAlarm;
        public event AlarmEventHandler OnNormalize;

        public int AlarmCount { get => Controls.Count; }


        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_PRINT = 791;

        /// <summary>
        /// The WM_PRINT drawing options
        /// </summary>
        [Flags]
        private enum DrawingOptions
        {
            /// <summary>
            /// Draws the window only if it is visible.
            /// </summary>
            PRF_CHECKVISIBLE = 1,

            /// <summary>
            /// Draws the nonclient area of the window.
            /// </summary>
            PRF_NONCLIENT = 2,
            /// <summary>

            /// Draws the client area of the window.
            /// </summary>
            PRF_CLIENT = 4,

            /// <summary>
            /// Erases the background before drawing the window.
            /// </summary>
            PRF_ERASEBKGND = 8,

            /// <summary>
            /// Draws all visible children windows.
            /// </summary>
            PRF_CHILDREN = 16,

            /// <summary>
            /// Draws all owned windows.
            /// </summary>
            PRF_OWNED = 32
        }

        public AlarmSheet()
        {
            InitializeComponent();
            timerCheckAlarmStatus.Interval = 1000;
            timerCheckAlarmStatus.Tick += TimerCheckAlarmStatus_Tick;
            timerCheckAlarmStatus.Start();
        }

        private void TimerCheckAlarmStatus_Tick(object sender, EventArgs e)
        {
            CheckNormalization();
        }

        private void CheckNormalization()
        {
            foreach (var control in Controls)
            {
                if (control.GetType().Name == "Alarm")
                {
                    var alarm = (Alarm)control;
                    if (alarm.Status == Alarm.AlarmStatus.Active)
                    {
                        return;
                    }
                }
            }
            OnNormalize?.Invoke(this, new EventArgs());
        }

        public void AddAlarm(string text)
        {
            foreach (var control in Controls)
            {
                if(control.GetType().Name == "Alarm")
                {
                    var alarm = (Alarm)control;
                    if (alarm.LabelText == text)
                    {
                        if(alarm.Status == Alarm.AlarmStatus.Active || alarm.Status == Alarm.AlarmStatus.Acked)
                        {
                            alarm.Status = Alarm.AlarmStatus.Active;
                            return;
                        }
                    }
                }
            }
            UpdateAlarms(text);
        }

        public void AckAll()
        {
            foreach (var control in Controls)
            {
                if (control.GetType().Name == "Alarm")
                {
                    var alarm = (Alarm)control;
                    alarm.Ack();
                }
            }
        }

        public void DeleteAll()
        {
            Controls.Clear();
        }

        public void SaveSnapshot(string path)
        {
            using (Bitmap screenshot = new Bitmap(this.DisplayRectangle.Width, this.DisplayRectangle.Height))
            using (Graphics g = Graphics.FromImage(screenshot))
            {
                try
                {
                    SendMessage(this.Handle, WM_PRINT, g.GetHdc().ToInt32(), (int)(DrawingOptions.PRF_CHILDREN | DrawingOptions.PRF_CLIENT | DrawingOptions.PRF_NONCLIENT | DrawingOptions.PRF_OWNED));
                }
                finally
                {
                    g.ReleaseHdc();
                }
                screenshot.Save(path);
            }
        }

        private void UpdateAlarms(string text)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    Controls.Add(new Alarm(text)
                    {
                        Dock = DockStyle.Top
                    });
                });
            }
            else
            {
                Controls.Add(new Alarm(text)
                {
                    Dock = DockStyle.Top
                });
            }
            OnAlarm?.Invoke(this, new EventArgs());
        }
    }
}
