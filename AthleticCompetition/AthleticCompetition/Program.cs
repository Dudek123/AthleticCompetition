using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AthleticCompetition
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Models.ACModel model = new Models.ACModel();
            Views.ACView view = new Views.ACView();
            Presenters.ACPresenter presenter = new Presenters.ACPresenter(model, view);
            Application.Run(view);
        }
    }
}
