namespace ClinicaFrba.AbmAfiliado
{
    using DataAccess;
    using DataAccess.DAO;
    using System.Text;
    using System.Windows.Forms;
    using System;

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

            BuildAfiliado();

            string motivo = _planMedico.SelectedItem != null ? _motivo.Text : null;
            
            _afiliadoDao.UpdateAfiliado(_afiliado, motivo);
        }

        private void BuildAfiliado()
        {
            throw new NotImplementedException();
        }

        private bool ValidateFields()
        {
            StringBuilder sb = new StringBuilder();

            if (sb.Length != 0)
            {
                MessageBox.Show(sb.ToString());
                return false;
            }

            return true;
        }
    }
}
