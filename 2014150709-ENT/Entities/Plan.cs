using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150709_ENT.Entities
{
    public class Plan
    {
        public int Plan_Id { get; set; }
        public string Descripcion { get; set; }

        public TipoPlan TipoPlan_Id { get; set; }
    }
}
