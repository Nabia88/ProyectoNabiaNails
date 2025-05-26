using COMMON.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisponibilidadController : GenericController<Disponibilidad>
    {
        public DisponibilidadController() : base(Parametros.FabricaRepository.DisponibilidadRepository())
        {

        }
    }
}
