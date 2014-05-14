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
        public STGMSG.STGMSG setProfile(STGMSG.STGMSG oMsg)
        {
            this.dal = new DAL.DAL();
            BCQuestionnary oQuestionnary = new BCQuestionnary();
            UserProfile profile = oQuestionnary.setFeatures(dal);
           
            /***choix de la premiére question a poser***/
            profile.nextQuestion = this.getNextQuestion(oMsg);
            object[] ArrayProfile = new object[1];
            ArrayProfile.SetValue(profile,0);
            oMsg.setData(ArrayProfile);

            return oMsg;
        }

        

        public void weightProfile(STGMSG.STGMSG oMsg)
        {
          
        }

        /*** appelle les fonction qui choisissent la prochaine question en fonction du poid des features du profil courant***/
        public Question getNextQuestion(STGMSG.STGMSG oMsg)
        {
            object[] ArrayProfile = oMsg.getData();
            UserProfile profile = (UserProfile)ArrayProfile.GetValue(0);
            BCQuestionnary oQuestionnary = new BCQuestionnary();
            Question questionPicked = oQuestionnary.chooseQuestion(profile, this.dal);
            return questionPicked;
            

        }
    }
}
