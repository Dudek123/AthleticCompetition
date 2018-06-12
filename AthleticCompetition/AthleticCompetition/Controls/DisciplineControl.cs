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
        #region PROPERTIES
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
     
        public List<string> PlayersList
        {
            get
            {
                playersList.Clear();
                for(int i = 0; i < 8; i++)
                {
                    if(resultControls[i].Visible == true)
                        playersList.Add(resultControls[i].PlayerName);
                }
                return playersList;
            }
            set
            {
                for (int i = 0; i < 8; i++)
                {
                    if(i < value.Count)
                    {
                        resultControls[i].Visible = true;
                        resultControls[i].PlayerName = value[i];
                    }
                    else  
                        resultControls[i].Visible = false;   
                }
                resultsCounter = value.Count;
            }
        }

        public List<string> PlayersResults
        {
            get
            {
                playersResults.Clear();
                for (int i = 0; i < 8; i++)
                {
                    if (resultControls[i].Visible == true)
                        playersResults.Add(resultControls[i].PlayerResult);
                }
                return playersResults;
            }
            set
            {
                for(int j = 0; j < value.Count; j++)
                {
                    if(value[j].Contains(":"))
                    {
                        for (int k = 0; k < 8; k++)
                        {
                            resultControls[k].IsTime = true;    
                        }
                        break;
                    }
                    else
                    {
                        for (int k = 0; k < 8; k++)
                        {
                            resultControls[k].IsTime = false;
                        }
                    }         
                }
                for (int i = 0; i < 8; i++)
                {               
                    if (i < value.Count)
                    {
                        resultControls[i].Visible = true;
                        resultControls[i].PlayerResult = value[i];
                    }
                    else
                        resultControls[i].Visible = false;
                }
            }
        }
        #endregion

        #region PRIVATE_FIELDS
        private List<string> playersList = new List<string>();
        private List<string> playersResults = new List<string>();
        private int resultsCounter;
        private ResultControl[] resultControls = new ResultControl[8];
        #endregion

        #region EVENT_HANDLERS
        public EventHandler SaveDisciplineButtonClick;
        #endregion

        #region CONSTRUCTOR
        public DisciplineControl()
        {
            InitializeComponent();
            resultControls[0] = resultControl1;
            resultControls[0].textBoxResultLeave += new EventHandler(Result_Leave);
            
            for(int i = 1; i < 8; i++)
            {
                ResultControl newResult = new ResultControl();
                newResult.Top = 64 + 30 * i;
                newResult.Left = 7;
                newResult.PlayerPlace = (i + 1).ToString();
                newResult.Visible = false;
                resultControls[i] = newResult;
                resultControls[i].textBoxResultLeave += new EventHandler(Result_Leave);
                if (comboBoxMeasureUnit.SelectedIndex == 1)
                    resultControls[i].IsTime = true;   
                this.Controls.Add(newResult);
                this.Height += 35;
            }
            resultsCounter = 1;
        }
        #endregion

        #region CONTROLS_METHODS
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
        #endregion

        #region PRIVATE_METHODS
        private void buttonAddPlace_Click(object sender, EventArgs e)
        {
            if(resultsCounter < 8)
            {
                resultControls[resultsCounter].Visible = true;
                resultControls[resultsCounter].PlayerName = "";
                if (resultControls[0].IsTime)
                    resultControls[resultsCounter].PlayerResult = "0:0:0:0";
                else
                    resultControls[resultsCounter].PlayerResult = "";
                resultsCounter++;
            }
        }

        private void buttonDeletePlace_Click(object sender, EventArgs e)
        {
            if(resultsCounter > 1)
            {
                resultControls[resultsCounter-1].Visible = false;
                resultsCounter--;
            }
        }

        private void DisciplineControl_Load(object sender, EventArgs e)
        {
            comboBoxMeasureUnit.SelectedItem = comboBoxMeasureUnit.Items[0];
        }

        private void comboBoxMeasureUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < 8; i++)
            {          
                resultControls[i].NotResult = false;
                resultControls[i].PlayerResult = "";
            }
            
            if (comboBoxMeasureUnit.SelectedIndex == 1 ) 
            {
                showTimeLabels(true);
                for (int i = 0; i < 8; i++)
                {
                    resultControls[i].IsTime = true;
                }
            }
            else 
            {
                showTimeLabels(false);
                for (int i = 0; i < 8; i++)
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
           }               
        }
        #endregion

        #region PUBLIC_METHODS
        public void ClearDiscipline()
        {
            List<string> lista = new List<string>();
            for(int i = 0; i < resultsCounter; i++)
            {
                lista.Add("");  
            }
            PlayersList = lista;
            PlayersResults = lista;
            showTimeLabels(false);

            for (int i = 0; i < resultsCounter; i++)
            {
                resultControls[i].NotResult = false;
            }
        }
        #endregion
    }
}
