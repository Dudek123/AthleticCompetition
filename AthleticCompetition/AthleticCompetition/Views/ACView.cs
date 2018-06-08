using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public string CompetitionDate { get { return dateTimePickerDate.Value.ToString(); } }
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
                Console.WriteLine("Zapisałem dyscyplinę do klasy");
            }
        }

        private void buttonSaveCompetition_Click(object sender, EventArgs e)
        {
            if (SaveCompetition(CompetitionName, CompetitionLocation, CompetitionDate))
            {
                Console.WriteLine("Zapisałem plik XML");
            }
        }
    }
}
