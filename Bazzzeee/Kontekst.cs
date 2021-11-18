using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazzzeee
{
    public class Kontekst : DbContext
    {
        public DbSet<Osoba> Osobas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = BazaZaEF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Osoba>().HasKey(o => o.Id);
            Osoba o = new();
            modelBuilder.Entity<Osoba>().Property(nameof(o.Ime)).IsRequired();
            modelBuilder.Entity<Osoba>().Property(nameof(o.Prezime)).IsRequired();
            base.OnModelCreating(modelBuilder);
        }
    }
}
