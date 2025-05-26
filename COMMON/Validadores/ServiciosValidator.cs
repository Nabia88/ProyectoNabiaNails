using COMMON.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Validadores
{
    public class ServiciosValidator : CamposControlValidator<Servicios>
    {
        public ServiciosValidator()
        {
            RuleFor(s => s.Nombre).NotEmpty().MaximumLength(100);
            RuleFor(s => s.Descripcion).NotEmpty().MaximumLength(500);
            RuleFor(s => s.Precio).GreaterThan(0);
        }
    }
}