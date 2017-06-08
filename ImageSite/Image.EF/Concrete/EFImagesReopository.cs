using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Image.EF.Abstract;

namespace Image.EF.Concrete
{
    public class EFImagesReopository:IImagesReopository
    {
        private ImageSiteEntities db = new ImageSiteEntities();
        public IQueryable<Images> Images
        {
            get { return db.Images; }
        }
    }
}
