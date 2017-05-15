using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150709_ENT.Entities
{
    public class Cliente
    {
        public int Cliente_Id { get; set; }
        public string Nombre { get; set; }
        public string  Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Telefono { get; set; }
    }
}
