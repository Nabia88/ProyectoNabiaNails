using COMMON.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistorialClientesController : GenericController<HistorialClientes>
    {
        public HistorialClientesController() : base(Parametros.FabricaRepository.HistorialClientesRepository())
        {

        }
    }
}
