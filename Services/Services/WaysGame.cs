using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class WaysGame : Services
    {
        public override StgMsg.StgMsg launchServices(StgMsg.StgMsg msg)
        {
            return msg;
        }
    }

    private enum Functionalities
    {
        Next = "nextQuestion",
        Previous = "previousQuestion",
        Launch = "launch",
        Validate = "validate",
        Score = "showScore",
    }
}
