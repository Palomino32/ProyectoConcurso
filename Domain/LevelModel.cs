using Common;
using DataAccess;

namespace Domain
{
    public class LevelModel
    {
        LevelDao levelDao = new LevelDao();
        public List<Level> Levels()
        {
            return levelDao.GetLevels();
        }
    }
}
