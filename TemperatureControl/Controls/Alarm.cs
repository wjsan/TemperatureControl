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
    public partial class Alarm : UserControl
    {
        public enum AlarmStatus
        {
            Active,
            Acked,
            Inactive
        }

        private AlarmStatus alarmStatus;
        private System.Timers.Timer timer = new System.Timers.Timer();
        private bool actived = false;
        private bool acked = false;
        private bool alarmDisplayed = false;

        public Color ActiveColor { get; set; }
        public Color AckedColor { get; set; }
        public Color InactiveColor { get; set; }

        public string LabelText { get; }

        public AlarmStatus Status
        { 
            get => alarmStatus; 
            set
            {
                alarmStatus = value;
                if (!acked)
                {
                    pictureBoxAlarmStatus.Image = imageListAlarmStatus.Images[(int)alarmStatus];
                }
                else
                {
                    pictureBoxAlarmStatus.Image = imageListAlarmStatus.Images[1];
                }
                actived = alarmStatus == AlarmStatus.Active;
                if (acked && alarmStatus != AlarmStatus.Inactive)
                {
                    alarmStatus = AlarmStatus.Acked;
                    return;
                }
                switch (alarmStatus)
                {
                    case AlarmStatus.Active:
                        ForeColor = ActiveColor;
                        if (!alarmDisplayed)
                        {
                            if (this.InvokeRequired)
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    labelData.Invoke((MethodInvoker)delegate
                                    {
                                        labelData.Text = DateTime.Now.ToString();
                                    });
                                });
                            }
                            else
                            {
                                 labelData.Text = DateTime.Now.ToString();
                            }
                        }
                        alarmDisplayed = true;
                        break;
                    case AlarmStatus.Acked:
                        ForeColor = AckedColor;
                        acked = true;
                        break;
                    case AlarmStatus.Inactive:
                        acked = false;
                        ForeColor = InactiveColor;
                        break;
                    default:
                        break;
                }
            }
        }

        public Alarm()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.AutoReset = true;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
            ActiveColor = Color.Red;
            AckedColor = Color.Yellow;
            InactiveColor = Color.Green;
            labelData.Text = DateTime.Now.ToString();
            pictureBoxDelete.Image = imageListAlarmStatus.Images[3];
            pictureBoxAck.Image = imageListAlarmStatus.Images[2];
            Status = AlarmStatus.Active;
        }

        public Alarm(String text)
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.AutoReset = true;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
            ActiveColor = Color.Red;
            AckedColor = Color.Yellow;
            InactiveColor = Color.Green;
            labelData.Text = DateTime.Now.ToString();
            pictureBoxDelete.Image = imageListAlarmStatus.Images[3];
            pictureBoxAck.Image = imageListAlarmStatus.Images[2];
            Status = AlarmStatus.Active;
            labelMessage.Text = text;
            LabelText = text;
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (!actived)
            {
                Status = AlarmStatus.Inactive;
            }
            actived = false;
        }

        public void Ack()
        {
            if(Status != AlarmStatus.Inactive)
            {
                Status = AlarmStatus.Acked;
            }
        }

        private void Alarm_ForeColorChanged(object sender, EventArgs e)
        {
            labelData.ForeColor = ForeColor;
            labelMessage.ForeColor = ForeColor;
        }

        private void pictureBoxDelete_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }

        private void pictureBoxAck_Click(object sender, EventArgs e)
        {
            Ack();
        }
    }
}
