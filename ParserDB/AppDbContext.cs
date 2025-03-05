using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ParserDB;

public class AppDbContext : DbContext
{
    public AppDbContext() : base("name=CarMarketDB") { }

    public DbSet<Car> Cars { get; set; } // Таблица Cars в базе данных
}
