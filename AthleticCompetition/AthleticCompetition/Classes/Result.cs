using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthleticCompetition.Classes
{
    public class Result
    {
        #region PUBLIC_FIELDS
        public string Player { get; set; }
        public string PlayerResult { get; set; }
        #endregion

        #region CONSTRUCTORS
        public Result(string player, string playerResult)
        {
            Player = player;
            PlayerResult = playerResult;
        }

        public Result()
        {

        }
        #endregion
    }
}
