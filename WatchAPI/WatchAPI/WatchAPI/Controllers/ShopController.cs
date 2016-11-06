using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WatchAPI.Models;
using WatchAPI.ModelView;

namespace WatchAPI.Controllers
{
    public class ShopController : BaseController
    {
        public ShopController(ILocator locator) : base(locator)
        {
        }

        public ActionResult AddWatches()
        {
            using (var context = new WatchShopModel())
            {
                var watchesList = new List<Watch>()
                {
                    new Watch()
                    {
                        Name = "Apple - Apple Watch™ Sport 38mm Silver Aluminum Case - White Sports Band",
                        Producer = "Apple",
                        Model = "MJ3T2LL/A",
                        Rating = 4.7,
                        HasScreen = true,
                        SreenSizes = new List<int> {42},
                        Colors = new List<Color> {new Color {Hex = "#c3c4c4", Name = "Space Gray Sports Band"}},
                        Price = 299.00M,
                        OS = "Apple iOS",
                        PictureUrls = new List<string>()
                        {
                            "http://pisces.bbystatic.com/image2/BestBuy_US/images/products/4274/4274802_rd.jpg;maxHeight=550;maxWidth=642",
                            "http://pisces.bbystatic.com/image2/BestBuy_US/images/products/4274/4274802_bd.jpg;maxHeight=550;maxWidth=642",
                            "http://pisces.bbystatic.com/image2/BestBuy_US/images/products/4274/4274802cv1d.jpg;maxHeight=550;maxWidth=642"
                        },
                        Desc =
                            "Apple Watch (first-generation) is an incredibly customizable timepiece, has entirely new ways to stay in touch, and is a comprehensive health and fitness companion."
                    },
                    new Watch()
                    {
                        Name = "Apple - Apple Watch Sport 42mm Silver Aluminum Case - White Sports Band",
                        Producer = "Apple",
                        Model = "MJ3N2LL/A",
                        Rating = 4.7,
                        HasScreen = true,
                        SreenSizes = new List<int> {38, 42},
                        Colors = new List<Color>
                        {
                            new Color {Hex = "#fff", Name = "White Sports Band"},
                            new Color {Hex = "#1646a8", Name = "Scuba Blue Woven Nylon Band"},
                        },
                        Price = 349.00M,
                        OS = "Apple iOS",
                        PictureUrls = new List<string>()
                        {
                            "http://pisces.bbystatic.com/image2/BestBuy_US/images/products/4274/4274601_rd.jpg;maxHeight=550;maxWidth=642",
                            "http://pisces.bbystatic.com/image2/BestBuy_US/images/products/4274/4274601_bd.jpg;maxHeight=550;maxWidth=642",
                            "http://pisces.bbystatic.com/image2/BestBuy_US/images/products/4274/4274601cv1d.jpg;maxHeight=550;maxWidth=642"
                        },
                        Desc =
                            "Apple Watch is an incredibly customizable timepiece, has entirely new ways to stay in touch, and is a comprehensive health and fitness companion."
                    },
                    new Watch()
                    {
                        Name =
                            "Apple - Apple - Apple Watch (first-generation) 42mm Space Black Stainless Steel Case - Black Sport Band - Black Sport Band",
                        Producer = "Apple",
                        Model = "MLC82LL/A",
                        Rating = 4.7,
                        HasScreen = true,
                        SreenSizes = new List<int> {42},
                        Colors = new List<Color>
                        {
                            new Color {Hex = "#c3c4c4", Name = "Space Gray Sports Band"},
                        },
                        Price = 599.00M,
                        OS = "Apple iOS",
                        PictureUrls = new List<string>()
                        {
                            "http://pisces.bbystatic.com/image2/BestBuy_US/images/products/4469/4469200_rd.jpg;maxHeight=550;maxWidth=642",
                            "http://pisces.bbystatic.com/image2/BestBuy_US/images/products/4469/4469200_bd.jpg;maxHeight=550;maxWidth=642",
                            "http://pisces.bbystatic.com/image2/BestBuy_US/images/products/4469/4469200cv11d.jpg;maxHeight=550;maxWidth=642"
                        },
                        Desc =
                            "Apple Watch (first-generation) is an incredibly customizable timepiece, has entirely new ways to stay in touch, and is a comprehensive health and fitness companion."
                    },
                    new Watch()
                    {
                        Name = "Samsung - Gear S2 Classic Smartwatch 40mm Stainless Steel - Rose Gold",
                        Producer = "Samsung",
                        Model = "SM-R7320ZDAXAR",
                        Rating = 4.5,
                        HasScreen = false,
                        Colors = new List<Color>
                        {
                            new Color {Hex = "#ECD0C4", Name = "Gold"},
                            new Color {Hex = "#C9CACE", Name = "Grey"},
                        },
                        Price = 349.99M,
                        PictureUrls = new List<string>()
                        {
                            "http://pisces.bbystatic.com/image2/BestBuy_US/images/products/4917/4917304_sd.jpg;maxHeight=550;maxWidth=642",
                        },
                        Desc =
                            "This Samsung Gear smart watch features a rose gold color for a fashionable statement. The watch integrates with Samsung smartphones to display notifications and messages, track health and make mobile payments using Samsung Pay. This Samsung Gear smart watch has 4GB of internal memory, letting you store up to 300 songs so you can listen to music on the go."
                    },
                    new Watch()
                    {
                        Name = "Pebble - Time Steel Smartwatch 38mm Leather - Black Leather",
                        Producer = "Pebble",
                        Model = "PBSTLTM-BLK",
                        Rating = 4.6,
                        HasScreen = true,
                        SreenSizes = new List<int> {38},
                        Colors = new List<Color>
                        {
                            new Color {Hex = "#66615D", Name = "Grey"},
                        },
                        Price = 179.99M,
                        PictureUrls = new List<string>()
                        {
                            "http://pisces.bbystatic.com/image2/BestBuy_US/images/products/8192/8192054_sa.jpg;maxHeight=550;maxWidth=642",
                            "http://pisces.bbystatic.com/image2/BestBuy_US/images/products/8192/8192054_ra.jpg;maxHeight=550;maxWidth=642",
                            "http://pisces.bbystatic.com/image2/BestBuy_US/images/products/8192/8192054_ba.jpg;maxHeight=550;maxWidth=642",
                            "http://pisces.bbystatic.com/image2/BestBuy_US/images/products/8192/8192054cv12a.jpg;maxHeight=550;maxWidth=642"
                        },
                        Desc =
                            "Pebble Time Steel Smartwatch 38mm Leather: Everything you need to manage another busy day is right at your wrist with a timeline interface that keeps you apprised of appointments and events. Includes Pebble Health to seamlessly track activity and sleep patterns. Send messages by speaking for hands-free communication."
                    },
                    new Watch()
                    {
                        Name = "Pebble - Time Steel Smartwatch 38mm Leather - Silver",
                        Producer = "",
                        Model = "PBSTLTM-SLV",
                        Rating = 4.6,
                        HasScreen = true,
                        SreenSizes = new List<int> {38},
                        Colors = new List<Color>
                        {
                            new Color {Hex = "#A39D8D", Name = "Grey"},
                        },
                        Price = 199.99M,
                        PictureUrls = new List<string>()
                        {
                            "http://pisces.bbystatic.com/image2/BestBuy_US/images/products/8191/8191838_sa.jpg;maxHeight=550;maxWidth=642",
                            "http://pisces.bbystatic.com/image2/BestBuy_US/images/products/8191/8191838_ra.jpg;maxHeight=550;maxWidth=642",
                            "http://pisces.bbystatic.com/image2/BestBuy_US/images/products/8191/8191838le.jpg;maxHeight=550;maxWidth=642"
                        },
                        Desc =
                            "Pebble Time Steel Smartwatch 38mm Leather: Everything you need to manage another busy day is right at your wrist with a timeline interface that keeps you apprised of appointments and events. Includes Pebble Health to seamlessly track activity and sleep patterns. Send messages by speaking for hands-free communication."
                    },
                    new Watch()
                    {
                        Name = "Asus - ZenWatch 2 WI501Q Smartwatch Gunmetal",
                        Producer = "Asus",
                        Model = "WI501Q-2J-GB2",
                        Rating = 4.5,
                        HasScreen = false,
                        Colors = new List<Color>
                        {
                            new Color {Hex = "#3D3D3D", Name = "Black"},
                        },
                        Price = 149.99M,
                        PictureUrls = new List<string>()
                        {
                            "http://pisces.bbystatic.com/image2/BestBuy_US/images/products/5251/5251901_rd.jpg;maxHeight=550;maxWidth=642",
                            "http://pisces.bbystatic.com/image2/BestBuy_US/images/products/5251/5251901ld.jpg;maxHeight=550;maxWidth=642",
                            "http://pisces.bbystatic.com/image2/BestBuy_US/images/products/5251/5251901cv12d.jpg;maxHeight=550;maxWidth=642"
                        },
                        Desc =
                            "Power through the daily grind with this ASUS ZenWatch 2 smart watch. This 1.63-inch AMOLED touch screen watch is IP67-waterproof, so it's safe to wear in the shower while waiting for a very important call. This ASUS ZenWatch 2 smart watch also has a Wellness Suite that lets you plan workout routines, set training goals and track your progress."
                    }
                };

                context.Watches.AddRange(watchesList.Select(w => ServiceUoW.WatchService.MapperUoW.WatchMapper.InverseMap(w)));
                context.SaveChanges();
            }
            return View("Index");
        }

        public ActionResult RemoveAll()
        {
            using (var context = new WatchShopModel())
            {
                context.Watches.RemoveRange(context.Watches.Select(w => w));
                context.SaveChanges();
            }

            return View("Index");
        }

        public JsonResult GetAll()
        {
            var watchList = ServiceUoW.WatchService.GetAll();
            return Json(watchList, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetByName(string query, string field, int offset, int limit, bool desc)
        {
            var watchList = ServiceUoW.WatchService
                .GetByName(query, field, offset, limit, desc);
            return Json(watchList, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetById(int id)
        {
            var watch = ServiceUoW.WatchService.GetById(id);
            return Json(watch, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetWatchCount(string query)
        {
            var watchCount = ServiceUoW.WatchService.GetWatchCount(query);
            return Json(watchCount, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetWatchesOrderByPrice(int offset, int limit, bool desc = false)
        {
            var watchList = ServiceUoW.WatchService.GetWatchesOrderByPrice(offset, limit, desc);
            return Json(watchList, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetWatchesOrderByName(int offset, int limit, bool desc = false)
        {
            var watchList = ServiceUoW.WatchService.GetWatchesOrderByName(offset, limit, desc);
            return Json(watchList, JsonRequestBehavior.AllowGet);
        }
    }
}