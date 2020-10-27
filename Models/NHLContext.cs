using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace NHLTeams.Models
{
    public class NHLContext : DbContext
    {
        public NHLContext(DbContextOptions<NHLContext> options) : base(options)
        {

        }
        protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer("Server=DESKTOP-UVR8UE5;Database=NHL;Trusted_Connection=True;");
        }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Division> Divisions { get; set; }
    }
}
