using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TemperatureControl
{
    public partial class StartScreen : Form
    {
        Control openedControl = new Home();

        public StartScreen()
        {
            InitializeComponent();
            mainPanel.Controls.Add(openedControl);
            openedControl.Dock = DockStyle.Fill;
            homeSelected.Visible = true;
            lHome.BackColor = BackColor;
        }

        public void UpdateAlarmCount(int count)
        {
            if (labelAlarmCount.InvokeRequired)
            {
                labelAlarmCount.Invoke((MethodInvoker)delegate
                {
                    labelAlarmCount.Invoke((MethodInvoker)delegate
                    {
                        labelAlarmCount.Text = count.ToString();
                        labelAlarmCount.Visible = count != 0;
                    });
                });
            }
            else
            {
                labelAlarmCount.Text = count.ToString();
                labelAlarmCount.Visible = count != 0;
            }
        }

        private void label_MouseEnter(object sender, EventArgs e)
        {
            var label = (Label)sender;
            label.BackColor = Color.FromArgb(BackColor.A, BackColor.R + 20, BackColor.G + 20, BackColor.B + 20);
        }

        private void label_MouseLeave(object sender, EventArgs e)
        {
            var label = (Label)sender;
            var backColor = splitContainer1.Panel1.BackColor;
            if(label.Tag != null)
               label.BackColor = openedControl.GetType().Name == label.Tag.GetType().Name ? BackColor : backColor;
            else
                label.BackColor = backColor;
        }

        private void label_Click(object sender, EventArgs e)
        {
            var label = (Control)sender;
            OpenScreen(label);
            UpdateGraphics(label);
        }

        private void UpdateGraphics(Control label)
        {
            var backColor = splitContainer1.Panel1.BackColor;
            lHome.BackColor = backColor;
            lAlarms.BackColor = backColor;
            lSettings.BackColor = backColor;
            homeSelected.Visible = label.Name == "lHome";
            alarmsSelected.Visible = label.Name == "lAlarms";
            settingsSelected.Visible = label.Name == "lSettings";
            label.BackColor = Color.FromArgb(BackColor.A, BackColor.R + 20, BackColor.G + 20, BackColor.B + 20);
        }

        private void OpenScreen(Control label)
        {
            mainPanel.Controls.Remove(openedControl);
            switch (label.Name)
            {
                case "lHome":
                    openedControl = Program.App.Screens.Home;
                    break;
                case "lAlarms":
                    openedControl = Program.App.Screens.Alarms;
                    break;
                case "lSettings":
                    openedControl = Program.App.Screens.Settings;
                    break;
                default:
                    break;
            }
            mainPanel.Controls.Add(openedControl);
            openedControl.Dock = DockStyle.Fill;
        }

        private void lQuit_Click(object sender, EventArgs e)
        {
            Program.App.SaveData();
            Application.Exit();
        }
    }
}
