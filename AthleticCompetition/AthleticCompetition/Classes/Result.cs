using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthleticCompetition.Classes
{
    public class Result
    {
        public string Player { get; set; }
        public string PlayerResult { get; set; }

        public Result(string player, string playerResult)
        {
            Player = player;
            PlayerResult = playerResult;
        }

        public Result()
        {

        }
    }
}
