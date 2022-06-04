namespace YoutubeDersleri.WebUI.Site.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class CategoryViewModel
    {
        public CategoryViewModel()
        {
            Category = new Model.Category();
            Contents = new List<Model.Content>();
        }

        public Model.Category Category { get; set; }
        public List<Model.Content> Contents { get; set; }

        public int CurrentPage { get; set; }
        public int TotalData { get; set; }
        public double TotalPage { get; set; }

    }
}
