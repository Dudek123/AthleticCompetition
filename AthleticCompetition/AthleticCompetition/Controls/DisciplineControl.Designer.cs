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
            this.comboBoxMeasureUnit = new System.Windows.Forms.ComboBox();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelMinutes = new System.Windows.Forms.Label();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.labelHounredths = new System.Windows.Forms.Label();
            this.buttonSaveDiscipline = new System.Windows.Forms.Button();
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
            this.comboBoxDisciplineName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDisciplineName.FormattingEnabled = true;
            this.comboBoxDisciplineName.Items.AddRange(new object[] {
            "100 m M",
            "100 m W",
            "400 m przez płotki",
            "Siedmiobój",
            "Skok w dal"});
            this.comboBoxDisciplineName.Location = new System.Drawing.Point(103, 10);
            this.comboBoxDisciplineName.Name = "comboBoxDisciplineName";
            this.comboBoxDisciplineName.Size = new System.Drawing.Size(155, 21);
            this.comboBoxDisciplineName.TabIndex = 3;
            this.comboBoxDisciplineName.SelectedIndexChanged += new System.EventHandler(this.comboBoxDisciplineName_SelectedIndexChanged);
            // 
            // buttonAddPlace
            // 
            this.buttonAddPlace.Location = new System.Drawing.Point(264, 8);
            this.buttonAddPlace.Name = "buttonAddPlace";
            this.buttonAddPlace.Size = new System.Drawing.Size(26, 23);
            this.buttonAddPlace.TabIndex = 4;
            this.buttonAddPlace.Text = "+";
            this.buttonAddPlace.UseVisualStyleBackColor = true;
            this.buttonAddPlace.Click += new System.EventHandler(this.buttonAddPlace_Click);
            // 
            // buttonDeletePlace
            // 
            this.buttonDeletePlace.Location = new System.Drawing.Point(296, 8);
            this.buttonDeletePlace.Name = "buttonDeletePlace";
            this.buttonDeletePlace.Size = new System.Drawing.Size(26, 23);
            this.buttonDeletePlace.TabIndex = 5;
            this.buttonDeletePlace.Text = "-";
            this.buttonDeletePlace.UseVisualStyleBackColor = true;
            this.buttonDeletePlace.Click += new System.EventHandler(this.buttonDeletePlace_Click);
            // 
            // comboBoxMeasureUnit
            // 
            this.comboBoxMeasureUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMeasureUnit.FormattingEnabled = true;
            this.comboBoxMeasureUnit.Items.AddRange(new object[] {
            "m",
            "czas",
            "pkt"});
            this.comboBoxMeasureUnit.Location = new System.Drawing.Point(328, 10);
            this.comboBoxMeasureUnit.Name = "comboBoxMeasureUnit";
            this.comboBoxMeasureUnit.Size = new System.Drawing.Size(47, 21);
            this.comboBoxMeasureUnit.TabIndex = 6;
            this.comboBoxMeasureUnit.SelectedIndexChanged += new System.EventHandler(this.comboBoxMeasureUnit_SelectedIndexChanged);
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(254, 47);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(35, 13);
            this.labelHours.TabIndex = 7;
            this.labelHours.Text = "Godz.";
            this.labelHours.Visible = false;
            // 
            // labelMinutes
            // 
            this.labelMinutes.AutoSize = true;
            this.labelMinutes.Location = new System.Drawing.Point(300, 47);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(27, 13);
            this.labelMinutes.TabIndex = 8;
            this.labelMinutes.Text = "Min.";
            this.labelMinutes.Visible = false;
            // 
            // labelSeconds
            // 
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.Location = new System.Drawing.Point(346, 47);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(29, 13);
            this.labelSeconds.TabIndex = 9;
            this.labelSeconds.Text = "Sek.";
            this.labelSeconds.Visible = false;
            // 
            // labelHounredths
            // 
            this.labelHounredths.AutoSize = true;
            this.labelHounredths.Location = new System.Drawing.Point(392, 47);
            this.labelHounredths.Name = "labelHounredths";
            this.labelHounredths.Size = new System.Drawing.Size(35, 13);
            this.labelHounredths.TabIndex = 10;
            this.labelHounredths.Text = "Setne";
            this.labelHounredths.Visible = false;
            // 
            // buttonSaveDiscipline
            // 
            this.buttonSaveDiscipline.Location = new System.Drawing.Point(381, 3);
            this.buttonSaveDiscipline.Name = "buttonSaveDiscipline";
            this.buttonSaveDiscipline.Size = new System.Drawing.Size(75, 38);
            this.buttonSaveDiscipline.TabIndex = 11;
            this.buttonSaveDiscipline.Text = "Zapisz dyscyplinę";
            this.buttonSaveDiscipline.UseVisualStyleBackColor = true;
            this.buttonSaveDiscipline.Click += new System.EventHandler(this.buttonSaveDiscipline_Click);
            // 
            // resultControl1
            // 
            this.resultControl1.IsTime = false;
            this.resultControl1.Location = new System.Drawing.Point(7, 63);
            this.resultControl1.Name = "resultControl1";
            this.resultControl1.PlayerPlace = "1";
            this.resultControl1.PlayerResult = "";
            this.resultControl1.Size = new System.Drawing.Size(449, 28);
            this.resultControl1.TabIndex = 0;
            // 
            // DisciplineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSaveDiscipline);
            this.Controls.Add(this.labelHounredths);
            this.Controls.Add(this.labelSeconds);
            this.Controls.Add(this.labelMinutes);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.comboBoxMeasureUnit);
            this.Controls.Add(this.buttonDeletePlace);
            this.Controls.Add(this.buttonAddPlace);
            this.Controls.Add(this.comboBoxDisciplineName);
            this.Controls.Add(this.labelDisciplineName);
            this.Controls.Add(this.resultControl1);
            this.Name = "DisciplineControl";
            this.Size = new System.Drawing.Size(473, 109);
            this.Load += new System.EventHandler(this.DisciplineControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ResultControl resultControl1;
        private System.Windows.Forms.Label labelDisciplineName;
        private System.Windows.Forms.ComboBox comboBoxDisciplineName;
        private System.Windows.Forms.Button buttonAddPlace;
        private System.Windows.Forms.Button buttonDeletePlace;
        private System.Windows.Forms.ComboBox comboBoxMeasureUnit;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label labelMinutes;
        private System.Windows.Forms.Label labelSeconds;
        private System.Windows.Forms.Label labelHounredths;
        private System.Windows.Forms.Button buttonSaveDiscipline;
    }
}
