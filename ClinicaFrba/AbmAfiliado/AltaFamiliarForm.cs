namespace ClinicaFrba.AbmAfiliado
{
    using DataAccess;
    using DataAccess.DAO;
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    public partial class AltaFamiliarForm : Form
    {
        private AltaAfiliadoForm _parent;
        private TipoDeFamiliar _tipoFamiliar;
        private AfiliadoDao _afiliadoDao;

        public AltaFamiliarForm(AfiliadoDao afiliadoDao, AltaAfiliadoForm parent, TipoDeFamiliar tipoFamiliar)
        {
            InitializeComponent();

            _afiliadoDao = afiliadoDao;
            _parent = parent;
            _tipoFamiliar = tipoFamiliar;

            InitializeCombos();
        }

        private void InitializeCombos()
        {
            _tipoDoc.Items.AddRange(_afiliadoDao.GetTipoDeDocumentos());

            _estadoCivil.Items.AddRange(_afiliadoDao.GetEstadosCiviles());

            _sexo.Items.AddRange(new string[] { "M", "F" });
        }

        private void AceptarClick(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            _parent.AfiliadoAlta.Afiliado1.Add(new Afiliado()
            {
                afiliado_nombre = _nombre.Text,
                afiliado_apellido = _apellido.Text,
                afiliado_numero = GetNueroFamiliar(),
                afiliado_direccion = _direccion.Text,
                afiliado_tipodocumento = _tipoDoc.Text,
                afiliado_numero_documento = Int32.Parse(_numeroDocumento.Text),
                afiliado_mail = _mail.Text,
                afiliado_sexo = _sexo.Text,
                afiliado_fecha_nacimiento = _fechaNacimiento.Value,
                estadocivil_id = ((EstadoCivil)_estadoCivil.SelectedItem).estadocivil_id,
                afiliado_telefono = Int32.Parse(_telefono.Text)
            });

            Close();
        }

        private int GetNueroFamiliar()
        {
            if (_tipoFamiliar == TipoDeFamiliar.Conyugue)
                return 2;
            else if (_parent.AfiliadoAlta.Afiliado1.Count > 0)
                return _parent.AfiliadoAlta.Afiliado1.Max(x => x.afiliado_numero) + 1;
            else
                return 3;
        }

        private bool ValidateFields()
        {
            StringBuilder sb = new StringBuilder();

            if (((EstadoCivil)_estadoCivil.SelectedItem) == null)
                sb.AppendLine("Debe completar el estado civil");

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

            if (!Int32.TryParse(_numeroDocumento.Text, out result))
                sb.AppendLine("Numnero de documento incorrecto");

            if (sb.Length == 0)
                return true;

            MessageBox.Show(sb.ToString());
            return false;
        }
    }
}
