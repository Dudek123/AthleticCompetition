using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthleticCompetition.Classes
{
    public class Discipline
    {
        #region PUBLIC_FIELDS
        public string DisciplineName { get; set; }        
        public List<Result> Results { get { return results; } set { results = value; } }
        #endregion

        #region PRIVATE FIELDS
        private List<Result> results = new List<Result>();
        #endregion

        #region CONSTRUCTORS
        public Discipline(string disciplineName)
        {
            DisciplineName = disciplineName;
        }
        
        public Discipline()
        {

        }
        #endregion

        #region PUBLIC_METHODS
        public void AddResult(Result result)
        {
            results.Add(result);
        }
        #endregion
    }
}
