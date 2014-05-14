using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAC
{
    public class BAC : Ibac
    {
        public StgMsg.StgMsg redirect(StgMsg.StgMsg msg)
        {
            switch (msg.invoke)
            {
                case "nextQuestionWaysOriention":
                    break;
                case "launchWaysOriention":
                    break;
                case "validateWaysOriention":
                    break;
                case "nextQuestionWaysGame":
                    break;
                case "launchWaysGame":
                    break;
                case "validateWaysGame":
                    break;
                case "previousQuestionWaysGame":
                    break;
                case "sendMailWaysOrientation":
                    break;
                case "showScoreWaysGame":
                    break;
                case "addQuestionAdmin":
                    break;
                case "modifyQuestionAdmin":
                    break;
                case "deleteQuestionAdmin":
                    break;
                case "showQuestionAdmin":
                    break;
                case "loginAdmin":
                    break;
                default:
                    return msg;
            }

            return msg;
        }
    }
}
