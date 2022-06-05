namespace Blog.Data
{
    using Microsoft.Extensions.Options;
    using Blog.Data.Infrastructure;
    using Blog.Data.Infrastructure.Entities;

    public class AuthorData : EntityBaseData<Model.Author>
    {
        public AuthorData(IOptions<DatabaseSettings> dbOptions) 
            : base(new DataContext(dbOptions.Value.ConnectionString))
        {

        }
    }
}
