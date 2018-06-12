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
            this.listBoxDisciplines = new System.Windows.Forms.ListBox();
            this.buttonDeleteDiscipline = new System.Windows.Forms.Button();
            this.disciplineControl1 = new AthleticCompetition.Controls.DisciplineControl();
            this.SuspendLayout();
            // 
            // buttonSaveCompetition
            // 
            this.buttonSaveCompetition.BackColor = System.Drawing.Color.Gray;
            this.buttonSaveCompetition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveCompetition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveCompetition.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSaveCompetition.ForeColor = System.Drawing.Color.White;
            this.buttonSaveCompetition.Location = new System.Drawing.Point(12, 160);
            this.buttonSaveCompetition.Name = "buttonSaveCompetition";
            this.buttonSaveCompetition.Size = new System.Drawing.Size(296, 41);
            this.buttonSaveCompetition.TabIndex = 1;
            this.buttonSaveCompetition.Text = "Zapisz całe zawody";
            this.buttonSaveCompetition.UseVisualStyleBackColor = false;
            this.buttonSaveCompetition.Click += new System.EventHandler(this.buttonSaveCompetition_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.Gray;
            this.textBoxName.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxName.ForeColor = System.Drawing.Color.White;
            this.textBoxName.Location = new System.Drawing.Point(108, 69);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 21);
            this.textBoxName.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(4, 71);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(104, 15);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Nazwa zawodów:";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLocation.ForeColor = System.Drawing.Color.White;
            this.labelLocation.Location = new System.Drawing.Point(0, 103);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(108, 15);
            this.labelLocation.TabIndex = 5;
            this.labelLocation.Text = "Miejsce zawodów:";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.BackColor = System.Drawing.Color.Gray;
            this.textBoxLocation.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLocation.ForeColor = System.Drawing.Color.White;
            this.textBoxLocation.Location = new System.Drawing.Point(108, 98);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(200, 21);
            this.textBoxLocation.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Data zawodów:";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CalendarFont = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerDate.CalendarMonthBackground = System.Drawing.Color.Gray;
            this.dateTimePickerDate.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerDate.Location = new System.Drawing.Point(108, 125);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerDate.TabIndex = 7;
            this.dateTimePickerDate.Value = new System.DateTime(2018, 6, 8, 20, 55, 32, 0);
            // 
            // comboBoxCompetitions
            // 
            this.comboBoxCompetitions.BackColor = System.Drawing.Color.Gray;
            this.comboBoxCompetitions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCompetitions.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxCompetitions.ForeColor = System.Drawing.Color.White;
            this.comboBoxCompetitions.FormattingEnabled = true;
            this.comboBoxCompetitions.Location = new System.Drawing.Point(314, 13);
            this.comboBoxCompetitions.Name = "comboBoxCompetitions";
            this.comboBoxCompetitions.Size = new System.Drawing.Size(230, 23);
            this.comboBoxCompetitions.TabIndex = 8;
            this.comboBoxCompetitions.Visible = false;
            this.comboBoxCompetitions.DropDown += new System.EventHandler(this.comboBoxCompetitions_DropDown);
            this.comboBoxCompetitions.SelectedIndexChanged += new System.EventHandler(this.comboBoxCompetitions_SelectedIndexChanged);
            // 
            // buttonLoadCompetition
            // 
            this.buttonLoadCompetition.BackColor = System.Drawing.Color.Gray;
            this.buttonLoadCompetition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLoadCompetition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadCompetition.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLoadCompetition.ForeColor = System.Drawing.Color.White;
            this.buttonLoadCompetition.Location = new System.Drawing.Point(432, 40);
            this.buttonLoadCompetition.Name = "buttonLoadCompetition";
            this.buttonLoadCompetition.Size = new System.Drawing.Size(112, 31);
            this.buttonLoadCompetition.TabIndex = 12;
            this.buttonLoadCompetition.Text = "Załaduj zawody";
            this.buttonLoadCompetition.UseVisualStyleBackColor = false;
            this.buttonLoadCompetition.Visible = false;
            this.buttonLoadCompetition.Click += new System.EventHandler(this.buttonLoadCompetition_Click);
            // 
            // radioButtonGenerate
            // 
            this.radioButtonGenerate.AutoSize = true;
            this.radioButtonGenerate.Checked = true;
            this.radioButtonGenerate.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonGenerate.ForeColor = System.Drawing.Color.White;
            this.radioButtonGenerate.Location = new System.Drawing.Point(14, 24);
            this.radioButtonGenerate.Name = "radioButtonGenerate";
            this.radioButtonGenerate.Size = new System.Drawing.Size(153, 23);
            this.radioButtonGenerate.TabIndex = 13;
            this.radioButtonGenerate.TabStop = true;
            this.radioButtonGenerate.Text = "Tryb generowania";
            this.radioButtonGenerate.UseVisualStyleBackColor = true;
            this.radioButtonGenerate.Click += new System.EventHandler(this.radioButtonGenerate_Click);
            // 
            // radioButtonEdit
            // 
            this.radioButtonEdit.AutoSize = true;
            this.radioButtonEdit.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonEdit.ForeColor = System.Drawing.Color.White;
            this.radioButtonEdit.Location = new System.Drawing.Point(169, 25);
            this.radioButtonEdit.Name = "radioButtonEdit";
            this.radioButtonEdit.Size = new System.Drawing.Size(145, 23);
            this.radioButtonEdit.TabIndex = 14;
            this.radioButtonEdit.Text = "Tryb edytowania";
            this.radioButtonEdit.UseVisualStyleBackColor = true;
            this.radioButtonEdit.Click += new System.EventHandler(this.radioButtonEdit_Click);
            // 
            // listBoxDisciplines
            // 
            this.listBoxDisciplines.BackColor = System.Drawing.Color.Gray;
            this.listBoxDisciplines.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxDisciplines.ForeColor = System.Drawing.Color.White;
            this.listBoxDisciplines.FormattingEnabled = true;
            this.listBoxDisciplines.ItemHeight = 15;
            this.listBoxDisciplines.Location = new System.Drawing.Point(315, 77);
            this.listBoxDisciplines.Name = "listBoxDisciplines";
            this.listBoxDisciplines.Size = new System.Drawing.Size(230, 124);
            this.listBoxDisciplines.TabIndex = 16;
            this.listBoxDisciplines.Visible = false;
            this.listBoxDisciplines.DoubleClick += new System.EventHandler(this.listBoxDisciplines_DoubleClick);
            // 
            // buttonDeleteDiscipline
            // 
            this.buttonDeleteDiscipline.BackColor = System.Drawing.Color.Gray;
            this.buttonDeleteDiscipline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteDiscipline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteDiscipline.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeleteDiscipline.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteDiscipline.Location = new System.Drawing.Point(315, 40);
            this.buttonDeleteDiscipline.Name = "buttonDeleteDiscipline";
            this.buttonDeleteDiscipline.Size = new System.Drawing.Size(112, 31);
            this.buttonDeleteDiscipline.TabIndex = 17;
            this.buttonDeleteDiscipline.Text = "Usuń dyscyplinę";
            this.buttonDeleteDiscipline.UseVisualStyleBackColor = false;
            this.buttonDeleteDiscipline.Visible = false;
            this.buttonDeleteDiscipline.Click += new System.EventHandler(this.buttonDeleteDiscipline_Click);
            // 
            // disciplineControl1
            // 
            this.disciplineControl1.BackColor = System.Drawing.Color.LightGray;
            this.disciplineControl1.DisciplineName = null;
            this.disciplineControl1.Location = new System.Drawing.Point(14, 211);
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
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(557, 528);
            this.Controls.Add(this.buttonDeleteDiscipline);
            this.Controls.Add(this.listBoxDisciplines);
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
            this.Text = "Athletic Competition";
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
        private System.Windows.Forms.Button buttonLoadCompetition;
        private System.Windows.Forms.RadioButton radioButtonGenerate;
        private System.Windows.Forms.RadioButton radioButtonEdit;
        private System.Windows.Forms.ListBox listBoxDisciplines;
        private System.Windows.Forms.Button buttonDeleteDiscipline;
    }
}