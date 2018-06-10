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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACView));
            this.buttonSaveCompetition = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCompetitions = new System.Windows.Forms.ComboBox();
            this.disciplineControl1 = new AthleticCompetition.Controls.DisciplineControl();
            this.buttonPrevDisc = new System.Windows.Forms.Button();
            this.buttonNextDisc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSaveCompetition
            // 
            this.buttonSaveCompetition.Location = new System.Drawing.Point(328, 21);
            this.buttonSaveCompetition.Name = "buttonSaveCompetition";
            this.buttonSaveCompetition.Size = new System.Drawing.Size(112, 36);
            this.buttonSaveCompetition.TabIndex = 1;
            this.buttonSaveCompetition.Text = "Zapisz całe zawody";
            this.buttonSaveCompetition.UseVisualStyleBackColor = true;
            this.buttonSaveCompetition.Click += new System.EventHandler(this.buttonSaveCompetition_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(109, 21);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 24);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(91, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Nazwa zawodów:";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(12, 50);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(94, 13);
            this.labelLocation.TabIndex = 5;
            this.labelLocation.Text = "Miejsce zawodów:";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(109, 47);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(200, 20);
            this.textBoxLocation.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Data zawodów:";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(110, 77);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDate.TabIndex = 7;
            this.dateTimePickerDate.Value = new System.DateTime(2018, 6, 8, 20, 55, 32, 0);
            // 
            // comboBoxCompetitions
            // 
            this.comboBoxCompetitions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCompetitions.FormattingEnabled = true;
            this.comboBoxCompetitions.Location = new System.Drawing.Point(328, 76);
            this.comboBoxCompetitions.Name = "comboBoxCompetitions";
            this.comboBoxCompetitions.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCompetitions.TabIndex = 8;
            // 
            // disciplineControl1
            // 
            this.disciplineControl1.Location = new System.Drawing.Point(12, 136);
            this.disciplineControl1.Name = "disciplineControl1";
            this.disciplineControl1.PlayersList = ((System.Collections.Generic.List<string>)(resources.GetObject("disciplineControl1.PlayersList")));
            this.disciplineControl1.Size = new System.Drawing.Size(533, 109);
            this.disciplineControl1.TabIndex = 0;
            // 
            // buttonPrevDisc
            // 
            this.buttonPrevDisc.Location = new System.Drawing.Point(12, 107);
            this.buttonPrevDisc.Name = "buttonPrevDisc";
            this.buttonPrevDisc.Size = new System.Drawing.Size(140, 23);
            this.buttonPrevDisc.TabIndex = 9;
            this.buttonPrevDisc.Text = "Poprzednia dyscyplina";
            this.buttonPrevDisc.UseVisualStyleBackColor = true;
            this.buttonPrevDisc.Visible = false;
            // 
            // buttonNextDisc
            // 
            this.buttonNextDisc.Location = new System.Drawing.Point(405, 107);
            this.buttonNextDisc.Name = "buttonNextDisc";
            this.buttonNextDisc.Size = new System.Drawing.Size(140, 23);
            this.buttonNextDisc.TabIndex = 10;
            this.buttonNextDisc.Text = "Następna dyscyplina";
            this.buttonNextDisc.UseVisualStyleBackColor = true;
            this.buttonNextDisc.Visible = false;
            // 
            // ACView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 488);
            this.Controls.Add(this.buttonNextDisc);
            this.Controls.Add(this.buttonPrevDisc);
            this.Controls.Add(this.comboBoxCompetitions);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonSaveCompetition);
            this.Controls.Add(this.disciplineControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ACView";
            this.Text = "ACView";
            this.Load += new System.EventHandler(this.ACView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.DisciplineControl disciplineControl1;
        private System.Windows.Forms.Button buttonSaveCompetition;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.ComboBox comboBoxCompetitions;
        private System.Windows.Forms.Button buttonPrevDisc;
        private System.Windows.Forms.Button buttonNextDisc;
    }
}