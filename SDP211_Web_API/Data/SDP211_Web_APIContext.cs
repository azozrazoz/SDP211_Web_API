using Microsoft.EntityFrameworkCore;

namespace SDP211_Web_API.Data
{
    public class SDP211_Web_APIContext : DbContext
    {
        public SDP211_Web_APIContext(DbContextOptions<SDP211_Web_APIContext> options)
            : base(options)
        {
        }

        public DbSet<Models.WeatherForecast> WeatherForecast { get; set; }
    }
}
