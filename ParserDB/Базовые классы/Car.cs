using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserDB
{
    public class Car
    {
        public int Id { get; set; } // Уникальный идентификатор
        public string Name { get; set; } // Название автомобиля
        public string Price { get; set; } // Цена
        public string Year { get; set; } // Год выпуска
        public string Mileage { get; set; } // Пробег
        public string Link { get; set; } // Ссылка на объявление
    }
}
