namespace ClinicaFrba.AbmAfiliado
{
    using DataAccess;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class DetalleAfiliadoForm : Form
    {
        private Afiliado _afiliado;
        private List<HistorialPlan> _historialPlan;
        private PlanMedico _planmedico;

        public DetalleAfiliadoForm(Afiliado afiliado, PlanMedico planMedico, List<HistorialPlan> historialPlan)
        {
            InitializeComponent();

            _afiliado = afiliado;
            _planmedico = planMedico;
            _historialPlan = historialPlan;

            InitializeFields();
        }

        private void InitializeFields()
        {
            _nombre.Text = _afiliado.afiliado_nombre;
            _apellido.Text = _afiliado.afiliado_apellido;
            _tipoDoc.Text = _afiliado.afiliado_tipodocumento;
            _nroDoc.Text = _afiliado.afiliado_numero_documento.ToString();
            _direccion.Text = _afiliado.afiliado_direccion;
            _telefono.Text = _afiliado.afiliado_telefono.ToString();
            _estadoCivil.Text = _afiliado.EstadoCivil.ToString();
            _mail.Text = _afiliado.afiliado_mail;
            _planMedico.Text = _planmedico.ToString();
            _sexo.Text = _afiliado.afiliado_sexo;
            _nroAfiliado.Text = _afiliado.afiliado_numero.ToString();
            _fechaNacimiento.Text = Utils.FormatDate(_afiliado.afiliado_fecha_nacimiento);

            foreach (var planHist in _historialPlan)
                _historialPlanMedico.Rows.Add(Utils.FormatDate(planHist.historial_fecha), planHist.historial_motivo);
        }
    }
}
