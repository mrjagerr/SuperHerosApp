using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SuperHeroApp.Models;
namespace SuperHeroApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<SuperHero> SuperHeroes { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}