﻿namespace YoutubeDersleri.WebUI.Site.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class SearchController : Controller
    {
        public IActionResult Index(string slug)
        {
            return View();
        }
    }
}
