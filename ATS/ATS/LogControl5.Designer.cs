namespace WindowsFormsApp2
{
    partial class LogControl5
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Debug = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_BlockWriteBlockRead = new System.Windows.Forms.Button();
            this.button_WriteBlock = new System.Windows.Forms.Button();
            this.button_ReadBlock = new System.Windows.Forms.Button();
            this.button_WriteWord = new System.Windows.Forms.Button();
            this.button_ReadWord = new System.Windows.Forms.Button();
            this.button_WriteByte = new System.Windows.Forms.Button();
            this.button_ReadByte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_SlaveAddress = new System.Windows.Forms.TextBox();
            this.textBox_CommandCode = new System.Windows.Forms.TextBox();
            this.textBox_WriteBuf = new System.Windows.Forms.TextBox();
            this.textBox_ReadBuf = new System.Windows.Forms.TextBox();
            this.groupBox_Gpio = new System.Windows.Forms.GroupBox();
            this.button_ControlLevelLow = new System.Windows.Forms.Button();
            this.button_ControlLevelHIgh = new System.Windows.Forms.Button();
            this.comboBox_GpioControl = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox_Gpio.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Debug
            // 
            this.textBox_Debug.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Debug.BackColor = System.Drawing.Color.Black;
            this.textBox_Debug.ForeColor = System.Drawing.Color.Lime;
            this.textBox_Debug.Location = new System.Drawing.Point(16, 4);
            this.textBox_Debug.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Debug.Name = "textBox_Debug";
            this.textBox_Debug.Size = new System.Drawing.Size(600, 29);
            this.textBox_Debug.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.23474F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.76526F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 254F));
            this.tableLayoutPanel1.Controls.Add(this.button_BlockWriteBlockRead, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_WriteBlock, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_ReadBlock, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_WriteWord, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_ReadWord, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_WriteByte, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_ReadByte, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox_SlaveAddress, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox_CommandCode, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox_WriteBuf, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBox_ReadBuf, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.6129F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.3871F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(341, 298);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // button_BlockWriteBlockRead
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.button_BlockWriteBlockRead, 2);
            this.button_BlockWriteBlockRead.Location = new System.Drawing.Point(4, 121);
            this.button_BlockWriteBlockRead.Margin = new System.Windows.Forms.Padding(4);
            this.button_BlockWriteBlockRead.Name = "button_BlockWriteBlockRead";
            this.button_BlockWriteBlockRead.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_BlockWriteBlockRead.Size = new System.Drawing.Size(283, 31);
            this.button_BlockWriteBlockRead.TabIndex = 15;
            this.button_BlockWriteBlockRead.Text = "(N/A) Block-Write-Block-Read";
            this.button_BlockWriteBlockRead.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_BlockWriteBlockRead.UseVisualStyleBackColor = true;
            this.button_BlockWriteBlockRead.Click += new System.EventHandler(this.button_BlockWriteBlockRead_Click_1);
            // 
            // button_WriteBlock
            // 
            this.button_WriteBlock.Location = new System.Drawing.Point(175, 78);
            this.button_WriteBlock.Margin = new System.Windows.Forms.Padding(4);
            this.button_WriteBlock.Name = "button_WriteBlock";
            this.button_WriteBlock.Size = new System.Drawing.Size(112, 34);
            this.button_WriteBlock.TabIndex = 14;
            this.button_WriteBlock.Text = "Write Block";
            this.button_WriteBlock.UseVisualStyleBackColor = true;
            this.button_WriteBlock.Click += new System.EventHandler(this.button_WriteBlock_Click);
            // 
            // button_ReadBlock
            // 
            this.button_ReadBlock.Location = new System.Drawing.Point(4, 78);
            this.button_ReadBlock.Margin = new System.Windows.Forms.Padding(4);
            this.button_ReadBlock.Name = "button_ReadBlock";
            this.button_ReadBlock.Size = new System.Drawing.Size(112, 34);
            this.button_ReadBlock.TabIndex = 13;
            this.button_ReadBlock.Text = "Read Block";
            this.button_ReadBlock.UseVisualStyleBackColor = true;
            this.button_ReadBlock.Click += new System.EventHandler(this.button_ReadBlock_Click_1);
            // 
            // button_WriteWord
            // 
            this.button_WriteWord.Location = new System.Drawing.Point(175, 42);
            this.button_WriteWord.Margin = new System.Windows.Forms.Padding(4);
            this.button_WriteWord.Name = "button_WriteWord";
            this.button_WriteWord.Size = new System.Drawing.Size(112, 28);
            this.button_WriteWord.TabIndex = 12;
            this.button_WriteWord.Text = "Write Word";
            this.button_WriteWord.UseVisualStyleBackColor = true;
            this.button_WriteWord.Click += new System.EventHandler(this.button_WriteWord_Click);
            // 
            // button_ReadWord
            // 
            this.button_ReadWord.Location = new System.Drawing.Point(4, 42);
            this.button_ReadWord.Margin = new System.Windows.Forms.Padding(4);
            this.button_ReadWord.Name = "button_ReadWord";
            this.button_ReadWord.Size = new System.Drawing.Size(112, 28);
            this.button_ReadWord.TabIndex = 11;
            this.button_ReadWord.Text = "Read Word";
            this.button_ReadWord.UseVisualStyleBackColor = true;
            this.button_ReadWord.Click += new System.EventHandler(this.button_ReadWord_Click);
            // 
            // button_WriteByte
            // 
            this.button_WriteByte.Location = new System.Drawing.Point(175, 4);
            this.button_WriteByte.Margin = new System.Windows.Forms.Padding(4);
            this.button_WriteByte.Name = "button_WriteByte";
            this.button_WriteByte.Size = new System.Drawing.Size(112, 30);
            this.button_WriteByte.TabIndex = 10;
            this.button_WriteByte.Text = "Write Byte";
            this.button_WriteByte.UseVisualStyleBackColor = true;
            this.button_WriteByte.Click += new System.EventHandler(this.button_WriteByte_Click);
            // 
            // button_ReadByte
            // 
            this.button_ReadByte.Location = new System.Drawing.Point(4, 4);
            this.button_ReadByte.Margin = new System.Windows.Forms.Padding(4);
            this.button_ReadByte.Name = "button_ReadByte";
            this.button_ReadByte.Size = new System.Drawing.Size(112, 30);
            this.button_ReadByte.TabIndex = 2;
            this.button_ReadByte.Text = "Read Byte";
            this.button_ReadByte.UseVisualStyleBackColor = true;
            this.button_ReadByte.Click += new System.EventHandler(this.button_ReadByte_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "PMBus address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Command code";
            // 
            // textBox_SlaveAddress
            // 
            this.textBox_SlaveAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_SlaveAddress.Location = new System.Drawing.Point(175, 160);
            this.textBox_SlaveAddress.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_SlaveAddress.Name = "textBox_SlaveAddress";
            this.textBox_SlaveAddress.Size = new System.Drawing.Size(110, 29);
            this.textBox_SlaveAddress.TabIndex = 30;
            this.textBox_SlaveAddress.Text = "73";
            // 
            // textBox_CommandCode
            // 
            this.textBox_CommandCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_CommandCode.Location = new System.Drawing.Point(175, 191);
            this.textBox_CommandCode.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_CommandCode.Name = "textBox_CommandCode";
            this.textBox_CommandCode.Size = new System.Drawing.Size(110, 29);
            this.textBox_CommandCode.TabIndex = 31;
            this.textBox_CommandCode.Text = "96";
            // 
            // textBox_WriteBuf
            // 
            this.textBox_WriteBuf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.textBox_WriteBuf, 2);
            this.textBox_WriteBuf.Location = new System.Drawing.Point(4, 265);
            this.textBox_WriteBuf.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_WriteBuf.Name = "textBox_WriteBuf";
            this.textBox_WriteBuf.Size = new System.Drawing.Size(333, 29);
            this.textBox_WriteBuf.TabIndex = 33;
            // 
            // textBox_ReadBuf
            // 
            this.textBox_ReadBuf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.textBox_ReadBuf, 2);
            this.textBox_ReadBuf.Location = new System.Drawing.Point(4, 226);
            this.textBox_ReadBuf.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ReadBuf.Name = "textBox_ReadBuf";
            this.textBox_ReadBuf.Size = new System.Drawing.Size(333, 29);
            this.textBox_ReadBuf.TabIndex = 32;
            // 
            // groupBox_Gpio
            // 
            this.groupBox_Gpio.Controls.Add(this.button_ControlLevelLow);
            this.groupBox_Gpio.Controls.Add(this.button_ControlLevelHIgh);
            this.groupBox_Gpio.Controls.Add(this.comboBox_GpioControl);
            this.groupBox_Gpio.Location = new System.Drawing.Point(379, 49);
            this.groupBox_Gpio.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_Gpio.Name = "groupBox_Gpio";
            this.groupBox_Gpio.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_Gpio.Size = new System.Drawing.Size(212, 164);
            this.groupBox_Gpio.TabIndex = 13;
            this.groupBox_Gpio.TabStop = false;
            this.groupBox_Gpio.Text = "Control Pin";
            // 
            // button_ControlLevelLow
            // 
            this.button_ControlLevelLow.Location = new System.Drawing.Point(48, 116);
            this.button_ControlLevelLow.Margin = new System.Windows.Forms.Padding(4);
            this.button_ControlLevelLow.Name = "button_ControlLevelLow";
            this.button_ControlLevelLow.Size = new System.Drawing.Size(112, 34);
            this.button_ControlLevelLow.TabIndex = 2;
            this.button_ControlLevelLow.Text = "Low";
            this.button_ControlLevelLow.UseVisualStyleBackColor = true;
            this.button_ControlLevelLow.Click += new System.EventHandler(this.button_ControlLevelLow_Click);
            // 
            // button_ControlLevelHIgh
            // 
            this.button_ControlLevelHIgh.Location = new System.Drawing.Point(48, 72);
            this.button_ControlLevelHIgh.Margin = new System.Windows.Forms.Padding(4);
            this.button_ControlLevelHIgh.Name = "button_ControlLevelHIgh";
            this.button_ControlLevelHIgh.Size = new System.Drawing.Size(112, 34);
            this.button_ControlLevelHIgh.TabIndex = 1;
            this.button_ControlLevelHIgh.Text = "High";
            this.button_ControlLevelHIgh.UseVisualStyleBackColor = true;
            this.button_ControlLevelHIgh.Click += new System.EventHandler(this.button_ControlLevelHIgh_Click_1);
            // 
            // comboBox_GpioControl
            // 
            this.comboBox_GpioControl.FormattingEnabled = true;
            this.comboBox_GpioControl.Items.AddRange(new object[] {
            "Ctrl5 (Pin #1)",
            "Ctrl4 (Pin #2)",
            "Ctrl3 (Pin #3)",
            "Ctrl2 (Pin #4)",
            "Ctrl1 (Pin #7)"});
            this.comboBox_GpioControl.Location = new System.Drawing.Point(10, 33);
            this.comboBox_GpioControl.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_GpioControl.Name = "comboBox_GpioControl";
            this.comboBox_GpioControl.Size = new System.Drawing.Size(180, 26);
            this.comboBox_GpioControl.TabIndex = 0;
            this.comboBox_GpioControl.Text = "Ctrl5 (Pin #1)";
            // 
            // LogControl5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_Gpio);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBox_Debug);
            this.Name = "LogControl5";
            this.Size = new System.Drawing.Size(744, 363);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox_Gpio.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Debug;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox_Gpio;
        private System.Windows.Forms.Button button_ControlLevelLow;
        private System.Windows.Forms.Button button_ControlLevelHIgh;
        private System.Windows.Forms.ComboBox comboBox_GpioControl;
        private System.Windows.Forms.Button button_ReadByte;
        private System.Windows.Forms.Button button_WriteByte;
        private System.Windows.Forms.Button button_ReadWord;
        private System.Windows.Forms.Button button_WriteWord;
        private System.Windows.Forms.Button button_ReadBlock;
        private System.Windows.Forms.Button button_WriteBlock;
        private System.Windows.Forms.Button button_BlockWriteBlockRead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_SlaveAddress;
        private System.Windows.Forms.TextBox textBox_CommandCode;
        private System.Windows.Forms.TextBox textBox_ReadBuf;
        private System.Windows.Forms.TextBox textBox_WriteBuf;
    }
}
