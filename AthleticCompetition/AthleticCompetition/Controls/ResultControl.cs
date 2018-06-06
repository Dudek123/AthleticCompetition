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
    public partial class ResultControl : UserControl
    {
        public string PlayerName { get { return textBoxPlayer.Text.ToString(); } }
        public string PlayerResult { get { return textBoxResult.Text.ToString(); } }
        public string PlayerPlace { get { return labelPlace.Text.ToString(); } set { labelPlace.Text = value; } }

        public ResultControl()
        {
            InitializeComponent();
        }
    }
}
