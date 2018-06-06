using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthleticCompetition.Classes
{
    public class Competition
    {
        public string CompetitionName { get; set; }
        public string CompetitionLocation { get; set; }
        public string CompetitionDate { get; set; }
        private List<Discipline> disciplines = new List<Discipline>();
        public List<Discipline> Disciplines { get { return disciplines; } set { disciplines = value; } }

        public Competition(string compName, string compLocation, string compDate)
        {
            CompetitionName = compName;
            CompetitionLocation = compLocation;
            CompetitionDate = compDate;
        }

        public Competition()
        {

        }

        public void AddDiscipline(Discipline discipline)
        {
            disciplines.Add(discipline);
        }
    }
}
