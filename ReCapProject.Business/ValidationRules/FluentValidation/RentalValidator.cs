using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using ReCapProject.Entities.Concrete;

namespace ReCapProject.Business.ValidationRules.FluentValidation
{
    public class RentalValidator:AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.CarId).NotEmpty();
            RuleFor(r => r.CustomerId).NotEmpty();
            RuleFor(r => r.RentDate).NotEmpty();
            RuleFor(r => r.RentDate).Must(RentalDateCannotBeLessThanTodayDate).WithMessage("Verilen tarih bugünün tarihinden küçük olmalıdır!");
            RuleFor(r => r.ReturnDate).NotEmpty();
            RuleFor(r => r.ReturnDate).Must(DeliveryDateShouldBeGreater).WithMessage("Verilen tarih bugünün tarihinden büyük olmalıdır!");
        }
        
        private bool RentalDateCannotBeLessThanTodayDate(DateTime arg)
        {
            return arg.Date < DateTime.Today;
        }

        private bool DeliveryDateShouldBeGreater(DateTime arg)
        {
            return arg.Date > DateTime.Now;
        }
    }
}
