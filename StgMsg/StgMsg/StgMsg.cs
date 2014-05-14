using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StgMsg
{
    public class StgMsg
    {
        public string appName { get; set; }
        public string invoke { get; set; }
        public string pSecurity { get; set; }
        public bool statut { get; set; }
        public string info { get; set; }
        public object[] data { get; set; }
        public string token { get; set; }
        public string servName { get; set; }

        public StgMsg()
        {

        }

    }

}
