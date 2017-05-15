using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150709_ENT.Entities
{
    public class Evaluacion
    {
        public int Evaluacion_Id { get; set; }
        public virtual Plan Plan_Id { get; set; }
        public virtual EquipoCelular EquipoCelular_Id { get; set; }
        public virtual LineaTelefonica LineaTelefonica_Id { get; set; }
        public virtual CentroAtencion CentroAtencion_Id { get; set; }
        
        public virtual Cliente Cliente_id { get; set; }
        public virtual TipoEvaluacion TipoEvaluacion_id { get; set; }
        public virtual EstadoEvaluacion EstadoEvaluacion { get; set; }
        public virtual Trabajador Trabajador_Id { get; set; }
    }
}
