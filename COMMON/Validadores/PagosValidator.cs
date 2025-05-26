using COMMON.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Validadores
{
    public class PagosValidator : CamposControlValidator<Pagos>
    {
        public PagosValidator()
        {
            RuleFor(p => p.IdCita).NotEmpty();
            RuleFor(p => p.Monto).NotEmpty();
            RuleFor(p => p.MetodoPago).NotEmpty().Must(m => m == "Efectivo" || m == "Tarjeta" || m == "Transferencia");
        }
    }
}
