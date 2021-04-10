using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReCapProject.Core.DataAccess.EntityFramework;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;
using ReCapProject.Entities.DTOs;

namespace ReCapProject.DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal:EfEntityRepositoryBase<Customer,NorthwindContext>,ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                var result = from cu in context.Customers
                    join u in context.Users on cu.UserId equals u.UserId
                    select new CustomerDetailDto
                    {
                        CustomerId = cu.CustomerId,
                        UserId = u.UserId,
                        CompanyName = cu.CompanyName,
                        Email = u.Email,
                        FirstName = u.FirstName,
                        LastName = u.LastName,
                        Status = u.Status
                    };
                return result.ToList();
            }
        }
    }
}
