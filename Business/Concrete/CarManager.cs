using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager:ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if(car.Description.Length>2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine("New Car Added: {0}\n", car.Description);
            }
            else
            {
                Console.WriteLine("There is an error. Car didnt add.Please look your detail.");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("Car has been updated.\n");
        }
        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine("Car has been updated.\n");
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }

       
    }
}
