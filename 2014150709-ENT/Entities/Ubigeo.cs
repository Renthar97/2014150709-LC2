using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150709_ENT.Entities
{
    public class Ubigeo
    {
        public int UbigeoId { get; set; }
        public virtual Departamento Departamento_Id { get; set; }
        public virtual Provincia Provincia_Id { get; set; }
        public virtual Distrito Distrito_Id { get; set; }
    }
}
