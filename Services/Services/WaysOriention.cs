using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class WaysOriention : Services
    {
        public override StgMsg.StgMsg launchServices(StgMsg.StgMsg msg)
        {
            foreach (string value in Enum.GetValues(typeof(Functionalities)))
            {
                if (value == msg.invoke)
                {
                    msg.invoke = msg.invoke + msg.servName;

                    this.bac = new BAC.BAC();
                    this.bac.redirect(msg);
                    return msg;
                }
            }

            msg.statut = false;
            return msg;
        }

       
    }

    private enum Functionalities
    {
        Next = "nextQuestion",
        Launch = "launch",
        Validate = "validate",
        Send = "sendMail",
    }
}
