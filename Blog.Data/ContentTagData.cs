namespace Blog.Data
{
    using Microsoft.Extensions.Options;
    using Blog.Data.Infrastructure;
    using Blog.Data.Infrastructure.Entities;

    public class ContentTagData : EntityBaseData<Model.ContentTag>
    {
        public ContentTagData(IOptions<DatabaseSettings> dbOptions) 
            : base(new DataContext(dbOptions.Value.ConnectionString))
        {

        }
    }
}
