using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150709_ENT.Entities
{
    public class Trabajador
    {
        public int Trabajador_Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Dni { get; set; }

        public virtual TipoTrabajador Tipo { get; set; }
    }
}
