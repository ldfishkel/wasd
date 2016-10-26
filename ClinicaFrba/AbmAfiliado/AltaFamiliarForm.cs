namespace ClinicaFrba.AbmAfiliado
{
    using DataAccess;
    using System;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    public partial class AltaFamiliarForm : Form
    {
        private AltaAfiliadoForm _parent;
        private TipoDeFamiliar _tipoFamiliar;

        public AltaFamiliarForm(AltaAfiliadoForm parent, TipoDeFamiliar tipoFamiliar)
        {
            InitializeComponent();
            _parent = parent;
            _tipoFamiliar = tipoFamiliar;
        }

        private void AceptarClick(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            _parent.AfiliadoAlta.Afiliado1.Add(new Afiliado()
            {
                afiliado_nombre = _nombre.Text,
                afiliado_apellido = _apellido.Text,
                afiliado_numero =  _tipoFamiliar == TipoDeFamiliar.Conyugue ? 2 : _parent.AfiliadoAlta.Afiliado1.Max(x => x.afiliado_numero) + 1
                
            });

            Close();
        }

        private bool ValidateFields()
        {
            StringBuilder sb = new StringBuilder();

            if (String.IsNullOrWhiteSpace(_nombre.Text))
                sb.AppendLine("Debe completar el nombre");

            if (String.IsNullOrWhiteSpace(_apellido.Text))
                sb.AppendLine("Debe completar el apellido");

            if (sb.Length != 0)
            {
                MessageBox.Show(sb.ToString());
                return false;
            }

            return true;
        }
    }
}
