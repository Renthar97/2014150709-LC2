using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150709_ENT.Entities
{
    public class Provincia
    {
        public int Provincia_Id { get; set; }
        public virtual Departamento Departamento { get; set; }

        public int Departamento_id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Distrito> Distrito { get; private set; }

    }
}
