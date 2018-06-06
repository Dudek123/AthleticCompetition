namespace AthleticCompetition.Views
{
    partial class ACView
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
            this.disciplineControl1 = new AthleticCompetition.Controls.DisciplineControl();
            this.SuspendLayout();
            // 
            // disciplineControl1
            // 
            this.disciplineControl1.Location = new System.Drawing.Point(29, 27);
            this.disciplineControl1.Name = "disciplineControl1";
            this.disciplineControl1.Size = new System.Drawing.Size(363, 109);
            this.disciplineControl1.TabIndex = 0;
            // 
            // ACView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 482);
            this.Controls.Add(this.disciplineControl1);
            this.Name = "ACView";
            this.Text = "ACView";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.DisciplineControl disciplineControl1;
    }
}