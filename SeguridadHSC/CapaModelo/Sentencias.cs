using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class Sentencias
    {

      
        Conexion cn = new Conexion();
        OdbcCommand Comm;
        //frmLogin
        public int funIniciarSesion(string Usuario, string Contraseña, int validar)
        {
            try
            {
                string con = "";

                string Query = "select * from `componenteseguridad`.`Usuario` where nombre='" + Usuario + "';";

                OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
                consulta.ExecuteNonQuery();

                OdbcDataReader busqueda;
                busqueda = consulta.ExecuteReader();

                if (busqueda.Read())
                {
                    con = busqueda["contraseña"].ToString();
                }

                validar = Contraseña.CompareTo(con);


            }
            catch
            {

            }

            return validar;


        }


        //frmMantenimientoAplicacion
        public void funInsertar(string Id, string Nombre, int estado, string ruta)
        {

            string cadena = "INSERT INTO" +
            " `componenteseguridad`.`Aplicacion` VALUES (" + "'" + Id + "', '" + Nombre + "' , " + estado + ", '" + ruta + "');";

            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();


        }


        public void funModificar(string Id, string Nombre, int estado, string ruta)
        {

            string cadena = "UPDATE componenteseguridad.aplicacion set pkId ='" + Id
              + "',nombre ='" + Nombre + "',estado = " + estado + ", idReporteAsociado = '" + ruta + "'  where pkId= '" + Id + "';";


            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();




        }

        public void funEliminar(string Id)
        {

            string cadena = "delete from componenteseguridad.aplicacion where pkId ='" + Id + "';";


            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();

        }




        public (string, int) funBuscar(string id, string nombre, int estado, string ruta)
        {


            string Query = "select * from `componenteseguridad`.`Aplicacion` where pkId='" + id + "';";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {

                nombre = busqueda["nombre"].ToString();
                estado = int.Parse(busqueda["estado"].ToString());

            }


            return (nombre, estado);


        }

    }
}
