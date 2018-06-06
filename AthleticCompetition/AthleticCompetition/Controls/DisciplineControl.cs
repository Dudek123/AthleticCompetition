using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AthleticCompetition.Controls
{
    public partial class DisciplineControl : UserControl
    {
        public string DisciplineName { get { return comboBoxDisciplineName.SelectedItem?.ToString(); } }

        private int disciplinesCounter;
        private ResultControl[] resultControls = new ResultControl[8];

        public DisciplineControl()
        {
            InitializeComponent();
            resultControls[0] = resultControl1;
            disciplinesCounter = 1;
        }

        private void buttonAddPlace_Click(object sender, EventArgs e)
        {
            if(disciplinesCounter < 8)
            {
                ResultControl newResult = new ResultControl();
                this.Controls.Add(newResult);
                newResult.Top = 35 + 30 * disciplinesCounter;
                newResult.Left = 6;
                newResult.PlayerPlace = (disciplinesCounter + 1).ToString();
                resultControls[disciplinesCounter] = newResult;
                disciplinesCounter++;
                this.Height += 35;
            }
        }

        private void buttonDeletePlace_Click(object sender, EventArgs e)
        {
            if(disciplinesCounter > 1)
            {
                this.Controls.Remove(resultControls[disciplinesCounter - 1]);
                disciplinesCounter--;
            }
        }
    }
}
