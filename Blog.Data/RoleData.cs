namespace Blog.Data
{
    using Microsoft.Extensions.Options;
    using Blog.Data.Infrastructure;
    using Blog.Data.Infrastructure.Entities;

    public class RoleData : EntityBaseData<Model.Role>
    {
        public RoleData(IOptions<DatabaseSettings> dbOptions) 
            : base(new DataContext(dbOptions.Value.ConnectionString))
        {

        }
    }
}
