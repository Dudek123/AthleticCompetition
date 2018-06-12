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
        #region PROPERTIES
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
        #endregion

        #region PRIVATE_FIELDS
        private int currentDiscipline;
        #endregion

        #region CONSTRUCTOR
        public ACView()
        {
            InitializeComponent();
            disciplineControl1.SaveDisciplineButtonClick += new EventHandler(saveDiscipline_Click);
        }
        #endregion

        #region INTERFACE_METHODS
        public event Func<string, List<string>, List<string>, bool> SaveDiscipline;
        public event Func<string, string, string, bool> SaveCompetition;
        public event Func<string, bool> LoadCompetition;
        public event Func<string[]> GetXMLFiles;
        public event Func<bool> ClearCompetition;
        public event Func<List<string>> GetCompetitionInfos;
        public event Func<int, Discipline> GetDiscipline;
        public event Func<List<string>> GetDisciplinesNames;
        public event Func<int, string, List<string>, List<string>, bool> UpdateDiscipline;
        public event Func<int, bool> DeleteDiscipline;
        #endregion

        #region CONTROLS_METHODS
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
            if (radioButtonEdit.Checked)
            {
                if (MessageBox.Show("Jeśli chcesz dodać nową dyscyplinę wybierz TAK. Jeśli chcesz zmienić dyscyplinę wybierz NIE.", "Wybór", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                { //update
                    if (UpdateDiscipline(currentDiscipline, disciplineControl1.DisciplineName, disciplineControl1.PlayersList, disciplineControl1.PlayersResults))
                    {
                        MessageBox.Show("Dyscyplina zaktualizowana pomyślnie", "Aktualizacja pomyślna", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadDiscipline(listBoxDisciplines.SelectedIndex);
                        var list = GetDisciplinesNames();
                        listBoxDisciplines.Items.Clear();

                        foreach (var d in list)
                        {
                            listBoxDisciplines.Items.Add(d);
                        }
                    }
                    else
                        MessageBox.Show("Brak wybranej dyscypliny, brak zawodnika lub brak wyniku", "Błąd danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                { //nowa
                    if (SaveDiscipline(disciplineControl1.DisciplineName, disciplineControl1.PlayersList, disciplineControl1.PlayersResults))
                    {
                        disciplineControl1.ClearDiscipline();

                        var list = GetDisciplinesNames();
                        listBoxDisciplines.Items.Clear();

                        foreach (var d in list)
                        {
                            listBoxDisciplines.Items.Add(d);
                        }

                        MessageBox.Show("Dyscyplina zapisana pomyślnie do bazy", "Zapisano pomyślnie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Brak wybranej dyscypliny, brak zawodnika lub brak wyniku", "Błąd danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region PRIVATE_METHODS
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
            if (comboBoxCompetitions.SelectedIndex != -1)
            {
                if (LoadCompetition(Path.Combine(Directory.GetCurrentDirectory(), comboBoxCompetitions.SelectedItem.ToString())))
                {
                    Console.WriteLine("wczytałem sobie");
                }
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
            if (comboBoxCompetitions.SelectedIndex != -1)
            {
                var compInfos = GetCompetitionInfos();
                CompetitionName = compInfos[0];
                CompetitionLocation = compInfos[1];
                CompetitionDate = compInfos[2];

                var list = GetDisciplinesNames();
                listBoxDisciplines.Items.Clear();

                foreach (var d in list)
                {
                    listBoxDisciplines.Items.Add(d);
                }

                if (LoadDiscipline(0))
                {
                    currentDiscipline = 0;
                    listBoxDisciplines.SelectedIndex = 0;
                }                  
            }
        }

        private bool LoadDiscipline(int number)
        {
            Discipline disc = new Discipline();
            try
            {
                disc = GetDiscipline(number);
            }
            catch (Exception)
            {
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

        private void showEdit(bool a)
        {
            comboBoxCompetitions.Visible = a;
            buttonLoadCompetition.Visible = a;
            listBoxDisciplines.Visible = a;
            buttonDeleteDiscipline.Visible = a;
            textBoxName.Enabled = !a;
        }

        private void listBoxDisciplines_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxDisciplines.SelectedIndex != -1)
            {
                if (!LoadDiscipline(listBoxDisciplines.SelectedIndex))
                {
                    MessageBox.Show("Błąd zapisu");
                }
            }
        }

        private void buttonDeleteDiscipline_Click(object sender, EventArgs e)
        {
            if (listBoxDisciplines.SelectedIndex != -1)
            {
                if (DeleteDiscipline(listBoxDisciplines.SelectedIndex))
                {
                    listBoxDisciplines.Items.Remove(listBoxDisciplines.SelectedItem);
                    MessageBox.Show("Dyscyplina usunięta pomyślnie", "Usunięcie pomyślna", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void radioButtonGenerate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz wejść w tryb generowania? Potwierdzenie wyczyści niezapisane dane w pliku XML", "Czy na pewno?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                showEdit(false);
                CompetitionName = "";
                CompetitionLocation = "";
                CompetitionDate = DateTime.Today.ToString();
                disciplineControl1.ClearDiscipline();
                ClearCompetition();
                radioButtonGenerate.Checked = true;    
            }
            else
                radioButtonEdit.Checked = true;
        }

        private void radioButtonEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz wejść w tryb edytowania? Potwierdzenie wyczyści niezapisane dane w pliku XML", "Czy na pewno?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                showEdit(true);
                CompetitionName = "";
                CompetitionLocation = "";
                CompetitionDate = DateTime.Today.ToString();
                disciplineControl1.ClearDiscipline();
                ClearCompetition();
                listBoxDisciplines.Items.Clear();
                comboBoxCompetitions.SelectedIndex = -1;
                radioButtonEdit.Checked = true;             
            }
            else
                radioButtonGenerate.Checked = true;
        }

        private void ACView_Load(object sender, EventArgs e)
        {
            dateTimePickerDate.Value = DateTime.Today;
        }
        #endregion
    }
}
