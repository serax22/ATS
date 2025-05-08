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
    public partial class LogControl2 : UserControl
    {
        public static string Gpib { set; get; }              // GPIB address
        public string ModelNameInitial { set; get; }  // 
        public string Vin { set; get; }
        public string Freq { set; get; }
        public double doubleVin { set; get; }
        public double doubleFreq { set; get; }

        public bool Get_Gpib()
        {
            //try
            //{
            //throw new NotImplementedException();
            string[] resources = ResourceManager.GetLocalManager().FindResources("GPIB0::?*::INSTR"); // Get all instruments

            // Reset combox items
            comboBox_Gpib.Items.Clear();
            comboBox_Gpib.Items.Add("");
            comboBox_Gpib.SelectedIndex = 0;    
            Application.DoEvents();    

            for (int i = 0; i < resources.Length; i++)  // Find the instrument
            {
                string responseString = GPIB_QUERY(resources[i], "*IDN?");
                GPIB_Write(resources[i], "*RST");
                GoToLocal(resources[i]);
                if (responseString != null)
                {
                    if (responseString.Split(',')[1].StartsWith(ModelNameInitial))
                    {
                        //GetInstrument.Add(resources[i]);

                        Gpib = resources[i];
                        comboBox_Gpib.Items.Add(resources[i] + " " + responseString);
                    }
                }
            }

            if (comboBox_Gpib.Items.Count == 2) // If only one instrument found
            {
                comboBox_Gpib.SelectedIndex = 1;
                Application.DoEvents();
                //Gpib = GetInstrument[0];
            }

            return true;
            //}
            //catch (Exception)
            //{
            //  return false;
            //  throw;
            //}
        }

        public LogControl2()
        {
            InitializeComponent();
            ModelNameInitial = "615";  // AC Source
            Get_Gpib();

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
                    //GpibInstrument.Dispose();
                    return _returnString;
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
                    //GpibInstrument.Dispose();
                    return true;
                }
                else
                {
                    //GpibInstrument.Dispose();
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

        /* Basic */

        public bool Output_Off()
        {
            return GPIB_Write(Gpib, "OUTP OFF");
        }

        public bool Output_on()
        {
            return GPIB_Write(Gpib, "OUTP ON");
        }

        public bool SetValue(string _Vin, string _Freq)
        {
            if (!GPIB_Write(Gpib, "RANG HIGH"))  // Set range
            {
                return false;
            }

            //GPIB_Write(Gpib, "OUTP OFF");   // Output off
            if (!GPIB_Write(Gpib, "SOUR:VOLT " + _Vin + ";:FREQ " + _Freq)) // Set values
            {
                return false;
            }

            Vin = _Vin;
            Freq = _Freq;
            return true;  
        }

        public bool SetValue(double _Vin, double _Freq)
        {
            if (SetValue(_Vin.ToString(), _Freq.ToString()))
            {
                doubleVin = _Vin;
                doubleFreq = _Freq;

                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetVin()
        {
            return GPIB_QUERY(Gpib, "MEAS:VOLT:AC?");
        }
        /* Application */      

            

        private void button_GetGpib_Click_1(object sender, EventArgs e)
        {
            Get_Gpib();
        }

        private void button_Set_Click_1(object sender, EventArgs e)
        {
            string _Vin = textBox_Voltage.Text;
            string _Freq = textBox_Freq.Text;

            if (SetValue(_Vin, _Freq))
            {
                Msg("Set ok.");
            }
            else
            {
                Msg("Set failed.");
            }
        }

        private void button_OutputOn_Click_1(object sender, EventArgs e)
        {
            Output_on();
        }

        private void button_OutputOff_Click_1(object sender, EventArgs e)
        {
            Output_Off();
        }
    }
}
