namespace WatchAPI.Models
{
    public class WatchDb : IIdentityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Producer { get; set; }
        public string Model { get; set; }
        public double Rating { get; set; }
        public bool HasScreen { get; set; }
        public string SreenSizes { get; set; }
        public virtual string Colors { get; set; }
        public decimal Price { get; set; }
        public string OS { get; set; }
        public string PictureUrls { get; set; }
        public string Desc { get; set; }
    }
}