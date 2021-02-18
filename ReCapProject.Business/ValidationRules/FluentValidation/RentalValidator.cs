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
            RuleFor(r => r.RentDate).Must(RentalDateShouldBeEqualToTodayDate);
            RuleFor(r => r.ReturnDate).NotEmpty();
            RuleFor(r => r.ReturnDate).Must(DeliveryDateShouldBeGreater);
        }
        
        private bool RentalDateShouldBeEqualToTodayDate(DateTime arg)
        {
            return arg.Date == DateTime.Now;
        }

        private bool DeliveryDateShouldBeGreater(DateTime arg)
        {
            return arg.Date > DateTime.Now;
        }
    }
}
