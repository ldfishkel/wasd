namespace ClinicaFrba.PedirTurno
{
    using DataAccess;
    using DataAccess.DAO;
    using Menu;
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class PedirTurnoForm : Form
    {
        private ProfesionalDao _profesionalDao;

        public PedirTurnoForm(ProfesionalDao profesionalDao)
        {
            _profesionalDao = profesionalDao;
        }

        public Panel Init(MenuForm parent)
        {
            InitializeComponent();

            parent.Text = "Pedir Turno";
            parent.FixBounds(_panel);

            InitializeCombo();

            return _panel;
        }

        private void InitializeCombo()
        {
            _especialidad.Items.AddRange(_profesionalDao.GetEspecialidades().ToArray());
        }

        private void CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EspecialidadChanged(object sender, EventArgs e)
        {
            List<Profesional> profesionales = _profesionalDao.GetProfesionales((Especialidad)_especialidad.SelectedItem);

            _profesionalCombo.Items.Clear();
            _profesionalCombo.Items.AddRange(profesionales.ToArray());
            _fechaHoraGroupbox.Enabled = false;
            _turnoBtn.Enabled = false;
        }

        private void ProfesionalChanged(object sender, EventArgs e)
        {
            _fechaHoraGroupbox.Enabled = true;
            _turnoBtn.Enabled = false;

            List<DateTime> fechas = _profesionalDao.GetFechasDisponibles((Profesional)_profesionalCombo.SelectedItem, (Especialidad)_especialidad.SelectedItem);

            _fecha.Items.Clear();
            _fecha.Items.AddRange(fechas.Select(x => x.Day + "/" + x.Month).ToArray()); 
        }

        private void HoraChanged(object sender, EventArgs e)
        {
            _turnoBtn.Enabled = true;
        }

        private void FechaChanged(object sender, EventArgs e)
        {
            _turnoBtn.Enabled = false;
            _hora.Enabled = true;

            List<DateTime> horas = _profesionalDao.GetHorasDisponibles((Profesional)_profesionalCombo.SelectedItem, (Especialidad)_especialidad.SelectedItem, _fecha.SelectedItem);

            _hora.Items.Clear();
            _hora.Items.AddRange(horas.Select(x => x.Hour + ":" + x.Minute).ToArray());
        }

        private void SolicitarTurnoClick(object sender, EventArgs e)
        {
            MessageBox.Show("Turno Solicitado");
        }
    }
}
