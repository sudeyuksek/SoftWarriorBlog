using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.WebUI.Site.Models
{
    public class AuthorViewModel
    {
        public AuthorViewModel()
        {
            Author = new Model.Author();
            Contents = new List<Model.Content>();
        }

        public Model.Author Author { get; set; }
        public List<Model.Content> Contents { get; set; }
    }
}
