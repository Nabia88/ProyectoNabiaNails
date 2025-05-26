using COMMON.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Validadores
{
    public class UsuariosValidator : CamposControlValidator<Usuarios>
    {
        public UsuariosValidator()
        {
            RuleFor(u => u.Nombre).NotEmpty().MaximumLength(100);
            RuleFor(u => u.Apellidos).NotEmpty().MaximumLength(100);
            RuleFor(u => u.Telefono).MaximumLength(15);
            RuleFor(u => u.Email).NotEmpty().EmailAddress().MaximumLength(100);
            RuleFor(u => u.Password).NotEmpty().MinimumLength(6).MaximumLength(255);
            RuleFor(u => u.Rol).NotEmpty().Must(r => r == "Cliente" || r == "Manicurista");
        }
    }

}
