using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
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
            picFurnaceStatus.Status = Program.App.Arduino.FurnaceStatus == 1;
            statusFurnace.Invoke((MethodInvoker) delegate
            {
                statusFurnace.StatusCode = Program.App.Arduino.FurnaceStatus;
            });
            temperatureIndicator.Invoke((MethodInvoker) delegate {
                temperatureIndicator.Temp = Program.App.Arduino.FurnaceTemperature;
            });
            if(Program.App.Arduino.FurnaceStatus == 2)
            {
                if (Thread.CurrentThread.CurrentCulture.Name == "en-EU")
                    Program.App.Screens.Alarms.alarmSheet.AddAlarm("General Fail");
                if (Thread.CurrentThread.CurrentCulture.Name == "pt-BR")
                    Program.App.Screens.Alarms.alarmSheet.AddAlarm("Falha Geral");
            }
            if (Program.App.Arduino.FurnaceTemperature > Program.App.Settings.Parameters.AlarmHigh)
            {
                if (Thread.CurrentThread.CurrentCulture.Name == "en-EU")
                    Program.App.Screens.Alarms.alarmSheet.AddAlarm("Furnace High Temperature");
                if (Thread.CurrentThread.CurrentCulture.Name == "pt-BR")
                    Program.App.Screens.Alarms.alarmSheet.AddAlarm("Temperatura alta no forno");
            }
            if (Program.App.Arduino.FurnaceTemperature < Program.App.Settings.Parameters.AlarmLow)
            {
                if (Thread.CurrentThread.CurrentCulture.Name == "en-EU")
                    Program.App.Screens.Alarms.alarmSheet.AddAlarm("Furnace Low Temperature");
                if (Thread.CurrentThread.CurrentCulture.Name == "pt-BR")
                    Program.App.Screens.Alarms.alarmSheet.AddAlarm("Temperatura baixa no forno");
            }
        }

        private void toogleAutomatic_OnToggle(object sender, EventArgs e)
        {
            toggleFurnace.Enabled = toggleAutomatic.ToggleStatus == false;
            Program.App.Arduino.AutomaticControl = toggleAutomatic.ToggleStatus;
            Program.App.Settings.Parameters.AutomaticControl = toggleAutomatic.ToggleStatus;
        }

        private void toogleFurnace_OnToggle(object sender, EventArgs e)
        {
            Program.App.Arduino.FurnaceControl = toggleFurnace.ToggleStatus;
            Program.App.Settings.Parameters.ManualToogle = toggleFurnace.ToggleStatus;
        }

        private void tbSetPoint_TextChanged(object sender, EventArgs e)
        {
            var tb = (MetroTextBox)sender;
            try
            {
                Program.App.Arduino.ParameterSetPoint = int.Parse(tb.Text);
                Program.App.Settings.Parameters.SetPoint = int.Parse(tb.Text);
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void tbHisteresis_TextChanged(object sender, EventArgs e)
        {
            var tb = (MetroTextBox)sender;
            try
            {
                Program.App.Arduino.ParameterHisteresis = int.Parse(tb.Text);
                Program.App.Settings.Parameters.Histeresis = int.Parse(tb.Text);
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void tbAlarmHigh_TextChanged(object sender, EventArgs e)
        {
            var tb = (MetroTextBox)sender;
            try
            {
                Program.App.Settings.Parameters.AlarmHigh = int.Parse(tb.Text);
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void tbAlarmLow_TextChanged(object sender, EventArgs e)
        {
            var tb = (MetroTextBox)sender;
            try
            {
                Program.App.Settings.Parameters.AlarmLow = int.Parse(tb.Text);
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void Home_ParentChanged(object sender, EventArgs e)
        {
            toggleAutomatic.ToggleStatus = Program.App.Settings.Parameters.AutomaticControl;
            toggleFurnace.ToggleStatus = Program.App.Settings.Parameters.ManualToogle;
            toogleAutomatic_OnToggle(toggleAutomatic, e);
            toogleFurnace_OnToggle(toggleFurnace, e);
            tbSetPoint.Text = Program.App.Settings.Parameters.SetPoint.ToString();
            tbHisteresis.Text = Program.App.Settings.Parameters.Histeresis.ToString();
            tbAlarmHigh.Text = Program.App.Settings.Parameters.AlarmHigh.ToString();
            tbAlarmLow.Text = Program.App.Settings.Parameters.AlarmLow.ToString();
        }

    }
}
