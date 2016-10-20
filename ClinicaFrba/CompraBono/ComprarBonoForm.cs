namespace ClinicaFrba.CompraBono
{
    using DataAccess;
    using DataAccess.DAO;
    using Menu;
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    public partial class ComprarBonoForm : Form
    {
        private AfiliadoDao _afiliadoDao;
        private PlanMedico _planMedico;

        public ComprarBonoForm(AfiliadoDao afiliadoDao)
        {
            _afiliadoDao = afiliadoDao;
        }

        public Panel Init(MenuForm parent, bool resize = true)
        {
            InitializeComponent();

            if (parent != null)
            {
                parent.Text = "Compra de Bonos";
                if (resize)
                    parent.FixBounds(_panel);
            }

            Rol rol = parent.Rol();

            if (rol.ToString() == "Afiliado")
            {
                var afiliado = parent.User().Afiliadoes.FirstOrDefault();

                _searchGroupbox.Enabled = false;

                _nombreYApellidoLbl.Text = afiliado.afiliado_nombre + " " + afiliado.afiliado_apellido;

                _planLbl.Text = afiliado.PlanMedico.planmedico_nombre;

                _nroAfliladoLbl.Text = "" + afiliado.afiliado_numero;

                _planMedico = afiliado.PlanMedico;

                _compraGroupBox.Enabled = true;
            }

            return _panel;
        }

        private void BuscarAfiliadoClick(object sender, System.EventArgs e)
        {
            if (ValidateSearch())
            {
                Afiliado afiliado = _afiliadoDao.GetAfiliado(_tipoDeDoc.SelectedItem.ToString(), Int32.Parse(_nroDocumento.Text));

                _nombreYApellidoLbl.Text = afiliado.afiliado_nombre + " " + afiliado.afiliado_apellido;

                _planLbl.Text = afiliado.PlanMedico.planmedico_nombre;

                _nroAfliladoLbl.Text = "" + afiliado.afiliado_numero;

                _planMedico = afiliado.PlanMedico;

                _compraGroupBox.Enabled = true;
            }
        }

        private bool ValidateSearch()
        {
            Regex regex = new Regex("[0-9]{8}");
            StringBuilder sb = new StringBuilder();

            if (String.IsNullOrEmpty(_nroDocumento.Text))
                sb.AppendLine("Debe completar el nro de Documento");
            else if (!regex.Match(_nroDocumento.Text).Success)
                sb.AppendLine("Nro de Documento invalido");

            if (_tipoDeDoc.SelectedItem == null)
                sb.AppendLine("Seleccione Tipo de Documento");

            if (sb.Length != 0)
            {
                MessageBox.Show(sb.ToString());
                return false;
            }

            return true;
        }

        private void ComprarClick(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("Se han comprado {0} bonos para el afiliado {1}", _cantidadBonos.Value, _nroAfliladoLbl.Text));

            _cantidadBonos.Value = 0;
        }

        private void CantidadBonosChanged(object sender, EventArgs e)
        {
            _precio.Text = "" + _cantidadBonos.Value * _planMedico.planmedico_precio_bono;

            _comprarBtn.Enabled = _cantidadBonos.Value > 0;
        }
    }
}
