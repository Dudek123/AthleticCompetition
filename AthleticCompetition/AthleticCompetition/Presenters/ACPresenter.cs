using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
