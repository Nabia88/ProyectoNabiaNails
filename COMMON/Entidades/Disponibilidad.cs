using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Entidades
{
    public class Disponibilidad : CamposControl
    {
        public int IdDisponibilidad { get; set; }
        public string DiaSemana { get; set; } // Dias trabajar
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
    }
}
