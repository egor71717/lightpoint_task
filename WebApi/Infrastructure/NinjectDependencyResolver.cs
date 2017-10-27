using Lightpoint.Task.DAL.Interface;
using Lightpoint.Task.DAL.Repository;
using Ninject;
using Ninject.Web.WebApi;
using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;

namespace WebApi.Infrastructure
{
    public class NinjectDependencyResolver : System.Web.Http.Dependencies.IDependencyResolver,  System.Web.Mvc.IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public IDependencyScope BeginScope()
        {
            return new NinjectDependencyScope(this.kernel.BeginBlock());
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            kernel.Bind<IUnitOfWork>().To<EFUnitOfWork>().InSingletonScope();
        }

        public void Dispose()
        {
        }
    }

}