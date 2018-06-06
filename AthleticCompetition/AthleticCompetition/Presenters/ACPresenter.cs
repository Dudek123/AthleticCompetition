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
        }
    }
}
