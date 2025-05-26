using COMMON.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitasController : GenericController<Citas>
    {
        public CitasController() : base(Parametros.FabricaRepository.CitasRepository())
        {

        }
    }
}
