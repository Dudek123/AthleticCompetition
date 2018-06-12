using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthleticCompetition.Classes
{
    public class Competition
    {
        #region PUBLIC_FIELDS
        public string CompetitionName { get; set; }
        public string CompetitionLocation { get; set; }
        public string CompetitionDate { get; set; }
        public List<Discipline> Disciplines { get { return disciplines; } set { disciplines = value; } }
        #endregion

        #region PRIVATE_FIELDS
        private List<Discipline> disciplines = new List<Discipline>();
        #endregion

        #region CONSTRUCTORS
        public Competition(string compName, string compLocation, string compDate)
        {
            CompetitionName = compName;
            CompetitionLocation = compLocation;
            CompetitionDate = compDate;
        }

        public Competition()
        {

        }
        #endregion

        #region PUBLIC_METHODS
        public void AddDiscipline(Discipline discipline)
        {
            disciplines.Add(discipline);
        }

        public void ClearCompetition()
        {
            disciplines.Clear();
            CompetitionName = string.Empty;
            CompetitionLocation = string.Empty;
            CompetitionDate = string.Empty;
        }

        public Discipline GetDiscipline(int number)
        {
            return disciplines[number];
        }
        #endregion
    }
}
