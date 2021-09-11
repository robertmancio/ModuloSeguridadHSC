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
    public partial class fmConsulta : Form
    {
        clsControlador cn = new clsControlador();
        public fmConsulta()
        {
            InitializeComponent();
        }

        //Mostrar los datos CAPA VISTA
        string tabla = "empleados";
        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarTbl(tabla);
            dtgConsulta.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            actualizardatagriew();

        }

        private void dtgConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void fmConsulta_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
