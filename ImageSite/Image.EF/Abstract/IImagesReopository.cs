using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Image.EF.Concrete;

namespace Image.EF.Abstract
{
    public interface IImagesReopository
    {
        IQueryable<Images> Images { get; }
    }
}
