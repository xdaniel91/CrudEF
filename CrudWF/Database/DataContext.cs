using Microsoft.EntityFrameworkCore;
using CrudWF.Enities;

namespace CrudWF.Database
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=praticing;Username=postgres;Password=adm");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Person> Persons { get; set; }

    }
}