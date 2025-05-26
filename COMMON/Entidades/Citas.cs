using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Entidades
{
    public class Citas : CamposControl
    {
        public int IdCita { get; set; }
        public int IdUsuario { get; set; }
        public int IdServicio { get; set; }
        public DateTime FechaHoraCita { get; set; }
        public string Estado { get; set; } // 'Pendiente', 'Confirmada', 'Cancelada'
    }
}
