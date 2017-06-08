using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Image.EF.Concrete;

namespace Image.EF.Abstract
{
    public interface IFavoritesReopository
    {
        IQueryable<Favorites> Favorites { get; }
        bool AddFavorites(int fodlerId,int userId);
        bool IsAddFavorites(int folderId, int userId);
        bool DelFavorites(int folderId, int userId);

    }
}
