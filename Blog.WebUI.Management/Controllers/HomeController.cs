namespace Blog.WebUI.Management.Controllers
{
    using Microsoft.AspNetCore.Authentication;
    using Microsoft.AspNetCore.Authentication.Cookies;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Claims;
    using Blog.Data;
    using Blog.Extensions.MediaHelper;
    using Blog.Model;
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

        public IActionResult Register()
        {
            var model = new RegisterModel
            {
                Fullname = "",
                Mail = "",
                Username = "",
                Password = "",
                IsActive = false,
                IsDeleted = false
            };

            return View(model);
        }
        public IActionResult ForgotPass()
        {
            var model = new Author();



            //altına bişeyler koyacak mıyız
            return View(model);
            //boş model döndürecek
        }

        [HttpPost]
        public IActionResult ForgotPass(string email)
        {
            var authors = _authorData.GetBy(x => x.Mail == email).FirstOrDefault();
            return View(authors);
        }
      


        [HttpPost]
        public IActionResult Register(string fullName, string mail, string username, string password)
        {
            var errors = new List<string>();
            var return_model = new RegisterModel();

            if (string.IsNullOrEmpty(fullName)) errors.Add("İsim Boş Bırakılamaz");
            if (string.IsNullOrEmpty(mail)) errors.Add("E-Mail Boş Bırakılamaz");
            if (string.IsNullOrEmpty(username)) errors.Add("Kullanıcı Boş Bırakılamaz");
            if (string.IsNullOrEmpty(password)) errors.Add("Şifre Boş Bırakılamaz");
            if (errors.Count() > 0)
            {
                ViewBag.Result = new ViewModelResult(false, "Hata Oluştu", errors);
                return View(return_model);
            }

            var author = _authorData.GetBy(x => x.Username == username && x.Mail == mail && x.Password == password && x.IsActive && !x.IsDeleted).FirstOrDefault();
            if (author != null)
            {
                ViewBag.Result = new ViewModelResult(false, "Böyle bir kullanıcı zaten mevcut");
                return View(return_model);
            }

            return_model = new RegisterModel
            {
                Fullname = fullName,
                Mail = mail,
                Username = username,
                Password = password,
                IsActive = false,
                IsDeleted = false
            };

            var operationResult = _authorData.Insert(return_model.ToAuthor());
            if (operationResult.IsSucceed)
            {
                ViewBag.Result = new ViewModelResult(true, "Kayıt Tamamlandı");

                return RedirectToAction("Login");
            }

            return View(return_model);
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
