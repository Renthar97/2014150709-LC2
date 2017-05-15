using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150709_ENT.Entities
{
    public class Distrito
    {
        public int Distrito_Id { get; set; }
        public virtual Provincia Provincia { get; set; }
        public virtual Departamento Departamento { get; set; }

        
        public string Nombre { get; set; }
    }
}
