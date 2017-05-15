using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014150709_ENT.Entities
{
    public class Venta
    {
        public int Codigo_venta { get; set; }
        public virtual LineaTelefonica LineaTelefonicaId { get; set; }
        public virtual CentroAtencion CentroAtencionId { get; set; }
        public virtual Contrato ContratoId { get; set; }
        public virtual TipoPago TipoPagoId { get; set; }
        public virtual Cliente ClienteId { get; set; }
        public virtual Evaluacion EvaluacionId { get; set; }
    }
}
