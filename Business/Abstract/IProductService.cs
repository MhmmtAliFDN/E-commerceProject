﻿using Core.Utilities.Results.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        IResult Add(Product product);
        IResult AddTransactionalTest(Product product);
        IResult Delete(Product product);
        IDataResult<Product> GetById(int id);
        IDataResult<List<Product>> GetAll();
        IResult Update(Product product);
        IDataResult<List<Product>> GetAllByCategoryId(int categoryId);
    }
}
