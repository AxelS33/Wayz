using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Admin : Services
    {
        
        public override StgMsg.StgMsg launchServices(StgMsg.StgMsg msg)
        {
            return msg;
        }
    }

    private enum Functionalities
    {
        Add = "addQuestion",
        Modify = "modifyQuestion",
        Delete = "deleteQuestion",
        Show = "showQuestion",
        Login = "login",
    }
}
