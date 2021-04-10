﻿using System;
using System.Collections.Generic;
using System.Text;
using ReCapProject.Core.DataAccess;
using ReCapProject.Entities.Concrete;
using ReCapProject.Entities.DTOs;

namespace ReCapProject.DataAccess.Abstract
{
    public interface ICustomerDal:IEntityRepository<Customer>
    {
        List<CustomerDetailDto> GetCustomerDetails();
    }
}
