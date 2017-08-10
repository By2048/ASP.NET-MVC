using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;
using System.Web.Mvc;
using Image.EF.Abstract;
using Image.EF.Concrete;


namespace Image.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }
        private void AddBindings()
        {
            //接口与实现类的绑定配置                       
            kernel.Bind<IImagesReopository>().To<EFImagesReopository>();
            kernel.Bind<IFoldersReopository>().To<EFFoldersReopository>();
            kernel.Bind<IUsersReopository>().To<EFUsersReopository>();
            kernel.Bind<IFavoritesReopository>().To<EFFavoritesReopository>();
            kernel.Bind<IAdminsReopository>().To<EFAdminsReopository>();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
            //throw new NotImplementedException();
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
            //throw new NotImplementedException();
        }
    }
}