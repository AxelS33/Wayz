using BusinessLayer.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.WC
{
    class WCQuestionnary : abstractWC
    {
        private DAL.DAL dal;

        /*** défini un profil par défaut, et choisi la premiére question ***/
        public StgMsg.StgMsg setProfile(StgMsg.StgMsg oMsg)
        {
            this.dal = new DAL.DAL();
            BCQuestionnary oQuestionnary = new BCQuestionnary();
            UserProfile profile = oQuestionnary.setFeatures(dal);
           
            /***choix de la premiére question a poser***/
            profile.nextQuestion = this.getNextQuestion(oMsg);
            object[] ArrayProfile = new object[1];
            ArrayProfile.SetValue(profile,0);
            oMsg.data = ArrayProfile;

            return oMsg;
        }


<<<<<<< HEAD

        public void weightProfile(StgMsg.StgMsg oMsg)
=======
        public void weightProfile( StgMsg.StgMsg oMsg)
>>>>>>> 6569d5e954a4e084669c5d460b3e24ec0e204c13
        {
          
        }

        /*** appelle les fonction qui choisissent la prochaine question en fonction du poid des features du profil courant***/
        public Question getNextQuestion(StgMsg.StgMsg oMsg)
        {
            object[] ArrayProfile = oMsg.data;
            UserProfile profile = (UserProfile)ArrayProfile.GetValue(0);
            BCQuestionnary oQuestionnary = new BCQuestionnary();
            Question questionPicked = oQuestionnary.chooseQuestion(profile, this.dal);
            return questionPicked;
            

        }
    }
}
