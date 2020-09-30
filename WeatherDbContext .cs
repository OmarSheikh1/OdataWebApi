using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdataWebApi
{
    public class WeatherDbContext : DbContext
    {
        public WeatherDbContext()
        {

        }
        public WeatherDbContext(DbContextOptions options)  : base(options)
        {
        }

        public DbSet<WeatherForecast> WeatherForecast { get; set; }
    }
}
