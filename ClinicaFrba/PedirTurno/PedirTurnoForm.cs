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

        private List<Hora> _horas;

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

            _horas = _profesionalDao.GetHoras();
            _afiliado = parent.User().Afiliadoes.FirstOrDefault();

            InitializeCombo();

            return _panel;
        }

        private void InitializeCombo()
        {
            _especialidad.Items.AddRange(_profesionalDao.GetEspecialidades().ToArray());
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

            List<int> horas = _profesionalDao.GetHorasDisponibles((Profesional)_profesionalCombo.SelectedItem, (Especialidad)_especialidad.SelectedItem, (string)_fecha.SelectedItem);

            _hora.Items.Clear();
            _hora.Items.AddRange(_horas.Where(z => horas.Any(y => y == z.hora_id)).ToArray());
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

            _afiliadoDao.PedirTurno(turno);

            MessageBox.Show("Turno Solicitado");
        }
    }
}
