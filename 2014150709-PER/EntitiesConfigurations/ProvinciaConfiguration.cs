using _2014150709_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150709_PER.EntitiesConfigurations
{
    public class ProvinciaConfiguration : EntityTypeConfiguration<Provincia>
    {
        public ProvinciaConfiguration()
        {
            ToTable("Provincia");
            HasKey(p => new { p.Departamento_id, p.Provincia_Id});

            HasRequired(p => p.Departamento)
                .WithMany(d => d.Provincia)
                .HasForeignKey(d => d.Departamento_id);
        }
    }
}
