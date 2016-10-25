namespace ClinicaFrba.CancelarTurno
{
    using DataAccess;
    using DataAccess.DAO;
    using Menu;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class CancelarTurnoForm : Form
    {
        private ProfesionalDao _profesionalDao;
        private AfiliadoDao _afiliadoDao;

        public CancelarTurnoForm(ProfesionalDao profesionalDao, AfiliadoDao afiliadoDao)
        {
            _profesionalDao = profesionalDao;
            _afiliadoDao = afiliadoDao;
        }

        public Panel Init(MenuForm parent)
        {
            InitializeComponent();

            parent.Text = "Cancelar Turno";
            parent.FixBounds(_panel);

            LoadTurnos(parent.UserId(), parent.Rol());

            return _panel;
        }

        private void LoadTurnos(int userId, Rol rol)
        {
            List<Turno> turnos = null;

            if (rol.rol_nombre.Trim() == "Afiliado")
                turnos = _afiliadoDao.GetTurnos(userId);
            else
                // turnos = _profesionalDao.GetTurnos(usuario.usuario_id, null);

                foreach (Turno turno in turnos)
                    _turnosView.Rows.Add(turno.turno_fecha, turno.turno_hora, turno.Profesional.ToString(), turno.Especialidad.ToString(), turno.Afiliado.ToString(), "Cancelar");
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
                CancelarTurnoDetalleForm cancelarTurnoDetalle = new CancelarTurnoDetalleForm(e.RowIndex);

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
