using System;
using ReCapProject.Business.Concrete;
using ReCapProject.DataAccess.Concrete.EntityFramework;
using ReCapProject.DataAccess.Concrete.InMemory;
using ReCapProject.Entities.Concrete;

namespace ReCapProject.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Add(new Car
            {
                BrandId = 2,
                ColorId = 3,
                Description = "Fiat",
                DailyPrice = 120,
                ModelYear = 2015
            });

            //carManager.Update(new Car
            //{
            //    CarId = 3,
            //    BrandId = 2,
            //    ColorId = 1,
            //    Description = "Reno",
            //    DailyPrice = 120,
            //    ModelYear = 2016
            //});

            //carManager.Delete(new Car
            //{
            //    CarId = 3,
            //    BrandId = 2,
            //    ColorId = 1,
            //    Description = "Reno",
            //    DailyPrice = 120,
            //    ModelYear = 2016
            //});

            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine("Marka:{0} Model:{1} Kiralama Ücreti:{2}",car.Description,car.ModelYear,car.DailyPrice );
                
            }
        }
    }
}
