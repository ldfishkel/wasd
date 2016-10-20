namespace ClinicaFrba.CancelarTurno
{
    using Menu;
    using System.Windows.Forms;
    using DataAccess;
    using System;
    using DataAccess.DAO;
    using System.Collections.Generic;

    public partial class CancelarTurnoForm : Form
    {
        private ProfesionalDao _profesionalDao;
        private AfiliadoDao _afiliadoDao;
        private TurnoDao _turnoDao;

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

            LoadTurnos(parent.User(), parent.Rol());

            return _panel;
        }

        private void LoadTurnos(Usuario usuario, Rol rol)
        {
            List<Turno> turnos = null;

            if (rol.rol_nombre.Trim() == "Afiliado")
                turnos = _afiliadoDao.GetTurnos(usuario.usuario_id);
            else
                turnos = _profesionalDao.GetTurnos(usuario.usuario_id, null);

            foreach (Turno turno in turnos)
                _turnosView.Rows.Add(GetFecha(turno.turno_fecha_hora), GetHora(turno.turno_fecha_hora), turno.Profesional.ToString(), turno.Especialidad.ToString(), turno.Afiliado.ToString(), "Cancelar");
        }

        private string GetHora(DateTime fecha)
        {
            return String.Format("{0}/{1}/{2}", fecha.Day, fecha.Month, fecha.Year);
        }

        private string GetFecha(DateTime fecha)
        {
            return String.Format("{0}:{1}", fecha.Hour, fecha.Minute);
        }

        private void CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                CancelarTurnoDetalleForm cancelarTurnoDetalle = new CancelarTurnoDetalleForm(_turnoDao, e.RowIndex);

                cancelarTurnoDetalle.FormClosed += CanecelarTurnoDetalleClosed;

                cancelarTurnoDetalle.Show();
            }
        }

        private void CanecelarTurnoDetalleClosed(object sender, EventArgs e)
        {
            MessageBox.Show("Turno Cancelado");
        }
    }
}
