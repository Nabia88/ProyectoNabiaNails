using COMMON.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Validadores
{
    public abstract class CamposControlValidator<T> : AbstractValidator<T> where T : CamposControl
    {
        public CamposControlValidator()
        {
            RuleFor(c => c.FechaAlta).NotEmpty().GreaterThanOrEqualTo(new DateTime(2025, 1, 1));
            RuleFor(c => c.UsuarioAlta).NotEmpty().MaximumLength(50).MinimumLength(5);
            RuleFor(c => c.UsuarioMod).MaximumLength(50);
        }
    }
}