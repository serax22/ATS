namespace ATS
{
    partial class Form2
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
            this.TEXT_BOX = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TEXT_BOX
            // 
            this.TEXT_BOX.BackColor = System.Drawing.Color.Black;
            this.TEXT_BOX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TEXT_BOX.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEXT_BOX.ForeColor = System.Drawing.Color.GreenYellow;
            this.TEXT_BOX.Location = new System.Drawing.Point(117, 79);
            this.TEXT_BOX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TEXT_BOX.Multiline = true;
            this.TEXT_BOX.Name = "TEXT_BOX";
            this.TEXT_BOX.ReadOnly = true;
            this.TEXT_BOX.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TEXT_BOX.Size = new System.Drawing.Size(566, 292);
            this.TEXT_BOX.TabIndex = 31;
           
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TEXT_BOX);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TEXT_BOX;
    }
}