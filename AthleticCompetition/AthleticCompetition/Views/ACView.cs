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

        private void saveDiscipline_Click(object sender, EventArgs e)
        {
            if (SaveDiscipline(disciplineControl1.DisciplineName, disciplineControl1.PlayersList, disciplineControl1.PlayersResults))
            {
                disciplineControl1.PlayersList = new List<string>();
                MessageBox.Show("Dyscyplina zapisana pomyślnie do bazy", "Zapisano pomyślnie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Brak wybranej dyscypliny, brak zawodnika lub brak wyniku","Błąd danych",MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ACView_Load(object sender, EventArgs e)
        {
        
            toolStripComboBoxTryb.SelectedItem = toolStripComboBoxTryb.Items[0];

        }

        private void toolStripComboBoxTryb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(toolStripComboBoxTryb.SelectedIndex == 1)
            {
                buttonPrevDisc.Visible = true;
                buttonNextDisc.Visible = true;
                comboBoxCompetitions.Visible = true;
            }
            else
            {
                buttonPrevDisc.Visible = false;
                buttonNextDisc.Visible = false;
                comboBoxCompetitions.Visible = false;
                ClearCompetition();
            }
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

            var disc = GetDiscipline(0);
            disciplineControl1.DisciplineName = disc.DisciplineName;
            
        }
    }
}
