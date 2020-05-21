using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using BqBusNet;
using System.IO.Ports;
using System.Windows.Forms;

namespace TemperatureControl
{
    class App
    {
        private SerialPort serial = new SerialPort();
        private string appDirectory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\TemperatureControl";

        public AppSettings Settings { get; set; } = new AppSettings();
        public Screens Screens { get; set;  }
        internal BqBusRegs Arduino { get; }

        public App()
        {
            Arduino = new BqBusRegs();
            Arduino.BqBus.Size = Arduino.Size;
        }

        public void SaveData()
        {
            var filePath = string.Format("{0}\\settings.json", appDirectory);
            Directory.CreateDirectory(appDirectory);
            string data = JsonConvert.SerializeObject(Settings, Formatting.Indented);
            File.WriteAllText(filePath, data);
        }

        public void LoadData()
        {
            var filePath = string.Format("{0}\\settings.json", appDirectory);
            if (File.Exists(filePath))
            {
                string data = File.ReadAllText(filePath);
                Settings = JsonConvert.DeserializeObject<AppSettings>(data);
            }
            else
            {
                Settings.AutoConnect = true;
                Settings.Language = "English";
                Settings.SerialPort = SerialPort.GetPortNames()?.First();
                Settings.BaudRate = 9600;
            }

            serial.PortName = Settings.SerialPort;
            serial.BaudRate = Settings.BaudRate;

            Arduino.BqBus.Serial = serial;

            if (Settings.AutoConnect)
            {
                try
                {
                    Arduino.BqBus.Connect();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

    class BqBusRegs
    {
        public BqBus BqBus { get; set; }

        enum Regs
        {
            AutomaticControl,          //Register Address for Auto/Manual Control Toggle
            FurnaceControl,            //Register Address for Furnace Control Toggle
            ParameterSetPoint,         //Register Address for Set-Point Parameter
            ParameterHisteresis,       //Register Address for Histeresis Parameter
            FurnaceStatus,             //Register Address for Furnace Control Status
            FurnaceTemperature,        //Register Address for Furnace Temperature
            LastRegister,              //Last register address used to get registers count
        };

        public int FurnaceStatus { get => BqBus.GetReg((ushort)Regs.FurnaceStatus); }
        public int FurnaceTemperature { get => BqBus.GetReg((ushort)Regs.FurnaceTemperature); }
        public bool AutomaticControl { set => BqBus.SetReg((ushort)Regs.AutomaticControl, value ? 1 : 0); }
        public bool FurnaceControl { set => BqBus.SetReg((ushort)Regs.FurnaceControl, value ? 1 : 0); }
        public int ParameterSetPoint { set => BqBus.SetReg((ushort)Regs.ParameterSetPoint, value); }
        public int ParameterHisteresis { set => BqBus.SetReg((ushort)Regs.ParameterHisteresis, value); }
        public ushort Size { get => (ushort)Regs.LastRegister; }

        public BqBusRegs() {
            BqBus = new BqBus();
        }
    }

    public class Screens
    {
        public Home Home { get;}
        public Alarms Alarms { get; }
        public Settings Settings { get;}
        public StartScreen StartScreen { get; }

        public Screens(){
            Home = new Home();
            Alarms = new Alarms();
            Settings = new Settings();
            StartScreen = new StartScreen();
        }
    }

    public class AppSettings
    {
        public bool AutoConnect { get; set; }
        public string Language { get; set; }
        public string SerialPort { get; set; }
        public int BaudRate { get; set; }
        public FurnaceParameters Parameters { get; set; }

        public AppSettings()
        {
            Parameters = new FurnaceParameters();
        }
    }

    public class FurnaceParameters
    {
        public bool AutomaticControl { get; set; }
        public bool ManualToogle { get; set; }
        public int SetPoint { get; set; }
        public int Histeresis { get; set; }
        public int AlarmHigh { get; set; }
        public int AlarmLow { get; set; }
    }
}
