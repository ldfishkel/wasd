namespace ClinicaFrba.AbmAfiliado
{
    using System;
    using System.Text;
    using System.Windows.Forms;

    public partial class AltaAfiliadoForm : Form
    {
        public AltaAfiliadoForm()
        {
            InitializeComponent();
        }

        private void _si_familia_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
        }

        private void _no_familia_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
        }

        private void AceptarClick(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
            }
        }

        private void CancelarClick(object sender, EventArgs e)
        {
            Close();
        }

        private bool ValidateFields()
        {
            StringBuilder sb = new StringBuilder();

            if (String.IsNullOrEmpty(_nombre.Text))
                sb.AppendLine("Debe completar el campo nombre");

            if (String.IsNullOrEmpty(_apellido.Text))
                sb.AppendLine("Debe completar el campo apellido");

            if (String.IsNullOrEmpty(_tipoDocumento.Text))
                sb.AppendLine("Debe completar el campo Tipo de Documento");

            if (String.IsNullOrEmpty(_numeroDocumento.Text))
                sb.AppendLine("Debe completar el campo Numero de Documento");

            if (String.IsNullOrEmpty(_direccion.Text))
                sb.AppendLine("Debe completar el campo Direccion");

            if (String.IsNullOrEmpty(_telefono.Text))
                sb.AppendLine("Debe completar el campo Telefono");

            if (String.IsNullOrEmpty(_mail.Text))
                sb.AppendLine("Debe completar el campo Email");

            if (_estado_civil.SelectedItem == null)
                sb.AppendLine("Debe seleccionar un Estado Civil");

            if (_sexo.SelectedItem == null)
                sb.AppendLine("Debe seleccionar un Sexo");

            if (sb.Length != 0)
            {
                MessageBox.Show(sb.ToString());
                return false;
            }

            return true;
        }

        private void _estado_civil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_estado_civil.SelectedText == "Casado/a" || _estado_civil.SelectedText == "Concubinato")
            {
                groupBox2.Enabled = true;
            }
            if (_estado_civil.SelectedText == "Soltero/a" || _estado_civil.SelectedText == "Viudo/a" || _estado_civil.SelectedText == "Divorciado/a")
            {
                groupBox2.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AltaCirculoFamiliarForm altaCirculoFamiliar = new AltaCirculoFamiliarForm();
            altaCirculoFamiliar.Show();
        }
    }
}
