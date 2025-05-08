namespace WindowsFormsApp2
{
    partial class LogControl3
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_title = new System.Windows.Forms.Label();
            this.button_GetGpib = new System.Windows.Forms.Button();
            this.label_Voltage = new System.Windows.Forms.Label();
            this.label_ReadVoltage = new System.Windows.Forms.Label();
            this.comboBox_Gpib = new System.Windows.Forms.ComboBox();
            this.label_Current = new System.Windows.Forms.Label();
            this.label_ReadCurrent = new System.Windows.Forms.Label();
            this.label_Power = new System.Windows.Forms.Label();
            this.label_ReadPower = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_SetCurrent = new System.Windows.Forms.Label();
            this.textBox_SetIout = new System.Windows.Forms.TextBox();
            this.button_SetIout = new System.Windows.Forms.Button();
            this.button_LoadOff = new System.Windows.Forms.Button();
            this.label_result = new System.Windows.Forms.Label();
            this.button_LoadOn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Gold;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.01639F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.9836F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tableLayoutPanel1.Controls.Add(this.label_title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_GetGpib, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_Voltage, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_ReadVoltage, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_Gpib, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_Current, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_ReadCurrent, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_Power, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_ReadPower, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button1, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_SetCurrent, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox_SetIout, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.button_SetIout, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.button_LoadOff, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.label_result, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.button_LoadOn, 2, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 28);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.48936F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.51064F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(533, 260);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Location = new System.Drawing.Point(4, 0);
            this.label_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(59, 15);
            this.label_title.TabIndex = 11;
            this.label_title.Text = "DC Load";
            // 
            // button_GetGpib
            // 
            this.button_GetGpib.Location = new System.Drawing.Point(4, 32);
            this.button_GetGpib.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_GetGpib.Name = "button_GetGpib";
            this.button_GetGpib.Size = new System.Drawing.Size(63, 26);
            this.button_GetGpib.TabIndex = 12;
            this.button_GetGpib.Text = "GetGpib";
            this.button_GetGpib.UseVisualStyleBackColor = true;
            // 
            // label_Voltage
            // 
            this.label_Voltage.AutoSize = true;
            this.label_Voltage.Location = new System.Drawing.Point(4, 71);
            this.label_Voltage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Voltage.Name = "label_Voltage";
            this.label_Voltage.Size = new System.Drawing.Size(51, 15);
            this.label_Voltage.TabIndex = 13;
            this.label_Voltage.Text = "Voltage";
            // 
            // label_ReadVoltage
            // 
            this.label_ReadVoltage.AutoSize = true;
            this.label_ReadVoltage.Location = new System.Drawing.Point(4, 103);
            this.label_ReadVoltage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ReadVoltage.Name = "label_ReadVoltage";
            this.label_ReadVoltage.Size = new System.Drawing.Size(14, 15);
            this.label_ReadVoltage.TabIndex = 14;
            this.label_ReadVoltage.Text = "0";
            // 
            // comboBox_Gpib
            // 
            this.comboBox_Gpib.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.comboBox_Gpib, 3);
            this.comboBox_Gpib.FormattingEnabled = true;
            this.comboBox_Gpib.Location = new System.Drawing.Point(75, 32);
            this.comboBox_Gpib.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_Gpib.Name = "comboBox_Gpib";
            this.comboBox_Gpib.Size = new System.Drawing.Size(454, 23);
            this.comboBox_Gpib.TabIndex = 15;
            // 
            // label_Current
            // 
            this.label_Current.AutoSize = true;
            this.label_Current.Location = new System.Drawing.Point(75, 71);
            this.label_Current.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Current.Name = "label_Current";
            this.label_Current.Size = new System.Drawing.Size(50, 15);
            this.label_Current.TabIndex = 16;
            this.label_Current.Text = "Current";
            // 
            // label_ReadCurrent
            // 
            this.label_ReadCurrent.AutoSize = true;
            this.label_ReadCurrent.Location = new System.Drawing.Point(75, 103);
            this.label_ReadCurrent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ReadCurrent.Name = "label_ReadCurrent";
            this.label_ReadCurrent.Size = new System.Drawing.Size(14, 15);
            this.label_ReadCurrent.TabIndex = 17;
            this.label_ReadCurrent.Text = "0";
            // 
            // label_Power
            // 
            this.label_Power.AutoSize = true;
            this.label_Power.Location = new System.Drawing.Point(213, 71);
            this.label_Power.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Power.Name = "label_Power";
            this.label_Power.Size = new System.Drawing.Size(43, 15);
            this.label_Power.TabIndex = 18;
            this.label_Power.Text = "Power";
            // 
            // label_ReadPower
            // 
            this.label_ReadPower.AutoSize = true;
            this.label_ReadPower.Location = new System.Drawing.Point(213, 103);
            this.label_ReadPower.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ReadPower.Name = "label_ReadPower";
            this.label_ReadPower.Size = new System.Drawing.Size(14, 15);
            this.label_ReadPower.TabIndex = 19;
            this.label_ReadPower.Text = "0";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(380, 74);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 26);
            this.button1.TabIndex = 21;
            this.button1.Text = "Get all";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_SetCurrent
            // 
            this.label_SetCurrent.AutoSize = true;
            this.label_SetCurrent.Location = new System.Drawing.Point(4, 131);
            this.label_SetCurrent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SetCurrent.Name = "label_SetCurrent";
            this.label_SetCurrent.Size = new System.Drawing.Size(52, 15);
            this.label_SetCurrent.TabIndex = 22;
            this.label_SetCurrent.Text = "Set Iout";
            // 
            // textBox_SetIout
            // 
            this.textBox_SetIout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_SetIout.Location = new System.Drawing.Point(75, 134);
            this.textBox_SetIout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_SetIout.Name = "textBox_SetIout";
            this.textBox_SetIout.Size = new System.Drawing.Size(130, 25);
            this.textBox_SetIout.TabIndex = 23;
            this.textBox_SetIout.Text = "2";
            this.textBox_SetIout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_SetIout
            // 
            this.button_SetIout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_SetIout.Location = new System.Drawing.Point(213, 134);
            this.button_SetIout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_SetIout.Name = "button_SetIout";
            this.button_SetIout.Size = new System.Drawing.Size(159, 30);
            this.button_SetIout.TabIndex = 24;
            this.button_SetIout.Text = "SetIout";
            this.button_SetIout.UseVisualStyleBackColor = true;
            this.button_SetIout.Click += new System.EventHandler(this.button_SetIout_Click);
            // 
            // button_LoadOff
            // 
            this.button_LoadOff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_LoadOff.Location = new System.Drawing.Point(380, 181);
            this.button_LoadOff.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_LoadOff.Name = "button_LoadOff";
            this.button_LoadOff.Size = new System.Drawing.Size(149, 28);
            this.button_LoadOff.TabIndex = 26;
            this.button_LoadOff.Text = "Load off";
            this.button_LoadOff.UseVisualStyleBackColor = true;
            this.button_LoadOff.Click += new System.EventHandler(this.button_LoadOff_Click_1);
            // 
            // label_result
            // 
            this.label_result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.label_result, 3);
            this.label_result.Location = new System.Drawing.Point(75, 238);
            this.label_result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(454, 22);
            this.label_result.TabIndex = 27;
            this.label_result.Text = "...";
            this.label_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_LoadOn
            // 
            this.button_LoadOn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_LoadOn.Location = new System.Drawing.Point(213, 181);
            this.button_LoadOn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_LoadOn.Name = "button_LoadOn";
            this.button_LoadOn.Size = new System.Drawing.Size(159, 28);
            this.button_LoadOn.TabIndex = 25;
            this.button_LoadOn.Text = "Load on";
            this.button_LoadOn.UseVisualStyleBackColor = true;
            this.button_LoadOn.Click += new System.EventHandler(this.button_LoadOn_Click_1);
            // 
            // LogControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LogControl3";
            this.Size = new System.Drawing.Size(661, 302);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button button_GetGpib;
        private System.Windows.Forms.Label label_Voltage;
        private System.Windows.Forms.Label label_ReadVoltage;
        private System.Windows.Forms.ComboBox comboBox_Gpib;
        private System.Windows.Forms.Label label_Current;
        private System.Windows.Forms.Label label_ReadCurrent;
        private System.Windows.Forms.Label label_Power;
        private System.Windows.Forms.Label label_ReadPower;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_SetCurrent;
        private System.Windows.Forms.TextBox textBox_SetIout;
        private System.Windows.Forms.Button button_SetIout;
        private System.Windows.Forms.Button button_LoadOn;
        private System.Windows.Forms.Button button_LoadOff;
        private System.Windows.Forms.Label label_result;
    }
}
