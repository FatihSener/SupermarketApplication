using System;
using System.Collections.Generic;
using System.Text;
using Market.Business.Abstract;
using Market.DataAccess.Abstract;
using Market.Entities.Concrete;

namespace Market.Business.Concrte
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
