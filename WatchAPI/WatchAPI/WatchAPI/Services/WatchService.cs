using System.Collections.Generic;
using System.Linq;
using WatchAPI.ModelView;

namespace WatchAPI.Services
{
    public class WatchService : BaseService
    {

        public WatchService(ILocator locator) : base(locator)
        {
        }

        public IEnumerable<Watch> GetByName(string query, string field, int offset, int limit, bool desc)
        {
            var dbEntries = RepositoryUoW.WatchRepository
                .GetByName(query, field, offset, limit, desc);
            return dbEntries.ToList().Select(w => MapperUoW.WatchMapper.Map(w));
        }

        public IEnumerable<Watch> GetAll()
        {
            var dbEntries = RepositoryUoW.WatchRepository.GetAll();
            return dbEntries.Select(w => MapperUoW.WatchMapper.Map(w));
        }

        public Watch GetById(int id)
        {
            var entry = RepositoryUoW.WatchRepository.Get(id);
            return entry != null
                ? MapperUoW.WatchMapper.Map(entry)
                : null;
        }

        public int GetWatchCount(string query)
        {
            return RepositoryUoW.WatchRepository.GetWatchCount(query);
        }

        public IEnumerable<Watch> GetWatchesOrderByPrice(int offset, int limit, bool desc)
        {
            var dbEntries = RepositoryUoW.WatchRepository
                .GetWatchesOrderByPrice(offset, limit, desc);
            return dbEntries.Select(w => MapperUoW.WatchMapper.Map(w));
        }

        public IEnumerable<Watch> GetWatchesOrderByName(int offset, int limit, bool desc)
        {
            var dbEntries = RepositoryUoW.WatchRepository
                .GetWatchesOrderByName(offset, limit, desc);
            return dbEntries.Select(w => MapperUoW.WatchMapper.Map(w));
        }
    }
}