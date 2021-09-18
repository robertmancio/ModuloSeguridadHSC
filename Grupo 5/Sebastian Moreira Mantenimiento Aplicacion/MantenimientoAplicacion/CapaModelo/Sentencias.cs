
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
       
        public void funInsertar(string Id, string Nombre, int estado)
        {

                    string cadena = "INSERT INTO" +
                    " `componenteseguridad`.`Aplicacion` VALUES (" + "'" + Id + "', '" + Nombre + "' , " + estado +");";

                    OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                    consulta.ExecuteNonQuery();
                   
    
        }

        /*
        public void funModificar()
        {

            if (btnHabilitado.Checked == true)
            {
                string cadena = "update componenteseguridad.aplicacion set pkId ='" + this.txtIdAplicacion.Text
                 + "',nombre ='" + this.txtNombreAplicacion.Text + "',estado ='1' where pkId= '" + txtIdAplicacion.Text + "';";


                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();

                MessageBox.Show("Modificacion realizada");
            }

            else if (btnInhabilitado.Checked == true)
            {
                string cadena = "update componenteseguridad.aplicacion set pkId ='" + this.txtIdAplicacion.Text
                 + "',nombre ='" + this.txtNombreAplicacion.Text + "',estado ='0' where pkId= '" + txtIdAplicacion.Text + "';";


                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();

                MessageBox.Show("Modificacion realizada");
            }





            txtIdAplicacion.Text = "";
            txtNombreAplicacion.Text = "";
            btnHabilitado.Checked = false;
            btnInhabilitado.Checked = false;

        }

       */


        /*
        public void funBuscar()
        {

            int estado = 0;
            string Query = "select * from `componenteseguridad`.`Aplicacion` where pkId='" + this.txtIdAplicacion.Text + "';";

            OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
            consulta.ExecuteNonQuery();

            OdbcDataReader busqueda;
            busqueda = consulta.ExecuteReader();

            if (busqueda.Read())
            {

                txtNombreAplicacion.Text = busqueda["nombre"].ToString();
                estado = int.Parse(busqueda["estado"].ToString());

            }
            else
            {
                MessageBox.Show("Registro no encontrado");
            }


            if (estado == 1)
            {
                btnHabilitado.Checked = true;
            }
            else if (estado == 0)
            {
                btnInhabilitado.Checked = true;
            }


        }
        */

        /*
        private void funEliminar()
        {

            try
            {
                funBuscar();
                string cadena = "delete from componenteseguridad.aplicacion where pkId='" + this.txtIdAplicacion.Text + "';";

                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();

                OdbcDataReader busqueda;
                busqueda = consulta.ExecuteReader();

                MessageBox.Show("Datos Eliminados");
                while (busqueda.Read())
                {
                }
                txtIdAplicacion.Text = "";
                txtNombreAplicacion.Text = "";
                btnHabilitado.Checked = false;
                btnInhabilitado.Checked = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        */
       
    }
}
