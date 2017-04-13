using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Rozliczenia.Models;
using Rozliczenia.Models.EF;
using Rozliczenia.Models.Interfaces;
using Ninject;

namespace Rozliczenia.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private readonly IKernel _kernel;

        public NinjectDependencyResolver()
        {
            _kernel = new StandardKernel();
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            _kernel.Bind<IDataModelEF>().To<DataModelEF>();

            _kernel.Bind<IWplaty>().To<WplatyService>();

            _kernel.Bind<INaleznosci>().To<NaleznosciService>();

            _kernel.Bind<IRozliczenie>().To<RozliczenieService>();
            _kernel.Bind<IParowanie>().To<ParowanieService>();
        }
    }
}