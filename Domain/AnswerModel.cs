using Common;
using DataAccess;

namespace Domain
{
    public class AnswerModel
    {
        AnswerDao answerDao = new AnswerDao();
        public List<Answer> Answers()
        {
            return answerDao.GetAnswers();
        }
    }
}
