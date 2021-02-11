using System;
using ReCapProject.Business.Concrete;
using ReCapProject.Business.Constants;
using ReCapProject.DataAccess.Concrete.EntityFramework;
using ReCapProject.Entities.Concrete;

namespace ReCapProject.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //CarAddUpdateDeleteTest(carManager);
            var result = carManager.GetAll();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    //Console.WriteLine("Marka:{0} Model:{1} Kiralama Ücreti:{2}",car.Description,car.ModelYear,car.DailyPrice ); //GetAll için
                    System.Console.WriteLine("Araba Adı:{0} / Kiralama Ücreti:{1}", car.Description,car.DailyPrice);
                }
            }
            else
            {
                System.Console.WriteLine(result.Message);
            }

        }

        private static void CarAddUpdateDeleteTest(CarManager carManager)
        {


            carManager.Add(new Car
            {
                BrandId = 1,
                ColorId = 2,
                Description = "ugr",
                DailyPrice = 152,
                ModelYear = 2015
            });



            //carManager.Update(new Car
            //{
            //    CarId = 3,
            //    BrandId = 2,
            //    ColorId = 1,
            //    Description = "ozan",
            //    DailyPrice = 110,
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
            //}
            //);
        }
    }
}
