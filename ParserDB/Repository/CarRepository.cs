using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserDB.Репозитории
{
    class CarRepository
    {
        private readonly AppDbContext _context;

        public CarRepository(AppDbContext context)
        {
            _context = context;
        }

        // Добавление автомобиля
        public void AddCar(Car car)
        {
            _context.Cars.Add(car);
            _context.SaveChanges();
        }

        // Получение всех автомобилей
        public List<Car> GetAllCars()
        {
            return _context.Cars.ToList();
        }

        // Получение автомобиля по ID
        public Car GetCarById(int id)
        {
            return _context.Cars.Find(id);
        }

        // Удаление автомобиля
        public void DeleteCar(int id)
        {
            var car = _context.Cars.Find(id);
            if (car != null)
            {
                _context.Cars.Remove(car);
                _context.SaveChanges();
            }
        }
    }
}
