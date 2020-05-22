using System;
using System.Windows.Forms;
using MetroFramework.Controls;
using System.Threading;

namespace TemperatureControl
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            Program.App.Arduino.BqBus.OnData += BqBus_OnData;
        }

        private void BqBus_OnData(object sender, EventArgs e)
        {
            ProcessStatus();
            ProcessAlarms();
        }

        private void ProcessStatus()
        {
            picFurnaceStatus.Status = Program.App.Arduino.FurnaceStatus == 1;
            statusFurnace.StatusCode = Program.App.Arduino.FurnaceStatus;
            temperatureIndicator.Temp = Program.App.Arduino.FurnaceTemperature;
        }

        private static void ProcessAlarms()
        {
            if (Program.App.Arduino.FurnaceStatus == 2)
            {
                if (Thread.CurrentThread.CurrentCulture.Name == "en-EU")
                    Program.App.Screens.Alarms.SetAlarm("General Fail");
                if (Thread.CurrentThread.CurrentCulture.Name == "pt-BR")
                    Program.App.Screens.Alarms.SetAlarm("Falha Geral");
            }
            if (Program.App.Arduino.FurnaceTemperature > Program.App.Settings.Parameters.AlarmHigh)
            {
                if (Thread.CurrentThread.CurrentCulture.Name == "en-EU")
                    Program.App.Screens.Alarms.SetAlarm("Furnace High Temperature");
                if (Thread.CurrentThread.CurrentCulture.Name == "pt-BR")
                    Program.App.Screens.Alarms.SetAlarm("Temperatura alta no forno");
            }
            if (Program.App.Arduino.FurnaceTemperature < Program.App.Settings.Parameters.AlarmLow)
            {
                if (Thread.CurrentThread.CurrentCulture.Name == "en-EU")
                    Program.App.Screens.Alarms.SetAlarm("Furnace Low Temperature");
                if (Thread.CurrentThread.CurrentCulture.Name == "pt-BR")
                    Program.App.Screens.Alarms.SetAlarm("Temperatura baixa no forno");
            }
        }

        private void toggleAutomatic_OnToggle(object sender, EventArgs e)
        {
            toggleFurnace.Enabled = toggleAutomatic.ToggleStatus == false;
            Program.App.Arduino.AutomaticControl = toggleAutomatic.ToggleStatus;
            Program.App.Settings.Parameters.AutomaticControl = toggleAutomatic.ToggleStatus;
        }

        private void toggleFurnace_OnToggle(object sender, EventArgs e)
        {
            Program.App.Arduino.FurnaceControl = toggleFurnace.ToggleStatus;
            Program.App.Settings.Parameters.ManualToogle = toggleFurnace.ToggleStatus;
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbSetPoint_TextChanged(object sender, EventArgs e)
        {
            var tb = (MetroTextBox)sender;
            Program.App.Arduino.ParameterSetPoint = int.Parse(tb.Text);
            Program.App.Settings.Parameters.SetPoint = int.Parse(tb.Text);
        }

        private void tbHisteresis_TextChanged(object sender, EventArgs e)
        {
            var tb = (MetroTextBox)sender;
            Program.App.Arduino.ParameterHisteresis = int.Parse(tb.Text);
            Program.App.Settings.Parameters.Histeresis = int.Parse(tb.Text);
        }

        private void tbAlarmHigh_TextChanged(object sender, EventArgs e)
        {
            var tb = (MetroTextBox)sender;
            Program.App.Settings.Parameters.AlarmHigh = int.Parse(tb.Text);
        }

        private void tbAlarmLow_TextChanged(object sender, EventArgs e)
        {
            var tb = (MetroTextBox)sender;
            Program.App.Settings.Parameters.AlarmLow = int.Parse(tb.Text);
        }

        private void Home_ParentChanged(object sender, EventArgs e)
        {
            toggleAutomatic.ToggleStatus = Program.App.Settings.Parameters.AutomaticControl;
            toggleFurnace.ToggleStatus = Program.App.Settings.Parameters.ManualToogle;
            toggleAutomatic_OnToggle(toggleAutomatic, e);
            toggleFurnace_OnToggle(toggleFurnace, e);
            tbSetPoint.Text = Program.App.Settings.Parameters.SetPoint.ToString();
            tbHisteresis.Text = Program.App.Settings.Parameters.Histeresis.ToString();
            tbAlarmHigh.Text = Program.App.Settings.Parameters.AlarmHigh.ToString();
            tbAlarmLow.Text = Program.App.Settings.Parameters.AlarmLow.ToString();
        }
    }
}
