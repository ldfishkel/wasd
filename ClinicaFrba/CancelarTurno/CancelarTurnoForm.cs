namespace ClinicaFrba.CancelarTurno
{
    using DataAccess;
    using DataAccess.Configuration;
    using DataAccess.DAO;
    using Menu;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Windows.Forms;

    public partial class CancelarTurnoForm : Form
    {
        #region [FIELDS]

        private readonly ProfesionalDao _profesionalDao;
        private readonly AfiliadoDao _afiliadoDao;
        private readonly TurnoDao _turnoDao;

        private Profesional _profesional;
        private Afiliado _afiliado;

        private DateTime _systemDate;

        #endregion

        #region [INIT]

        public CancelarTurnoForm(ProfesionalDao profesionalDao, AfiliadoDao afiliadoDao, TurnoDao turnoDao)
        {
            _profesionalDao = profesionalDao;
            _afiliadoDao = afiliadoDao;
            _turnoDao = turnoDao;
        }

        public Panel Init(MenuForm parent)
        {
            InitializeComponent();

            parent.Text = "Cancelar Turno";
            parent.FixBounds(_panel);

            _systemDate = Config.SystemDate();

            if (parent.Rol().ToString().ToString() == "Afiliado")
                _afiliado = _afiliadoDao.GetAfiliado(parent.UserId());
            else
                _profesional = _profesionalDao.GetProfesional(parent.UserId());

            LoadTurnos();

            return _panel;
        }

        #endregion

        #region [GRID MANIPULATION]

        private void LoadTurnos()
        {
            List<Turno> turnos = new List<Turno>();

            if (_afiliado != null)
            {
                turnos = _turnoDao.GetTurnosAfiliado(_afiliado.afiliado_id);

                _rangoGruopBox.Hide();
            }
            else if (_profesional != null)
            {
                turnos = _turnoDao.GetTurnosProfesional(_profesional.profesional_id);

                _rangoGruopBox.Show();
                _fechaDesde.Value = _systemDate;
                _fechaHasta.Value = _systemDate;
            }

            _turnosView.Rows.Clear();

            foreach (Turno turno in turnos)
                _turnosView.Rows.Add(turno.turno_id, turno.turno_fecha, turno.turno_hora, turno.Profesional.ToString(), turno.Especialidad.ToString(), turno.Afiliado.ToString(), "Cancelar");
        }

        private void CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                CancelarTurnoDetalleForm cancelarTurnoDetalle = new CancelarTurnoDetalleForm(e.RowIndex);

                cancelarTurnoDetalle.FormClosed += CanecelarTurnoDetalleClosed;

                cancelarTurnoDetalle.Show();
            }
        }

        private void CanecelarTurnoDetalleClosed(object sender, EventArgs e)
        {
            LoadTurnos();
        }

        #endregion

        #region [ACTION]

        private void CancelarRangoClick(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                CancelarTurnoDetalleForm cancelarTurnoDetalle = new CancelarTurnoDetalleForm(_fechaDesde.Value, _fechaHasta.Value, _profesional.profesional_id);

                cancelarTurnoDetalle.FormClosed += CanecelarTurnoDetalleClosed;

                cancelarTurnoDetalle.Show();

                _turnoDao.CancelarTurnos(_fechaDesde.Value, _fechaHasta.Value, _profesional.profesional_id);

                LoadTurnos();
            }
        }

        private bool ValidateFields()
        {
            StringBuilder sb = new StringBuilder();

            if (_fechaDesde.Value.CompareTo(_systemDate) <= 0)
                sb.AppendLine(String.Format("La fecha desde debe ser posterior al dia de hoy: {0}", _systemDate.ToString()));

            if (_fechaHasta.Value.CompareTo(_fechaDesde.Value) < 0)
                sb.AppendLine("La fecha hasta debe ser igual o posterior a la fecha desde");

            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString());
                return false;
            }

            return true;
        }

        #endregion
    }
}
