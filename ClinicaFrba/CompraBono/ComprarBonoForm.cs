﻿namespace ClinicaFrba.CompraBono
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
        private Afiliado _afiliado;

        public ComprarBonoForm(AfiliadoDao afiliadoDao)
        {
            _afiliadoDao = afiliadoDao;
        }

        public Panel Init(MenuForm parent, bool resize = true)
        {
            InitializeComponent();

            InitializeCombo();

            if (parent != null)
            {
                parent.Text = "Compra de Bonos";
                if (resize)
                    parent.FixBounds(_panel);
            }

            Rol rol = parent.Rol();

            if (rol.ToString() == "Afiliado")
            {
                _afiliado = parent.User().Afiliadoes.FirstOrDefault();

                InitializeAfiliado();
            }

            return _panel;
        }

        private void InitializeCombo()
        {
            _tipoDeDoc.Items.AddRange(_afiliadoDao.getTipoDeDocumentos().ToArray());
        }


        private void BuscarAfiliadoClick(object sender, System.EventArgs e)
        {
            if (ValidateSearch())
            {
                _afiliado = _afiliadoDao.GetAfiliado(((TipoDocumento)_tipoDeDoc.SelectedItem).tipodocumento_id, Int32.Parse(_nroDocumento.Text));

                InitializeAfiliado();
            }
        }

        private void InitializeAfiliado()
        {
            _searchGroupbox.Enabled = false;

            _nombreYApellidoLbl.Text = _afiliado.ToString();

            _planMedico = _afiliado.PlanMedico;

            _planLbl.Text = _planMedico.planmedico_nombre;

            _nroAfliladoLbl.Text = "" + _afiliado.afiliado_numero;

            _compraGroupBox.Enabled = true;
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
            _afiliadoDao.CompraDeBonos((int)_cantidadBonos.Value, _afiliado.afiliado_id, _planMedico.planmedico_id);

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
