namespace ClinicaFrba
{
    using DataAccess;
    using DataAccess.DAO;
    using Menu;
    using System;
    using System.Linq;
    using System.Windows.Forms;


    public partial class LoginForm : Form
    {
        private UsuarioDao _usuarioDao;

        private Usuario _user;

        public LoginForm(UsuarioDao usuarioDao)
        {
            InitializeComponent();

            _usuarioDao = usuarioDao;
        }

        private void SubmitLogin(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(_password.Text) || String.IsNullOrEmpty(_username.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
                return;
            }

            UsuarioDao userDao = new UsuarioDao();

            _user = _usuarioDao.Login(_username.Text, _password.Text);

            if (_user == null)
            {
                MessageBox.Show("Username o contraseña invalido");
                return;
            }

            if (_user.Rols == null || _user.Rols.Count == 0)
            {
                MessageBox.Show("El usuario ingresado no tiene ningun rol");
                return;
            }

            if (_user.Rols.Count > 1)
            {
                _rolCombobox.Items.AddRange(_user.Rols.ToArray());

                _rolSelectionGroupbox.Enabled = true;
                _loginGroupbox.Enabled = false;

                return;
            }

            OpenMenuForm(_user.Rols.FirstOrDefault());
        }

        private void OpenMenuForm(Rol rol)
        {
            this.Hide();

            var menuForm = new MenuForm(_user, rol, this);

            menuForm.Show();
        }

        private void LoginWithRolClick(object sender, EventArgs e)
        {
            var rol = _rolCombobox.SelectedItem;

            if (rol == null)
            {
                MessageBox.Show("Debes seleccionar un rol");
                return;
            }

            OpenMenuForm((Rol)_rolCombobox.SelectedItem);
        }
    }
}
