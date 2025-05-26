using COMMON.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : GenericController<Usuarios>
    {
        public UsuariosController() : base(Parametros.FabricaRepository.UsuariosRepository())
        {

        }
    }
}
