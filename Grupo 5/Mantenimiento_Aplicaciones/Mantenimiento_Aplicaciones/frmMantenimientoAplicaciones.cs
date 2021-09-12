using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mantenimiento_Aplicaciones
{
    public partial class frmMantenimientoAplicaciones : Form
    {
        Conexion cn = new Conexion();
        public frmMantenimientoAplicaciones()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {

        }
        /*
        public void funInsertar()
        {
           
                string cadena = "INSERT INTO" +
                " PUESTOS (id_puesto, nombre_puesto, status_puesto) VALUES (" + "'" + txtIdaplicacion.Text + "', '" + txtNombreaplicacion.Text + txtEstatusPuesto.Text + "' ); ";

                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();
                MessageBox.Show("Inserción realizada");
            
            

            txtIdaplicacion.Text = "";
            txtNombreaplicacion.Text = "";
            txtEstatusPuesto.Text = "";
        }
        */
        /*
        public void funModificar()
        {
            
                string cadena = "update CLINICA1.PUESTOS set id_puesto ='" + this.txtIdaplicacion.Text
                    + "',nombre_puesto ='" + this.txtNombreaplicacion.Text + "',status_puesto ='" + this.txtEstado.Text + "';";


                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();

                MessageBox.Show("Modificacion realizada");




            txtIdaplicacion.Text = "";
            txtNombreaplicacion.Text = "";
            btnHabilitado.Checked = false;
            btnInhabilitado.Checked = false;

        }
        */
        public void funLimpiar()
        {
            txtIdaplicacion.Text = "";
            txtNombreaplicacion.Text = "";
            btnHabilitado.Checked = false;
            btnInhabilitado.Checked = false;
        }

        /*
        public void funBuscar()
        {
            
                string Query = "select * from CLINICA1.PUESTOS where id_puesto='" + this.txtBuscar.Text + "';";

                OdbcCommand consulta = new OdbcCommand(Query, cn.conexion());
                consulta.ExecuteNonQuery();

                OdbcDataReader busqueda;
                busqueda = consulta.ExecuteReader();

                if (busqueda.Read())
                {
                txtIdaplicacion.Text = busqueda["id_puesto"].ToString();
                txtNombreaplicacion.Text = busqueda["nombre_puesto"].ToString();
                    txtEstatusPuesto.Text = busqueda["status_puesto"].ToString();

                }
                else
                {
                    MessageBox.Show("Registro no encontrado");
                }
                this.txtBuscar.Text = "";
            
           
        }
        */
        private void funEliminar()
        {

            try
            {
                string cadena = "delete from CLINICA1.PUESTOS where id_puesto='" + this.txtIdaplicacion.Text + "';";

                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                consulta.ExecuteNonQuery();

                OdbcDataReader busqueda;
                busqueda = consulta.ExecuteReader();

                MessageBox.Show("Datos Eliminados");
                while (busqueda.Read())
                {
                }
                txtIdaplicacion.Text = "";
                txtNombreaplicacion.Text = "";
                btnHabilitado.Checked = false;
                btnInhabilitado.Checked = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
