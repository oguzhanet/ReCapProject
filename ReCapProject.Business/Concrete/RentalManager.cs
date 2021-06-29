using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReCapProject.Business.Abstract;
using ReCapProject.Business.Constants;
using ReCapProject.Business.ValidationRules.FluentValidation;
using ReCapProject.Core.Aspects.Validation;
using ReCapProject.Core.CrossCuttingConcerns.Validation;
using ReCapProject.Core.Utilities.Results;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;
using ReCapProject.Entities.DTOs;

namespace ReCapProject.Business.Concrete
{
    public class RentalManager : IRentalService
    {
        private IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.Listed);
        }

        public IDataResult<List<Rental>> GetRentalsByRentalId(int rentalId)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.RentalId == rentalId));
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails());
        }

        public IDataResult<List<Rental>> GetAllByCarId(int carId)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r=>r.CarId==carId));
        }

        public IDataResult<List<Rental>> GetAllByCustomerId(int customerId)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.CustomerId == customerId));
        }

        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {   
            //İf in kapalı olan bölümünü RentalValidator de yazdım oyüzden burayı kapattım nasıl yazdığımı inceleyin diye silmedim.
            //if (/*rental.ReturnDate == null || */rental.RentDate.Date > rental.ReturnDate.Date)
            //{
            //    return new ErrorResult(Messages.CarNotRented);
            //}
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.CarRented);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.Updated);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.Deleted);
        }

        public IResult IsDelivered(Rental rental)
        {
            var result = this.GetAllByCarId(rental.CarId).Data.LastOrDefault();
            if (result==null || result.ReturnDate !=default)
            {
                return new SuccessResult();
            }
            return new ErrorResult();
        }

        public IResult IsRentable(Rental rental)
        {
            var result = this.GetAllByCarId(rental.CarId).Data.LastOrDefault();
            if (IsDelivered(rental).Success || (
                !(rental.RentDate < result.ReturnDate && rental.RentDate > result.RentDate) &&
                !(rental.ReturnDate < result.ReturnDate && rental.ReturnDate > result.RentDate) &&
                !(rental.RentDate < result.RentDate && rental.ReturnDate > result.ReturnDate) &&
                rental.RentDate >= DateTime.Now))
            {
                return new SuccessResult();
            }
            return new ErrorResult();
        }

        public bool Rentable(Rental rental)
        {
            var result = _rentalDal.GetAll(r => r.CarId == rental.CarId);
            if (result.Any(r=>r.RentEndDate >= rental.ReturnDate &&
                              r.RentDate <=rental.RentEndDate))
            {
                return true;
            }

            return false;
        }
    }
}
