namespace Blog.WebUI.Site.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Blog.Data;
    using Blog.WebUI.Site.Models;

    public class AuthorController : Controller
    {
        AuthorData _authorData;
        ContentData _contentData;

        public AuthorController(AuthorData _authorData, ContentData _contentData)
        {
            this._authorData = _authorData;
            this._contentData = _contentData;
        }

        public IActionResult Index(int id, int page = 1)
        {
            var author = _authorData.GetByKey(id);
            if (author == null)
                return RedirectToAction("Index", "Home", new { q = "yazar-bulunamadi" });

            var contents = _contentData.GetBy(x => x.AuthorId == id && x.IsActive && !x.IsDeleted);

            foreach(var content in contents)
            {
                var _author = _authorData.GetByKey(content.AuthorId);
                content.Author = _author;
            }

            var model = new AuthorViewModel()
            {
                Author = author,
                Contents = contents
            };

            return View(model);
        }
    }
}
