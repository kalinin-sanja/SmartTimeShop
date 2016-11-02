using System.Collections.Generic;

namespace WatchAPI.ModelView
{
    public class Watch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Producer { get; set; }
        public string Model { get; set; }
        public double Rating { get; set; }
        public bool HasScreen { get; set; }
        public List<int> SreenSizes { get; set; }
        public virtual List<Color> Colors { get; set; }
        public decimal Price { get; set; }
        public string OS { get; set; }
        public List<string> PictureUrls { get; set; }
        public string Desc { get; set; }
    }
}