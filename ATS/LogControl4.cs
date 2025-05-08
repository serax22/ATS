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
    public partial class LogControl4 : UserControl
    {
        public static string Gpib { set; get; }              // GPIB address
        public string ModelNameInitial { set; get; }  // 

        public LogControl4()
        {
            InitializeComponent();
            ModelNameInitial = "66";
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

                    if (responseString!=null&& responseString.Split(',')[1].StartsWith(ModelNameInitial))
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

        /* Basic */
        public string GetVoltage()
        {
            return GPIB_QUERY(Gpib, "MEAS? V");
        }
        public string GetCurrent()
        {
            return GPIB_QUERY(Gpib, "MEAS? I");
        }
        public string GetPower()
        {
            return GPIB_QUERY(Gpib, "MEAS? W");
        }
        public string GetPF()
        {
            return GPIB_QUERY(Gpib, "MEAS? PF");
        }
        public string GetTHDI()
        {
            return GPIB_QUERY(Gpib, "MEAS? THDI");
        }

        public string[] GetAll()
        {
            return GPIB_QUERY(Gpib, "FETC? V,I,W,PF,THDI;").Split(',', ',', ',', ',', '\n');
        }

        /* Application */

        private void button_GetVoltage_Click(object sender, EventArgs e)
        {
            label_ReadVoltage.Text = GetVoltage();
        }

        private void button_GetI_Click(object sender, EventArgs e)
        {
            label_ReadCurrent.Text = GetCurrent();
        }

        private void button_GetP_Click(object sender, EventArgs e)
        {
            label_ReadPower.Text = GetPower();
        }

        private void button_GetPF_Click(object sender, EventArgs e)
        {
            label_ReadPF.Text = GetPF();
        }

        private void button_GetTHDI_Click(object sender, EventArgs e)
        {
            label_ReadTHDI.Text = GetTHDI();
        }

        
        private void button_GetGpib_Click(object sender, EventArgs e)
        {
            Get_Gpib();
        }

        private void button_GetVoltage_Click_1(object sender, EventArgs e)
        {
            label_ReadVoltage.Text = GetVoltage();
        }

        private void button_GetI_Click_1(object sender, EventArgs e)
        {
            label_ReadCurrent.Text = GetCurrent();
        }

        private void button_GetP_Click_1(object sender, EventArgs e)
        {
            label_ReadPower.Text = GetPower();
        }

        private void button_GetPF_Click_1(object sender, EventArgs e)
        {
            label_ReadPF.Text = GetPF();
        }

        private void button_GetTHDI_Click_1(object sender, EventArgs e)
        {
            label_ReadTHDI.Text = GetTHDI();
        }

        private void button_GetAll_Click_1(object sender, EventArgs e)
        {
            string[] s = new string[5];
            s = GetAll();

            label_ReadVoltage.Text = s.ElementAt(0);
            label_ReadCurrent.Text = s.ElementAt(1);
            label_ReadPower.Text = s.ElementAt(2);
            label_ReadPF.Text = s.ElementAt(3);
            label_ReadTHDI.Text = s.ElementAt(4);
        }
    }
}
