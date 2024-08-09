using System;
using System.IO;
using FiapSmartCity.Models;
using System.Data.Entity.DbContext;
using Microsoft.Extensions.Configuration;
using Oracle.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace FiapSmartCity.Repository.Context
{
    public class DataBaseContext : DbContext
    {

        public DbSet<TipoProduto> TipoProduto { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
                optionsBuilder.UseOracle(config.GetConnectionString("FiapSmartCityConnection"));
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

    }
}
