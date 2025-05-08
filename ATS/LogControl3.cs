using NationalInstruments.VisaNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class LogControl3 : UserControl
    {
        public static string Gpib { set; get; }              // GPIB address
        public string ModelNameInitial { set; get; }  // 

        public LogControl3()
        {
            InitializeComponent();
            ModelNameInitial = "632";  // DC Load
            Get_Gpib();
        }       

        public bool Get_Gpib()
        {
            try
            {
                //throw new NotImplementedException();
                string[] resources = ResourceManager.GetLocalManager().FindResources("GPIB0::?*::INSTR"); // Get all instruments

                comboBox_Gpib.Items.Clear();  // Reset combox items
                comboBox_Gpib.Items.Add("");
                comboBox_Gpib.SelectedIndex = 0;
                Application.DoEvents();

                for (int i = 0; i < resources.Length; i++)  // Find the instrument
                {
                    string responseString = GPIB_QUERY(resources[i], "*IDN?");
                    GPIB_Write(resources[i], "*RST"); // Reset
                    GoToLocal(resources[i]);  // Release remote control lock

                    if (responseString!=null && responseString.Split(',')[1].StartsWith(ModelNameInitial))
                    {                        
                        Gpib = resources[i];
                        comboBox_Gpib.Items.Add(resources[i] + " " + responseString);
                    }
                }

                if (comboBox_Gpib.Items.Count == 2) // If only one instrument found
                {
                    comboBox_Gpib.SelectedIndex = 1;
                    Application.DoEvents();
                    Gpib = comboBox_Gpib.SelectedItem.ToString().Split(' ')[0];
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        private string GPIB_QUERY(string _Gpib, string _Command)
        {
            //throw new NotImplementedException();

            MessageBasedSession GpibInstrument = (MessageBasedSession)ResourceManager.GetLocalManager().Open(_Gpib);
            string _returnString;

            try
            {
                _returnString = GpibInstrument.Query(_Command);

                if (GpibInstrument.LastStatus == VisaStatusCode.Success)
                {
                    GpibInstrument.Dispose();
                    return _returnString.TrimEnd('\n', '\r');
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        private bool GPIB_Write(string _Gpib, string _Command)
        {
            //throw new NotImplementedException();
            try
            {
                MessageBasedSession GpibInstrument = (MessageBasedSession)ResourceManager.GetLocalManager().Open(_Gpib);
                GpibInstrument.Write(_Command);

                if (GpibInstrument.LastStatus == VisaStatusCode.Success)
                {
                    GpibInstrument.Dispose();
                    return true;
                }
                else
                {
                    GpibInstrument.Dispose();
                    return false;
                }

            }
            catch
            {
                return false;
            }
        }

        public void GoToLocal(string _Gpib)
        {
            GpibSession vi = (GpibSession)ResourceManager.GetLocalManager().Open(_Gpib);
            vi.ControlRen(RenMode.AddressAndGtl);
        }

        private void comboBox_Gpib_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gpib = comboBox_Gpib.SelectedItem.ToString().Split(' ')[0];
        }

        private void Msg(string s)
        {
            label_result.Text = s;
        }

        /* Basics */

        public bool LoadOff()
        {
            return GPIB_Write(Gpib, "LOAD OFF");
        }

        public bool LoadOn()
        {
            return GPIB_Write(Gpib, "LOAD ON");
        }

        // Static load

        public bool SetValue(string _Iout)
        {
            return GPIB_Write(Gpib, "CURR:STAT:L1 " + _Iout);
        }

        public bool SetValue(double _Iout)
        {
            return SetValue(_Iout.ToString());
        }

        public bool SetValue(string _Iout, string _Iout2)
        {
            GPIB_Write(Gpib, "CURR:STAT:L2 " + _Iout2);
            return GPIB_Write(Gpib, "CURR:STAT:L1 " + _Iout);
        }

        public bool SetValue(double _Iout, double _Iout2)
        {
            return SetValue(_Iout.ToString(), _Iout2.ToString());
        }

        // Dynamic load
        public bool SetDynamicLoad(string L1, string L2)
        {
            GPIB_Write(Gpib, "CURR:DYN:L1 " + L1);
            return GPIB_Write(Gpib, "CURR:DYN:L2 " + L2);
        }

        public bool SetDynamicLoad(double L1, double L2)
        {
            return SetDynamicLoad(L1.ToString(), L2.ToString());
        }

        public bool SetDynamicTime(string T1, string T2)
        {
            GPIB_Write(Gpib, "CURR:DYN:T1 " + T1);
            return GPIB_Write(Gpib, "CURR:DYN:T2 " + T2);
        }

        public bool SetDynamicTime(double T1, double T2)
        {
            return SetValue(T1.ToString(), T2.ToString());
        }


        public double GetDynamicRise()
        {
            return Convert.ToDouble(GPIB_QUERY(Gpib, "CURR:DYN:RISE?"));
        }

        public bool SetDynamicRise(string rise)
        {
            GPIB_Write(Gpib, "CURR:DYN:RISE " + rise);

            if (GetDynamicRise() != Convert.ToDouble(rise))
            {
                return false;
            }

            return true;
        }

        public bool SetDynamicRise(double rise)
        {
            return SetDynamicRise(rise.ToString());
        }

        public double GetDynamicFall()
        {
            return Convert.ToDouble(GPIB_QUERY(Gpib, "CURR:DYN:FALL?"));
        }

        public bool SetDynamicFall(string fall)
        {
            GPIB_Write(Gpib, "CURR:DYN:FALL " + fall);

            if (GetDynamicFall() != Convert.ToDouble(fall))
            {
                return false;
            }

            return true;
        }

        public bool SetDynamicFall(double fall)
        {
            return SetDynamicFall(fall.ToString());
        }


        // Measure

        public string GetVoltage()
        {
            return GPIB_QUERY(Gpib, "MEAS:VOLT?");
        }

        public string GetCurrent()
        {
            return GPIB_QUERY(Gpib, "MEAS:CURR?");
        }

        public string GetPower()
        {
            return GPIB_QUERY(Gpib, "MEAS:POW?");
        }

        public string[] GetAll()
        {
            return GPIB_QUERY(Gpib, "MEAS:VOLT?;CURR?;POW?").Split(';', ';', '\n');
        }

        // Set Mode

        public bool SetMode(string mode)
        {
            GPIB_Write(Gpib, "MODE " + mode);

            if (GetMode() != mode)
            {
                return false;
            }

            return true;
        }

        public string GetMode()
        {
            return GPIB_QUERY(Gpib, "MODE?");
        }

        // Slew Rate

        public double GetRise()
        {
            return Convert.ToDouble(GPIB_QUERY(Gpib, "CURR:STAT:RISE?"));
        }

        public bool SetRise(string rise)
        {
            GPIB_Write(Gpib, "CURR:STAT:RISE " + rise);

            if (GetRise() != Convert.ToDouble(rise))
            {
                return false;
            }

            return true;
        }

        public bool SetRise(double rise)
        {
            return SetRise(rise.ToString());
        }

        public double GetFall()
        {
            return Convert.ToDouble(GPIB_QUERY(Gpib, "CURR:STAT:FALL?"));
        }

        public bool SetFall(string fall)
        {
            GPIB_Write(Gpib, "CURR:STAT:FALL " + fall);

            if (GetFall() != Convert.ToDouble(fall))
            {
                return false;
            }

            return true;
        }

        public bool SetFall(double fall)
        {
            return SetFall(fall.ToString());
        }


        /* Application */

        private void button_GetGpib_Click(object sender, EventArgs e)
        {
            Get_Gpib();
        }

        private void button_Set_Click(object sender, EventArgs e)
        {
            string _Iout = textBox_SetIout.Text;

            if (SetValue(_Iout))
            {
                Msg("Set ok.");
            }
            else
            {
                Msg("Set failed.");
            }
        }

        private void button_LoadOn_Click(object sender, EventArgs e)
        {
            LoadOn();
        }

        private void button_LoadOff_Click(object sender, EventArgs e)
        {
            LoadOff();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
           
            string[] s = new string[3];
            s = GetAll();

            label_ReadVoltage.Text = s.ElementAt(0);
            label_ReadCurrent.Text = s.ElementAt(1);
            label_ReadPower.Text = s.ElementAt(2);
        
        }

        private void button_SetIout_Click(object sender, EventArgs e)
        {
            string _Iout = textBox_SetIout.Text;

            if (SetValue(_Iout))
            {
                Msg("Set ok.");
            }
            else
            {
                Msg("Set failed.");
            }
        }

        private void button_LoadOn_Click_1(object sender, EventArgs e)
        {
            LoadOn();
        }

        private void button_LoadOff_Click_1(object sender, EventArgs e)
        {
            LoadOff();
        }
    }
}
