using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Mapping
{
    class Feature
    {
        private int id { get; set; }
        private string name { get; set; }
        private int weight {get; set;}

        public Feature()
        {
        }

        public Feature(string name)
        {
            this.name = name;
        }

        public Feature(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }

    }
}
