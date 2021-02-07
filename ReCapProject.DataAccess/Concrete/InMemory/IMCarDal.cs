using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;
using ReCapProject.Entities.DTOs;

namespace ReCapProject.DataAccess.Concrete.InMemory
{
    public class IMCarDal : ICarDal
    {
        private List<Car> _cars;
        private List<Brand> _brands;
        private List<Color> _colors;

        public IMCarDal()
        {
            _brands = new List<Brand>
            {
                new Brand
                {
                    BrandId = 1, BrandName = "Fiyat"
                },
                new Brand
                {
                    BrandId = 2, BrandName = "Ford"
                },
                new Brand
                {
                BrandId = 1, BrandName = "Mercedes"
            }

            };

            _colors = new List<Color>
            {
                new Color
                {
                    ColorId = 1, ColorName = "Black"
                },

                new Color
                {
                ColorId = 1, ColorName = "White"
                },

                new Color
                {
                    ColorId = 1, ColorName = "Yellow"
                }
            };
            _cars = new List<Car>
            {
                new Car{CarId = 1,BrandId = 1,ColorId = 2,DailyPrice = 155,
                    Description ="95 Kilometrede",ModelYear = 2019},
                new Car{CarId = 2,BrandId = 1,ColorId = 3,DailyPrice = 165,
                    Description ="115 Kilometrede",ModelYear = 2019},
                new Car{CarId = 3,BrandId = 2,ColorId = 1,DailyPrice = 115,
                    Description ="335 Kilometrede",ModelYear = 2013},
                new Car{CarId = 4,BrandId = 2,ColorId = 1,DailyPrice = 159,
                    Description ="35 Kilometrede",ModelYear = 2020},
                new Car{CarId = 5,BrandId = 3,ColorId = 2,DailyPrice = 145,
                    Description ="135 Kilometrede",ModelYear = 2018},
                new Car{CarId = 6,BrandId = 3,ColorId = 3,DailyPrice = 105,
                    Description ="235 Kilometrede",ModelYear = 2010}
            };
        }

        public List<Car> GetByIdBrand(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetByIdColor(int colorId)
        {
            return _cars.Where(c => c.ColorId == colorId).ToList();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
