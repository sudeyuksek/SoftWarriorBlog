namespace YoutubeDersleri.Data
{
    using Microsoft.Extensions.Options;
    using YoutubeDersleri.Data.Infrastructure;
    using YoutubeDersleri.Data.Infrastructure.Entities;

    public class RoleData : EntityBaseData<Model.Role>
    {
        public RoleData(IOptions<DatabaseSettings> dbOptions) 
            : base(new DataContext(dbOptions.Value.ConnectionString))
        {

        }
    }
}
