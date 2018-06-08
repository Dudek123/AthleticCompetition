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
        public string Hours { get { return numericUpDownHours.Value.ToString(); } }
        public string Minutes { get { return numericUpDownMinutes.Value.ToString(); } }
        public string Seconds { get { return numericUpDownSeconds.Value.ToString(); } }
        public string Hundredths { get { return numericUpDownHundredths.Value.ToString(); } }

        public TimeControl()
        {
            InitializeComponent();
        }
    }
}
