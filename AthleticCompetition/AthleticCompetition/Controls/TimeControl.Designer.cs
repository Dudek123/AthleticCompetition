namespace AthleticCompetition.Controls
{
    partial class TimeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinutes = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSeconds = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHundredths = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHundredths)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.BackColor = System.Drawing.Color.Gray;
            this.numericUpDownHours.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownHours.ForeColor = System.Drawing.Color.White;
            this.numericUpDownHours.Location = new System.Drawing.Point(4, 4);
            this.numericUpDownHours.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownHours.Name = "numericUpDownHours";
            this.numericUpDownHours.Size = new System.Drawing.Size(40, 23);
            this.numericUpDownHours.TabIndex = 0;
            // 
            // numericUpDownMinutes
            // 
            this.numericUpDownMinutes.BackColor = System.Drawing.Color.Gray;
            this.numericUpDownMinutes.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownMinutes.ForeColor = System.Drawing.Color.White;
            this.numericUpDownMinutes.Location = new System.Drawing.Point(50, 4);
            this.numericUpDownMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownMinutes.Name = "numericUpDownMinutes";
            this.numericUpDownMinutes.Size = new System.Drawing.Size(40, 23);
            this.numericUpDownMinutes.TabIndex = 1;
            // 
            // numericUpDownSeconds
            // 
            this.numericUpDownSeconds.BackColor = System.Drawing.Color.Gray;
            this.numericUpDownSeconds.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownSeconds.ForeColor = System.Drawing.Color.White;
            this.numericUpDownSeconds.Location = new System.Drawing.Point(96, 4);
            this.numericUpDownSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownSeconds.Name = "numericUpDownSeconds";
            this.numericUpDownSeconds.Size = new System.Drawing.Size(40, 23);
            this.numericUpDownSeconds.TabIndex = 2;
            // 
            // numericUpDownHundredths
            // 
            this.numericUpDownHundredths.BackColor = System.Drawing.Color.Gray;
            this.numericUpDownHundredths.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownHundredths.ForeColor = System.Drawing.Color.White;
            this.numericUpDownHundredths.Location = new System.Drawing.Point(142, 4);
            this.numericUpDownHundredths.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownHundredths.Name = "numericUpDownHundredths";
            this.numericUpDownHundredths.Size = new System.Drawing.Size(40, 23);
            this.numericUpDownHundredths.TabIndex = 3;
            // 
            // TimeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericUpDownHundredths);
            this.Controls.Add(this.numericUpDownSeconds);
            this.Controls.Add(this.numericUpDownMinutes);
            this.Controls.Add(this.numericUpDownHours);
            this.Name = "TimeControl";
            this.Size = new System.Drawing.Size(190, 30);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHundredths)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownHours;
        private System.Windows.Forms.NumericUpDown numericUpDownMinutes;
        private System.Windows.Forms.NumericUpDown numericUpDownSeconds;
        private System.Windows.Forms.NumericUpDown numericUpDownHundredths;
    }
}
