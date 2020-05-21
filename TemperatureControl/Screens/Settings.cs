using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using MetroFramework.Properties;
using System.Threading;

namespace TemperatureControl
{
    public partial class Settings : UserControl
    {
        private bool first = true;

        public Settings()
        {
            InitializeComponent();
        }

        private void cbPort_MouseClick(object sender, MouseEventArgs e)
        {
            var cb = (ComboBox)sender;
            var selected = cb.SelectedItem;
            cb.Items.Clear();
            cb.Items.AddRange(SerialPort.GetPortNames());
            cb.SelectedItem = selected;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            cbPort.Items.Clear();
            cbPort.Items.AddRange(SerialPort.GetPortNames());
            toggleSturtupConnect.ToggleStatus = Program.App.Settings.AutoConnect;
            toggleConnection.ToggleStatus = Program.App.Arduino.BqBus.IsConnected;
            toggleConnection.LabelOff = Program.App.Arduino.BqBus.IsConnected ? "Connected" : "Disconnected";
            cbLanguage.SelectedIndex = Program.App.Settings.Language == "en" ? 0 : 1;
            cbPort.SelectedItem = Program.App.Settings.SerialPort;
            cbBaudRate.SelectedItem = Program.App.Settings.BaudRate.ToString();
        }

        private void toogleSturtupConnect_OnToggle(object sender, EventArgs e)
        {
            var toggle = (Toggle)sender;
            Program.App.Settings.AutoConnect = toggle.ToggleStatus;
        }

        private void toogleConnection_OnToggle(object sender, EventArgs e)
        {
            var toggle = (Toggle)sender;
            if (toggle.ToggleStatus)
            {
                Program.App.Arduino.BqBus.Connect();
                toggle.LabelOff = "Connected";
            }
            else
            {
                Program.App.Arduino.BqBus.Disconnect();
                toggle.LabelOff = "Disconnected";
            }
        }

        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (first)
            {
                first = false;
                return;
            }
            var cb = (ComboBox)sender;
            DialogResult result = DialogResult.No;
            switch (cb.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en", true);
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en", true);
                    Program.App.Settings.Language = Thread.CurrentThread.CurrentCulture.Name;
                     result = MessageBox.Show("Restart applicattion?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    break;
                case 1:
                    Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("pt", true);
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("pt", true);
                    Program.App.Settings.Language = Thread.CurrentThread.CurrentCulture.Name;
                    result = MessageBox.Show("Reiniciar aplicação?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    break;
                default:
                    break;
            }
            if(result == DialogResult.Yes)
            {
                Program.App.SaveData();
                Application.Restart();
            }
        }

        private void cbPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cb = (ComboBox)sender;
            Program.App.Settings.SerialPort = cb.SelectedItem.ToString();
            if(!Program.App.Arduino.BqBus.Serial.IsOpen)
                Program.App.Arduino.BqBus.Serial.PortName = cb.SelectedItem.ToString();
        }

        private void cbBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cb = (ComboBox)sender;
            Program.App.Settings.BaudRate = int.Parse(cb.SelectedItem.ToString());
        }
    }
}
