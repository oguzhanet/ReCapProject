using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using ReCapProject.Core.DataAccess.EntityFramework;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;
using ReCapProject.Entities.DTOs;

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

        public List<CarImageDto> GetCarImageDetails(Expression<Func<CarImage, bool>> filter = null)
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                var result = from cari in filter == null ? context.CarImages : context.CarImages.Where(filter)
                    join c in context.Cars on cari.CarId equals c.CarId
                    select new CarImageDto
                    {
                        CarId = c.CarId, ImagePath = cari.ImagePath
                    };
                return result.ToList();
            }
            
        }
    }
}
