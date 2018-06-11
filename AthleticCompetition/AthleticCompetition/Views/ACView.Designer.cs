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
            this.buttonLoadCompetition = new System.Windows.Forms.Button();
            this.radioButtonGenerate = new System.Windows.Forms.RadioButton();
            this.radioButtonEdit = new System.Windows.Forms.RadioButton();
            this.radioButtonShow = new System.Windows.Forms.RadioButton();
            this.listBoxDisciplines = new System.Windows.Forms.ListBox();
            this.disciplineControl1 = new AthleticCompetition.Controls.DisciplineControl();
            this.SuspendLayout();
            // 
            // buttonSaveCompetition
            // 
            this.buttonSaveCompetition.Location = new System.Drawing.Point(332, 49);
            this.buttonSaveCompetition.Name = "buttonSaveCompetition";
            this.buttonSaveCompetition.Size = new System.Drawing.Size(112, 36);
            this.buttonSaveCompetition.TabIndex = 1;
            this.buttonSaveCompetition.Text = "Zapisz całe zawody";
            this.buttonSaveCompetition.UseVisualStyleBackColor = true;
            this.buttonSaveCompetition.Click += new System.EventHandler(this.buttonSaveCompetition_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(108, 69);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(11, 72);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(91, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Nazwa zawodów:";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(11, 98);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(94, 13);
            this.labelLocation.TabIndex = 5;
            this.labelLocation.Text = "Miejsce zawodów:";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(108, 95);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(200, 20);
            this.textBoxLocation.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Data zawodów:";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(109, 125);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDate.TabIndex = 7;
            this.dateTimePickerDate.Value = new System.DateTime(2018, 6, 8, 20, 55, 32, 0);
            // 
            // comboBoxCompetitions
            // 
            this.comboBoxCompetitions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCompetitions.FormattingEnabled = true;
            this.comboBoxCompetitions.Location = new System.Drawing.Point(332, 12);
            this.comboBoxCompetitions.Name = "comboBoxCompetitions";
            this.comboBoxCompetitions.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCompetitions.TabIndex = 8;
            this.comboBoxCompetitions.Visible = false;
            this.comboBoxCompetitions.DropDown += new System.EventHandler(this.comboBoxCompetitions_DropDown);
            this.comboBoxCompetitions.SelectedIndexChanged += new System.EventHandler(this.comboBoxCompetitions_SelectedIndexChanged);
            // 
            // buttonLoadCompetition
            // 
            this.buttonLoadCompetition.Location = new System.Drawing.Point(470, 12);
            this.buttonLoadCompetition.Name = "buttonLoadCompetition";
            this.buttonLoadCompetition.Size = new System.Drawing.Size(75, 46);
            this.buttonLoadCompetition.TabIndex = 12;
            this.buttonLoadCompetition.Text = "Załaduj zawody";
            this.buttonLoadCompetition.UseVisualStyleBackColor = true;
            this.buttonLoadCompetition.Visible = false;
            this.buttonLoadCompetition.Click += new System.EventHandler(this.buttonLoadCompetition_Click);
            // 
            // radioButtonGenerate
            // 
            this.radioButtonGenerate.AutoSize = true;
            this.radioButtonGenerate.Location = new System.Drawing.Point(17, 25);
            this.radioButtonGenerate.Name = "radioButtonGenerate";
            this.radioButtonGenerate.Size = new System.Drawing.Size(110, 17);
            this.radioButtonGenerate.TabIndex = 13;
            this.radioButtonGenerate.TabStop = true;
            this.radioButtonGenerate.Text = "Tryb generowania";
            this.radioButtonGenerate.UseVisualStyleBackColor = true;
            this.radioButtonGenerate.CheckedChanged += new System.EventHandler(this.radioButtonGenerate_CheckedChanged);
            // 
            // radioButtonEdit
            // 
            this.radioButtonEdit.AutoSize = true;
            this.radioButtonEdit.Location = new System.Drawing.Point(133, 25);
            this.radioButtonEdit.Name = "radioButtonEdit";
            this.radioButtonEdit.Size = new System.Drawing.Size(76, 17);
            this.radioButtonEdit.TabIndex = 14;
            this.radioButtonEdit.TabStop = true;
            this.radioButtonEdit.Text = "Tryb edycji";
            this.radioButtonEdit.UseVisualStyleBackColor = true;
            this.radioButtonEdit.CheckedChanged += new System.EventHandler(this.radioButtonEdit_CheckedChanged);
            // 
            // radioButtonShow
            // 
            this.radioButtonShow.AutoSize = true;
            this.radioButtonShow.Location = new System.Drawing.Point(215, 25);
            this.radioButtonShow.Name = "radioButtonShow";
            this.radioButtonShow.Size = new System.Drawing.Size(108, 17);
            this.radioButtonShow.TabIndex = 15;
            this.radioButtonShow.TabStop = true;
            this.radioButtonShow.Text = "Tryb wyświetlania";
            this.radioButtonShow.UseVisualStyleBackColor = true;
            this.radioButtonShow.CheckedChanged += new System.EventHandler(this.radioButtonShow_CheckedChanged);
            // 
            // listBoxDisciplines
            // 
            this.listBoxDisciplines.FormattingEnabled = true;
            this.listBoxDisciplines.Location = new System.Drawing.Point(415, 98);
            this.listBoxDisciplines.Name = "listBoxDisciplines";
            this.listBoxDisciplines.Size = new System.Drawing.Size(120, 95);
            this.listBoxDisciplines.TabIndex = 16;
            this.listBoxDisciplines.Visible = false;
            this.listBoxDisciplines.DoubleClick += new System.EventHandler(this.listBoxDisciplines_DoubleClick);
            // 
            // disciplineControl1
            // 
            this.disciplineControl1.DisciplineName = null;
            this.disciplineControl1.Location = new System.Drawing.Point(12, 198);
            this.disciplineControl1.Name = "disciplineControl1";
            this.disciplineControl1.PlayersList = ((System.Collections.Generic.List<string>)(resources.GetObject("disciplineControl1.PlayersList")));
            this.disciplineControl1.PlayersResults = ((System.Collections.Generic.List<string>)(resources.GetObject("disciplineControl1.PlayersResults")));
            this.disciplineControl1.Size = new System.Drawing.Size(533, 305);
            this.disciplineControl1.TabIndex = 0;
            // 
            // ACView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 515);
            this.Controls.Add(this.listBoxDisciplines);
            this.Controls.Add(this.radioButtonShow);
            this.Controls.Add(this.radioButtonEdit);
            this.Controls.Add(this.radioButtonGenerate);
            this.Controls.Add(this.buttonLoadCompetition);
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
        private System.Windows.Forms.Button buttonLoadCompetition;
        private System.Windows.Forms.RadioButton radioButtonGenerate;
        private System.Windows.Forms.RadioButton radioButtonEdit;
        private System.Windows.Forms.RadioButton radioButtonShow;
        private System.Windows.Forms.ListBox listBoxDisciplines;
    }
}