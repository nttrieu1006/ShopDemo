using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;


namespace TeduShop.Data.Repositories
{
    public interface ISupportIOnlineRepository { }
    public class SupportIOnlineRepository : RepositoryBase<SupportOnline>,ISupportIOnlineRepository
    {
        public SupportIOnlineRepository(IDbFactory dbFactory) : base(dbFactory) { 
}
    }
}
