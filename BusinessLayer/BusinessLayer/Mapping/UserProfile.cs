using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Reflection;
using DAL;
using System.Data.SqlClient;

namespace BusinessLayer.Mapping
{
    class UserProfile
    {
        public List<Feature> listFeature { get; set; }
        public Question lastQuestion;
        public Question nextQuestion;
        public List<Question> listAskedQuestion;

        public Question getLastQuestion()
        {
            return this.lastQuestion;
        }

        public UserProfile()
        {
            this.listFeature = new List<Feature>();
            this.listAskedQuestion = new List<Question>();
        }

        public void setFeatures(DAL.IDAL dal)
        {
           
            SqlDataReader featuresDataReader = dal.getFeatures();

            while(featuresDataReader.Read())
            {
                string featureName = (string) featuresDataReader["nameFeature"];
                int weight = 0;
                int idFeature = (int)featuresDataReader["idFeature"];

                Feature feature = new Feature(idFeature, featureName, weight);
                this.listFeature.Add(feature);
              
            }
            featuresDataReader.Close();

        }

        
    }
}
