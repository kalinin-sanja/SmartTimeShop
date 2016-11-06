using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using WatchAPI.Models;

namespace WatchAPI.Repositories
{
    public class WatchRepository : Repository<WatchDb, WatchShopModel>
    {

        public WatchRepository(WatchShopModel context) : base(context)
        {
        }

        public IEnumerable<WatchDb> GetByQuery(string name, string field, int offset, int limit, bool desc)
        {
            IQueryable<WatchDb> watches = Context.Watches;

            watches = string.IsNullOrEmpty(name)
                ? watches.Select(w => w)
                : watches.Where(w => w.Name.ToLower()
                        .Contains(name.ToLower()));

            if (field == "Price")
            {
                watches = desc
                    ? watches.OrderByDescending(w => w.Price)
                    : watches.OrderBy(w => w.Price);
            }
            else
            {
                watches = desc
                    ? watches.OrderByDescending(w => w.Name)
                    : watches.OrderBy(w => w.Name);
            }

            return watches.Skip(offset)
                .Take(limit)
                .ToList();
        }

        public IEnumerable<WatchDb> GetAll()
        {
            return Context.Watches.Select(w => w).ToList();
        }

        public int GetWatchCount(string query)
        {
            if (!string.IsNullOrEmpty(query))
                return Context.Watches
                    .Count(w => w.Name.ToLower()
                        .Contains(query.ToLower()));

            return Context.Watches.Select(w => w).Count();
        }

    }
}