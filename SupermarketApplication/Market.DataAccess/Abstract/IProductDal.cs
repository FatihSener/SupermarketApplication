using System;
using System.Collections.Generic;
using System.Text;
using Market.Entities.Concrete;
using MarketUygulamasi.Core.DataAccess;

namespace Market.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}
