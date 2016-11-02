using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WatchAPI.Models;

namespace WatchAPI.Repositories
{
    public class RepositoryUoW
    {
        public WatchShopModel Context { get; }
        public WatchRepository WatchRepository => new WatchRepository(Context);

        public RepositoryUoW(WatchShopModel context)
        {
            Context = context;
        }

        public void Save()
        {
            Context.SaveChanges();
        }

        public IRepository<T> GetRepo<T>() where T : class, IIdentityBase
        {
            var property = typeof(RepositoryUoW).GetProperties()
                .FirstOrDefault(x => x.Name.StartsWith(typeof(T).Name));
            return property?.GetValue(this) as IRepository<T>
                ?? new Repository<T, WatchShopModel>(Context);
        }

        public IBaseRepository<T> GetBaseRepo<T>() where T : class
        {
            return new BaseRepository<T, WatchShopModel>(Context);
        }
    }
}