using COMMON.Entidades;
using COMMON.Validadores;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Validadores
{
    public class HistorialClientesValidator : CamposControlValidator<HistorialClientes>
    {
    public HistorialClientesValidator()
      {
        RuleFor(h => h.IdUsuario).NotEmpty();
        RuleFor(h => h.Descripcion).NotEmpty().MaximumLength(500);
      }
    }
}
