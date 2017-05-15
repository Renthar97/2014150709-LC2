using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150709_ENT.Entities
{
    public class Departamento
    {
        public int Departamento_Id { get; set; }
        public String Nombre { get; set; }

        public virtual ICollection<Provincia> Provincia { get; private set; }
    }
}
