using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Mapping
{
    class Question
    {
        private int id { get; set; }
        private string description { get; set; }
        private List<Answer> listAnswer { get; set; }
        private Feature feature { get; set; }
        private int order { get; set; }

        public Question( )
        {
           
        }
        
    }
}
