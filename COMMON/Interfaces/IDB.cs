using COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.Interfaces
{
    /// <summary>
    /// Interface que define el comportamiento de una clase para la comunicación con una base de datos.
    /// </summary>
    /// <typeparam name="T">Tipo de clase que extiende de CamposControl</typeparam>
    public interface IDB<T> where T : CamposControl
    {
        /// <summary>
        /// Obtiene el mensaje de error generado en la última operación realizada.
        /// </summary>
        string Error { get; }

        /// <summary>
        /// Obtiene todos los registros de la tabla correspondiente.
        /// </summary>
        /// <returns>Lista de objetos que representan todos los registros.</returns>
        List<T> ObtenerTodos();

        /// <summary>
        /// Obtiene un registro específico mediante un identificador entero.
        /// </summary>
        /// <param name="id">Id entero del registro a obtener.</param>
        /// <returns>Objeto correspondiente al Id proporcionado.</returns>
        T ObtenerPorId(int id);

        /// <summary>
        /// Obtiene un registro específico mediante un identificador de tipo cadena.
        /// </summary>
        /// <param name="id">Id en formato string del registro a obtener.</param>
        /// <returns>Objeto correspondiente al Id proporcionado.</returns>
        T ObtenerPorId(string id);

        /// <summary>
        /// Elimina un registro de la base de datos.
        /// </summary>
        /// <param name="entidad">Entidad a eliminar.</param>
        /// <returns>True si se eliminó correctamente, false en caso contrario.</returns>
        bool Eliminar(T entidad);

        /// <summary>
        /// Inserta un nuevo registro en la base de datos
        /// </summary>
        /// <param name="entidad">Entidad a insertar.</param>
        /// <returns>Entidad insertada con los datos generados (por ejemplo, Id)</returns>
        T Insertar(T entidad);

        /// <summary>
        /// Actualiza un registro existente en la base de datos
        /// </summary>
        /// <param name="entidad">Entidad con los datos actualizados</param>
        /// <returns>Entidad actualizada.</returns>
        T Actualizar(T entidad);

        /// <summary>
        /// Ejecuta un procedimiento almacenado en la base de datos y obtiene una lista de resultados.
        /// </summary>
        /// <typeparam name="M">Tipo de clase que representa el modelo de los resultados.</typeparam>
        /// <param name="nombre">Nombre del procedimiento almacenado a ejecutar.</param>
        /// <param name="parametros">Diccionario de parámetros a enviar al procedimiento.</param>
        /// <returns>Lista de objetos que representan los resultados devueltos por el procedimiento.</returns>
        List<M> EjecutarProcedimiento<M>(string nombre, Dictionary<string, string> parametros) where M : class;
    }
}
