﻿using System.Collections.Generic;
using Market.Entities.Concrete;

namespace Market.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}