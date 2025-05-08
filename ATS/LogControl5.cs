using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TIDP.SAA;    

namespace WindowsFormsApp2
{
    public partial class LogControl5 : UserControl
    {
        private static bool IsAdapterOK = false;
        public static int Active_adapter_num { get; set; }
        public int WriteBuf { get; set; }
        private static string TI_PMBus_Address { get; set; }
        TIBusAdapters Adapter = new TIBusAdapters();

        public LogControl5()
        {
            InitializeComponent();
        }

        private void TI_USB_GPIO_Load(object sender, EventArgs e)
        {

        }

        public void Init()
        {
            if (Adapter.Discover() == 0)
            {
                textBox_Debug.Text = "No TI USB adapter found.";
                IsAdapterOK = false;
            }
            else if (Adapter.Discover() > 1)
            {
                textBox_Debug.Text = "More than 1 TI USB adapter is found.";
                IsAdapterOK = false;
            }
            else
            {
                textBox_Debug.Text = "Ready.";
                IsAdapterOK = true;
                Active_adapter_num = 1;
            }
        }


        public string ReadByte()
        {
            ClearTextBox();

            if (IsAdapterOK == false)
            {
                textBox_Debug.Text = "Check adapter.";
                return "N/A";
            }

            IReadByteResult result;
            TI_PMBus_Address = this.textBox_SlaveAddress.Text;
            byte _addr = 0;
            if (TI_PMBus_Address.Length > 0)
            {
                _addr = Convert.ToByte(Convert.ToInt32(TI_PMBus_Address, 16) >> 1);
            }
            else
            {
                _addr = Convert.ToByte(Convert.ToInt32(textBox_SlaveAddress.Text, 16) >> 1);
            }
            byte _cmdcode = Convert.ToByte(textBox_CommandCode.Text, 16);

            result = Adapter.Read_Byte(Active_adapter_num, _addr, _cmdcode);

            if (result.Success)
            {
                textBox_Debug.Text = "Success.";
                textBox_ReadBuf.Text = result.Byte.ToString("X");
                return textBox_ReadBuf.Text;
            }
            else
            {
                textBox_Debug.Text = "Read byte fail.";
                return "N/A";
            }
        }


        public string ReadWord()
        {
            ClearTextBox();

            if (IsAdapterOK == false)
            {
                textBox_Debug.Text = "Check adapter.";
                return "N/A";
            }

            IReadWordResult result;

            byte _addr = 0;
            TI_PMBus_Address = this.textBox_SlaveAddress.Text;
            if (TI_PMBus_Address.Length > 0)
            {
                _addr = Convert.ToByte(Convert.ToInt32(TI_PMBus_Address, 16) >> 1);
            }
            else
            {
                _addr = Convert.ToByte(Convert.ToInt32(textBox_SlaveAddress.Text, 16) >> 1);
            }
            byte _cmdcode = Convert.ToByte(textBox_CommandCode.Text, 16);

            result = Adapter.Read_Word(Active_adapter_num, _addr, _cmdcode);

            if (result.Success)
            {
                textBox_Debug.Text = "Success.";
                textBox_ReadBuf.Text = result.Word.Hex.Substring(2);
                return textBox_ReadBuf.Text;
            }
            else
            {
                textBox_Debug.Text = "Read word fail.";
                return "N/A";
            }
        }

        private void ClearTextBox()
        {
            textBox_Debug.Text = "";
            textBox_ReadBuf.Text = "";
        }       

        public string ReadBlock()
        {
            ClearTextBox();

            if (IsAdapterOK == false)
            {
                textBox_Debug.Text = "Check adapter.";
                return "N/A";
            }

            IReadBlockResult result;

            byte _addr = 0;
            TI_PMBus_Address = this.textBox_SlaveAddress.Text;
            if (TI_PMBus_Address.Length > 0)
            {
                _addr = Convert.ToByte(Convert.ToInt32(TI_PMBus_Address, 16) >> 1);
            }
            else
            {
                _addr = Convert.ToByte(Convert.ToInt32(textBox_SlaveAddress.Text, 16) >> 1);
            }
            byte _cmdcode = Convert.ToByte(textBox_CommandCode.Text, 16);

            result = Adapter.Read_Block(Active_adapter_num, _addr, _cmdcode);

            if (result.Success)
            {
                textBox_Debug.Text = "Success.";
                textBox_ReadBuf.Text = result.Block.Hex.Substring(2);
                return textBox_ReadBuf.Text;
            }
            else
            {
                textBox_Debug.Text = "Read block fail.";
                return "N/A";
            }
        }

       

        public void WriteByte()
        {
            if (IsAdapterOK == false)
            {
                textBox_Debug.Text = "Check adapter.";
                return;
            }

            IAdapterResult result;

            byte _addr = 0;
            TI_PMBus_Address = this.textBox_SlaveAddress.Text;
            if (TI_PMBus_Address.Length > 0)
            {
                _addr = Convert.ToByte(Convert.ToInt32(TI_PMBus_Address, 16) >> 1);
            }
            else
            {
                _addr = Convert.ToByte(Convert.ToInt32(textBox_SlaveAddress.Text, 16) >> 1);
            }
            byte _cmdcode = Convert.ToByte(textBox_CommandCode.Text, 16);

            if (textBox_WriteBuf.Text == "")
            {
                textBox_Debug.Text = "Empty write string.";
                return;
            }

            result = Adapter.Write_Byte(Active_adapter_num, _addr, _cmdcode, "0x" + textBox_WriteBuf.Text);

            if (result.Success)
            {
                textBox_Debug.Text = "Success.";
            }
            else
            {
                textBox_Debug.Text = "Failed.";
            }
        }

      

        public void WriteWord()
        {
            if (IsAdapterOK == false)
            {
                textBox_Debug.Text = "Check adapter.";
                return;
            }

            IAdapterResult result;

            byte _addr = 0;
            if (TI_PMBus_Address.Length > 0)
            {
                _addr = Convert.ToByte(Convert.ToInt32(TI_PMBus_Address, 16) >> 1);
            }
            else
            {
                _addr = Convert.ToByte(Convert.ToInt32(textBox_SlaveAddress.Text, 16) >> 1);
            }
            byte _cmdcode = Convert.ToByte(textBox_CommandCode.Text, 16);

            if (textBox_WriteBuf.Text == "")
            {
                textBox_Debug.Text = "Empty write string.";
                return;
            }

            result = Adapter.Write_Word(Active_adapter_num, _addr, _cmdcode, "0x" + textBox_WriteBuf.Text);

            if (result.Success)
            {
                textBox_Debug.Text = "Success.";
            }
            else
            {
                textBox_Debug.Text = "Failed.";
            }
        }

       

        public void WriteBlock()
        {
            if (IsAdapterOK == false)
            {
                textBox_Debug.Text = "Check adapter.";
                return;
            }

            IAdapterResult result;

            byte _addr = 0;
            if (TI_PMBus_Address.Length > 0)
            {
                _addr = Convert.ToByte(Convert.ToInt32(TI_PMBus_Address, 16) >> 1);
            }
            else
            {
                _addr = Convert.ToByte(Convert.ToInt32(textBox_SlaveAddress.Text, 16) >> 1);
            }
            byte _cmdcode = Convert.ToByte(textBox_CommandCode.Text, 16);

            if (textBox_WriteBuf.Text == "")
            {
                textBox_Debug.Text = "Empty write string.";
                return;
            }

            result = Adapter.Write_Block(Active_adapter_num, _addr, _cmdcode, textBox_WriteBuf.Text);

            if (result.Success)
            {
                textBox_Debug.Text = "Success.";
            }
            else
            {
                textBox_Debug.Text = "Failed.";
            }
        }

        public void SetAddress(string s)
        {
            textBox_SlaveAddress.Text = s;
            //this.label1 = s;
            TI_PMBus_Address = s;
        }

        public string GetAddress()
        {
            return textBox_SlaveAddress.Text;
        }

        public void SetCommandCode(string s)
        {
            textBox_CommandCode.Text = s;
        }

        public string GetCommandCode()
        {
            return textBox_CommandCode.Text;
        }

        public void SetWriteBuf(string s)
        {
            textBox_WriteBuf.Text = s;
        }

        public string GetWriteBuf()
        {
            return textBox_WriteBuf.Text;
        }

        public string ParmInfoValue(string s)
        {
            SetCommandCode("E2");
            SetWriteBuf(s);
            WriteBlock();
            SetCommandCode("E3");
            return ReadBlock();
        }

        public void ParmInfoWrite(string s, string p)
        {
            string q = "";

            // Low byte first, need to reverse the order.
            if (p.Length == 0)
            {
                q = "0000";
            }
            else if (p.Length == 1)
            {
                q = "0" + p + "00";
            }
            else if (p.Length == 2)
            {
                q = p + "00";
            }
            else
            {
                int i;

                if (p.Length > 4)
                {
                    p = p.Substring(0, 4);
                }

                for (i = p.Length; i >= 2; i -= 2)
                {
                    q += p.Substring((i - 2), 2);
                }

                if (i == 1)
                {
                    q += ("0" + p.Substring(0, 1));
                }
            }

            SetCommandCode("E2");
            SetWriteBuf(s);
            WriteBlock();
            SetCommandCode("E3");
            SetWriteBuf(q);
            WriteBlock();
        }

        public string DebugBuffer()
        {
            SetCommandCode("F0");
            return ReadBlock();
        }


        public string BlockWriteBlockRead()
        {
            if (IsAdapterOK == false)
            {
                textBox_Debug.Text = "Check adapter.";
                return "N/A";
            }

            IReadWordResult result;
            TI_PMBus_Address = this.textBox_SlaveAddress.Text;

            byte _addr = 0;
            if (TI_PMBus_Address.Length > 0)
            {
                _addr = Convert.ToByte(Convert.ToInt32(TI_PMBus_Address, 16) >> 1);
            }
            else
            {
                _addr = Convert.ToByte(Convert.ToInt32(textBox_SlaveAddress.Text, 16) >> 1);
            }
            byte _cmdcode = Convert.ToByte(textBox_CommandCode.Text, 16);
            //byte[] _wrbuf = new byte[10];

            if (textBox_WriteBuf.Text == "")
            {
                textBox_Debug.Text = "Empty write string.";
                textBox_ReadBuf.Text = "N/A";
                return textBox_ReadBuf.Text;
            }

            if (textBox_WriteBuf.TextLength > 2)
            {
                textBox_Debug.Text = "Only 1 byte is allowed.";
                textBox_ReadBuf.Text = "N/A";
                return textBox_ReadBuf.Text;
            }

            int _value = Convert.ToInt32(textBox_WriteBuf.Text, 16);
            byte _wrbuf = Convert.ToByte(_value);

            result = Adapter.Process_Call(1, _addr, _cmdcode, 0x01, _wrbuf);

            if (result.Success)
            {
                textBox_Debug.Text = "Success.";
                textBox_ReadBuf.Text = result.Bytes[1].ToString("X2");
                return textBox_ReadBuf.Text;
            }
            else
            {
                textBox_Debug.Text = "Read byte fail.";
                return "N/A";
            }
        }

        public double Linear11(string s)
        {
            try
            {
                int _Val = Convert.ToInt32(s, 16);
                int mantissa = 0;
                int exponent = 0;

                UInt16 exp_temp;

                exp_temp = (UInt16)((_Val >> 11) & 0x1F);

                if ((exp_temp & 0x10) != 0)
                {
                    exponent = exp_temp - 32;
                }
                else
                {
                    exponent = exp_temp;
                }

                mantissa = _Val & 0x07FF;


                return (double)mantissa * Math.Pow(2.0, exponent);
            }
            catch
            {
                return 0;
            }
        }

        public double Linear16(string s, int exp)
        {
            try
            {
                int _Val = Convert.ToInt32(s, 16);
                int mantissa = _Val;

                return (double)mantissa * Math.Pow(2.0, exp);
            }
            catch
            {
                return 0;
            }
        }

        /* I2C */
        public bool I2CWrite(int len, byte[] WriteData)
        {
            if (len <= 0)
            {
                textBox_Debug.Text = "Len can not be zero.";
                return false;
            }

            if (IsAdapterOK == false)
            {
                textBox_Debug.Text = "Check adapter.";
                return false;
            }

            IAdapterResult result;

            byte _addr = 0;
            TI_PMBus_Address = this.textBox_SlaveAddress.Text;
            if (TI_PMBus_Address.Length > 0)
            {
                _addr = Convert.ToByte(Convert.ToInt32(TI_PMBus_Address, 16) >> 1);
            }
            else
            {
                _addr = Convert.ToByte(Convert.ToInt32(textBox_SlaveAddress.Text, 16) >> 1);
            }
            byte _cmdcode = Convert.ToByte(textBox_CommandCode.Text, 16);

            result = Adapter.I2C_Write(Active_adapter_num, _addr, _cmdcode, len, WriteData);

            if (result.Success)
            {
                textBox_Debug.Text = "Success.";
                return true;
            }
            else
            {
                textBox_Debug.Text = "Read I2C fail.";
                return false;
            }
        }

        public string I2CRead(int len)
        {
            ClearTextBox();

            if (len <= 0)
            {
                textBox_Debug.Text = "Len can not be zero.";
                return "N/A";
            }

            if (IsAdapterOK == false)
            {
                textBox_Debug.Text = "Check adapter.";
                return "N/A";
            }

            IReadBlockResult result;

            byte _addr = 0;
            TI_PMBus_Address = this.textBox_SlaveAddress.Text;
            if (TI_PMBus_Address.Length > 0)
            {
                _addr = Convert.ToByte(Convert.ToInt32(TI_PMBus_Address, 16) >> 1);
            }
            else
            {
                _addr = Convert.ToByte(Convert.ToInt32(textBox_SlaveAddress.Text, 16) >> 1);
            }
            byte _cmdcode = Convert.ToByte(textBox_CommandCode.Text, 16);

            result = Adapter.I2C_Read(Active_adapter_num, _addr, _cmdcode, len);

            if (result.Success)
            {
                textBox_Debug.Text = "Success.";
                textBox_ReadBuf.Text = result.Block.Hex.Substring(2);
                return textBox_ReadBuf.Text;
            }
            else
            {
                textBox_Debug.Text = "Read I2C fail.";
                return "N/A";
            }
        }

        public bool GPIO_Control(int line_num, LogicLevel level)
        {
            ILogicLevelResult result;

            Adapter.Set_Control(Active_adapter_num, line_num, level);   // Set control
            result = Adapter.Get_Control(Active_adapter_num, line_num);

            if (result.Level == level)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

      

       

        private void button_BlockWriteBlockRead_Click_1(object sender, EventArgs e)
        {
            BlockWriteBlockRead();

        }

        private void button_ReadByte_Click_1(object sender, EventArgs e)
        {
            ReadByte();
        }

        private void button_ReadWord_Click(object sender, EventArgs e)
        {
            ReadWord();
        }

        private void button_ReadBlock_Click_1(object sender, EventArgs e)
        {
            ReadBlock();
        }

        private void button_WriteByte_Click(object sender, EventArgs e)
        {
            WriteByte();
        }

        private void button_WriteWord_Click(object sender, EventArgs e)
        {
            WriteWord();
        }

        private void button_WriteBlock_Click(object sender, EventArgs e)
        {
            WriteBlock();
        }

        private void button_ControlLevelHIgh_Click_1(object sender, EventArgs e)
        {
            int line_num = 0;

            switch (comboBox_GpioControl.SelectedIndex)
            {
                default:
                case 0:
                    line_num = 5; break;
                case 1:
                    line_num = 4; break;
                case 2:
                    line_num = 3; break;
                case 3:
                    line_num = 2; break;
                case 4:
                    line_num = 1; break;
            }

            GPIO_Control(line_num, LogicLevel.High);
        }

        private void button_ControlLevelLow_Click(object sender, EventArgs e)
        {
            int line_num = 0;

            switch (comboBox_GpioControl.SelectedIndex)
            {
                default:
                case 0:
                    line_num = 5; break;
                case 1:
                    line_num = 4; break;
                case 2:
                    line_num = 3; break;
                case 3:
                    line_num = 2; break;
                case 4:
                    line_num = 1; break;
            }

            GPIO_Control(line_num, LogicLevel.Low);
        }
    }
}
