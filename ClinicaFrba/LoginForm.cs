namespace ClinicaFrba
{
    using DataAccess;
    using DataAccess.DAO;
    using Menu;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;


    public partial class LoginForm : Form
    {
        private UsuarioDao _usuarioDao;
        private MenuForm _menuForm;

        private int _userId;

        public LoginForm(UsuarioDao usuarioDao, MenuForm menuForm)
        {
            InitializeComponent();

            _usuarioDao = usuarioDao;
            _menuForm = menuForm;
        }

        private void SubmitLogin(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(_password.Text) || String.IsNullOrEmpty(_username.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
                return;
            }

            UsuarioDao userDao = new UsuarioDao();

            Login_Result result = _usuarioDao.Login(_username.Text, _password.Text);

            MessageBox.Show(result.message);

            if (result.usuario_id == null)
                return;

            _userId = result.usuario_id.Value;

            List<Rol> roles = userDao.GetRoles(result.usuario_id.Value);

            if (roles == null || roles.Count == 0)
            {
                MessageBox.Show("El usuario ingresado no tiene ningun rol");
                return;
            }

            if (roles.Count > 1)
            {
                _rolCombobox.Items.AddRange(roles.ToArray());

                _rolSelectionGroupbox.Enabled = true;
                _loginGroupbox.Enabled = false;

                return;
            }

            OpenMenuForm(roles.FirstOrDefault());
        }

        private void OpenMenuForm(Rol rol)
        {
            this.Hide();

            _menuForm.Init(_userId, rol, this.CloseForm);
            _menuForm.Show();
        }

        private void CloseForm(object sender, FormClosingEventArgs e)
        {
            this.Close();
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
