using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface ISupportIOnlineRepository : IRepository<SupportOnline> { }

    public class SupportIOnlineRepository : RepositoryBase<SupportOnline>, ISupportIOnlineRepository
    {
        public SupportIOnlineRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}