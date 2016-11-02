using System.Collections.Generic;
using Newtonsoft.Json;
using WatchAPI.Models;
using WatchAPI.ModelView;

namespace WatchAPI.Mappers
{
    public interface IModelMapper<TIn, TOut>
    {
        TOut Map(TIn entry);
    }

    public abstract class ModelMapper<TIn, TOut> : IModelMapper<TIn, TOut>
    {
        public abstract TOut Map(TIn entry);
    }

    public class WatchMapper : ModelMapper<WatchDb, Watch>
    {
        public override Watch Map(WatchDb entry)
        {
            var colors = entry.Colors != null
                ? JsonConvert.DeserializeObject<List<Color>>(entry.Colors)
                : null;

            var pictureUrls = entry.PictureUrls != null
                ? JsonConvert.DeserializeObject<List<string>>(entry.PictureUrls)
                : null;

            var screenSizes = entry.SreenSizes != null
                ? JsonConvert.DeserializeObject<List<int>>(entry.SreenSizes)
                : null;

            return new Watch
            {
                Id = entry.Id,
                Name = entry.Name,
                Colors = colors,
                Desc = entry.Desc,
                HasScreen = entry.HasScreen,
                Model = entry.Model,
                OS = entry.OS,
                PictureUrls = pictureUrls,
                Price = entry.Price,
                Producer = entry.Producer,
                Rating = entry.Rating,
                SreenSizes = screenSizes
            };
        }

        public WatchDb InverseMap(Watch entry)
        {
            return new WatchDb
            {
                Id = entry.Id,
                Name = entry.Name,
                Colors = JsonConvert.SerializeObject(entry.Colors),
                Desc = entry.Desc,
                HasScreen = entry.HasScreen,
                Model = entry.Model,
                OS = entry.OS,
                PictureUrls = JsonConvert.SerializeObject(entry.PictureUrls),
                Price = entry.Price,
                Producer = entry.Producer,
                Rating = entry.Rating,
                SreenSizes = JsonConvert.SerializeObject(entry.SreenSizes)
            };
        }
    }
}