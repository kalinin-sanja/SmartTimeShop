namespace WatchAPI.Mappers
{
    public class MapperUoW
    {
        protected ILocator Locator { get; }
        public WatchMapper WatchMapper => new WatchMapper();

        public MapperUoW(ILocator locator)
        {
            Locator = locator;
        }
    }
}