using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WatchAPI.Mappers;
using WatchAPI.Repositories;

namespace WatchAPI.Services
{
    public abstract class BaseService
    {
        //private ILocator Locator;

        protected BaseService(ILocator locator)
        {
            RepositoryUoW = locator.RepoUoW;
            MapperUoW = locator.MapperUoW;
        }

        public RepositoryUoW RepositoryUoW { get; }
        public MapperUoW MapperUoW { get; }
    }
}