using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;

namespace CapaControlador
{
    public class clsControladorAplicacion
    {
        Sentencias sn = new Sentencias();

        public void insertarAplicacion(string Id, string Nombre, int Estado)
        {
           sn.funInsertar(Id, Nombre, Estado);
        }

   }

    
}
