using System.Linq;
using WatchAPI.Models;

namespace WatchAPI.Mappers
{
    public interface IAutoDbMapper<T>
        where T : IIdentityBase
    {
        T Map(T fromEntry, T inEntry);
    }

    public class AutoDbMapper<T> : IAutoDbMapper<T>
        where T : IIdentityBase
    {
        public T Map(T fromEntry, T inEntry)
        {
            var baseProperties = typeof(IIdentityBase).GetProperties().Select(x => x.Name).ToList();
            var properties = typeof(T).GetProperties()
                .Where(x => x.CanRead && x.CanWrite)
                .Where(x => !baseProperties.Contains(x.Name));

            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetMethod.Invoke(fromEntry, null);
                propertyInfo.SetMethod.Invoke(inEntry, new[] {value});
            }

            return inEntry;
        }
    }
}