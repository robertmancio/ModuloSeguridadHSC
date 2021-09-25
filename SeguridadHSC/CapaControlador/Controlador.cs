using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;

namespace CapaControlador
{
    public class Controlador
    {
        Sentencias sn = new Sentencias();

        //frmLogin
        public int InicarSesion(string Usuario, string Contraseña, int validar)
        {
            validar = sn.funIniciarSesion(Usuario, Contraseña, validar);

            return validar;
        }

        //frmMantenimientoAplicacion
        public void insertarAplicacion(string Id, string Nombre, int Estado, string Ruta)
        {
            sn.funInsertar(Id, Nombre, Estado, Ruta);
        }

        public void modificarAplicacion(string Id, string Nombre, int Estado, string Ruta)
        {
            sn.funModificar(Id, Nombre, Estado, Ruta);


        }

        public (string, int, string) buscarAplicacion(string id, string nombre, int estado, string ruta)
        {
            sn.funBuscar(id, nombre, estado, ruta);
            return (nombre, estado, ruta);
        }

        public void eliminarAplicacion(string id)
        {
            sn.funEliminar(id);
        }
    }
}
