﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WatchAPI.Models;
using WatchAPI.Repositories;

namespace WatchAPI.Util
{
    using Ninject;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Web.Mvc;

    namespace IoSApp.Util
    {
        public class NinjectDependencyResolver : IDependencyResolver
        {
            private IKernel kernel;
            public NinjectDependencyResolver(IKernel kernelParam)
            {
                kernel = kernelParam;
                AddBindings();
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
                kernel.Bind<ILocator>().To<Locator>();
            }
        }
    }
}