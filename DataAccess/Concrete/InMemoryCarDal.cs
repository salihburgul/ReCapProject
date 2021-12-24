using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ReCapProject.DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _carsList;
        public InMemoryCarDal()
        {
            _carsList = new List<Car>
            {
                new Car { Id = 1, BrandId = 1, ColorId = 1, ModelYear = "2005", DailyPrice = 500, Description = "Ford" },
                new Car { Id = 2, BrandId = 1, ColorId = 2, ModelYear = "2012", DailyPrice = 500, Description = "Ford" },
                new Car { Id = 3, BrandId = 2, ColorId = 2, ModelYear = "2005", DailyPrice = 500, Description = "Fiat" },
                new Car { Id = 4, BrandId = 3, ColorId = 3, ModelYear = "2005", DailyPrice = 500, Description = "Kia" },
                new Car { Id = 5, BrandId = 4, ColorId = 4, ModelYear = "2005", DailyPrice = 500, Description = "Volvo" },
            };



        }

        public void Add(Car car)
        {
            _carsList.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _carsList.SingleOrDefault(c =>c.Id==car.Id);
            _carsList.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _carsList;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _carsList.Where(c => c.BrandId==id).ToList();    
        }

        public void Update(Car car)
        {
            Car carToUpdate = _carsList.SingleOrDefault(c => car.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;   
        }
    }

}
