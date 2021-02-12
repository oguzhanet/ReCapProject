using System;
using System.Collections.Generic;
using System.Text;
using ReCapProject.Core.DataAccess.EntityFramework;
using ReCapProject.DataAccess.Concrete.EntityFramework;
using ReCapProject.Entities.Concrete;

namespace ReCapProject.DataAccess.Abstract
{
    public class EfRentalDal:EfEntityRepositoryBase<Rental,NorthwindContext>,IRentalDal
    {
    }
}
