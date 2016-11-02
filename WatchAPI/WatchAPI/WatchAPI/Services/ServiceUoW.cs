namespace WatchAPI.Services
{
    public class ServiceUoW
    {
        protected ILocator Locator;
        public WatchService WatchService => new WatchService(Locator);

        public ServiceUoW(ILocator locator)
        {
            Locator = locator;
        }

    }
}