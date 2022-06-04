namespace YoutubeDersleri.Data
{
    using Microsoft.Extensions.Options;
    using YoutubeDersleri.Data.Infrastructure;
    using YoutubeDersleri.Data.Infrastructure.Entities;

    public class RolePageData : EntityBaseData<Model.RolePage>
    {
        public RolePageData(IOptions<DatabaseSettings> dbOptions) 
            : base(new DataContext(dbOptions.Value.ConnectionString))
        {

        }
    }
}
