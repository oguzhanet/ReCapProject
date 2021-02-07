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

            //CarAddUpdateDeleteTest(carManager);

            foreach (var car in carManager.GetCarDetails())
            {
                //System.Console.WriteLine("Marka:{0} Model:{1} Kiralama Ücreti:{2}",car.Description,car.ModelYear,car.DailyPrice ); //GetAll için
                System.Console.WriteLine("Araba Adı:{0} / Marka Adı:{1} / Renk Adı:{2} / Kiralama Ücreti:{3}",car.Description,car.BrandName,car.ColorName,car.DailyPrice);
            }
        }

        private static void CarAddUpdateDeleteTest(CarManager carManager)
        {
            carManager.Add(new Car
            {
                BrandId = 2,
                ColorId = 3,
                Description = "Fiat",
                DailyPrice = 120,
                ModelYear = 2015
            });

            carManager.Update(new Car
            {
                CarId = 3,
                BrandId = 2,
                ColorId = 1,
                Description = "Reno",
                DailyPrice = 120,
                ModelYear = 2016
            });

            carManager.Delete(new Car
            {
                CarId = 3,
                BrandId = 2,
                ColorId = 1,
                Description = "Reno",
                DailyPrice = 120,
                ModelYear = 2016
            });
        }
    }
}
