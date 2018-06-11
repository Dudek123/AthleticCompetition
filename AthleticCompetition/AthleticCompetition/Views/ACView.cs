using AthleticCompetition.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AthleticCompetition.Views
{
    public partial class ACView : Form, Views.IACView
    {
        public string CompetitionName { get { return textBoxName.Text.ToString(); } set { textBoxName.Text = value; } }
        public string CompetitionLocation { get { return textBoxLocation.Text.ToString(); } set { textBoxLocation.Text = value; } }
        public string CompetitionDate
        {
            get
            {
                return dateTimePickerDate.Value.ToShortDateString();
            }
            set
            {
                dateTimePickerDate.Value = DateTime.Parse(value);
            }
        }

        private int currentDiscipline;


        public ACView()
        {
            InitializeComponent();
            disciplineControl1.SaveDisciplineButtonClick += new EventHandler(saveDiscipline_Click);
        }

        public event Func<string, List<string>, List<string>, bool> SaveDiscipline;
        public event Func<string, string, string, bool> SaveCompetition;
        public event Func<string, bool> LoadCompetition;
        public event Func<string[]> GetXMLFiles;
        public event Func<bool> ClearCompetition;
        public event Func<List<string>> GetCompetitionInfos;
        public event Func<int, Discipline> GetDiscipline;
        public event Func<List<string>> GetDisciplinesNames;
        public event Func<int, string, List<string>, List<string>, bool> UpdateDiscipline;

        private void saveDiscipline_Click(object sender, EventArgs e)
        {
            if (radioButtonGenerate.Checked)
            {
                if (SaveDiscipline(disciplineControl1.DisciplineName, disciplineControl1.PlayersList, disciplineControl1.PlayersResults))
                {
                    disciplineControl1.ClearDiscipline();
                    MessageBox.Show("Dyscyplina zapisana pomyślnie do bazy", "Zapisano pomyślnie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Brak wybranej dyscypliny, brak zawodnika lub brak wyniku", "Błąd danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(radioButtonEdit.Checked)
            {
                if (UpdateDiscipline(currentDiscipline, disciplineControl1.Name, disciplineControl1.PlayersList, disciplineControl1.PlayersResults))
                {
                    MessageBox.Show("Dyscyplina zaktualizowana pomyślnie", "Aktualizacja pomyślna", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Brak wybranej dyscypliny, brak zawodnika lub brak wyniku", "Błąd danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonSaveCompetition_Click(object sender, EventArgs e)
        {
            if (SaveCompetition(CompetitionName, CompetitionLocation, CompetitionDate))
            {
                MessageBox.Show("Zawody zapisane pomyślnie do pliku XML", "Zapisano pomyślnie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Brak nazwy, miejsca lub dodanych dyscyplin", "Błąd danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

  
        private void comboBoxCompetitions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(LoadCompetition(Path.Combine(Directory.GetCurrentDirectory(),comboBoxCompetitions.SelectedItem.ToString())))
            {
                Console.WriteLine("wczytałem sobie");
            }
        }

        private void comboBoxCompetitions_DropDown(object sender, EventArgs e)
        {
            var xmlFiles = GetXMLFiles();
            comboBoxCompetitions.Items.Clear();
            for (int i = 0; i < xmlFiles.Length; i++)
            {
                comboBoxCompetitions.Items.Add(Path.GetFileName(xmlFiles[i]));
            }
        }

        private void buttonLoadCompetition_Click(object sender, EventArgs e)
        {
            var compInfos = GetCompetitionInfos();
            CompetitionName = compInfos[0];
            CompetitionLocation = compInfos[1];
            CompetitionDate = compInfos[2];

            var list = GetDisciplinesNames();

            listBoxDisciplines.Items.Clear();

            foreach(var d in list)
            {
                listBoxDisciplines.Items.Add(d);
            }

            if (LoadDiscipline(0))
                currentDiscipline = 0;

        }

        private bool LoadDiscipline(int number)
        {
            Discipline disc = new Discipline();
            try
            {
                disc = GetDiscipline(number);
            }
            catch(Exception)
            {
                MessageBox.Show("To jest pierwsze lub ostanie pytanie, wybierz inne", "Brak pytania", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            
            disciplineControl1.DisciplineName = disc.DisciplineName;

            var results = disc.Results;

            List<string> ps = new List<string>();
            List<string> rs = new List<string>();
            currentDiscipline = number;

            foreach (var r in results)
            {
                ps.Add(r.Player);
                rs.Add(r.PlayerResult);
            }

            disciplineControl1.PlayersList = ps;
            disciplineControl1.PlayersResults = rs;

            return true;
        }


        private void radioButtonGenerate_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonGenerate.Checked)
            {
                showEdit(false);
                ClearCompetition();
            }
        }

        private void radioButtonEdit_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonEdit.Checked)
            {
                showEdit(true);
                ClearCompetition();
            }
        }

        private void showEdit(bool a)
        {
            comboBoxCompetitions.Visible = a;
            buttonLoadCompetition.Visible = a;
            listBoxDisciplines.Visible = a;
        }

        private void radioButtonShow_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonShow.Checked)
            {
                showEdit(false);
                ClearCompetition();
            }
        }

        private void buttonPrevDisc_Click(object sender, EventArgs e)
        {
            int c = currentDiscipline - 1;
            if (LoadDiscipline(c))
                currentDiscipline = c;
       
            
        }

        private void buttonNextDisc_Click(object sender, EventArgs e)
        {
            int c = currentDiscipline + 1;
            if (LoadDiscipline(c))
                currentDiscipline = c;
        }

        private void listBoxDisciplines_DoubleClick(object sender, EventArgs e)
        {
            if(listBoxDisciplines.SelectedIndex != -1)
            {
                //disciplineControl1.ClearDiscipline();
                if(LoadDiscipline(listBoxDisciplines.SelectedIndex))
                {

                }
            }
        }
    }
}
