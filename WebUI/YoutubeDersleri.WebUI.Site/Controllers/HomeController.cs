namespace YoutubeDersleri.WebUI.Site.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Threading.Tasks;
    using YoutubeDersleri.WebUI.Site.Models;

    public class HomeController : Controller
    {
        public IActionResult Index(string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                return View(new Unsplash());
            }

            var wc = new WebClient();
            var json = wc.DownloadString($"https://unsplash.com/napi/search/photos?query={query}&per_page=20&page=1&xp=");

            var json_model = JsonConvert.DeserializeObject<Unsplash>(json);

            return View(json_model);
        }
    }
}
