using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150709_ENT.Entities
{
    public class AdministradorEquipo
    {
        public int AdministradorEquipo_Id { get; set; }

        public string Nombre_AdEquipo { get; set; }
        public string Apellido_Paterno_AdEquipo { get; set; }
        public string Apellido_Materno_AdEquipo { get; set; }
        public string Dni { get; set; }
    }
}
