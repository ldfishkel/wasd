namespace ClinicaFrba.Menu
{
    using ClinicaFrba.DataAccess;
    using System;
    using System.Windows.Forms;

    public partial class MenuForm : Form
    {
        public MenuForm(Usuario usuario, Rol rol)
        {
            InitializeComponent();

            label1.Text = String.Format("Estas logueado con el usuario nro {0}, con el rol {1}", usuario.usuario_id, rol.rol_nombre);
        }
    }
}
