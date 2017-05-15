using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150709_ENT.Entities
{
    public class EquipoCelular
    {
        public int EquipoCelular_Id { get; set; }

        public string Nombre_Equipo { get; set; }
        public string Marca_Equipo { get; set; }

        public AdministradorEquipo AdministradorEquipo_Id { get; set; }
    }
}
