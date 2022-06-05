namespace Blog.Data
{
    using Microsoft.Extensions.Options;
    using Blog.Data.Infrastructure;
    using Blog.Data.Infrastructure.Entities;

    public class CommentData : EntityBaseData<Model.Comment>
    {
        public CommentData(IOptions<DatabaseSettings> dbOptions) 
            : base(new DataContext(dbOptions.Value.ConnectionString))
        {

        }
    }
}
