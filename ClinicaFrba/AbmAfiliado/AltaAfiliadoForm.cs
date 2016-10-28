namespace ClinicaFrba.AbmAfiliado
{
    using DataAccess;
    using DataAccess.DAO;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
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

            // TODO Validar los campos AltaAfiliado
            // Ver validacion con regex en CompraBonoForm (usar regex para numeros y mail, google it)
            // Validar que los campos de texto no esten vacios ni sean WhiteSpace clase statica String. tiene esos metodos
            // Validar que los combo.SelectedItem no sean null 

            if (sb.Length != 0)
            {
                MessageBox.Show(sb.ToString());
                return false;
            }

            return true;
        }

        private void BuildAfiliado()
        {
            _afiliado.afiliado_nombre = _nombre.Text;
            _afiliado.afiliado_apellido = _apellido.Text;
            // TODO Llenar _afiliado con los datos de los campos
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
            AltaFamiliarForm altaConyugueForm = new AltaFamiliarForm(this, tipo);

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
