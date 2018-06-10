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
        public string CompetitionName { get { return textBoxName.Text.ToString(); } }
        public string CompetitionLocation { get { return textBoxLocation.Text.ToString(); } }
        public string CompetitionDate { get { return dateTimePickerDate.Value.ToShortDateString(); } }
        public ACView()
        {
            InitializeComponent();
            disciplineControl1.SaveDisciplineButtonClick += new EventHandler(saveDiscipline_Click);
        }

        public event Func<string, List<string>, List<string>, bool> SaveDiscipline;
        public event Func<string, string, string, bool> SaveCompetition;

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
            string[] xmlFiles = Directory.GetFiles(Directory.GetCurrentDirectory().ToString(),"*.xml");

            for(int i = 0; i < xmlFiles.Length; i++)
            {
                comboBoxCompetitions.Items.Add(Path.GetFileName(xmlFiles[i]));
            }

        }
    }
}
