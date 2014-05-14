using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Mapping
{
    class Question
    {
        public int id { get; set; }
        private string description { get; set; }
        public List<Answer> listAnswer { get; set; }
        public Feature feature { get; set; }
        private int order { get; set; }

        public Question( )
        {
           
        }

        /*** récupére toute la liste des questions ainsi que la feature de la question en fonction de l'ID..**/
        public List<Question> getAllQuestions(DAL.IDAL dal)
        {
            List<Question> allQuestions = new List<Question>();
            SqlDataReader questionReader = dal.getAllQuestions();
            while (questionReader.Read())
            {
                Question question = new Question();
                question.id = (int)questionReader["idQuestion"];
                question.feature = new Feature(question.id);
                question.feature = question.feature.getFeatureByID(dal);
                allQuestions.Add(question);

            }
            questionReader.Close();
            return allQuestions;
        }






        public List<Answer> getAnswers(DAL.IDAL dal)
        {
            List<Answer> listAnswer = new List<Answer>;
            SqlDataReader answerReader = dal.getAnswers(this.id);
            while (answerReader.Read())
            {
                Answer answer = new Answer();
                answer.id = (int) answerReader["idAnswer"];
                answer.description = (string) answerReader["descriptionAnswer"];
                answer.weight = (int) answerReader["weightAnswer"];
                listAnswer.Add(answer);
            }
            answerReader.Close();
            return listAnswer;
        }
    }
}
