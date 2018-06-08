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

        private List<string> playersList = new List<string>();
        public List<string> PlayersList
        {
            get
            {
                for(int i = 0; i < resultsCounter; i++)
                {
                    playersList.Add(resultControls[i].PlayerName);
                }
                return playersList;
            }
            set
            {
                playersList.Clear();
                playersResults.Clear();
                for (int i = 0; i < resultsCounter; i++)
                {
                    resultControls[i].PlayerName = "";
                    resultControls[i].PlayerResult = "";
                }
            }
        }

        private List<string> playersResults = new List<string>();
        public List<string> PlayersResults
        {
            get
            {
                for (int i = 0; i < resultsCounter; i++)
                {
                    playersResults.Add(resultControls[i].PlayerResult);
                }
                return playersResults;
            }
        }

        private int resultsCounter;
        private ResultControl[] resultControls = new ResultControl[8];

        public EventHandler SaveDisciplineButtonClick;

        public DisciplineControl()
        {
            InitializeComponent();
            resultControls[0] = resultControl1;
            resultControls[0].textBoxResultLeave += new EventHandler(Result_Leave);
            resultsCounter = 1;
        }

        private void Result_Leave(object sender, EventArgs e)
        {
            string result = ((ResultControl)sender).PlayerResult;
            double number;
            
            if ((!result.EndsWith(" m") || !result.EndsWith(" pkt")) && result != "")
            {
                int a = result.LastIndexOf(' ');
                if (Double.TryParse(result, out number))
                    ((ResultControl)sender).PlayerResult += " " + comboBoxMeasureUnit.SelectedItem.ToString();
                else
                    ((ResultControl)sender).PlayerResult = "";

            }
           
        }

        private void buttonAddPlace_Click(object sender, EventArgs e)
        {
            if(resultsCounter < 8)
            {
                ResultControl newResult = new ResultControl();
                newResult.Top = 64 + 30 * resultsCounter;
                newResult.Left = 7;
                newResult.PlayerPlace = (resultsCounter + 1).ToString();
                resultControls[resultsCounter] = newResult;
                resultControls[resultsCounter].textBoxResultLeave+= new EventHandler(Result_Leave);
                if (comboBoxMeasureUnit.SelectedIndex == 1)
                    resultControls[resultsCounter].IsTime = true;
                resultsCounter++;
                this.Controls.Add(newResult);
                this.Height += 35;
            }
        }

        private void buttonDeletePlace_Click(object sender, EventArgs e)
        {
            if(resultsCounter > 1)
            {
                this.Controls.Remove(resultControls[resultsCounter - 1]);
                resultsCounter--;
            }
        }

        private void DisciplineControl_Load(object sender, EventArgs e)
        {
            comboBoxMeasureUnit.SelectedItem = comboBoxMeasureUnit.Items[0];
        }

        private void comboBoxMeasureUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMeasureUnit.SelectedIndex == 0 || comboBoxMeasureUnit.SelectedIndex == 2) //metry i punkty
            {
                showTimeLabels(false);
                for (int i = 0; i < resultsCounter; i++)
                {
                    resultControls[i].IsTime = false;
                    if (resultControls[i].PlayerResult != "")
                    {
                        int a = resultControls[i].PlayerResult.ToString().LastIndexOf(' ');
                        resultControls[i].PlayerResult = resultControls[i].PlayerResult.Remove(a, resultControls[i].PlayerResult.Length - a) + " " + comboBoxMeasureUnit.SelectedItem.ToString();
                    }

                }
            }
            else //czas
            {
                showTimeLabels(true);
                for (int i = 0; i < resultsCounter; i++)
                {
                    resultControls[i].IsTime = true;
                }
            }
            
        }

        private void showTimeLabels(bool x)
        {
            labelHours.Visible = x;
            labelMinutes.Visible = x;
            labelSeconds.Visible = x;
            labelHounredths.Visible = x;
        }

        private void buttonSaveDiscipline_Click(object sender, EventArgs e)
        {
            if (this.SaveDisciplineButtonClick != null)
            {
                this.SaveDisciplineButtonClick(this, e);
            }
        }

        private void comboBoxDisciplineName_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlayersList = new List<string>();
        }
    }
}
