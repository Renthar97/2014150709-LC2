using _2014150709_ENT.Entities;
using _2014150709_PER.EntitiesConfigurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150709_PER
{
    public class LineasNuevasDbContext : DbContext
    {
        public DbSet<AdministradorEquipo> AdministradorEquipo { get; set; }
        public DbSet<EquipoCelular> EquipoCelular { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Admin");
            modelBuilder.Configurations.Add(new AdministradorEquipoConfiguration());
            modelBuilder.Configurations.Add(new EquipoCelularConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
