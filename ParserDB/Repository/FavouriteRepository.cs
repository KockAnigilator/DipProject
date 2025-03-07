using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserDB.Репозитории
{
    class FavouriteRepository
    {
        private readonly AppDbContext _context;

        public FavouriteRepository(AppDbContext context)
        {
            _context = context;
        }

        // Добавление автомобиля в избранное
        public void AddToFavourite(int userId, int carId)
        {
            var favourite = new Favourite
            {
                UserId = userId,
                CarId = carId
            };
            _context.Favourites.Add(favourite);
            _context.SaveChanges();
        }

        // Удаление автомобиля из избранного
        public void RemoveFromFavourite(int userId, int carId)
        {
            var favourite = _context.Favourites.Find(userId, carId);
            if (favourite != null)
            {
                _context.Favourites.Remove(favourite);
                _context.SaveChanges();
            }
        }

        // Получение избранных автомобилей пользователя
        public List<Car> GetFavouriteCars(int userId)
        {
            return _context.Favourites
                .Where(f => f.UserId == userId)
                .Select(f => f.car)
                .ToList();
        }
    }
}
