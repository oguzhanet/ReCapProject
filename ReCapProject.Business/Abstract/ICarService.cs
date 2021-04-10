using System;
using System.Collections.Generic;
using System.Text;
using ReCapProject.Core.Utilities.Results;
using ReCapProject.Entities.Concrete;
using ReCapProject.Entities.DTOs;

namespace ReCapProject.Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByCarId(int carId);
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult<List<Car>> GetCarsByColorId(int colorId);
        IDataResult<List<CarDetailDto>> GetCarDetailsByCarsId(int carId);
        IDataResult<List<CarDetailDto>> GetCarsDetailsByBrandId(int brandId);
        IDataResult<List<CarDetailDto>> GetCarsDetailsByColorId(int colorId);
        IDataResult<List<CarDetailDto>> GetCarsDetailsByBrandIdAndColorId(int brandId, int colorId);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(int carId);
        IResult TransactionalOperation(Car car);
    }
}
