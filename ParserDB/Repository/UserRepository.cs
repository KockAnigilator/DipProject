using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserDB.Репозитории
{
    class UserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        // Добавление пользователя
        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        // Получение пользователя по ID
        public User GetUserById(int id)
        {
            return _context.Users.Find(id);
        }

        // Получение всех пользователей
        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }
    }
}
