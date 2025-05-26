using COMMON.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace COMMON.Validadores
{
    public class DisponibilidadValidator : CamposControlValidator<Disponibilidad>
    {
        public DisponibilidadValidator()
        {
            RuleFor(d => d.DiaSemana).NotEmpty().Must(d => d == "Lunes" || d == "Martes" || d == "Miércoles" || d == "Jueves" || d == "Viernes" || d == "Sábado" || d == "Domingo");
            RuleFor(d => d.HoraInicio).NotEmpty();
            RuleFor(d => d.HoraFin).NotEmpty().GreaterThan(d => d.HoraInicio);
        }
    }
}