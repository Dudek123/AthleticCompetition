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
    public partial class TimeControl : UserControl
    {
        #region PROPERTIES
        public string Hours { get { return numericUpDownHours.Value.ToString(); } set { numericUpDownHours.Value = new decimal(int.Parse(value)); } }
        public string Minutes { get { return numericUpDownMinutes.Value.ToString(); } set { numericUpDownMinutes.Value = new decimal(int.Parse(value)); } }
        public string Seconds { get { return numericUpDownSeconds.Value.ToString(); } set { numericUpDownSeconds.Value = new decimal(int.Parse(value)); } }
        public string Hundredths { get { return numericUpDownHundredths.Value.ToString(); } set { numericUpDownHundredths.Value = new decimal(int.Parse(value)); } }
        #endregion

        #region CONSTRUCTOR
        public TimeControl()
        {
            InitializeComponent();
        }
        #endregion
    }
}
