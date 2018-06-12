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
            this.labelDNF = new System.Windows.Forms.Label();
            this.labelDNS = new System.Windows.Forms.Label();
            this.labelDQ = new System.Windows.Forms.Label();
            this.resultControl1 = new AthleticCompetition.Controls.ResultControl();
            this.SuspendLayout();
            // 
            // labelDisciplineName
            // 
            this.labelDisciplineName.AutoSize = true;
            this.labelDisciplineName.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDisciplineName.ForeColor = System.Drawing.Color.Black;
            this.labelDisciplineName.Location = new System.Drawing.Point(2, 18);
            this.labelDisciplineName.Name = "labelDisciplineName";
            this.labelDisciplineName.Size = new System.Drawing.Size(72, 15);
            this.labelDisciplineName.TabIndex = 2;
            this.labelDisciplineName.Text = "Dyscyplina:";
            // 
            // comboBoxDisciplineName
            // 
            this.comboBoxDisciplineName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDisciplineName.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxDisciplineName.ForeColor = System.Drawing.Color.Black;
            this.comboBoxDisciplineName.FormattingEnabled = true;
            this.comboBoxDisciplineName.Items.AddRange(new object[] {
            "100 m K",
            "100 m M",
            "200 m M",
            "200 m K",
            "400 m M",
            "400 m K",
            "800 m M",
            "800 m K",
            "1500 m M",
            "1500 m K",
            "5000 m M",
            "5000 m K",
            "10000 m M",
            "10000 m K",
            "Maraton M",
            "Maraton K",
            "100 m przez płotki K",
            "110 m przez płotki M",
            "400 m przez płotki M",
            "400 m przez płotki K",
            "3000 m z przeszkodami M",
            "3000 m z przeszkodami K",
            "4x100 m M",
            "4x100 m K",
            "4x400 m M",
            "4x400 m K",
            "Chód 20 km K",
            "Chód 20 km M",
            "Chód 50 km M",
            "Skok wzwyż M",
            "Skok wzwyż K",
            "Trójskok M",
            "Trójskok K",
            "Skok w dal M",
            "Skok w dal K",
            "Skok o tyczce M",
            "Skok o tyczce K",
            "Pchnięcie kulą M",
            "Pchnięcie kulą K",
            "Rzut dyskiem M",
            "Rzut dyskiem K",
            "Rzut młotem M",
            "Rzut młotem K",
            "Rzut oszczepem M",
            "Rzut oszczepem K",
            "Dziesięciobój M",
            "Siedmiobój K"});
            this.comboBoxDisciplineName.Location = new System.Drawing.Point(77, 14);
            this.comboBoxDisciplineName.Name = "comboBoxDisciplineName";
            this.comboBoxDisciplineName.Size = new System.Drawing.Size(159, 23);
            this.comboBoxDisciplineName.TabIndex = 3;
            // 
            // buttonAddPlace
            // 
            this.buttonAddPlace.BackColor = System.Drawing.Color.Gray;
            this.buttonAddPlace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddPlace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPlace.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddPlace.ForeColor = System.Drawing.Color.White;
            this.buttonAddPlace.Location = new System.Drawing.Point(242, 4);
            this.buttonAddPlace.Name = "buttonAddPlace";
            this.buttonAddPlace.Size = new System.Drawing.Size(58, 40);
            this.buttonAddPlace.TabIndex = 4;
            this.buttonAddPlace.Text = "Dodaj miejsce";
            this.buttonAddPlace.UseVisualStyleBackColor = false;
            this.buttonAddPlace.Click += new System.EventHandler(this.buttonAddPlace_Click);
            // 
            // buttonDeletePlace
            // 
            this.buttonDeletePlace.BackColor = System.Drawing.Color.Gray;
            this.buttonDeletePlace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeletePlace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeletePlace.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeletePlace.ForeColor = System.Drawing.Color.White;
            this.buttonDeletePlace.Location = new System.Drawing.Point(306, 4);
            this.buttonDeletePlace.Name = "buttonDeletePlace";
            this.buttonDeletePlace.Size = new System.Drawing.Size(59, 40);
            this.buttonDeletePlace.TabIndex = 5;
            this.buttonDeletePlace.Text = "Usuń miejsce";
            this.buttonDeletePlace.UseVisualStyleBackColor = false;
            this.buttonDeletePlace.Click += new System.EventHandler(this.buttonDeletePlace_Click);
            // 
            // comboBoxMeasureUnit
            // 
            this.comboBoxMeasureUnit.BackColor = System.Drawing.Color.Gray;
            this.comboBoxMeasureUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMeasureUnit.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxMeasureUnit.ForeColor = System.Drawing.Color.White;
            this.comboBoxMeasureUnit.FormattingEnabled = true;
            this.comboBoxMeasureUnit.Items.AddRange(new object[] {
            "m",
            "czas",
            "pkt"});
            this.comboBoxMeasureUnit.Location = new System.Drawing.Point(371, 15);
            this.comboBoxMeasureUnit.Name = "comboBoxMeasureUnit";
            this.comboBoxMeasureUnit.Size = new System.Drawing.Size(47, 23);
            this.comboBoxMeasureUnit.TabIndex = 6;
            this.comboBoxMeasureUnit.SelectedIndexChanged += new System.EventHandler(this.comboBoxMeasureUnit_SelectedIndexChanged);
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHours.ForeColor = System.Drawing.Color.Black;
            this.labelHours.Location = new System.Drawing.Point(254, 50);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(35, 13);
            this.labelHours.TabIndex = 7;
            this.labelHours.Text = "Godz.";
            this.labelHours.Visible = false;
            // 
            // labelMinutes
            // 
            this.labelMinutes.AutoSize = true;
            this.labelMinutes.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMinutes.ForeColor = System.Drawing.Color.Black;
            this.labelMinutes.Location = new System.Drawing.Point(300, 50);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(29, 13);
            this.labelMinutes.TabIndex = 8;
            this.labelMinutes.Text = "Min.";
            this.labelMinutes.Visible = false;
            // 
            // labelSeconds
            // 
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSeconds.ForeColor = System.Drawing.Color.Black;
            this.labelSeconds.Location = new System.Drawing.Point(346, 50);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(27, 13);
            this.labelSeconds.TabIndex = 9;
            this.labelSeconds.Text = "Sek.";
            this.labelSeconds.Visible = false;
            // 
            // labelHounredths
            // 
            this.labelHounredths.AutoSize = true;
            this.labelHounredths.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHounredths.ForeColor = System.Drawing.Color.Black;
            this.labelHounredths.Location = new System.Drawing.Point(392, 50);
            this.labelHounredths.Name = "labelHounredths";
            this.labelHounredths.Size = new System.Drawing.Size(33, 13);
            this.labelHounredths.TabIndex = 10;
            this.labelHounredths.Text = "Setne";
            this.labelHounredths.Visible = false;
            // 
            // buttonSaveDiscipline
            // 
            this.buttonSaveDiscipline.BackColor = System.Drawing.Color.Gray;
            this.buttonSaveDiscipline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveDiscipline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveDiscipline.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSaveDiscipline.ForeColor = System.Drawing.Color.White;
            this.buttonSaveDiscipline.Location = new System.Drawing.Point(424, 4);
            this.buttonSaveDiscipline.Name = "buttonSaveDiscipline";
            this.buttonSaveDiscipline.Size = new System.Drawing.Size(106, 43);
            this.buttonSaveDiscipline.TabIndex = 11;
            this.buttonSaveDiscipline.Text = "Zapisz dyscyplinę";
            this.buttonSaveDiscipline.UseVisualStyleBackColor = false;
            this.buttonSaveDiscipline.Click += new System.EventHandler(this.buttonSaveDiscipline_Click);
            // 
            // labelDNF
            // 
            this.labelDNF.AutoSize = true;
            this.labelDNF.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDNF.ForeColor = System.Drawing.Color.Black;
            this.labelDNF.Location = new System.Drawing.Point(444, 51);
            this.labelDNF.Name = "labelDNF";
            this.labelDNF.Size = new System.Drawing.Size(29, 13);
            this.labelDNF.TabIndex = 12;
            this.labelDNF.Text = "DNF";
            // 
            // labelDNS
            // 
            this.labelDNS.AutoSize = true;
            this.labelDNS.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDNS.ForeColor = System.Drawing.Color.Black;
            this.labelDNS.Location = new System.Drawing.Point(473, 51);
            this.labelDNS.Name = "labelDNS";
            this.labelDNS.Size = new System.Drawing.Size(29, 13);
            this.labelDNS.TabIndex = 13;
            this.labelDNS.Text = "DNS";
            // 
            // labelDQ
            // 
            this.labelDQ.AutoSize = true;
            this.labelDQ.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDQ.ForeColor = System.Drawing.Color.Black;
            this.labelDQ.Location = new System.Drawing.Point(507, 51);
            this.labelDQ.Name = "labelDQ";
            this.labelDQ.Size = new System.Drawing.Size(24, 13);
            this.labelDQ.TabIndex = 14;
            this.labelDQ.Text = "DQ";
            // 
            // resultControl1
            // 
            this.resultControl1.IsTime = false;
            this.resultControl1.Location = new System.Drawing.Point(7, 63);
            this.resultControl1.Name = "resultControl1";
            this.resultControl1.NotResult = false;
            this.resultControl1.PlayerName = "";
            this.resultControl1.PlayerPlace = "1";
            this.resultControl1.PlayerResult = "";
            this.resultControl1.Size = new System.Drawing.Size(527, 28);
            this.resultControl1.TabIndex = 0;
            // 
            // DisciplineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.labelDQ);
            this.Controls.Add(this.labelDNS);
            this.Controls.Add(this.labelDNF);
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
            this.Size = new System.Drawing.Size(536, 109);
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
        private System.Windows.Forms.Label labelDNF;
        private System.Windows.Forms.Label labelDNS;
        private System.Windows.Forms.Label labelDQ;
    }
}
