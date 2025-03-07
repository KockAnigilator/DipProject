using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserDB
{
    class User
    {
        private int Id { get; set; } // Айди
        private int Name { get; set; } // Имя пользователя
        private int ProfilePic { get; set; } // Путь к изображению

        // Навигационное свойство для избранных автомобилей
        public virtual ICollection<Favourite> Favourites { get; set; }
    }
}
