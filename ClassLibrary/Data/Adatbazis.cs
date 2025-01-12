using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Data
{
    public class Adatbazis:DbContext
    {
        public Adatbazis(DbContextOptions<Adatbazis> options)
           : base(options)
        {
        }

        public Adatbazis()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=aspnet-53bc9b9d-9d6a-45d4-8429-2a2761773502;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public DbSet<ClassLibrary.Models.Huzas> Huzas { get; set; } = default!;

    }
}
