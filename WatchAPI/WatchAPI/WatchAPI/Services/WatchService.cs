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

        public IEnumerable<Watch> GetByName(string text)
        {
            var dbEntries = RepositoryUoW.WatchRepository.GetByName(text);
            return dbEntries.Select(w => MapperUoW.WatchMapper.Map(w));
        }

        public IEnumerable<Watch> GetAll()
        {
            var dbEntries = RepositoryUoW.WatchRepository.GetAll();
            return dbEntries.Select(w => MapperUoW.WatchMapper.Map(w));
        }
    }
}