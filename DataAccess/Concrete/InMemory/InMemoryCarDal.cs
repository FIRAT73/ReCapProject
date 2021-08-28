using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
                new Car{CarId=1,BrandId=2,ColorId=3,ModelYear=2020,DailyPrice=150000,Description="Spor Araç"},
                new Car{CarId=2,BrandId=2,ColorId=1,ModelYear=1970,DailyPrice=12000,Description="Audi V7"},
                new Car{CarId=3,BrandId=1,ColorId=2,ModelYear=2015,DailyPrice=110000,Description="Arazi Araç"},
                new Car{CarId=4,BrandId=4,ColorId=4,ModelYear=2017,DailyPrice=170000,Description="Spor Araç"},
                new Car{CarId=5,BrandId=3,ColorId=4,ModelYear=2000,DailyPrice=70000,Description="Yük Aracı"},
                new Car{CarId=6,BrandId=4,ColorId=2,ModelYear=2022,DailyPrice=650000,Description="Sıfır Araç"},
                new Car{CarId=7,BrandId=5,ColorId=1,ModelYear=2013,DailyPrice=125000,Description="Ferrari 516"},
                new Car{CarId=8,BrandId=5,ColorId=4,ModelYear=2018,DailyPrice=180000,Description="Buggatti"},
                new Car{CarId=9,BrandId=1,ColorId=5,ModelYear=1965,DailyPrice=135000,Description="Mercedes XX"},
                new Car{CarId=10,BrandId=3,ColorId=3,ModelYear=2022,DailyPrice=750000,Description="Volvo X4"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == c.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
            
        }
    }
}
