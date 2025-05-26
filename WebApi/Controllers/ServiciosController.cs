using COMMON.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiciosController : GenericController<Servicios>
    {
        public ServiciosController() : base(Parametros.FabricaRepository.ServiciosRepository())
        {

        }
    }
}

