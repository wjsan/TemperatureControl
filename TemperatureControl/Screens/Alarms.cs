using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using MetroFramework.Properties;
using System.Resources;

namespace TemperatureControl
{
    public partial class Alarms : UserControl
    {
        SoundPlayer player = new SoundPlayer(Properties.Resources.Alarm10);
        public Alarms()
        {
            InitializeComponent();
        }

        public void SetAlarm(string text)
        {
            alarmSheet.SetAlarm(text);
        }

        private void alarmSheet_OnAlarm(object sender, EventArgs e)
        {
            player.PlayLooping();
            Program.App.Screens.StartScreen.UpdateAlarmCount(alarmSheet.AlarmCount);
        }

        private void alarmSheet_OnNormalize(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void buttonMouseEnter(object sender, EventArgs e)
        {
            var bt = (Label)sender;
            bt.BackColor = Color.Gray;
            bt.ForeColor = Color.White;
        }

        private void buttonMouseLeave(object sender, EventArgs e)
        {
            var bt = (Label)sender;
            bt.BackColor = Color.LightGray;
            bt.ForeColor = Color.Black;
        }

        private void buttonMouseDown(object sender, MouseEventArgs e)
        {
            var bt = (Label)sender;
            bt.BackColor = Color.FromArgb(0xFF, 85, 85, 85);
            bt.ForeColor = Color.White;
        }

        private void buttonMouseUp(object sender, MouseEventArgs e)
        {
            var bt = (Label)sender;
            bt.BackColor = Color.Gray;
            bt.ForeColor = Color.White;
        }

        private void buttonAckAll_Click(object sender, EventArgs e)
        {
            Program.App.Screens.StartScreen.UpdateAlarmCount(0);
            alarmSheet.AckAll();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Program.App.Screens.StartScreen.UpdateAlarmCount(0);
            alarmSheet.DeleteAll();
        }

        private void buttonSaveAlarms_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog()
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Filter = "Image File | *.bmp"
            };
            var result = dialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                alarmSheet.SaveSnapshot(dialog.FileName);
            }
        }
    }
}
