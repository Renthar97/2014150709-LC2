using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150709_ENT.Entities
{
    public class CentroAtencion
    {
        public int CentroAtencionId { get; set; }
        public virtual Direccion DireccionId { get; set; }
        public string Nombre { get; set; }
    }
}
