using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using ReCapProject.Core.DataAccess;
using ReCapProject.Entities.Concrete;
using ReCapProject.Entities.DTOs;

namespace ReCapProject.DataAccess.Abstract
{
    public interface ICarImageDal:IEntityRepository<CarImage>
    {
        bool IsExist(int id);
        List<CarImageDto> GetCarImageDetails(Expression<Func<CarImage, bool>> filter = null);
    }
}
