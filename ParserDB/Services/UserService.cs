using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParserDB.Репозитории;

namespace ParserDB.Services
{
    class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // Добавление пользователя
        public void AddUser(User user)
        {
            _userRepository.AddUser(user);
        }

        // Получение пользователя по ID
        public User GetUserById(int id)
        {
            return _userRepository.GetUserById(id);
        }
    }
}
