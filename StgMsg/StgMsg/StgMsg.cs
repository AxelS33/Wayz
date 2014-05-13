using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StgMsg
{
    public class StgMsg
    {
        private string appName { get; set; } 
        private string invoke { get; set; }
        private string pSecurity { get; set; }
        private bool statut { get; set; }
        private string info { get; set; }
        private object[] data { get; set; }
        private string token { get; set; }
        private string servName { get; set; }

    }
    public StgMsg() 
    {
        
    }
}
