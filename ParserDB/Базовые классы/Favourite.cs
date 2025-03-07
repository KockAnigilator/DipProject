using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserDB
{
    class Favourite
    {
        public int UserId { get; set; } //Индефикатор пользлователя
        public int CarId { get; set; } // Индефикатор автомобиля



        //Вспомагательные свойства для навигации
        public virtual User user { get; set; }
        public virtual Car car { get; set; }
    }
}
