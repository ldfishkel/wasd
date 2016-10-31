namespace ClinicaFrba.AbmAfiliado
{
    using DataAccess;
    using DataAccess.DAO;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    public partial class AltaAfiliadoForm : Form
    {
        private readonly AfiliadoDao _afiliadoDao;

        private Afiliado _afiliado;

        public Afiliado AfiliadoAlta
        {
            get
            {
                return _afiliado;
            }
        }

        public AltaAfiliadoForm(AfiliadoDao afiliadoDao)
        {
            InitializeComponent();

            _afiliadoDao = afiliadoDao;

            _afiliado = new Afiliado()
            {
                Afiliado1 = new List<Afiliado>()
            };

            InitializeCombos();
        }

        private void InitializeCombos()
        {
            _tipoDoc.Items.AddRange(_afiliadoDao.GetTipoDeDocumentos());

            _estadoCivil.Items.AddRange(_afiliadoDao.GetEstadosCiviles());

            _planMedico.Items.AddRange(_afiliadoDao.PlanesMedicos().ToArray());

            _sexo.Items.AddRange(new string[] { "M", "F", "X" });
        }

        private bool ValidateFields()
        {
            StringBuilder sb = new StringBuilder();

            if (String.IsNullOrWhiteSpace(_nombre.Text))
                sb.AppendLine("Debe completar el nombre");

            if (String.IsNullOrWhiteSpace(_apellido.Text))
                sb.AppendLine("Debe completar el apellido");

            if (String.IsNullOrWhiteSpace(_tipoDoc.Text))
                sb.AppendLine("Debe completar el Tipo de documento");

            if (String.IsNullOrWhiteSpace(_direccion.Text))
                sb.AppendLine("Debe completar el campo direccion");

            if (!(new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?").IsMatch(_mail.Text)))
                sb.AppendLine("Campo e-mail incorrecto");

            if (String.IsNullOrWhiteSpace(_telefono.Text))
                sb.AppendLine("Debe completar el campo telefono");

            if (String.IsNullOrWhiteSpace(_sexo.Text))
                sb.AppendLine("Debe completar el campo sexo");

            int result;
            if (!Int32.TryParse(_telefono.Text, out result))
                sb.AppendLine("Telefono incorrecto");

            if (_planMedico.SelectedItem == null)
                sb.AppendLine("Debe seleccionar un plan medico");

            if (sb.Length != 0)
            {
                MessageBox.Show(sb.ToString());
                return false;
            }

            return true;
        }

        private void BuildAfiliado()
        {
            _afiliado.afiliado_numero = 1;
            _afiliado.afiliado_nombre = _nombre.Text;
            _afiliado.afiliado_apellido = _apellido.Text;
            _afiliado.afiliado_sexo = _sexo.Text;
            _afiliado.afiliado_tipodocumento = _tipoDoc.Text;
            _afiliado.afiliado_numero_documento = Int32.Parse(_numeroDocumento.Text);
            _afiliado.afiliado_direccion = _direccion.Text;
            _afiliado.afiliado_telefono = Int32.Parse(_telefono.Text);
            _afiliado.estadocivil_id = ((EstadoCivil)_estadoCivil.SelectedItem).estadocivil_id;
            _afiliado.afiliado_mail = _mail.Text;
            _afiliado.afiliado_fecha_nacimiento = _fechaNacimiento.Value;
            _afiliado.planmedico_id = ((PlanMedico)_planMedico.SelectedItem).planmedico_id;
        }

        private void CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (senderGrid.Rows[e.RowIndex].Cells[1].Value.ToString() == "Conyugue")
                {
                    _agregarConyugueBtn.Enabled = true;
                    _estadoCivil.Enabled = true;
                }

                _afiliado.Afiliado1.Remove(_afiliado.Afiliado1.SingleOrDefault(x => x.ToString() == senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString()));

                RefreshFamiliares(null, null);
            }
        }

        private void AceptarClick(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            BuildAfiliado();

            var response = _afiliadoDao.AltaAfiliado(_afiliado);

            if (response.status == 0)
                foreach (Afiliado a in _afiliado.Afiliado1)
                {
                    response = _afiliadoDao.AltaAfiliado(a);
                    if (response.status == 1)
                        break;
                }

            if (response.status == 1)
                if (response.errorMessage.Contains("UNIQUE"))
                    MessageBox.Show(String.Format("Ya existe un afiliado con el numero de documento {0}", response.errorMessage.Substring(response.errorMessage.IndexOf("("))));
            else
                Close();
        }

        private void AgregarFamiliarClick(object sender, EventArgs e)
        {
            ShowAgregarFamiliarForm(TipoDeFamiliar.ACargo);
        }

        private void AgregarConyugueClick(object sender, EventArgs e)
        {
            ShowAgregarFamiliarForm(TipoDeFamiliar.Conyugue);
        }

        private void ShowAgregarFamiliarForm(TipoDeFamiliar tipo)
        {
            AltaFamiliarForm altaConyugueForm = new AltaFamiliarForm(_afiliadoDao, this, tipo);

            altaConyugueForm.FormClosing += RefreshFamiliares;

            altaConyugueForm.Show();
        }

        private void RefreshFamiliares(object sender, FormClosingEventArgs e)
        {
            _afiliadosACargo.Rows.Clear();

            if (_afiliado.Afiliado1.Any(x => x.afiliado_numero == 2))
            {
                _agregarConyugueBtn.Enabled = false;
                _estadoCivil.Enabled = false;
            }

            foreach (Afiliado afiliado in _afiliado.Afiliado1)
                _afiliadosACargo.Rows.Add(
                        afiliado,
                        (afiliado.afiliado_numero == 2 ? "Conyugue" : "Familiar a cargo"),
                        "Quitar"
                    );
        }

        private void EstadoCivilChanged(object sender, EventArgs e)
        {
            string[] conyugueOptions = { "Casado/a", "Concubinato" };

            if (conyugueOptions.Contains(_estadoCivil.SelectedItem.ToString()))
                _agregarConyugueBtn.Enabled = true;
            else
                _agregarConyugueBtn.Enabled = false;
        }
    }
}
