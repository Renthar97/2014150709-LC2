using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150709_ENT.Entities
{
    public class Direccion
    {
        public int DireccionId { get; set; }
        public string Adress { get; set; }

        public virtual Ubigeo UbigeoId { get; set; }
    }
}
