using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Text;

namespace CapaModelo
{
    class IniciarSesion
    {
        public void clickIniciarUsuario(object sender, EventArgs e)
        {

            string nombre = vista.txtNombre.Text;
            List<string> contraseñaHasheada = daoUsuario.obtenerDatosDeUsuario(nombre);
            string contraseñaObtenidaHasheada = "";
            bool esValido = false;
            if (contraseñaHasheada != null)
            {
                foreach (var contraseña in contraseñaHasheada)
                {
                    contraseñaObtenidaHasheada = contraseña;
                }

                esValido = BCrypt.Net.BCrypt.EnhancedVerify(vista.txtContraseña.Text, contraseñaObtenidaHasheada, hashType: HashType.SHA384);
            }

            if (esValido)
            {
                vista.Hide();

                abrirForm(new formPolideportivo());

            }

        }

    }
}
