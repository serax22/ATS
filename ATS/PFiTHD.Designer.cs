namespace ATS
{
    partial class PFiTHD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PFiTHD));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.voltageTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iratingTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stepTextBox = new System.Windows.Forms.TextBox();
            this.Request = new System.Windows.Forms.Button();
            this.Poll = new System.Windows.Forms.Button();
            this.TEXT_BOX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.134969F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.86503F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.Controls.Add(this.AddressLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.addressTextBox, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.voltageTextBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.iratingTextBox, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.stepTextBox, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.Request, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.Poll, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.TEXT_BOX, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.7415F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.2585F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 197F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(788, 439);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // AddressLabel
            // 
            this.AddressLabel.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AddressLabel.Location = new System.Drawing.Point(543, 15);
            this.AddressLabel.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(78, 23);
            this.AddressLabel.TabIndex = 33;
            this.AddressLabel.Text = "Address";
            this.AddressLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(644, 15);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(86, 25);
            this.addressTextBox.TabIndex = 34;
            this.addressTextBox.Text = "B0";
            this.addressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(550, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 22);
            this.label1.TabIndex = 35;
            this.label1.Text = "Vin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // voltageTextBox
            // 
            this.voltageTextBox.Location = new System.Drawing.Point(644, 59);
            this.voltageTextBox.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.voltageTextBox.Name = "voltageTextBox";
            this.voltageTextBox.Size = new System.Drawing.Size(86, 25);
            this.voltageTextBox.TabIndex = 36;
            this.voltageTextBox.Text = "230";
            this.voltageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(550, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 37;
            this.label2.Text = "Irating";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iratingTextBox
            // 
            this.iratingTextBox.Location = new System.Drawing.Point(644, 96);
            this.iratingTextBox.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.iratingTextBox.Name = "iratingTextBox";
            this.iratingTextBox.Size = new System.Drawing.Size(86, 25);
            this.iratingTextBox.TabIndex = 38;
            this.iratingTextBox.Text = "80";
            this.iratingTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(550, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 39;
            this.label3.Text = "Step";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stepTextBox
            // 
            this.stepTextBox.Location = new System.Drawing.Point(644, 143);
            this.stepTextBox.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.stepTextBox.Name = "stepTextBox";
            this.stepTextBox.Size = new System.Drawing.Size(86, 25);
            this.stepTextBox.TabIndex = 40;
            this.stepTextBox.Text = "100";
            this.stepTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Request
            // 
            this.Request.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Request.Location = new System.Drawing.Point(543, 373);
            this.Request.Name = "Request";
            this.Request.Size = new System.Drawing.Size(95, 40);
            this.Request.TabIndex = 31;
            this.Request.Text = "Request";
            this.Request.UseVisualStyleBackColor = true;
            this.Request.Click += new System.EventHandler(this.Request_Click);
            // 
            // Poll
            // 
            this.Poll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Poll.Location = new System.Drawing.Point(644, 373);
            this.Poll.Name = "Poll";
            this.Poll.Size = new System.Drawing.Size(92, 40);
            this.Poll.TabIndex = 32;
            this.Poll.Text = "Poll";
            this.Poll.UseVisualStyleBackColor = true;
            // 
            // TEXT_BOX
            // 
            this.TEXT_BOX.BackColor = System.Drawing.Color.Black;
            this.TEXT_BOX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TEXT_BOX.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEXT_BOX.ForeColor = System.Drawing.Color.GreenYellow;
            this.TEXT_BOX.Location = new System.Drawing.Point(37, 47);
            this.TEXT_BOX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TEXT_BOX.Multiline = true;
            this.TEXT_BOX.Name = "TEXT_BOX";
            this.TEXT_BOX.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.TEXT_BOX, 5);
            this.TEXT_BOX.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TEXT_BOX.Size = new System.Drawing.Size(499, 292);
            this.TEXT_BOX.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(749, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 22);
            this.label4.TabIndex = 42;
            this.label4.Text = "V";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(749, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 22);
            this.label5.TabIndex = 43;
            this.label5.Text = "A";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PFiTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PFiTHD";
            this.Text = "PF & iTHD";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Request;
        private System.Windows.Forms.Button Poll;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox voltageTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox iratingTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stepTextBox;
        private System.Windows.Forms.TextBox TEXT_BOX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}