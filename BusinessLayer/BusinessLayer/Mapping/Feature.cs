using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Mapping
{
    class Feature
    {
        private int id { get; set; }
        private string name { get; set; }
        public int weight {get; set;}


        public Feature(int id)
        {
            this.id = id;
        }

        public Feature getFeatureByID(DAL.IDAL dal)
        {
       //   SqlDataReader featureReader =  dal.getFeatureByID(this.id);
          this.name = (string)featureReader["nameFeature"];

          return this;
        }

        public Feature(string name)
        {
            this.name = name;
        }

        public Feature(int id, string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }


      
    }
}
