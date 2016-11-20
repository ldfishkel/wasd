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

            string msgErrorFecha = "La fecha desde y la fecha hasta deben conformar un semestre desde 1/1 hasta 30/6 o desde 1/7 hasta 31/12 del mismo año";

            if (_fechaDesde.Value.Year != _fechaHasta.Value.Year)
                sb.AppendLine(msgErrorFecha);

            else if (_fechaDesde.Value.Day != 1 && !(_fechaDesde.Value.Month == 1 || _fechaDesde.Value.Month == 7))
                sb.AppendLine(msgErrorFecha);

            else if ((_fechaHasta.Value.Day == 30 || _fechaHasta.Value.Day == 31) && !(_fechaHasta.Value.Month == 6 || _fechaDesde.Value.Month == 12))
                sb.AppendLine(msgErrorFecha);

            else if (_fechaDesde.Value.Month == 1 && _fechaHasta.Value.Month != 6)
                sb.AppendLine(msgErrorFecha);

            else if (_fechaDesde.Value.Month == 7 && _fechaHasta.Value.Month != 12)
                sb.AppendLine(msgErrorFecha);

            if (sb.Length == 0)
                return true;

            MessageBox.Show(sb.ToString());
            return false;
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
                                               result.profesional_nombre,
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
                        _grid5.Rows.Add(result.especialidad_nombre,
                                               result.cantidad,
                                               result.mes);
                    break;
            }
        }

        private void VerConsulta1(object sender, EventArgs e)
        {
            this.VerEstadisticas(ConsultasOption.Consulta1);
        }

        private void VerConsulta2(object sender, EventArgs e)
        {
            this.VerEstadisticas(ConsultasOption.Consulta2);
        }

        private void VerConsulta3(object sender, EventArgs e)
        {
            this.VerEstadisticas(ConsultasOption.Consulta3);
        }

        private void VerConsulta4(object sender, EventArgs e)
        {
            this.VerEstadisticas(ConsultasOption.Consulta4);
        }

        private void VerConsulta5(object sender, EventArgs e)
        {
            this.VerEstadisticas(ConsultasOption.Consulta5);
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
