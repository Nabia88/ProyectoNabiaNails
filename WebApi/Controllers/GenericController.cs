using COMMON.Entidades;
using COMMON.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class GenericController<T> : ControllerBase where T : CamposControl
    {
        //CRUD
        //Create-->Post
        //Read-->Get
        //Update-->Put
        //Delete-->Delete

        private IDB<T> _repositorio;

        public GenericController(IDB<T> repositorio)
        {
            _repositorio = repositorio;
        }


        [HttpGet]

        //ObtenerTodos

        public ActionResult<List<T>> Get()
        {
            try
            {
                var datos = _repositorio.ObtenerTodos();
                if (datos != null)
                {
                    return Ok(datos);
                }
                else
                {
                    return BadRequest(_repositorio.Error);
                }
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult<T> Post([FromBody] T entidad)
        {
            try
            {
                var datos = _repositorio.Insertar(entidad);
                if (datos == null)
                {
                    return BadRequest(_repositorio.Error);
                }
                else
                {
                    return Ok(datos);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<T> GetById(string id)
        {
            try
            {
                T datos;

                // Intentar convertir el id a int.
                if (int.TryParse(id, out int intId))
                {
                    datos = _repositorio.ObtenerPorId(intId); // Llama al método que acepta int.
                }
                else
                {
                    datos = _repositorio.ObtenerPorId(id); // Llama al método que acepta string.
                }

                if (datos != null)
                {
                    return Ok(datos);
                }
                else
                {
                    return NotFound($"No se encontró el registro con ID {id}.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public ActionResult<T> Put([FromBody] T entidad)
        {
            try
            {
                var datos = _repositorio.Actualizar(entidad);
                if (datos == null)
                {
                    return BadRequest(_repositorio.Error);
                }
                else
                {
                    return Ok(datos);
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public ActionResult<bool> Delete([FromBody] T entidad)
        {
            try
            {
                var datos = _repositorio.Eliminar(entidad);
                if (datos)
                {
                    return Ok(datos);
                }
                else
                {
                    return BadRequest(_repositorio.Error);
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}