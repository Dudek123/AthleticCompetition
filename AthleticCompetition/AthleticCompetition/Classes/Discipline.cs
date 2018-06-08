using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthleticCompetition.Classes
{
    public class Discipline
    {
        public string DisciplineName { get; set; }
        private List<Result> results = new List<Result>();
        public List<Result> Results { get { return results; } set { results = value; } }

        public Discipline(string disciplineName)
        {
            DisciplineName = disciplineName;
        }

        public Discipline()
        {

        }

        public void AddResult(Result result)
        {
            results.Add(result);
        }
    }
}
