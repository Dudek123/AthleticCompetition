using AthleticCompetition.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthleticCompetition.Views
{
    public interface IACView
    {
     
        event Func<string, List<string>, List<string>, bool> SaveDiscipline;
        event Func<string, string, string, bool> SaveCompetition;
        event Func<string, bool> LoadCompetition;
        event Func<string[]> GetXMLFiles;
        event Func<bool> ClearCompetition;
        event Func<List<string>> GetCompetitionInfos;
        event Func<int, Discipline> GetDiscipline;
        
    }
}
