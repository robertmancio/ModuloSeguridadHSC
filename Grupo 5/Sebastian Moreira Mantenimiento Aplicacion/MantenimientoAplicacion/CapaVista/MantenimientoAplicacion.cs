using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class MantenimientoAplicacion : UserControl
    {
        clsControladorAplicacion conAplicacion = new clsControladorAplicacion();
        public MantenimientoAplicacion()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            //funInsertar();
            //funBuscar();
            //funLimpiar();
            //funEliminar();
            //funModificar();

            
            
            try
            {
                if (btnHabilitado.Checked == true)
                {
                    conAplicacion.insertarAplicacion(txtIdAplicacion.Text, txtNombreAplicacion.Text, 1);
                    MessageBox.Show("Inserción realizada");
                    txtIdAplicacion.Text = "";
                    txtNombreAplicacion.Text = "";
                    btnInhabilitado.Checked = false;
                    btnHabilitado.Checked = false;
                }
                else if (btnInhabilitado.Checked == true)
                {
                    conAplicacion.insertarAplicacion(txtIdAplicacion.Text, txtNombreAplicacion.Text, 0);
                    MessageBox.Show("Inserción realizada");
                    txtIdAplicacion.Text = "";
                    txtNombreAplicacion.Text = "";
                    btnInhabilitado.Checked = false;
                    btnHabilitado.Checked = false;
                }
                else
                {
                    MessageBox.Show("No ha seleccionado estado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }



        }
        public void funLimpiar()
        {
            txtIdAplicacion.Text = "";
            txtNombreAplicacion.Text = "";
            btnHabilitado.Checked = false;
            btnInhabilitado.Checked = false;
        }

    }
}
