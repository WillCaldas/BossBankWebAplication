using System;
using BossBank.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BossBank.Data.Context
{
    public partial class BossBankDbContext : DbContext
    {
        public BossBankDbContext()
        {
        }

        public BossBankDbContext(DbContextOptions<BossBankDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Colaborador> Colaborador { get; set; }
        public DbSet<ContaCorrente> ContaCorrente { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //optionsBuilder.UseSqlServer(b => b.MigrationsAssembly("BossBank.Web"));

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=MIDPIXELDESK\\SQLDATABASE;Initial Catalog=BossBankNewDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}