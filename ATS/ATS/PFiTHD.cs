using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace ATS
{
    public partial class PFiTHD : Form
    {
        public static WindowsFormsApp2.LogControl2 gpibACSource = new LogControl2();
        public static WindowsFormsApp2.LogControl3 gpibDCLoad = new LogControl3();
        public static WindowsFormsApp2.LogControl4 gpibPowerMeter = new LogControl4();
        public static WindowsFormsApp2.LogControl5 TIAdapter = new LogControl5();
        string PMBus_CommandCode_MFR_IOUT_CAPABILITY = "F1";

        public string filename { set; get; }

        public PFiTHD()     
        {      
            InitializeComponent();
            InitGpib();
            TIAdapter.Init();
            CreatLogFolder();
            /* Default Filename */
            filename = "Log_" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }
        private void CreatLogFolder()
        {
            //throw new NotImplementedException();
            /* Creat Log Folder */
            string strFolderPath = @".\Log\";
            DirectoryInfo DIFO = new DirectoryInfo(strFolderPath);
            if (!DIFO.Exists)
            {
                DIFO.Create();
            }
        }
        public struct MFR_IOUT_MAX_CAPABILITY_S
        {
            public double Irating;
            public double Ipeak;
            public double Ipeak_Duration;
            public double Ipeak_app;
            public double Ipeak_app_Duration;
            public double Ipeak_max;
            public double Ipeak_max_Duration;

            public override string ToString() => Irating.ToString()
              + ", " + Ipeak.ToString() + ", " + Ipeak_Duration.ToString()
              + ", " + Ipeak_app.ToString() + ", " + Ipeak_app_Duration.ToString()
              + ", " + Ipeak_max.ToString() + ", " + Ipeak_max_Duration.ToString();
        }
        private void InitGpib()
        {
            // gpibACSource = new LogControl2();
            // gpibDCLoad = new LogControl3();
            // gpibPowerMeter = new LogControl4();

            if (!gpibACSource.Get_Gpib())
            {
                gpibACSource.Visible = false;
            }

            if (!gpibDCLoad.Get_Gpib())
            {
                gpibDCLoad.Visible = false;
            }

            if (!gpibPowerMeter.Get_Gpib())
            {
                gpibPowerMeter.Visible = false;
            }
        }
        public void Clear()
        {
            this.TEXT_BOX.Clear();
        }
        public void RefreshFileName()
        {
            filename = "Log_" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }
        private static void AddTextToFile(string path, string value)
        {
            try
            {
                path += ".txt";
                FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.Write);
                fs.Close();
                StreamWriter sw = new StreamWriter(path, true, Encoding.ASCII);
                sw.Write(value);
                sw.Close();
            }
            catch
            {

            }
        }
        public void Add(string msg)
        {
            string path = @".\Log\" + filename;

            if (this.TEXT_BOX.TextLength > 65535) // Avoiding AP halt.
                Clear();

            this.TEXT_BOX.SelectionStart = this.TEXT_BOX.TextLength;
            this.TEXT_BOX.SelectedText = msg + "\r\n";
            //this.TEXT_BOX.SelectionStart = this.TEXT_BOX.TextLength;
            //this.TEXT_BOX.ScrollToCaret();

            AddTextToFile(path, msg + "\r\n");

            Application.DoEvents();
        }
        private void initSetting()
        {
            // Instruments
            LogControl2 ac = gpibACSource;
            LogControl3 load = gpibDCLoad;
            LogControl5 ti = TIAdapter;

            DialogResult dr;

            // Values
            MFR_IOUT_MAX_CAPABILITY_S MfrIoutCapability_Highline;
            MFR_IOUT_MAX_CAPABILITY_S MfrIoutCapability_Lowline;

            // Variables
            string Result = "";
            string s = "";
            DateTime _start_time;

            // DateTime
            RefreshFileName();
            Add(DateTime.Now.ToString("MM/dd HH:mm:ss "));

            // Initial State
            ac.Output_Off();
            load.LoadOff();
            ac.SetValue(0, 0);
            load.SetValue(0);
            Thread.Sleep(200);

            ti.SetAddress(addressTextBox.Text);
                  
            // Procedures Begin ************************************************************************************************
            ac.SetValue(230, 50);
            load.SetValue(5);
            ac.Output_on();
            load.LoadOn();
            Thread.Sleep(3000);
        }
        private int StringHex2IntLittle(string s)
        {
            if (s.Contains("N/A"))
                return 0;
            //throw new NotImplementedException();
            if (s.Length == 4)
            {
                int _lowByte = Convert.ToInt16(s.Substring(0, 2), 16);
                int _highByte = Convert.ToInt16(s.Substring(2, 2), 16);
                return _lowByte + _highByte * 256;
            }
            else if (s.Length == 6)
            {
                int _lowByte = Convert.ToInt16(s.Substring(0, 2), 16);
                int _midByte = Convert.ToInt16(s.Substring(2, 2), 16);
                int _highByte = Convert.ToInt16(s.Substring(4, 2), 16);
                return _lowByte + _midByte * 256 + _highByte * 65536;
            }
            else if (s.Length == 8)
            {
                int _lowByte = Convert.ToInt16(s.Substring(0, 2), 16);
                int _midlowByte = Convert.ToInt16(s.Substring(2, 2), 16);
                int _midhighByte = Convert.ToInt16(s.Substring(4, 2), 16);
                int _highByte = Convert.ToInt16(s.Substring(6, 2), 16);
                return _lowByte + _midlowByte * (int)Math.Pow(2, 8) + _midhighByte * (int)Math.Pow(2, 16) + _highByte * (int)Math.Pow(2, 24);
            }

            return 0;
        }
        private double LinearTransfer(int val)
        {
            double realValue = 0.0;
            if (val < 65536)
            {
                int exp = Convert.ToInt16(val / Math.Pow(2, 11));
                int mantissa = Convert.ToInt16(val % Math.Pow(2, 11));

                if (exp > 15)
                {
                    exp -= 32;
                }

                if (mantissa > 1023)
                {
                    mantissa -= 2048;
                }

                realValue = Convert.ToDouble(mantissa * Math.Pow(2, exp));

                return realValue;
            }

            return 65535;
        }
        private MFR_IOUT_MAX_CAPABILITY_S GetMfrIoutMaxCapability(string command)
        {
            //throw new NotImplementedException();
            LogControl5 ti = TIAdapter;
            //LogControl log = logControl;

            MFR_IOUT_MAX_CAPABILITY_S result = new MFR_IOUT_MAX_CAPABILITY_S
            {
                // Init Values
                Irating = 0,
                Ipeak = 0,
                Ipeak_Duration = 0,
                Ipeak_app = 0,
                Ipeak_max = 0,
                Ipeak_max_Duration = 0
            };

            // Check compatebility
            if (command.Length > 2)
                return result;

            // Set PMBus Command
            ti.SetCommandCode(command);

            // Block Read
            string s = ti.ReadBlock();

            if (s == "N/A")
                return result;

            Add("DATA READ: " + s);

            // Parse value
            result.Irating = LinearTransfer(StringHex2IntLittle(s.Substring(0, 4)));
            result.Ipeak = LinearTransfer(StringHex2IntLittle(s.Substring(4, 4)));
            result.Ipeak_Duration = LinearTransfer(StringHex2IntLittle(s.Substring(8, 4)));
            result.Ipeak_app = LinearTransfer(StringHex2IntLittle(s.Substring(12, 4)));
            result.Ipeak_app_Duration = LinearTransfer(StringHex2IntLittle(s.Substring(16, 4)));
            result.Ipeak_max = LinearTransfer(StringHex2IntLittle(s.Substring(20, 4)));
            result.Ipeak_max_Duration = LinearTransfer(StringHex2IntLittle(s.Substring(24, 4)));

            // return result
            return result;    
        }
        private void Check_PF_THDI(double Vin, double Freq, MFR_IOUT_MAX_CAPABILITY_S mfrIoutCapability_Highline)
        {
            //throw new NotImplementedException();
            LogControl2 ac = gpibACSource;
            LogControl3 load = gpibDCLoad;
            LogControl4 meter = gpibPowerMeter;  

            string Result = "";
            string s = "";
            double Ireating = Convert.ToDouble(iratingTextBox.Text);//mfrIoutCapability_Highline.Irating;
            double Loadstep = 0;
            double Loadset = 0;

            int _loop = Convert.ToInt32(stepTextBox.Text);

            //ac.SetValue(Vin, Freq);
            Loadstep = Convert.ToInt32(stepTextBox.Text);//Ireating / (double)_loop;

            ac.SetValue(Vin, Freq);

            Loadset = Loadstep;
            load.SetValue(Loadset);
            ac.Output_on();
            load.LoadOn();
            Thread.Sleep(8000);

            // Vin, Pin, Pout, PF, THDI
            //log.Add("Vin, Pin, Pout, PF, THDI");
            Add("Vin,Iout,Pin, Pout, PF, THDI");
            Result = Vin.ToString();            // Vin
            Result += ", " + load.GetCurrent(); //Iout
            Result += ", " + meter.GetPower();  // Pin
            Result += ", " + load.GetPower();   // Pout
            Result += ", " + meter.GetPF();     // PF
            Result += ", " + meter.GetTHDI();   // THDI

            //log.Add(Result);
            Add(Result);

            for (int i = 2; i <= _loop; i++)
            {
                Loadset = Loadstep * i;
                load.SetValue(Loadset);
                Thread.Sleep(2000);

                // Vin, Iout,Pin, Pout, PF, THDI
                Result = Vin.ToString();            // Vin
                Result += ", " + load.GetCurrent(); //Iout
                Result += ", " + meter.GetPower();  // Pin
                Result += ", " + load.GetPower();   // Pout
                Result += ", " + meter.GetPF();     // PF
                Result += ", " + meter.GetTHDI();   // THDI

                //log.Add(Result);
                Add(Result);
            }

            ac.Output_Off();
            load.LoadOff();
        }
        private void PFTHDTest()//to do:test this first
        {
            //LogControl log = new LogControl();
            DialogResult dr;
            LogControl2 ac = gpibACSource;
            LogControl3 load = gpibDCLoad;

            MFR_IOUT_MAX_CAPABILITY_S MfrIoutCapability_Lowline;
            MFR_IOUT_MAX_CAPABILITY_S MfrIoutCapability_Highline;
            //dr = MessageBox.Show("Run PF & THDI test?", "Go", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            //if (dr == DialogResult.Yes)
            {
                ac.Output_Off();
                load.LoadOff();
                load.SetValue(0);
                Thread.Sleep(1000);
                Add("");
                Add("Start checking PF & THDI curve.");

                double _Vin = Convert.ToDouble(voltageTextBox.Text); //200.0;
                double _Freq = 50.0;
                ac.SetValue(_Vin, _Freq);
                ac.Output_on();
                Thread.Sleep(3000);
                MfrIoutCapability_Highline = GetMfrIoutMaxCapability(PMBus_CommandCode_MFR_IOUT_CAPABILITY);
                Check_PF_THDI(_Vin, _Freq, MfrIoutCapability_Highline);

                /*_Vin = 115.0;
                _Freq = 60.0;
                ac.SetValue(_Vin, _Freq);
                ac.Output_on();
                Thread.Sleep(3000);
                MfrIoutCapability_Lowline = GetMfrIoutMaxCapability(PMBus_CommandCode_MFR_IOUT_CAPABILITY);
                Check_PF_THDI(_Vin, _Freq, MfrIoutCapability_Lowline);*/
            }
            /*else if (dr == DialogResult.Cancel)
            {
                log.Add("User cancelled.");
                return;
            }*/
        }
        private void Request_Click(object sender, EventArgs e)
        {
            initSetting();
            PFTHDTest();
        }

       

        
    }
}
