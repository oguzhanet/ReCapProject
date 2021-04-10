using System;
using System.Collections.Generic;
using System.Text;
using ReCapProject.Core.Utilities.Results;
using ReCapProject.Entities.Concrete;
using ReCapProject.Entities.DTOs;

namespace ReCapProject.Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<Rental>> GetRentalsByRentalId(int rentalId);
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
        IDataResult<List<Rental>> GetAllByCarId(int carId);
        IDataResult<List<Rental>> GetAllByCustomerId(int customerId);
        IResult Add(Rental rental);
        IResult Update(Rental rental);
        IResult Delete(Rental rental);
        IResult IsDelivered(Rental rental);
        IResult IsRentable(Rental rental);
        Boolean Rentable(Rental rental);
    }
}
