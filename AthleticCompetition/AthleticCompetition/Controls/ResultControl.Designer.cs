namespace AthleticCompetition.Controls
{
    partial class ResultControl
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
            this.labelPlace = new System.Windows.Forms.Label();
            this.textBoxPlayer = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.checkBoxDNF = new System.Windows.Forms.CheckBox();
            this.checkBoxDNS = new System.Windows.Forms.CheckBox();
            this.checkBoxDQ = new System.Windows.Forms.CheckBox();
            this.timeControl1 = new AthleticCompetition.Controls.TimeControl();
            this.SuspendLayout();
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(6, 8);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(13, 13);
            this.labelPlace.TabIndex = 0;
            this.labelPlace.Text = "1";
            // 
            // textBoxPlayer
            // 
            this.textBoxPlayer.Location = new System.Drawing.Point(25, 5);
            this.textBoxPlayer.Name = "textBoxPlayer";
            this.textBoxPlayer.Size = new System.Drawing.Size(216, 20);
            this.textBoxPlayer.TabIndex = 1;
            this.textBoxPlayer.Leave += new System.EventHandler(this.textBoxPlayer_Leave);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(247, 5);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(190, 20);
            this.textBoxResult.TabIndex = 2;
            this.textBoxResult.Enter += new System.EventHandler(this.textBoxResult_Enter);
            this.textBoxResult.Leave += new System.EventHandler(this.textBoxResult_Leave);
            // 
            // checkBoxDNF
            // 
            this.checkBoxDNF.AutoSize = true;
            this.checkBoxDNF.Location = new System.Drawing.Point(443, 8);
            this.checkBoxDNF.Name = "checkBoxDNF";
            this.checkBoxDNF.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDNF.TabIndex = 4;
            this.checkBoxDNF.UseVisualStyleBackColor = true;
            this.checkBoxDNF.CheckedChanged += new System.EventHandler(this.checkBoxDNF_CheckedChanged);
            // 
            // checkBoxDNS
            // 
            this.checkBoxDNS.AutoSize = true;
            this.checkBoxDNS.Location = new System.Drawing.Point(474, 8);
            this.checkBoxDNS.Name = "checkBoxDNS";
            this.checkBoxDNS.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDNS.TabIndex = 5;
            this.checkBoxDNS.UseVisualStyleBackColor = true;
            this.checkBoxDNS.CheckedChanged += new System.EventHandler(this.checkBoxDNS_CheckedChanged);
            // 
            // checkBoxDQ
            // 
            this.checkBoxDQ.AutoSize = true;
            this.checkBoxDQ.Location = new System.Drawing.Point(505, 8);
            this.checkBoxDQ.Name = "checkBoxDQ";
            this.checkBoxDQ.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDQ.TabIndex = 6;
            this.checkBoxDQ.UseVisualStyleBackColor = true;
            this.checkBoxDQ.CheckedChanged += new System.EventHandler(this.checkBoxDQ_CheckedChanged);
            // 
            // timeControl1
            // 
            this.timeControl1.Location = new System.Drawing.Point(247, 0);
            this.timeControl1.Name = "timeControl1";
            this.timeControl1.Size = new System.Drawing.Size(190, 30);
            this.timeControl1.TabIndex = 3;
            this.timeControl1.Visible = false;
            // 
            // ResultControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxDQ);
            this.Controls.Add(this.checkBoxDNS);
            this.Controls.Add(this.checkBoxDNF);
            this.Controls.Add(this.timeControl1);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxPlayer);
            this.Controls.Add(this.labelPlace);
            this.Name = "ResultControl";
            this.Size = new System.Drawing.Size(533, 28);
            this.Load += new System.EventHandler(this.ResultControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.TextBox textBoxPlayer;
        private System.Windows.Forms.TextBox textBoxResult;
        private TimeControl timeControl1;
        private System.Windows.Forms.CheckBox checkBoxDNF;
        private System.Windows.Forms.CheckBox checkBoxDNS;
        private System.Windows.Forms.CheckBox checkBoxDQ;
    }
}
