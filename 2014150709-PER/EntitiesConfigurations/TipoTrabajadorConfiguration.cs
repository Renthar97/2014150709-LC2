using _2014150709_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150709_PER.EntitiesConfigurations
{
    public class TipoTrabajadorConfiguration : EntityTypeConfiguration<TipoTrabajador>
    {
        public TipoTrabajadorConfiguration()
        {
            ToTable("Tipo_Trabajador");
            HasKey(t => t.TipoTrabajador_Id);
        }
    }
}
