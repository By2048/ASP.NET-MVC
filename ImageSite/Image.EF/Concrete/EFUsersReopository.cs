using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Image.EF.Abstract;

namespace Image.EF.Concrete
{
    public class EFUsersReopository:IUsersReopository
    {
        private ImageSiteEntities db = new ImageSiteEntities();
        public IQueryable<Users> Users
        {
            get { return db.Users; }
        }

        public void AddFavorite(int userId, int folderId)
        {
            throw new NotImplementedException();
        }

        public void AddUser(Users user)
        {
            throw new NotImplementedException();
        }

        public void ChangeUser(Users oldUser, Users newUser)
        {
            throw new NotImplementedException();
        }

        public void ChangeUserInfo(Users oldUser, Users newUser)
        {
            throw new NotImplementedException();
        }

        public void DelFavorite(int userId, int folderId)
        {
            throw new NotImplementedException();
        }

        public void DelUser(int userId)
        {
            throw new NotImplementedException();
        }

        public Users Login(string userName, string passWord)
        {
            Users user = db.Users.FirstOrDefault(tmp => tmp.UserName == userName && tmp.PassWord==passWord);
            if (user != null)
                return user;
            else
                return null;
        }
    }
}
