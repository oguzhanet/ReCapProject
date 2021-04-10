using System.Collections.Generic;
using System.Linq;
using ReCapProject.Core.DataAccess.EntityFramework;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;
using ReCapProject.Entities.DTOs;

namespace ReCapProject.DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, NorthwindContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from r in context.Rentals
                             join cu in context.Customers on r.CustomerId equals cu.CustomerId
                             join c in context.Cars on r.CarId equals c.CarId
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join col in context.Colors on c.ColorId equals col.ColorId
                             join u in context.Users on cu.UserId equals u.UserId 
                             select new RentalDetailDto
                             {
                                 RentalId = r.RentalId,
                                 CarId = c.CarId,
                                 BrandName = b.BrandName,
                                 ColorName = col.ColorName,
                                 CustomerName = u.FirstName+u.LastName,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,
                                 CompanyName = cu.CompanyName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}
