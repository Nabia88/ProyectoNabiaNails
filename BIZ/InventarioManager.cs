using COMMON.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    public class InventarioManager : GenericManager<Inventario>
    {
        public InventarioManager(AbstractValidator<Inventario> validador) : base(validador)
        {
        }
    }
}
