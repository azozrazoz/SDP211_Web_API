using Microsoft.EntityFrameworkCore;

namespace SDP211_Web_API.Models
{
    public class WeatherContext : DbContext
    { 
        public DbSet<WeatherForecast> weatherForecast { get; set; }
    }
}
