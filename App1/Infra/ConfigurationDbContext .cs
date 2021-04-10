using App1.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App1.Infra
{
    public class ConfigurationDbContext : DbContext
    {
        public ConfigurationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<ConfigurationEntity> ConfigurationEntities { get; set; }

    }
}
