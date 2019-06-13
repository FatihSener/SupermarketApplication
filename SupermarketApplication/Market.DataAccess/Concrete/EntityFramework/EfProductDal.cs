using System;
using System.Collections.Generic;
using System.Text;
using Market.DataAccess.Abstract;
using Market.Entities.Concrete;
using MarketUygulamasi.Core.DataAccess.EntityFramework;

namespace Market.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, MarketContext>,IProductDal
    {
    }
}
