﻿using Core.Utilities.Results.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IResult Add(Customer customer);
        IResult Delete(Customer customer);
        IDataResult<Customer> GetById(string id);
        IDataResult<List<Customer>> GetAll();
        IResult Update(Customer customer);
    }
}
