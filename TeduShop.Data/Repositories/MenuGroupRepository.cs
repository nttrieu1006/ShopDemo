using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IMenuGroupRepository { }
    public class MenuGroupRepository : RepositoryBase<MenuGroupRepository>
    {
        public MenuGroupRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}
