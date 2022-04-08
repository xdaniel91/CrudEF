using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relationship
{
    public class BaseContext : DbContext
    {
        public BaseContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("DefaultConnection");
        }

        public DbSet<Model> Models { get; set; }
        public DbSet<Car> Cars { get; set; }
    }
}
