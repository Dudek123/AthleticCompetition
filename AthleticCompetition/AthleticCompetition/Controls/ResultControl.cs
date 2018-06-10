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
                textBoxResult.Text = value;
            }
        }
        public string PlayerPlace { get { return labelPlace.Text.ToString(); } set { labelPlace.Text = value; } }
        private bool isTime = false;
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
                textBoxResult.Text = "";
                textBoxResult.Enabled = true;
                checkBoxDNF.Enabled = true;
                checkBoxDNF.Checked = false;
                checkBoxDNS.Enabled = true;
                checkBoxDNS.Checked = false;
                checkBoxDQ.Enabled = true;
                checkBoxDQ.Checked = false;
                timeControl1.Hours = "0";
                timeControl1.Minutes = "0";
                timeControl1.Seconds = "0";
                timeControl1.Hundredths = "0";
            }
        }

        public EventHandler textBoxResultLeave;
        public ResultControl()
        {
            InitializeComponent();
        }

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
            
            if(!Regex.Match(content, @"^[A-Z,a-z,ą,ę,ć,ł,ó,ż,ź,ń,ś]+\s[,A-Z,a-z,ś,ą,ę,ć,ł,ó,ż,ź,ń,ś]+$").Success)
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

        private void ResultControl_Load(object sender, EventArgs e)
        {
            //textBoxResult.Enabled = true;
        }
    }
}
