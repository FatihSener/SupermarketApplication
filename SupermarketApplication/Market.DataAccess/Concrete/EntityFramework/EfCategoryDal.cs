using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Market.DataAccess.Abstract;
using Market.Entities.Concrete;
using MarketUygulamasi.Core.DataAccess.EntityFramework;

namespace Market.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category,MarketContext>,ICategoryDal
    {
    }
}