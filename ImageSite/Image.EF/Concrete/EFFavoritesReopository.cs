using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Image.EF.Abstract;

namespace Image.EF.Concrete
{
    public class EFFavoritesReopository:IFavoritesReopository
    {
        private ImageSiteEntities db = new ImageSiteEntities();
        public IQueryable<Favorites> Favorites
        {
            get { return db.Favorites; }
        }

        public bool AddFavorites(int folderId, int userId)
        {
            Users user = db.Users.FirstOrDefault(tmp => tmp.Id == userId);
            Folders folder = db.Folders.FirstOrDefault(tmp => tmp.Id == folderId);
            Favorites favorite = db.Favorites.FirstOrDefault(tmp => tmp.UserId == userId && tmp.FolderId == folderId);
            if (favorite != null || folder == null || user==null)
            {
                return false;
            }
            else
            {
                Favorites newFavorite = new Favorites();
                newFavorite.UserId = userId;
                newFavorite.UserName = user.UserName;
                newFavorite.FolderId = folderId;
                newFavorite.FolderName = folder.Name;
                newFavorite.CollectionDate = DateTime.Now;
                db.Favorites.Add(newFavorite);
            }
            db.SaveChanges();
            return true;
        }
        public bool IsAddFavorites(int folderId, int userId)
        {
            Favorites favorite = db.Favorites.FirstOrDefault(tmp => tmp.UserId == userId && tmp.FolderId == folderId);
            if (favorite == null )
                return false;
            else
                return true;           
        }
        public bool DelFavorites(int folderId, int userId)
        {
            Favorites favorite = db.Favorites.FirstOrDefault(tmp => tmp.UserId == userId && tmp.FolderId == folderId);
            if (favorite != null)
            {
                db.Favorites.Remove(favorite);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;               
            }
        }

       
    }
}
