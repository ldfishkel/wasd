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

        private IDictionary<string, int> _horasNumero;

        public PedirTurnoForm(ProfesionalDao profesionalDao)
        {
            _profesionalDao = profesionalDao;
        }

        public Panel Init(MenuForm parent)
        {
            InitializeComponent();

            InitializeHoras();
            parent.Text = "Pedir Turno";
            parent.FixBounds(_panel);

            InitializeCombo();

            return _panel;
        }

        private void InitializeHoras()
        {
            _horasNumero = new Dictionary<string, int>()
            {
               { "07:00", 0 },
               { "07:30", 1 },
               { "08:00", 2 },
               { "08:30", 3 },
               { "09:00", 4 },
               { "09:30", 5 },
               { "10:00", 6 },
               { "10:30", 7 },
               { "11:00", 8 },
               { "11:30", 9 },
               { "12:00", 10 },
               { "12:30", 11 },
               { "13:00", 12 },
               { "13:30", 13 },
               { "14:00", 14 },
               { "14:30", 15 },
               { "15:00", 16 },
               { "15:30", 17 },
               { "16:00", 18 },
               { "16:30", 19 },
               { "17:00", 20 },
               { "17:30", 21 },
               { "18:00", 22 },
               { "18:30", 23 },
               { "19:00", 24 },
               { "19:30", 25 },
               { "20:00", 26 }
            };
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
            _hora.Items.AddRange(horas.Select(z => _horasNumero.FirstOrDefault(x => x.Value == z).Key).ToArray());
        }

        private void SolicitarTurnoClick(object sender, EventArgs e)
        {
            MessageBox.Show("Turno Solicitado");
        }
    }
}
