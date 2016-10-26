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

        public Afiliado AfiliadoAlta {
            get
            {
                return _afiliado;
            }
        }

        public AltaAfiliadoForm(AfiliadoDao afiliadoDao)
        {
            InitializeComponent();

            _afiliadoDao = afiliadoDao;

            InitializeCombos();
        }

        private void InitializeCombos()
        {
            _tipoDoc.Items.AddRange(_afiliadoDao.GetTipoDeDocumentos());

            _estadoCivil.Items.AddRange(_afiliadoDao.GetEstadosCiviles());

            _sexo.Items.AddRange(new string[] { "M", "F", "X" });
        }

        private void ValidarAfiliadoClick(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            BuildAfiliado();

            var result = DialogResult.No;

            TipoDeFamiliar tipo = TipoDeFamiliar.ACargo;

            if (_afiliado.estadocivil_id == 1)
            {
                result = MessageBox.Show("Desea agregar a su conyugue?", "Casado o en concubinato", MessageBoxButtons.YesNo);

                tipo = TipoDeFamiliar.Conyugue;
            }
            else
                result = MessageBox.Show("Desea agregar persona a cargo?", "Persona a cargo", MessageBoxButtons.YesNo);

            ShowAgregarFamiliarForm(result, tipo);

            _aceptarBtn.Enabled = true;
        }

        private void RefreshFamiliares(object sender, FormClosingEventArgs e)
        {
            _afiliadosACargo.Rows.Clear();

            foreach (Afiliado afiliado in _afiliado.Afiliado1)
                _afiliadosACargo.Rows.Add(
                        afiliado,
                        (afiliado.afiliado_numero == 2 ? "Conyugue" : "Familiar a cargo"),
                        "Quitar"
                    );

            if (sender != null)
            {
                DialogResult result = MessageBox.Show("Desea agregar mas personas a cargo?", "Personas a cargo", MessageBoxButtons.YesNo);

                ShowAgregarFamiliarForm(result, TipoDeFamiliar.ACargo);
            }
        }

        private void ShowAgregarFamiliarForm(DialogResult result, TipoDeFamiliar tipo)
        {
            if (result == DialogResult.Yes)
            {
                AltaFamiliarForm altaConyugueForm = new AltaFamiliarForm(this, tipo);

                altaConyugueForm.FormClosing += RefreshFamiliares;

                altaConyugueForm.Show();
            }
        }

        private bool ValidateFields()
        {
            StringBuilder sb = new StringBuilder();

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
            _afiliado = new Afiliado();

            _afiliado.Afiliado1 = new List<Afiliado>();

            // TODO Llenar _afiliado con los datos de los campos
        }

        private void CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                _afiliado.Afiliado1.Remove(_afiliado.Afiliado1.SingleOrDefault(x => x.ToString() == senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString()));

                RefreshFamiliares(null, null);
            }
        }

        private void AceptarClick(object sender, EventArgs e)
        {
            _afiliadoDao.AltaAfiliado(_afiliado);
        }

        private void CancelarClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
