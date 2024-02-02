using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TEST_DEFIS_APP.DataAccess;

namespace TEST_DEFIS_APP
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MoviesDbContext>(options =>
                options.UseNpgsql());
        }

    }
}
