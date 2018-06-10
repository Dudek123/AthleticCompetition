using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AthleticCompetition.Classes;

namespace AthleticCompetition.Presenters
{
    public class ACPresenter
    {
        Models.ACModel model;
        Views.IACView view;
        public ACPresenter(Models.ACModel model, Views.IACView view)
        {
            this.model = model;
            this.view = view;
            view.SaveDiscipline += saveDiscipline;
            view.SaveCompetition += saveCompetition;
            view.LoadCompetition += loadCompetition;
            view.GetXMLFiles += getXMLFiles;
            view.ClearCompetition += clearCompetition;
            view.GetCompetitionInfos += getCompetitionInfos;
            view.GetDiscipline += getDiscipline;
        }

        private Discipline getDiscipline(int number)
        {
            return model.GetDiscipline(number);
        }

        private List<string> getCompetitionInfos()
        {
            return model.GetCompetitionInfos();
        }

        private bool clearCompetition()
        {
            return model.ClearCompetition();
        }

        private string[] getXMLFiles()
        {
            return model.GetXMLFiles();
        }

        private bool loadCompetition(string path)
        {
            return model.LoadCompetition(path);
        }

        private bool saveCompetition(string name, string location, string date)
        {
            return model.SaveCompetition(name, location, date);
        }

        private bool saveDiscipline(string name, List<string> players, List<string> results)
        {
            return model.SaveDiscipline(name, players, results);
        }
    }
}
