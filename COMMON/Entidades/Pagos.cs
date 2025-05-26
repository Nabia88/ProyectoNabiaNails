using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Entidades
{
    public class Pagos : CamposControl
    {
        public int IdPago { get; set; }
        public int IdCita { get; set; }
        public decimal Monto { get; set; }
        public string MetodoPago { get; set; } // 'Efectivo', 'Transferencia'
    }
}
