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
        #region PRIVATE_FIELDS
        Models.ACModel model;
        Views.IACView view;
        #endregion

        #region CONSTRUCTOR
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
            view.GetDisciplinesNames += getDisciplinesNames;
            view.UpdateDiscipline += updateDiscipline;
            view.DeleteDiscipline += deleteDiscipline;
        }
        #endregion

        #region PRIVATE_METHODS
        private bool deleteDiscipline(int number)
        {
            return model.DeleteDiscipline(number);
        }

        private bool updateDiscipline(int number, string name, List<string> players, List<string> results)
        {
            return model.UpdateDiscipline(number, name, players, results);
        }

        private List<string> getDisciplinesNames()
        {
            return model.GetDisciplinesNames();
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
        #endregion
    }
}
