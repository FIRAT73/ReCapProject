using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=2,ColorId=3,ModelYear=2020,DailyPrice=150000,Description="Spor Araç"},
                new Car{Id=2,BrandId=2,ColorId=1,ModelYear=1970,DailyPrice=12000,Description="Audi V7"},
                new Car{Id=3,BrandId=1,ColorId=2,ModelYear=2015,DailyPrice=110000,Description="Arazi Araç"},
                new Car{Id=4,BrandId=4,ColorId=4,ModelYear=2017,DailyPrice=170000,Description="Spor Araç"},
                new Car{Id=5,BrandId=3,ColorId=4,ModelYear=2000,DailyPrice=70000,Description="Yük Aracı"},
                new Car{Id=6,BrandId=4,ColorId=2,ModelYear=2022,DailyPrice=650000,Description="Sıfır Araç"},
                new Car{Id=7,BrandId=5,ColorId=1,ModelYear=2013,DailyPrice=125000,Description="Ferrari 516"},
                new Car{Id=8,BrandId=5,ColorId=4,ModelYear=2018,DailyPrice=180000,Description="Buggatti"},
                new Car{Id=9,BrandId=1,ColorId=5,ModelYear=1965,DailyPrice=135000,Description="Mercedes XX"},
                new Car{Id=10,BrandId=3,ColorId=3,ModelYear=2022,DailyPrice=750000,Description="Volvo X4"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == c.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public List<Car> GetById(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
         
        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
            
        }
    }
}
