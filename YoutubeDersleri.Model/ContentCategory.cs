namespace YoutubeDersleri.Model
{
    using System;

    public class ContentCategory : Core.ModelBase
    {
        public ContentCategory()
        {
        }

        public ContentCategory(int contentId, int categoryId)
        {
            CategoryId = categoryId;
            ContentId = contentId;
        }

        public int CategoryId { get; set; }
        public int ContentId { get; set; }
    }
}
