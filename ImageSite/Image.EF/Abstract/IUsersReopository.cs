using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Image.EF.Concrete;

namespace Image.EF.Abstract
{
    public interface IUsersReopository
    {
        IQueryable<Users> Users{ get; }
        void AddUser(Users user);
        void DelUser(int userId);
        Users Login(string userName, string passWord);
        void AddFavorite(int userId, int folderId);
        void DelFavorite(int userId, int folderId);
        void ChangeUserInfo(Users oldUser, Users newUser);
    }
}
