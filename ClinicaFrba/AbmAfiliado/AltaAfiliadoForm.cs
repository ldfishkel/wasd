using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.AbmAfiliado
{
    public partial class AltaAfiliadoForm : Form
    {
        public AltaAfiliadoForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AltaAfiliado_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void _si_familia_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
        }

        private void _no_familia_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
        }

        private void _aceptar_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
            }
            else
            {
                Close();
            }
        }

        private void _cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ValidateFields()
        {
            StringBuilder sb = new StringBuilder();
            if(String.IsNullOrEmpty(_nombre.Text))
            {
                sb.AppendLine("Debe completar el campo nombre");
            }
            if (String.IsNullOrEmpty(_apellido.Text))
            {
                sb.AppendLine("Debe completar el campo apellido");
            }
            if (String.IsNullOrEmpty(_tipo_documento.Text))
            {
                sb.AppendLine("Debe completar el campo Tipo de Documento");
            }
            if (String.IsNullOrEmpty(_numero_documento.Text))
            {
                sb.AppendLine("Debe completar el campo Numero de Documento");
            }
            if (String.IsNullOrEmpty(_direccion.Text))
            {
                sb.AppendLine("Debe completar el campo Direccion");
            }
            if (String.IsNullOrEmpty(_telefono.Text))
            {
                sb.AppendLine("Debe completar el campo Telefono");
            }
            if (String.IsNullOrEmpty(_mail.Text))
            {
                sb.AppendLine("Debe completar el campo Email");
            }
            if (_estado_civil.SelectedItem == null)
            {
                sb.AppendLine("Debe seleccionar un Estado Civil");
            }
            if (_sexo.SelectedItem == null)
            {
                sb.AppendLine("Debe seleccionar un Sexo");
            }
            if (_si_familia.Checked == false && _no_familia.Checked == false)
            {
                sb.AppendLine("Debe de no tener hijos o familiares a cargo seleccione 'NO'");
            }
            if (sb.Length != 0)
            {
                MessageBox.Show(sb.ToString());
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
