using System;
using System.Collections.Generic;
using System.Text;
using ReCapProject.Core.Utilities.Results;
using ReCapProject.Entities.Concrete;

namespace ReCapProject.Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
        IDataResult<List<Brand>> GetBrandsByBrandId(int brandId);
        IDataResult<List<Brand>> GetBrandsByName(string brandName);
        IResult Add(Brand brand);
        IResult Update(Brand brand);
        IResult Delete(Brand brand);
    }
}
