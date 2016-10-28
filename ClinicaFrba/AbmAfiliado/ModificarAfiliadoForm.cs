namespace ClinicaFrba.AbmAfiliado
{
    using DataAccess;
    using DataAccess.DAO;
    using System.Text;
    using System.Windows.Forms;
    using System;
    using System.Text.RegularExpressions;

    public partial class ModificarAfiliadoForm : Form
    {
        private Afiliado _afiliado;
        private AfiliadoDao _afiliadoDao;

        public ModificarAfiliadoForm(Afiliado afiliado, AfiliadoDao afiliadoDao)
        {
            InitializeComponent();

            _afiliado = afiliado;
            _afiliadoDao = afiliadoDao;

            InitializeCombos();

            InitializeFields();
        }

        private void InitializeCombos()
        {
            _estadoCivil.Items.AddRange(_afiliadoDao.GetEstadosCiviles());

            _planMedico.Items.AddRange(_afiliadoDao.PlanesMedicos().ToArray());
        }

        private void InitializeFields()
        {
            _direccion.Text = _afiliado.afiliado_direccion;
            _telefono.Text = _afiliado.afiliado_telefono.ToString();
            _mail.Text = _afiliado.afiliado_mail;
            _estadoCivil.Text = _afiliado.EstadoCivil.ToString();
            _planMedico.Text = _afiliado.PlanMedico.ToString();
        }

        private void GuardarClick(object sender, System.EventArgs e)
        {
            if (!ValidateFields())
                return;

            string motivo = BuildAfiliado();

            _afiliadoDao.UpdateAfiliado(_afiliado, motivo);

            Close();
        }

        private string BuildAfiliado()
        {
            string motivo = _planMedico.SelectedItem != null && _planMedico.Text != _afiliado.PlanMedico.ToString() ? _motivo.Text : null;

            _afiliado.afiliado_telefono = Int32.Parse(_telefono.Text);
            _afiliado.afiliado_mail = _mail.Text;
            _afiliado.afiliado_direccion = _direccion.Text;

            if (_planMedico.SelectedItem != null)
                _afiliado.planmedico_id = ((PlanMedico)_planMedico.SelectedItem).planmedico_id;
            else
                _afiliado.planmedico_id = _afiliado.PlanMedico.planmedico_id;

            if (_estadoCivil.SelectedItem != null)
                _afiliado.estadocivil_id = ((EstadoCivil)_estadoCivil.SelectedItem).estadocivil_id;
            else
                _afiliado.estadocivil_id = _afiliado.EstadoCivil.estadocivil_id;

            return motivo;
        }

        private bool ValidateFields()
        {
            StringBuilder sb = new StringBuilder();

            if (_planMedico.SelectedItem != null && _planMedico.Text != _afiliado.PlanMedico.ToString() && String.IsNullOrWhiteSpace(_motivo.Text))
                sb.AppendLine("Si cambias el plan tenes que poner un motivo");

            if (String.IsNullOrWhiteSpace(_direccion.Text))
                sb.AppendLine("Debe completar el campo direccion");

            if (!(new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?").IsMatch(_mail.Text)))
                sb.AppendLine("Campo e-mail incorrecto");

            if (String.IsNullOrWhiteSpace(_telefono.Text))
                sb.AppendLine("Debe completar el campo telefono");

            int result;
            if (!Int32.TryParse(_telefono.Text, out result))
                sb.AppendLine("Telefono incorrecto");

            if (sb.Length != 0)
            {
                MessageBox.Show(sb.ToString());
                return false;
            }

            return true;
        }
    }
}
