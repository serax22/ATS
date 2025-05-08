namespace WindowsFormsApp2
{
    partial class LogControl4
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
            this.label_ReadPF = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_GetGpib = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Current = new System.Windows.Forms.Label();
            this.label_Power = new System.Windows.Forms.Label();
            this.label_PF = new System.Windows.Forms.Label();
            this.label_THDI = new System.Windows.Forms.Label();
            this.button_GetVoltage = new System.Windows.Forms.Button();
            this.button_GetP = new System.Windows.Forms.Button();
            this.button_GetPF = new System.Windows.Forms.Button();
            this.button_GetTHDI = new System.Windows.Forms.Button();
            this.comboBox_Gpib = new System.Windows.Forms.ComboBox();
            this.button_GetI = new System.Windows.Forms.Button();
            this.label_ReadVoltage = new System.Windows.Forms.Label();
            this.label_ReadCurrent = new System.Windows.Forms.Label();
            this.label_ReadPower = new System.Windows.Forms.Label();
            this.label_ReadTHDI = new System.Windows.Forms.Label();
            this.button_GetAll = new System.Windows.Forms.Button();
            this.label_result = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.64048F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.35952F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel1.Controls.Add(this.label_ReadPF, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_GetGpib, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_Current, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_Power, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label_PF, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label_THDI, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.button_GetVoltage, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_GetP, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.button_GetPF, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.button_GetTHDI, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_Gpib, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_GetI, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_ReadVoltage, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_ReadCurrent, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_ReadPower, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label_ReadTHDI, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.button_GetAll, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_result, 1, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.43662F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.56338F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 312);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label_ReadPF
            // 
            this.label_ReadPF.AutoSize = true;
            this.label_ReadPF.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_ReadPF.Location = new System.Drawing.Point(165, 196);
            this.label_ReadPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ReadPF.Name = "label_ReadPF";
            this.label_ReadPF.Size = new System.Drawing.Size(20, 18);
            this.label_ReadPF.TabIndex = 23;
            this.label_ReadPF.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "PowerMeter";
            // 
            // button_GetGpib
            // 
            this.button_GetGpib.Location = new System.Drawing.Point(4, 32);
            this.button_GetGpib.Margin = new System.Windows.Forms.Padding(4);
            this.button_GetGpib.Name = "button_GetGpib";
            this.button_GetGpib.Size = new System.Drawing.Size(106, 33);
            this.button_GetGpib.TabIndex = 28;
            this.button_GetGpib.Text = "GetGpib";
            this.button_GetGpib.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(4, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "Voltage";
            // 
            // label_Current
            // 
            this.label_Current.AutoSize = true;
            this.label_Current.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_Current.Location = new System.Drawing.Point(4, 108);
            this.label_Current.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Current.Name = "label_Current";
            this.label_Current.Size = new System.Drawing.Size(60, 18);
            this.label_Current.TabIndex = 32;
            this.label_Current.Text = "Current";
            // 
            // label_Power
            // 
            this.label_Power.AutoSize = true;
            this.label_Power.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_Power.Location = new System.Drawing.Point(4, 151);
            this.label_Power.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Power.Name = "label_Power";
            this.label_Power.Size = new System.Drawing.Size(51, 18);
            this.label_Power.TabIndex = 33;
            this.label_Power.Text = "Power";
            // 
            // label_PF
            // 
            this.label_PF.AutoSize = true;
            this.label_PF.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_PF.Location = new System.Drawing.Point(4, 196);
            this.label_PF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_PF.Name = "label_PF";
            this.label_PF.Size = new System.Drawing.Size(26, 18);
            this.label_PF.TabIndex = 34;
            this.label_PF.Text = "PF";
            // 
            // label_THDI
            // 
            this.label_THDI.AutoSize = true;
            this.label_THDI.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_THDI.Location = new System.Drawing.Point(4, 239);
            this.label_THDI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_THDI.Name = "label_THDI";
            this.label_THDI.Size = new System.Drawing.Size(48, 18);
            this.label_THDI.TabIndex = 35;
            this.label_THDI.Text = "THDI";
            // 
            // button_GetVoltage
            // 
            this.button_GetVoltage.Location = new System.Drawing.Point(335, 75);
            this.button_GetVoltage.Margin = new System.Windows.Forms.Padding(4);
            this.button_GetVoltage.Name = "button_GetVoltage";
            this.button_GetVoltage.Size = new System.Drawing.Size(115, 29);
            this.button_GetVoltage.TabIndex = 36;
            this.button_GetVoltage.Text = "Get";
            this.button_GetVoltage.UseVisualStyleBackColor = true;
            this.button_GetVoltage.Click += new System.EventHandler(this.button_GetVoltage_Click_1);
            // 
            // button_GetP
            // 
            this.button_GetP.Location = new System.Drawing.Point(335, 155);
            this.button_GetP.Margin = new System.Windows.Forms.Padding(4);
            this.button_GetP.Name = "button_GetP";
            this.button_GetP.Size = new System.Drawing.Size(115, 34);
            this.button_GetP.TabIndex = 38;
            this.button_GetP.Text = "Get";
            this.button_GetP.UseVisualStyleBackColor = true;
            this.button_GetP.Click += new System.EventHandler(this.button_GetP_Click_1);
            // 
            // button_GetPF
            // 
            this.button_GetPF.Location = new System.Drawing.Point(335, 200);
            this.button_GetPF.Margin = new System.Windows.Forms.Padding(4);
            this.button_GetPF.Name = "button_GetPF";
            this.button_GetPF.Size = new System.Drawing.Size(115, 32);
            this.button_GetPF.TabIndex = 39;
            this.button_GetPF.Text = "Get";
            this.button_GetPF.UseVisualStyleBackColor = true;
            this.button_GetPF.Click += new System.EventHandler(this.button_GetPF_Click_1);
            // 
            // button_GetTHDI
            // 
            this.button_GetTHDI.Location = new System.Drawing.Point(335, 243);
            this.button_GetTHDI.Margin = new System.Windows.Forms.Padding(4);
            this.button_GetTHDI.Name = "button_GetTHDI";
            this.button_GetTHDI.Size = new System.Drawing.Size(115, 34);
            this.button_GetTHDI.TabIndex = 40;
            this.button_GetTHDI.Text = "Get";
            this.button_GetTHDI.UseVisualStyleBackColor = true;
            this.button_GetTHDI.Click += new System.EventHandler(this.button_GetTHDI_Click_1);
            // 
            // comboBox_Gpib
            // 
            this.comboBox_Gpib.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.comboBox_Gpib, 3);
            this.comboBox_Gpib.FormattingEnabled = true;
            this.comboBox_Gpib.Location = new System.Drawing.Point(165, 32);
            this.comboBox_Gpib.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Gpib.Name = "comboBox_Gpib";
            this.comboBox_Gpib.Size = new System.Drawing.Size(431, 26);
            this.comboBox_Gpib.TabIndex = 29;
            // 
            // button_GetI
            // 
            this.button_GetI.Location = new System.Drawing.Point(335, 112);
            this.button_GetI.Margin = new System.Windows.Forms.Padding(4);
            this.button_GetI.Name = "button_GetI";
            this.button_GetI.Size = new System.Drawing.Size(115, 34);
            this.button_GetI.TabIndex = 37;
            this.button_GetI.Text = "Get";
            this.button_GetI.UseVisualStyleBackColor = true;
            this.button_GetI.Click += new System.EventHandler(this.button_GetI_Click_1);
            // 
            // label_ReadVoltage
            // 
            this.label_ReadVoltage.AutoSize = true;
            this.label_ReadVoltage.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_ReadVoltage.Location = new System.Drawing.Point(165, 71);
            this.label_ReadVoltage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ReadVoltage.Name = "label_ReadVoltage";
            this.label_ReadVoltage.Size = new System.Drawing.Size(20, 18);
            this.label_ReadVoltage.TabIndex = 42;
            this.label_ReadVoltage.Text = "...";
            // 
            // label_ReadCurrent
            // 
            this.label_ReadCurrent.AutoSize = true;
            this.label_ReadCurrent.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_ReadCurrent.Location = new System.Drawing.Point(165, 108);
            this.label_ReadCurrent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ReadCurrent.Name = "label_ReadCurrent";
            this.label_ReadCurrent.Size = new System.Drawing.Size(20, 18);
            this.label_ReadCurrent.TabIndex = 43;
            this.label_ReadCurrent.Text = "...";
            // 
            // label_ReadPower
            // 
            this.label_ReadPower.AutoSize = true;
            this.label_ReadPower.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_ReadPower.Location = new System.Drawing.Point(165, 151);
            this.label_ReadPower.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ReadPower.Name = "label_ReadPower";
            this.label_ReadPower.Size = new System.Drawing.Size(20, 18);
            this.label_ReadPower.TabIndex = 44;
            this.label_ReadPower.Text = "...";
            // 
            // label_ReadTHDI
            // 
            this.label_ReadTHDI.AutoSize = true;
            this.label_ReadTHDI.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_ReadTHDI.Location = new System.Drawing.Point(165, 239);
            this.label_ReadTHDI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ReadTHDI.Name = "label_ReadTHDI";
            this.label_ReadTHDI.Size = new System.Drawing.Size(20, 18);
            this.label_ReadTHDI.TabIndex = 45;
            this.label_ReadTHDI.Text = "...";
            // 
            // button_GetAll
            // 
            this.button_GetAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_GetAll.Location = new System.Drawing.Point(475, 75);
            this.button_GetAll.Margin = new System.Windows.Forms.Padding(4);
            this.button_GetAll.Name = "button_GetAll";
            this.tableLayoutPanel1.SetRowSpan(this.button_GetAll, 5);
            this.button_GetAll.Size = new System.Drawing.Size(121, 205);
            this.button_GetAll.TabIndex = 41;
            this.button_GetAll.Text = "GetAll";
            this.button_GetAll.UseVisualStyleBackColor = true;
            this.button_GetAll.Click += new System.EventHandler(this.button_GetAll_Click_1);
            // 
            // label_result
            // 
            this.label_result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.label_result, 3);
            this.label_result.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_result.Location = new System.Drawing.Point(165, 284);
            this.label_result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(431, 28);
            this.label_result.TabIndex = 46;
            this.label_result.Text = "...";
            this.label_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogControl4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LogControl4";
            this.Size = new System.Drawing.Size(744, 363);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_GetGpib;
        private System.Windows.Forms.ComboBox comboBox_Gpib;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Current;
        private System.Windows.Forms.Label label_Power;
        private System.Windows.Forms.Label label_PF;
        private System.Windows.Forms.Label label_THDI;
        private System.Windows.Forms.Button button_GetVoltage;
        private System.Windows.Forms.Button button_GetI;
        private System.Windows.Forms.Button button_GetP;
        private System.Windows.Forms.Button button_GetPF;
        private System.Windows.Forms.Button button_GetTHDI;
        private System.Windows.Forms.Button button_GetAll;
        private System.Windows.Forms.Label label_ReadVoltage;
        private System.Windows.Forms.Label label_ReadCurrent;
        private System.Windows.Forms.Label label_ReadPower;
        private System.Windows.Forms.Label label_ReadPF;
        private System.Windows.Forms.Label label_ReadTHDI;
        private System.Windows.Forms.Label label_result;
    }
}
