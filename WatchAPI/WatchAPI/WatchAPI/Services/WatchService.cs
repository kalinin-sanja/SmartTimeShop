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

        public IEnumerable<Watch> GetByName(string query)
        {
            var dbEntries = RepositoryUoW.WatchRepository.GetByName(query);
            return dbEntries.Select(w => MapperUoW.WatchMapper.Map(w));
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
    }
}