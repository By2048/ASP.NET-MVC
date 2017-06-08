using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Image.EF.Abstract;

namespace Image.EF.Concrete
{
    public class EFFoldersReopository:IFoldersReopository
    {
        private ImageSiteEntities db = new ImageSiteEntities();
        public IQueryable<Folders> Folders
        {
            get { return db.Folders; }
        }
    }
}
