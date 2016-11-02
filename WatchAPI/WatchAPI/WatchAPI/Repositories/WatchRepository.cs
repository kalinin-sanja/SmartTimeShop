using System.Collections.Generic;
using System.Linq;
using WatchAPI.Models;

namespace WatchAPI.Repositories
{
    public class WatchRepository : Repository<WatchDb, WatchShopModel>
    {

        public WatchRepository(WatchShopModel context) : base(context)
        {
        }

        public IEnumerable<WatchDb> GetByName(string name)
        {
            return Context.Watches.Where(w => w.Name.ToLower()
                    .StartsWith(name.ToLower()))
                    .ToList();
        }

        public IEnumerable<WatchDb> GetAll()
        {
            return Context.Watches.Select(w => w).ToList();
        }

    }
}