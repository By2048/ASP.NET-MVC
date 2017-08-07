using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Image.EF.Abstract;

namespace Image.EF.Concrete
{
    public class EFAdminsReopository : IAdminsReopository
    {
        private ImageSiteEntities db = new ImageSiteEntities();

        public void AddFolder(Folders folder)
        {
            throw new NotImplementedException();
        }

        public void AddUser(Users user)
        {
            throw new NotImplementedException();
        }

        public void ChangeFolderInfo(Folders oldInfo, Folders newInfo)
        {
            throw new NotImplementedException();
        }

        public void ChangeUserInfo(Users oldInfo, Users newInfo)
        {
            throw new NotImplementedException();
        }

        public void DelFolder(int folderId)
        {
            throw new NotImplementedException();
        }

        public void DelUser(int userId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Favorites> GetUserFavorites(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
