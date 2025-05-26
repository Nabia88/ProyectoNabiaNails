using COMMON.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagosController : GenericController<Pagos>
    {
        public PagosController() : base(Parametros.FabricaRepository.PagosRepository())
        {

        }
    }
}

