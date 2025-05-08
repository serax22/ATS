namespace WindowsFormsApp2
{
    partial class LogControl2
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
            this.label_Title = new System.Windows.Forms.Label();
            this.button_GetGpib = new System.Windows.Forms.Button();
            this.comboBox_Gpib = new System.Windows.Forms.ComboBox();
            this.textBox_Voltage = new System.Windows.Forms.TextBox();
            this.textBox_Freq = new System.Windows.Forms.TextBox();
            this.button_Set = new System.Windows.Forms.Button();
            this.button_OutputOn = new System.Windows.Forms.Button();
            this.label_Voltage = new System.Windows.Forms.Label();
            this.label_Freq = new System.Windows.Forms.Label();
            this.button_OutputOff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Navy;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.01639F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.9836F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 186F));
            this.tableLayoutPanel1.Controls.Add(this.label_Title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_GetGpib, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_Gpib, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Voltage, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Freq, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_Set, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.button_OutputOn, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label_Voltage, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_Freq, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_OutputOff, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.39394F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.60606F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 312);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.ForeColor = System.Drawing.Color.LightGray;
            this.label_Title.Location = new System.Drawing.Point(4, 0);
            this.label_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(83, 18);
            this.label_Title.TabIndex = 1;
            this.label_Title.Text = "AC Source";
            // 
            // button_GetGpib
            // 
            this.button_GetGpib.Location = new System.Drawing.Point(4, 46);
            this.button_GetGpib.Margin = new System.Windows.Forms.Padding(4);
            this.button_GetGpib.Name = "button_GetGpib";
            this.button_GetGpib.Size = new System.Drawing.Size(110, 33);
            this.button_GetGpib.TabIndex = 2;
            this.button_GetGpib.Text = "GetGpib";
            this.button_GetGpib.UseVisualStyleBackColor = true;
            this.button_GetGpib.Click += new System.EventHandler(this.button_GetGpib_Click_1);
            // 
            // comboBox_Gpib
            // 
            this.comboBox_Gpib.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.comboBox_Gpib, 2);
            this.comboBox_Gpib.FormattingEnabled = true;
            this.comboBox_Gpib.Location = new System.Drawing.Point(144, 46);
            this.comboBox_Gpib.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Gpib.Name = "comboBox_Gpib";
            this.comboBox_Gpib.Size = new System.Drawing.Size(452, 26);
            this.comboBox_Gpib.TabIndex = 3;
            // 
            // textBox_Voltage
            // 
            this.textBox_Voltage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Voltage.Location = new System.Drawing.Point(144, 112);
            this.textBox_Voltage.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Voltage.Name = "textBox_Voltage";
            this.textBox_Voltage.Size = new System.Drawing.Size(265, 29);
            this.textBox_Voltage.TabIndex = 5;
            this.textBox_Voltage.Text = "230";
            // 
            // textBox_Freq
            // 
            this.textBox_Freq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Freq.Location = new System.Drawing.Point(144, 156);
            this.textBox_Freq.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Freq.Name = "textBox_Freq";
            this.textBox_Freq.Size = new System.Drawing.Size(265, 29);
            this.textBox_Freq.TabIndex = 7;
            this.textBox_Freq.Text = "50";
            // 
            // button_Set
            // 
            this.button_Set.Location = new System.Drawing.Point(144, 194);
            this.button_Set.Margin = new System.Windows.Forms.Padding(4);
            this.button_Set.Name = "button_Set";
            this.button_Set.Size = new System.Drawing.Size(172, 34);
            this.button_Set.TabIndex = 8;
            this.button_Set.Text = "Set";
            this.button_Set.UseVisualStyleBackColor = true;
            this.button_Set.Click += new System.EventHandler(this.button_Set_Click_1);
            // 
            // button_OutputOn
            // 
            this.button_OutputOn.Location = new System.Drawing.Point(417, 194);
            this.button_OutputOn.Margin = new System.Windows.Forms.Padding(4);
            this.button_OutputOn.Name = "button_OutputOn";
            this.button_OutputOn.Size = new System.Drawing.Size(172, 34);
            this.button_OutputOn.TabIndex = 9;
            this.button_OutputOn.Text = "On";
            this.button_OutputOn.UseVisualStyleBackColor = true;
            this.button_OutputOn.Click += new System.EventHandler(this.button_OutputOn_Click_1);
            // 
            // label_Voltage
            // 
            this.label_Voltage.AutoSize = true;
            this.label_Voltage.ForeColor = System.Drawing.Color.LightGray;
            this.label_Voltage.Location = new System.Drawing.Point(4, 108);
            this.label_Voltage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Voltage.Name = "label_Voltage";
            this.label_Voltage.Size = new System.Drawing.Size(62, 18);
            this.label_Voltage.TabIndex = 4;
            this.label_Voltage.Text = "Voltage";
            // 
            // label_Freq
            // 
            this.label_Freq.AutoSize = true;
            this.label_Freq.ForeColor = System.Drawing.Color.LightGray;
            this.label_Freq.Location = new System.Drawing.Point(4, 152);
            this.label_Freq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Freq.Name = "label_Freq";
            this.label_Freq.Size = new System.Drawing.Size(39, 18);
            this.label_Freq.TabIndex = 6;
            this.label_Freq.Text = "Freq";
            // 
            // button_OutputOff
            // 
            this.button_OutputOff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_OutputOff.Location = new System.Drawing.Point(144, 243);
            this.button_OutputOff.Margin = new System.Windows.Forms.Padding(4);
            this.button_OutputOff.Name = "button_OutputOff";
            this.button_OutputOff.Size = new System.Drawing.Size(265, 28);
            this.button_OutputOff.TabIndex = 10;
            this.button_OutputOff.Text = "Off";
            this.button_OutputOff.UseVisualStyleBackColor = true;
            this.button_OutputOff.Click += new System.EventHandler(this.button_OutputOff_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(144, 286);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_result
            // 
            this.label_result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_result.ForeColor = System.Drawing.Color.LightGray;
            this.label_result.Location = new System.Drawing.Point(9, 304);
            this.label_result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(530, 21);
            this.label_result.TabIndex = 11;
            this.label_result.Text = "...";
            this.label_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label_result);
            this.Name = "LogControl2";
            this.Size = new System.Drawing.Size(744, 363);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Button button_GetGpib;
        private System.Windows.Forms.ComboBox comboBox_Gpib;
        private System.Windows.Forms.Label label_Voltage;
        private System.Windows.Forms.TextBox textBox_Voltage;
        private System.Windows.Forms.Label label_Freq;
        private System.Windows.Forms.TextBox textBox_Freq;
        private System.Windows.Forms.Button button_Set;
        private System.Windows.Forms.Button button_OutputOn;
        private System.Windows.Forms.Button button_OutputOff;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label label1;
    }
}
