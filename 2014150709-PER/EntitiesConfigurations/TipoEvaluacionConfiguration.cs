using _2014150709_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150709_PER.EntitiesConfigurations
{
    public class TipoEvaluacionConfiguration : EntityTypeConfiguration<TipoEvaluacion>
    {
        public TipoEvaluacionConfiguration()
        {
            ToTable("Tipo_Evaluacion");
            HasKey(t => t.TipoEvaluacion_Id);
        }
    }
}
