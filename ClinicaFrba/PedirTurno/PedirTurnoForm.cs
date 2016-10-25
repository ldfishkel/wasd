namespace ClinicaFrba.PedirTurno
{
    using DataAccess;
    using DataAccess.DAO;
    using Menu;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    public partial class PedirTurnoForm : Form
    {
        private ProfesionalDao _profesionalDao;
        private AfiliadoDao _afiliadoDao;
        private Afiliado _afiliado;

        private List<Hora> _horasSemana;

        public PedirTurnoForm(ProfesionalDao profesionalDao, AfiliadoDao afiliadoDao)
        {
            _profesionalDao = profesionalDao;
            _afiliadoDao = afiliadoDao;
        }

        public Panel Init(MenuForm parent)
        {
            InitializeComponent();

            parent.Text = "Pedir Turno";
            parent.FixBounds(_panel);

            _horasSemana = _profesionalDao.GetHorasSemana();
            _afiliado = _afiliadoDao.GetAfiliado(parent.UserId());

            InitializeCombo();

            return _panel;
        }

        private void InitializeCombo()
        {
            _especialidad.Items.Clear();
            _tipoEspecialidad.Items.Clear();
            _profesionalCombo.Items.Clear();

            _especialidad.Items.AddRange(_profesionalDao.GetEspecialidades().ToArray());
            _tipoEspecialidad.Items.AddRange(_profesionalDao.GetTipoDeEspecialidades().ToArray());

            _tipoEspecialidad.Text = "Tipo de Especialidad";
            _especialidad.Text = "Especialidad";
            _profesionalCombo.Text = "Profesional";

            _fecha.Items.Clear();
            _hora.Items.Clear();
            _fecha.Text = "Fecha";
            _hora.Text = "Hora";
            _fechaHoraGroupbox.Enabled = false;
        }

        private void EspecialidadChanged(object sender, EventArgs e)
        {
            Especialidad especialidad = (Especialidad)_especialidad.SelectedItem;
            List<Profesional> profesionales = _profesionalDao.GetProfesionales(especialidad.especialidad_id);

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
            _fecha.Items.AddRange(fechas.Select(x => x.Day + "/" + x.Month + "/" + x.Year).ToArray());
        }

        private void HoraChanged(object sender, EventArgs e)
        {
            _turnoBtn.Enabled = true;
        }

        private void FechaChanged(object sender, EventArgs e)
        {
            _turnoBtn.Enabled = false;
            _hora.Enabled = true;

            Profesional profesional = (Profesional)_profesionalCombo.SelectedItem;
            Especialidad especialidad = (Especialidad)_especialidad.SelectedItem;

            List<int> horas = _profesionalDao.GetHorasDisponibles(profesional, especialidad, (string)_fecha.SelectedItem);

            _hora.Items.Clear();
            _hora.Items.AddRange(_horasSemana.Where(z => horas.Any(y => y == z.hora_id)).ToArray());
        }

        private void SolicitarTurnoClick(object sender, EventArgs e)
        {
            Turno turno = new Turno();

            turno.afiliado_id = _afiliado.afiliado_id;
            turno.profesional_id = ((Profesional)_profesionalCombo.SelectedItem).profesional_id;
            turno.especialidad_id = ((Especialidad)_especialidad.SelectedItem).especialidad_id;
            var splitted = ((string)_fecha.SelectedItem).Split('/').Select(x => Int32.Parse(x)).ToArray();
            turno.turno_fecha = new DateTime(splitted[2], splitted[1], splitted[0]);
            turno.turno_hora = ((Hora)_hora.SelectedItem).hora_comienzo;
            turno.turno_llego = false;

            _afiliadoDao.PedirTurno(turno);

            MessageBox.Show("Turno Solicitado");

            InitializeCombo();
        }

        private void TipoEspecialidadChanged(object sender, EventArgs e)
        {
            TipoEspecialidad tipoEspecialidad = (TipoEspecialidad)_tipoEspecialidad.SelectedItem;

            List<Especialidad> especialidades = _profesionalDao.GetEspecialidades(tipoEspecialidad.tipoespecialidad_id);

            _especialidad.Items.Clear();
            _especialidad.Items.AddRange(especialidades.ToArray());
        }
    }
}
