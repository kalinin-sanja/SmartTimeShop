using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WatchAPI.Mappers;
using WatchAPI.Models;

namespace WatchAPI.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        IQueryable<T> GetRange();
        T Add(T entry);
        ICollection<T> AddRange(ICollection<T> entries);
        //T Update(T entry);
        //ICollection<T> UpdateRange(ICollection<T> entries);
        void Remove(T entry);
        void RemoveRange(ICollection<T> entries);
    }

    public class BaseRepository<T, TContext> : IBaseRepository<T>
        where T : class
        where TContext : DbContext
    {
        public BaseRepository(TContext context)
        {
            Context = context;
        }

        protected TContext Context { get; }

        public virtual IQueryable<T> GetRange()
        {
            return Context.Set<T>().AsQueryable();
        }

        public virtual T Add(T entry)
        {
            return Context.Set<T>().Add(entry);
        }

        public virtual ICollection<T> AddRange(ICollection<T> entries)
        {
            return entries.Select(Add).ToList();
        }

        //public virtual T Update(T entry)
        //{
        //    return Context.Set<T>().Update(entry);
        //}

        //public virtual ICollection<T> UpdateRange(ICollection<T> entries)
        //{
        //    return entries.Select(Update).ToList();
        //}

        public virtual void Remove(T entry)
        {
            Context.Set<T>().Remove(entry);
        }

        public virtual void RemoveRange(ICollection<T> entries)
        {
            foreach (var entry in entries)
            {
                Remove(entry);
            }
        }
    }

    public interface IRepository<T> : IBaseRepository<T>
        where T : class, IIdentityBase
    {
        T Get(long id);
        void Remove(long id);
        void RemoveRange(ICollection<long> ids);
    }

    public class Repository<T, TContext> : BaseRepository<T, TContext>, IRepository<T>
        where T : class, IIdentityBase
        where TContext : DbContext
    {
        protected IAutoDbMapper<T> AutoMapper => new AutoDbMapper<T>();

        public Repository(TContext context) : base(context)
        {
        }

        public virtual T Get(long id)
        {
            return Context.Set<T>().SingleOrDefault(x => x.Id == id);
        }

        //public override T Update(T entry)
        //{
        //    var dbEntry = Get(entry.Id);
        //    dbEntry = AutoMapper.Map(entry, dbEntry);
        //    return Context.Set<T>().Update(dbEntry);
        //}

        public virtual void Remove(long id)
        {
            var entry = Get(id);
            base.Remove(entry);
        }

        public virtual void RemoveRange(ICollection<long> ids)
        {
            foreach (var id in ids)
            {
                Remove(id);
            }
        }

        public override void Remove(T entry)
        {
            var dbEntry = Get(entry.Id);
            base.Remove(dbEntry);
        }
    }
}