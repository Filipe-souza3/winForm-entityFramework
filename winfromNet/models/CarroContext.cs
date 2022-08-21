using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winfromNet.models
{
    internal class CarroContext : DbContext
    {
        public DbSet<Carro> Carros { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server = localhost; Database = csharp; Uid = root; Pwd = ;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { }
    }
}
