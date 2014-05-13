using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Mapping
{
    class Job
    {
        private int id { get; set; }
        private string name { get; set; }
        private string description{get; set;}
        private List<Feature> listFeature { get; set; }

        public void addFeature(string featureName, int weight)
        {
            this.listFeature.Add(new Feature(featureName, weight));
        }

        public Job(List<Feature> listFeature)
        {
            this.listFeature = listFeature;
        }
    }
}
