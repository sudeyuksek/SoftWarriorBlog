namespace Blog.Data
{
    using Microsoft.Extensions.Options;
    using Blog.Data.Infrastructure;
    using Blog.Data.Infrastructure.Entities;

    public class MediaData : EntityBaseData<Model.Media>
    {
        public MediaData(IOptions<DatabaseSettings> dbOptions) 
            : base(new DataContext(dbOptions.Value.ConnectionString))
        {

        }
    }
}
