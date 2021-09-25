using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class frmMIDSeguridad : Form
    {
        public frmMIDSeguridad()
        {
            InitializeComponent();
            CenterToScreen();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new frmLoginHSC();
            form2.Closed += (s, args) => this.Hide();
            form2.Show();

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            //nombreform form3 = new nombreform();
            //form3.MdiParent = this.MdiParent;

            //form3.Show();

        }

        private void btnAplicacion_Click(object sender, EventArgs e)
        {
            frmMantenimientoAplicacion form3 = new frmMantenimientoAplicacion();
            form3.MdiParent = this.MdiParent;

            form3.Show();
        }

        private void btnModulos_Click(object sender, EventArgs e)
        {

        }

        private void btnPerfiles_Click(object sender, EventArgs e)
        {

        }

        private void btnAsignacionDeAplicacionAUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void btnAsignacionDeAplicacionesAPerfiles_Click(object sender, EventArgs e)
        {

        }

        private void btnCambioContraseña_Click(object sender, EventArgs e)
        {

        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {

        }
    }
}
