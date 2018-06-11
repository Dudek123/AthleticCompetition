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
        public string DisciplineName
        {
            get
            {
                return comboBoxDisciplineName.SelectedItem?.ToString();
            }
            set
            {
                comboBoxDisciplineName.SelectedItem = value;
            }
        }

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
                for (int i = 0; i < resultsCounter; i++)
                {
                    //try
                    //{
                        resultControls[i].PlayerName = value[i];
                    //}
                    //catch(Exception)
                    //{
                     //   Console.WriteLine("Głupi catch, nie wiem po co xD");
                    //}
                    
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
            set
            {
                for (int i = 0; i < resultsCounter; i++)
                {
                    
                    resultControls[i].PlayerResult = value[i];
                   
                }
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
            for(int i = 0; i < resultsCounter; i++)
            {
                 resultControls[i].NotResult = false;
            }
            
            if (comboBoxMeasureUnit.SelectedIndex == 1 ) 
            {
                showTimeLabels(true);
                for (int i = 0; i < resultsCounter; i++)
                {
                    resultControls[i].IsTime = true;
                }

            }
            else 
            {
                showTimeLabels(false);
                for (int i = 0; i < resultsCounter; i++)
                {
                    resultControls[i].IsTime = false;
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

                for (int i = 0; i < resultsCounter; i++)
                {
                    resultControls[i].NotResult = false;
                }
                makeResultControls(1);
                
            }
        }

        public void ClearDiscipline()
        {
            List<string> lista = new List<string>();
            for(int i = 0; i < resultsCounter; i++)
            {
                lista.Add("");
            }
            PlayersList = lista;
            PlayersResults = lista;
        }

        public void makeResultControls(int number)
        {
            
            if (resultsCounter == number)
                return;
            else if(resultsCounter < number)
            {
                int m = number - resultsCounter;
                for (int i = 0; i < m; i++)
                {
                    ResultControl newResult = new ResultControl();
                    newResult.Top = 64 + 30 * resultsCounter;
                    newResult.Left = 7;
                    newResult.PlayerPlace = (resultsCounter + 1).ToString();
                    resultControls[resultsCounter] = newResult;
                    resultControls[resultsCounter].textBoxResultLeave += new EventHandler(Result_Leave);
                    if (comboBoxMeasureUnit.SelectedIndex == 1)
                        resultControls[resultsCounter].IsTime = true;
                    resultsCounter++;
                    this.Controls.Add(newResult);
                    this.Height += 35;
                }
                resultsCounter = number;
            }
            else if(resultsCounter > number)
            {
                Console.WriteLine(number);
                int n = resultsCounter - number;

                for(int i = n-1; i < resultsCounter; i++)
                {
                    this.Controls.Remove(resultControls[i]);
                   
                }
                resultsCounter = number;
                
                
            }
        }

    }
}
