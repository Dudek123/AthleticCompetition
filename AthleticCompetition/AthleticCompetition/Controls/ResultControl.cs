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
    }
}
