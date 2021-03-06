using DataAccess.Abstract;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCapProject.DataAccess.Abstract
{
    public interface ICarDal: IEntityRepository<Car>
    {
        List<Car> GetAll();
        List<Car> GetById(int id);
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        
    }
}
