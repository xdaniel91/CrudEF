using Microsoft.EntityFrameworkCore;
using CrudWF.Enities;
using CrudWF.ValueObjects;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CrudWF.Database
{
    public class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Person> Persons { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=praticing;Username=postgres;Password=adm");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var converter = new ValueConverter<Cpf, string>(v => v.ToString(), v => Cpf.Parse(v));

            modelBuilder
                .Entity<Person>()
                .Property(e => e.Cpf)
                .HasConversion(converter);
        }
    }
}