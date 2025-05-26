using COMMON.Validadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ
{
    public static class FabricManager
    {
        public static CitasManager CitasManager => new CitasManager(new CitasValidator());
        public static DisponibilidadManager DisponibilidadManager => new DisponibilidadManager(new DisponibilidadValidator());
        public static HistorialClientesManager HistorialClientesManager => new HistorialClientesManager(new HistorialClientesValidator());
        public static InventarioManager InventarioManager => new InventarioManager(new InventarioValidator());
        public static PagosManager PagosManager => new PagosManager(new PagosValidator());
        public static ServiciosManager ServiciosManager => new ServiciosManager(new ServiciosValidator());
        public static UsuariosManager UsuariosManager => new UsuariosManager(new UsuariosValidator());

    }
}
