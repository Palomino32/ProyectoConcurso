using Common;
using DataAccess;

namespace Domain
{
    public class QuestionModel
    {
        QuestionDao questionDao = new QuestionDao();
        public List<Question> Questions()
        { 
            return questionDao.GetQuestions();
        }       
    }
}
