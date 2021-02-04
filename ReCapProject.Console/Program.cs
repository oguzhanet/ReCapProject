using System;
using ReCapProject.Business.Concrete;
using ReCapProject.DataAccess.Concrete.EntityFramework;
using ReCapProject.DataAccess.Concrete.InMemory;
using ReCapProject.DataAccess.Concrete.Validation;
using ReCapProject.Entities.Concrete;

namespace ReCapProject.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal(new ValidationDal()));


            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine(car.Description);
                System.Console.WriteLine(car.ModelYear);
            }
        }
    }
}
