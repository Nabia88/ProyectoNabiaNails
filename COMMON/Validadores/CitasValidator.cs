using COMMON.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Validadores
{
    public class CitasValidator : CamposControlValidator<Citas>
    {
        public CitasValidator()
        {
            RuleFor(c => c.IdUsuario).NotEmpty();
            RuleFor(c => c.IdServicio).NotEmpty();
            RuleFor(c => c.FechaHoraCita).NotEmpty().GreaterThan(DateTime.Now);
            RuleFor(c => c.Estado).NotEmpty().Must(e => e == "Pendiente" || e == "Confirmada" || e == "Cancelada" || e == "Completada");
        }
    }
}
