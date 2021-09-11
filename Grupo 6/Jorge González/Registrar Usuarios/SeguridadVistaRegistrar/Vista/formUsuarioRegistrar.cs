using Controlador;
using System.Windows.Forms;

namespace Vista
{
    public partial class formUsuarioRegistrar : Form
    {
        public formUsuarioRegistrar()
        {
            InitializeComponent();
            controladorUsuarioRegistrar controladorUsuarioRegistrar = new controladorUsuarioRegistrar(this);
        }
    }
}