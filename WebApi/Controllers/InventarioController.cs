using COMMON.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventarioController : GenericController<Inventario>
    {
        public InventarioController() : base(Parametros.FabricaRepository.InventarioRepository())
        {

        }
    }
}
