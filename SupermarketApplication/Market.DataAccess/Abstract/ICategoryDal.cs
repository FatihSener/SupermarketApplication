using Market.Entities.Concrete;
using MarketUygulamasi.Core.DataAccess;

namespace Market.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }
}