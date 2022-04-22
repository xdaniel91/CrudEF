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
        public DbSet<Company> Companies { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=praticing;Username=postgres;Password=adm");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cpfConverter = new ValueConverter<Cpf, string>(v => v.ToString(), v => Cpf.Parse(v));
            var CnpjConverter = new ValueConverter<Cnpj, string>(v => v.ToString(), v => Cnpj.Parse(v));

            modelBuilder.Entity<Person>().Property(person => person.Cpf).HasConversion(cpfConverter);
            modelBuilder.Entity<Company>().Property(company => company.Cnpj).HasConversion(CnpjConverter);
        }
    }
}