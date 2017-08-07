using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Image.EF.Concrete;

namespace Image.EF.Abstract
{
    public interface IAdminsReopository
    {
        void AddUser(Users user);
        void DelUser(int userId);
        void ChangeUserInfo(Users oldInfo, Users newInfo);

        void AddFolder(Folders folder);
        void DelFolder(int folderId);
        void ChangeFolderInfo(Folders oldInfo, Folders newInfo);

        IQueryable<Favorites> GetUserFavorites(int userId);

    }
}
