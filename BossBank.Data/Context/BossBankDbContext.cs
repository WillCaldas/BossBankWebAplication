﻿using System;
using BossBank.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BossBank.Data.Context
{
    public class BossBankDbContext : DbContext
    {
        public BossBankDbContext(DbContextOptions<BossBankDbContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Colaborador> Colabs { get; set; }
        public DbSet<ContaCorrente> ContasCC { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(b => b.MigrationsAssembly("BossBank.Web"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}