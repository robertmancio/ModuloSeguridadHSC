using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;



namespace CapaVista
{
    public partial class frmMantenimientoPerfil : Form
    {
        Controlador conAplicacion = new Controlador();
        public frmMantenimientoPerfil()
        {
            InitializeComponent();
        }

        

        public void funLimpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            btnHabilitado.Checked = false;
            btnInhabilitado.Checked = false;
            textBox3.Text = "";
            
        }



        private void btnHabilitado_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = "1";
        }

        private void btnInhabilitado_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = "0";
        }

        private void frmMantenimientoPerfil_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta línea de código carga datos en la tabla 'dataSet3.perfil' Puede moverla o quitarla según sea necesario.
                this.perfilTableAdapter.Fill(this.dataSet3.perfil);
            }
            catch (Exception Error)
            {
                Console.WriteLine("404", Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void perfilTabla_RowHeaderMouseClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = perfilTabla.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = perfilTabla.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = perfilTabla.CurrentRow.Cells[2].Value.ToString();

                if (textBox3.Text == "1")
                {
                    btnHabilitado.Checked = true;
                }
                else if (textBox3.Text == "0")
                {
                    btnInhabilitado.Checked = true;
                }
            }
            catch
            {

            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                
                conAplicacion.insertarPerfil(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text));
                MessageBox.Show("Insercion realizada");
                funLimpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            actualizarTablaDeporte();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            conAplicacion.modificarPerfil(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text));
            MessageBox.Show("Insercion realizada");
            funLimpiar();
            actualizarTablaDeporte();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conAplicacion.eliminarPerfil(textBox1.Text);
            MessageBox.Show("Eliminacion realizada");
            funLimpiar();
            actualizarTablaDeporte();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            funLimpiar();
        }


        public void actualizarTablaDeporte()
        {
            try
            {
                this.perfilTableAdapter.Fill(this.dataSet3.perfil);
                //CapaVista.deporteTableAdapter.Fill(vista.vwDeportes.deporte);
            }
            catch (Exception Error)
            {
                Console.WriteLine("404 ", Error);
            }

        }


    }




}
