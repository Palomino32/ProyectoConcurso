using Common;
using DataAccess;

namespace Domain
{
    public class UserDataModel
    {
        UserDataDao userDataDao = new UserDataDao();
        public List<UserData> UserDatas()
        {
            return userDataDao.GetUserDatas();
        }

        public bool AddData(UserData data)
        {
            return userDataDao.AddUserData(data);
        }
    }
}
