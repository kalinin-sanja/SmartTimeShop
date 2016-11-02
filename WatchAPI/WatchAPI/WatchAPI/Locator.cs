using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WatchAPI.Mappers;
using WatchAPI.Models;
using WatchAPI.Repositories;
using WatchAPI.Services;

namespace WatchAPI
{
    public interface ILocator
    {
        RepositoryUoW RepoUoW { get; }
        ServiceUoW ServiceUoW { get; }
        MapperUoW MapperUoW { get; }
    }

    public class Locator : ILocator
    {
        public Locator(WatchShopModel context)
        {
            Context = context;
        }

        protected WatchShopModel Context { get; }

        public RepositoryUoW RepoUoW => new RepositoryUoW(Context);
        public ServiceUoW ServiceUoW => new ServiceUoW(this);
        public MapperUoW MapperUoW => new MapperUoW(this);
    }
}