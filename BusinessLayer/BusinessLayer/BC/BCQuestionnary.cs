using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Mapping
{
    class BCQuestionnary : abstractBC
    {
   
            public UserProfile setFeatures(DAL.IDAL dal)
            {
                UserProfile profile = new UserProfile();
                profile.setFeatures(dal);

                return profile;
            }
            
           
            
            public void weightProfileFeature()
            {

            }

         /***choisi de maniére pertinente la prochaine question a poser en fonction des caractéristiques du joueur, et retourne la prochaine question
          * avec les réponces correspondantes***/
            public Question chooseQuestion(UserProfile profile, DAL.IDAL dal)
            {
                Question questionPicked = new Question();
                List<Question> listQuestion = questionPicked.getAllQuestions(dal);
                bool found = false;
                
                    foreach (Question curentQuestion in listQuestion)
                    {
                        foreach (Feature eachFeature in profile.listFeature)
                        {
                            if ((curentQuestion.feature == eachFeature)&&(eachFeature.weight > 5)
                                 &&(this.questionAsked(curentQuestion, profile.listAskedQuestion)))
                            {
                                found = true;
                            }

                        }
                        if (found == true)
                        {
                            questionPicked = curentQuestion;
                            break;
                        }
                    }
                   questionPicked.listAnswer =  questionPicked.getAnswers(dal);
                   
                    return questionPicked;
                
            }

            private bool questionAsked(Question question, List<Question> askedQuestion)
            {
                bool found = false;
                foreach (Question eachQuestion in askedQuestion)
                {
                    if (question.id == eachQuestion.id)
                    {
                       found = true;
                    }
                }
                return found;
            }
    }
}
