using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParserDB.Репозитории;

namespace ParserDB.Services
{
    class CarService
    {
        private readonly CarRepository _carRepository;

        public CarService(CarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        // Получение всех автомобилей
        public List<Car> GetAllCars()
        {
            return _carRepository.GetAllCars();
        }

        // Добавление автомобиля
        public void AddCar(Car car)
        {
            _carRepository.AddCar(car);
        }

        // Удаление автомобиля
        public void DeleteCar(int id)
        {
            _carRepository.DeleteCar(id);
        }
    }
}
