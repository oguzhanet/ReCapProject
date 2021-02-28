using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReCapProject.Core.DataAccess.EntityFramework;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;

namespace ReCapProject.DataAccess.Concrete.EntityFramework
{
    public class EfCarImageDal:EfEntityRepositoryBase<CarImage,NorthwindContext>,ICarImageDal
    {
        public bool IsExist(int id)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.CarImages.Any(p => p.Id == id);
            }
        }
    }
}
