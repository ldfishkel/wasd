namespace ClinicaFrba.VerEstadisticas
{
    using DataAccess;
    using DataAccess.DAO;
    using Menu;
    using System;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    public partial class VerEstadisticasForm : Form
    {
        private EstadisticasDao _estadisticasDao;
        private AfiliadoDao _afiliadoDao;
        private ProfesionalDao _profesionalDao;

        public VerEstadisticasForm(EstadisticasDao estadisticasDao, AfiliadoDao afiliadoDao, ProfesionalDao profesionalDao)
        {
            _estadisticasDao = estadisticasDao;
            _profesionalDao = profesionalDao;
            _afiliadoDao = afiliadoDao;
        }

        public Panel Init(MenuForm parent)
        {
            InitializeComponent();

            parent.Text = "Estadisticas";
            parent.FixBounds(_panel);

            InitializeCombos();

            return _panel;
        }

        private void InitializeCombos()
        {
            _planMedico.Items.AddRange(_afiliadoDao.PlanesMedicos().ToArray());
            _planMedico3.Items.AddRange(_afiliadoDao.PlanesMedicos().ToArray());
            _especialidad.Items.AddRange(_profesionalDao.GetEspecialidades().ToArray());
        }

        private bool ValidateFields(ConsultasOption option)
        {
            StringBuilder sb = new StringBuilder();

            switch (option)
            {
                case ConsultasOption.Consulta1:
                    if (_canceladoPor.SelectedItem == null || !new Regex("(A|P)").IsMatch(_canceladoPor.SelectedItem.ToString()))
                        sb.AppendLine("Debe Seleccionar Afiliado o Profesional");
                    break;
                case ConsultasOption.Consulta2:
                    if (_planMedico.SelectedItem == null)
                        sb.AppendLine("Debe Seleccionar Plan Medico");
                    break;
                case ConsultasOption.Consulta3:
                    if (_planMedico3.SelectedItem == null)
                        sb.AppendLine("Debe Seleccionar Plan Medico");

                    if (_especialidad.SelectedItem == null)
                        sb.AppendLine("Debe Seleccionar Especialidad");
                    break;
                case ConsultasOption.Consulta4:
                case ConsultasOption.Consulta5:
                default:
                    break;
            }

            if (_fechaDesde.Value.CompareTo(_fechaHasta.Value) >= 0)
                sb.AppendLine("Fecha hasta debe ser posterior a fecha desde");

            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString());
                return false;
            }

            return true;
        }

        private void OnTabSelected(object sender, TabControlEventArgs e)
        {
            ConsultasOption option = ConsultasOption.Consulta1;

            switch (e.TabPageIndex)
            {
                case 0: option = ConsultasOption.Consulta1; break;
                case 1: option = ConsultasOption.Consulta2; break;
                case 2: option = ConsultasOption.Consulta3; break;
                case 3: option = ConsultasOption.Consulta4; break;
                case 4: option = ConsultasOption.Consulta5; break;
            }

            this.VerEstadisticas(option);
        }

        private void VerEstadisticas(ConsultasOption option)
        {
            if (!ValidateFields(option))
                return;

            switch (option)
            {
                case ConsultasOption.Consulta1:

                    _grid1.Rows.Clear();

                    foreach (var result in _estadisticasDao.Consulta1(_fechaDesde.Value, _fechaHasta.Value, _canceladoPor.SelectedItem.ToString()))
                        _grid1.Rows.Add(result.especialidad,
                                               result.cancelaciones,
                                               result.mes);
                    break;
                case ConsultasOption.Consulta2:

                    _grid2.Rows.Clear();

                    foreach (var result in _estadisticasDao.Consulta2(_fechaDesde.Value, _fechaHasta.Value, ((PlanMedico)_planMedico.SelectedItem).planmedico_id))
                        _grid2.Rows.Add(result.profesional_apellido,
                                               result.planmedico_nombre,
                                               result.especialidad_nombre,
                                               result.consultas,
                                               result.mes);
                    break;
                case ConsultasOption.Consulta3:

                    _grid3.Rows.Clear();

                    foreach (var result in _estadisticasDao.Consulta3(_fechaDesde.Value, _fechaHasta.Value, ((PlanMedico)_planMedico3.SelectedItem).planmedico_id, ((Especialidad)_especialidad.SelectedItem).especialidad_id))
                        _grid3.Rows.Add(result.profesional_apellido,
                                               result.profesional_nombre,
                                               result.horas,
                                               result.mes);
                    break;
                case ConsultasOption.Consulta4:

                    _grid4.Rows.Clear();

                    foreach (var result in _estadisticasDao.Consulta4(_fechaDesde.Value, _fechaHasta.Value))
                        _grid4.Rows.Add(result.afiliado_numero,
                                               result.afiliado_apellido,
                                               result.afiliado_nombre,
                                               result.cantidad,
                                               result.pertenece_a_grupo,
                                               result.mes);
                    break;
                case ConsultasOption.Consulta5:

                    _grid5.Rows.Clear();

                    foreach (var result in _estadisticasDao.Consulta5(_fechaDesde.Value, _fechaHasta.Value))
                        _grid1.Rows.Add(result.especialidad_nombre,
                                               result.cantidad,
                                               result.mes);
                    break;
            }
        }

        private void VerConsulta1(object sender, EventArgs e)
        {
            this.VerEstadisticas(ConsultasOption.Consulta1);
        }

        private void VerConsulta3(object sender, EventArgs e)
        {
            this.VerEstadisticas(ConsultasOption.Consulta3);
        }

        private void VerConsulta2(object sender, EventArgs e)
        {
            this.VerEstadisticas(ConsultasOption.Consulta2);

        }
    }

    public enum ConsultasOption
    {
        Consulta1,
        Consulta2,
        Consulta3,
        Consulta4,
        Consulta5,
    }
}
