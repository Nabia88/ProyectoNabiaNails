using Azure;
using COMMON.Entidades;
using COMMON.Interfaces;
using COMMON.Validadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FabricRepository
    {
        private string _cadenaConexion;
        private TipoDB _tipo;

        public FabricRepository(string cadenaConexion, TipoDB tipo)
        {
            _cadenaConexion = cadenaConexion;
            _tipo = tipo;
        }

        public IDB<Citas> CitasRepository()
        {
            switch (_tipo)
            {
                case TipoDB.SQLServer:
                case TipoDB.MySql:
                    return new DBSqlServer<Citas>(_cadenaConexion, new CitasValidator(), "IdCita", true);
                default:
                    return null;
            }
        }

        public IDB<Disponibilidad> DisponibilidadRepository()
        {
            switch (_tipo)
            {
                case TipoDB.SQLServer:
                case TipoDB.MySql:
                    return new DBSqlServer<Disponibilidad>(_cadenaConexion, new DisponibilidadValidator(), "IdDisponibilidad", true);
                default:
                    return null;
            }
        }

        public IDB<HistorialClientes> HistorialClientesRepository()
        {
            switch (_tipo)
            {
                case TipoDB.SQLServer:
                case TipoDB.MySql:
                    return new DBSqlServer<HistorialClientes>(_cadenaConexion, new HistorialClientesValidator(), "IdHistorial", true);
                default:
                    return null;
            }
        }

        public IDB<Inventario> InventarioRepository()
        {
            switch (_tipo)
            {
                case TipoDB.SQLServer:
                case TipoDB.MySql:
                    return new DBSqlServer<Inventario>(_cadenaConexion, new InventarioValidator(), "IdInventario", true);
                default:
                    return null;
            }
        }

        public IDB<Pagos> PagosRepository()
        {
            switch (_tipo)
            {
                case TipoDB.SQLServer:
                case TipoDB.MySql:
                    return new DBSqlServer<Pagos>(_cadenaConexion, new PagosValidator(), "IdPago", true);
                default:
                    return null;
            }
        }

        public IDB<Servicios> ServiciosRepository()
        {
            switch (_tipo)
            {
                case TipoDB.SQLServer:
                case TipoDB.MySql:
                    return new DBSqlServer<Servicios>(_cadenaConexion, new ServiciosValidator(), "IdServicio", true);
                default:
                    return null;
            }
        }

        public IDB<Usuarios> UsuariosRepository()
        {
            switch (_tipo)
            {
                case TipoDB.SQLServer:
                case TipoDB.MySql:
                    return new DBSqlServer<Usuarios>(_cadenaConexion, new UsuariosValidator(), "IdUsuario", true);
                default:
                    return null;
            }
        }
    }

    public enum TipoDB
    {
        SQLServer,
        MySql,
        Oracle
    }
}
