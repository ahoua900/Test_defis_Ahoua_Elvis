using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TEST_DEFIS_APP.Models;

namespace TEST_DEFIS_APP.DataAccess
{
    public class MoviesDbContext : DbContext
    {
        public DbSet<UserModel> UserModels { get; set; }
        public DbSet<Auteur> Auteurs { get; set; }
        public DbSet<Films> Films { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseNpgsql(@"Host=5.182.33.229;Port=5430;Database=movies;Username=postgres;Password=postgres;"));
        }
    }
    
}
