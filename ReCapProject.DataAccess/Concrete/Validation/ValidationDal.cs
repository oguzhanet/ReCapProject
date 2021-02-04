using System;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;

namespace ReCapProject.DataAccess.Concrete.Validation
{
    public class ValidationDal:IValidationDal
    {
        public bool Validate(Car car)
        {
            if (car.Description.Length>=2&&car.DailyPrice>0)
            {
               return true;
            }
            else
            {
                return false;
            }
        }
    }
}
