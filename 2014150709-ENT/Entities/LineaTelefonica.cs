using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150709_ENT.Entities
{
    public class LineaTelefonica
    {
        public int LineaTelefonica_Id { get; set; }
        public string Operador { get; set; }
        public string Numero { get; set; }

        public virtual TipoLinea Tipo { get; set; }

    }
}
