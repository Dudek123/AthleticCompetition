using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace AthleticCompetition.Controls
{
    public partial class ResultControl : UserControl
    {
        #region PROPERTIES
        public string PlayerName { get { return textBoxPlayer.Text.ToString(); } set { textBoxPlayer.Text = value; } }
        public string PlayerResult
        {
            get
            {
                if (checkBoxDNF.Checked)
                    return "DNF";
                if (checkBoxDNS.Checked)
                    return "DNS";
                if (checkBoxDQ.Checked)
                    return "DQ";
                if (IsTime == false)
                    return textBoxResult.Text.ToString();
                else
                {
                    return timeControl1.Hours + ":" + timeControl1.Minutes + ":" + timeControl1.Seconds + ":" + timeControl1.Hundredths;     
                }
            }
            set
            {
                if (value == "DNF" || value == "DNS" || value == "DQ")
                {
                    textBoxResult.Enabled = false;
                    timeControl1.Enabled = false;
                    textBoxResult.Text = "";
                    timeControl1.Hours = "0";
                    timeControl1.Minutes = "0";
                    timeControl1.Seconds = "0";
                    timeControl1.Hundredths = "0";
                    NotResult = false;

                    if(value == "DNF")
                    {
                        checkBoxDNF.Checked = true;
                    }
                    if (value == "DNS")
                    {
                        checkBoxDNS.Checked = true;
                    }
                    if (value == "DQ")
                    {
                        checkBoxDQ.Checked = true;
                    }
                }
                else
                {
                    textBoxResult.Enabled = true;
                    timeControl1.Enabled = true;
                    checkBoxDNF.Checked = false;
                    checkBoxDNS.Checked = false;
                    checkBoxDQ.Checked = false;

                    if(value.Contains(":")) //czas
                    {
                        var lista = value.Split(':');
                        timeControl1.Hours = lista[0];
                        timeControl1.Minutes = lista[1];
                        timeControl1.Seconds = lista[2];
                        timeControl1.Hundredths = lista[3];
                        timeControl1.Visible = true;
                        textBoxResult.Visible = false;
                    }
                    else
                    {
                        timeControl1.Visible = false;
                        textBoxResult.Visible = true;
                        textBoxResult.Text = value;
                    }
                }
            }
        }

        public string PlayerPlace { get { return labelPlace.Text.ToString(); } set { labelPlace.Text = value; } }
        
        public bool IsTime
        {
            get
            {
                return isTime;
            }
            set
            {
                if (value)
                {
                    isTime = true;
                    textBoxResult.Visible = false;
                    timeControl1.Visible = true;
                }
                else
                {
                    isTime = false;
                    textBoxResult.Visible = true;
                    timeControl1.Visible = false;
                }
            }
        }

        public bool NotResult
        {
            get
            {
                if (checkBoxDNF.Checked || checkBoxDNS.Checked || checkBoxDQ.Checked)
                {
                    Console.WriteLine("fdfsf");
                    return true;   
                }
                else
                    return false;
            }
            set
            {
                checkBoxDNF.Enabled = true;
                checkBoxDNF.Checked = false;
                checkBoxDNS.Enabled = true;
                checkBoxDNS.Checked = false;
                checkBoxDQ.Enabled = true;
                checkBoxDQ.Checked = false;
            }
        }
        #endregion

        #region PRIVATE_FIELDS
        private bool isTime = false;
        #endregion

        #region EVENT_HANDLERS
        public EventHandler textBoxResultLeave;
        #endregion

        #region CONSTRUCTOR
        public ResultControl()
        {
            InitializeComponent();
        }
        #endregion

        #region PRIVATE_METHODS
        private void textBoxResult_Leave(object sender, EventArgs e)
        {
            if (this.textBoxResultLeave != null)
            {
                this.textBoxResultLeave(this, e);
            }
        }

        private void textBoxResult_Enter(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
        }

        private void textBoxPlayer_Leave(object sender, EventArgs e)
        {
            string content = textBoxPlayer.Text.ToString();
            
            if(!Regex.Match(content, @"^[A-Z,a-z,ą,Ą,ę,Ę,ć,Ć,ł,Ł,ó,Ó,ż,Ż,ź,Ź,ń,Ń,ś,Ś, ,-]+$").Success)
            {
                textBoxPlayer.Text = "";
            }
        }

        private void checkBoxDNF_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxDNF.Checked == true)
            {
                checkBoxDNS.Enabled = false;
                checkBoxDQ.Enabled = false;

                if (timeControl1.Visible == true)
                {
                    timeControl1.Enabled = false;
                }    
                else
                    textBoxResult.Enabled = false;               
            }
            else
            {
                checkBoxDNS.Enabled = true;
                checkBoxDQ.Enabled = true;

                if (timeControl1.Visible == true)
                {
                    timeControl1.Enabled = true;
                }
                else
                    textBoxResult.Enabled = true;
            }  
        }

        private void checkBoxDNS_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDNS.Checked == true)
            {
                checkBoxDNF.Enabled = false;
                checkBoxDQ.Enabled = false;

                if (timeControl1.Visible == true)
                {
                    timeControl1.Enabled = false;
                }
                else
                    textBoxResult.Enabled = false;
            }
            else
            {
                checkBoxDNF.Enabled = true;
                checkBoxDQ.Enabled = true;

                if (timeControl1.Visible == true)
                {
                    timeControl1.Enabled = true;
                }
                else
                    textBoxResult.Enabled = true;
            }
        }

        private void checkBoxDQ_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDQ.Checked == true)
            {
                checkBoxDNF.Enabled = false;
                checkBoxDNS.Enabled = false;         

                if (timeControl1.Visible == true)
                {
                    timeControl1.Enabled = false;
                }
                else
                    textBoxResult.Enabled = false;
            }
            else
            {
                checkBoxDNF.Enabled = true;
                checkBoxDNS.Enabled = true;

                if (timeControl1.Visible == true)
                {
                    timeControl1.Enabled = true;
                }
                else
                    textBoxResult.Enabled = true;
            }
        }

        public void uncheckCheckBoxes()
        {
            checkBoxDNF.Checked = false;
            checkBoxDNS.Checked = false;
            checkBoxDQ.Checked = false;
        }

        private void textBoxResult_Click(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.IsBalloon = true;
            tt.InitialDelay = 0;
            tt.AutomaticDelay = 0;
            tt.AutoPopDelay = 0;
            tt.ShowAlways = true;
            tt.SetToolTip(textBoxResult, "Podaj liczbę");
        }

        private void textBoxPlayer_Click(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.IsBalloon = true;
            tt.InitialDelay = 0;
            tt.AutomaticDelay = 0;
            tt.AutoPopDelay = 0;
            tt.ShowAlways = true;
            tt.SetToolTip(textBoxPlayer, "Podaj imię i nazwisko");
        }
        #endregion
    }
}
