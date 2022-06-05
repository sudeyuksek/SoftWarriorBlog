﻿namespace Blog.WebUI.Management.Controllers
{
    using Microsoft.AspNetCore.Authentication;
    using Microsoft.AspNetCore.Authentication.Cookies;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Claims;
    using Blog.Data;
    using Blog.Extensions.MediaHelper;
    using Blog.WebUI.Management.Authorize;
    using Blog.WebUI.Management.Models;

    public class HomeController : Controller
    {
        AuthorData _authorData;

        public HomeController(AuthorData _authorData)
        {
            this._authorData = _authorData;
        }

        public IActionResult Index()
        {
            var image_helper = new FileUploader();

            var local_image_path = $"wwwroot/_uploads/images/image.jpg";
            var base_64_result = image_helper.UploadCdn(local_image_path);

            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            var image_helper = new ImageHelper();

            var local_image_path = $"wwwroot/_uploads/images/image.jpg";
            var base_64_result = image_helper.Crop(600, 300, local_image_path);

            var model = new LoginModel()
            {
                Password = "",
                Username = "",
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var errors = new List<string>();
            var return_model = new LoginModel();

            if (string.IsNullOrEmpty(username)) errors.Add("Kullanıcı Boş Bırakılamaz");
            if (string.IsNullOrEmpty(password)) errors.Add("Şifre Boş Bırakılamaz");
            if (errors.Count() > 0)
            {
                ViewBag.Result = new ViewModelResult(false, "Hata Oluştu", errors);
                return View(return_model);
            }

            var author = _authorData.GetBy(x => x.Username == username && x.Password == password && x.IsActive && !x.IsDeleted).FirstOrDefault();
            if(author == null)
            {
                ViewBag.Result = new ViewModelResult(false, "Böyle bir kullanıcı bulunamadı");
                return_model.Username = username;
                return View(return_model);
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, author.Fullname),
                new Claim("AuthorId", author.Id.ToString()),
                new Claim(ClaimTypes.Role, author.RoleId.ToString())
            };

            var clasim_identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var auth_properties = new AuthenticationProperties
            {
                ExpiresUtc = System.DateTimeOffset.UtcNow.AddMinutes(60),
            };

            HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(clasim_identity),
                auth_properties
            );

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Logout()
        {
            if (User.Identity.IsAuthenticated)
                HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Login","Home");
        }

        [HttpGet]
        public IActionResult _403()
        {
            return View();
        }
    }
}
