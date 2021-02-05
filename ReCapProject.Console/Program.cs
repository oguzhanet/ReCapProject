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
                BrandId = 2, ColorId = 3, Description = "Fiat", DailyPrice = 155, ModelYear = 2015
            });

            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.Description);
                System.Console.WriteLine(car.ModelYear);
            }
        }
    }
}
