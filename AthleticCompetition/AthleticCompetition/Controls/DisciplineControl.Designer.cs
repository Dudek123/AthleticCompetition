namespace AthleticCompetition.Controls
{
    partial class DisciplineControl
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
            this.labelDisciplineName = new System.Windows.Forms.Label();
            this.comboBoxDisciplineName = new System.Windows.Forms.ComboBox();
            this.buttonAddPlace = new System.Windows.Forms.Button();
            this.buttonDeletePlace = new System.Windows.Forms.Button();
            this.resultControl1 = new AthleticCompetition.Controls.ResultControl();
            this.SuspendLayout();
            // 
            // labelDisciplineName
            // 
            this.labelDisciplineName.AutoSize = true;
            this.labelDisciplineName.Location = new System.Drawing.Point(3, 13);
            this.labelDisciplineName.Name = "labelDisciplineName";
            this.labelDisciplineName.Size = new System.Drawing.Size(94, 13);
            this.labelDisciplineName.TabIndex = 2;
            this.labelDisciplineName.Text = "Nazwa dyscypliny:";
            // 
            // comboBoxDisciplineName
            // 
            this.comboBoxDisciplineName.FormattingEnabled = true;
            this.comboBoxDisciplineName.Items.AddRange(new object[] {
            "100 m M",
            "100 m W",
            "400 m przez płotki",
            "Siedmiobój",
            "Skok w dal"});
            this.comboBoxDisciplineName.Location = new System.Drawing.Point(103, 10);
            this.comboBoxDisciplineName.Name = "comboBoxDisciplineName";
            this.comboBoxDisciplineName.Size = new System.Drawing.Size(187, 21);
            this.comboBoxDisciplineName.TabIndex = 3;
            // 
            // buttonAddPlace
            // 
            this.buttonAddPlace.Location = new System.Drawing.Point(296, 8);
            this.buttonAddPlace.Name = "buttonAddPlace";
            this.buttonAddPlace.Size = new System.Drawing.Size(26, 23);
            this.buttonAddPlace.TabIndex = 4;
            this.buttonAddPlace.Text = "+";
            this.buttonAddPlace.UseVisualStyleBackColor = true;
            this.buttonAddPlace.Click += new System.EventHandler(this.buttonAddPlace_Click);
            // 
            // buttonDeletePlace
            // 
            this.buttonDeletePlace.Location = new System.Drawing.Point(325, 8);
            this.buttonDeletePlace.Name = "buttonDeletePlace";
            this.buttonDeletePlace.Size = new System.Drawing.Size(26, 23);
            this.buttonDeletePlace.TabIndex = 5;
            this.buttonDeletePlace.Text = "-";
            this.buttonDeletePlace.UseVisualStyleBackColor = true;
            this.buttonDeletePlace.Click += new System.EventHandler(this.buttonDeletePlace_Click);
            // 
            // resultControl1
            // 
            this.resultControl1.Location = new System.Drawing.Point(6, 37);
            this.resultControl1.Name = "resultControl1";
            this.resultControl1.PlayerPlace = "1";
            this.resultControl1.Size = new System.Drawing.Size(350, 28);
            this.resultControl1.TabIndex = 0;
            // 
            // DisciplineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDeletePlace);
            this.Controls.Add(this.buttonAddPlace);
            this.Controls.Add(this.comboBoxDisciplineName);
            this.Controls.Add(this.labelDisciplineName);
            this.Controls.Add(this.resultControl1);
            this.Name = "DisciplineControl";
            this.Size = new System.Drawing.Size(363, 109);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ResultControl resultControl1;
        private System.Windows.Forms.Label labelDisciplineName;
        private System.Windows.Forms.ComboBox comboBoxDisciplineName;
        private System.Windows.Forms.Button buttonAddPlace;
        private System.Windows.Forms.Button buttonDeletePlace;
    }
}
