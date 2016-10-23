namespace ClinicaFrba.RegistrarAgenda
{
    using DataAccess;
    using DataAccess.DAO;
    using Menu;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    public partial class RegistrarAgendaForm : Form
    {
        private ProfesionalDao _profesionalDao;

        private Profesional _profesional;

        private List<Hora> _horas;

        public RegistrarAgendaForm(ProfesionalDao profesionalDao)
        {
            _profesionalDao = profesionalDao;
        }

        public Panel Init(MenuForm parent)
        {
            InitializeComponent();

            parent.Text = "Registrar Agenda";
            parent.FixBounds(_panel);

            _horas = _profesionalDao.GetHoras();
            _profesional = _profesionalDao.GetProfesional(parent.User().usuario_id);

            InitializeAgenda();

            return _panel;
        }

        private void InitializeAgenda()
        {
            if (_profesional.Agenda != null && _profesional.Agenda.Count == 0)
                InitializeComboboxes();
            else
                ShowAgenda();
        }

        private void InitializeComboboxes()
        {
            string[] horasSabado = { "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00" };

            _lunesDesde.Items.AddRange(_horas.ToArray());
            _lunesHasta.Items.AddRange(_horas.ToArray());
            _martesDesde.Items.AddRange(_horas.ToArray());
            _martesHasta.Items.AddRange(_horas.ToArray());
            _miercolesDesde.Items.AddRange(_horas.ToArray());
            _miercolesHasta.Items.AddRange(_horas.ToArray());
            _juevesDesde.Items.AddRange(_horas.ToArray());
            _juevesHasta.Items.AddRange(_horas.ToArray());
            _viernesDesde.Items.AddRange(_horas.ToArray());
            _viernesHasta.Items.AddRange(_horas.ToArray());
            _sabadoDesde.Items.AddRange(_horas.Where(x => horasSabado.Any(y => y == x.ToString())).ToArray());
            _sabadoHasta.Items.AddRange(_horas.Where(x => horasSabado.Any(y => y == x.ToString())).ToArray());

            _lunesEspecialidad.Items.AddRange(_profesional.Especialidads.ToArray());
            _martesEspecialidad.Items.AddRange(_profesional.Especialidads.ToArray());
            _miercolesEspecialidad.Items.AddRange(_profesional.Especialidads.ToArray());
            _juevesEspecialidad.Items.AddRange(_profesional.Especialidads.ToArray());
            _viernesEspecialidad.Items.AddRange(_profesional.Especialidads.ToArray());
            _sabadoEspecialidad.Items.AddRange(_profesional.Especialidads.ToArray());
        }

        private void ShowAgenda()
        {
            foreach (Agendum agenda in _profesional.Agenda)
            {
                switch (agenda.agenda_dia.Trim())
                {
                    case "LUNES": ShowAgenda(_lunesCheck, _lunesDesde, _lunesHasta, _lunesEspecialidad, agenda); break;
                    case "MARTES": ShowAgenda(_martesCheck, _martesDesde, _martesHasta, _martesEspecialidad, agenda); break;
                    case "MIERCOLES": ShowAgenda(_miercolesCheck, _miercolesDesde, _miercolesHasta, _miercolesEspecialidad, agenda); break;
                    case "JUEVES": ShowAgenda(_juevesCheck, _juevesDesde, _juevesHasta, _juevesEspecialidad, agenda); break;
                    case "VIERNES": ShowAgenda(_viernesCheck, _viernesDesde, _viernesHasta, _viernesEspecialidad, agenda); break;
                    case "SABADO": ShowAgenda(_sabadoCheck, _sabadoDesde, _sabadoHasta, _sabadoEspecialidad, agenda); break;
                }
            }

            _fechaDesde.Value = _profesional.Agenda.First().agenda_fecha_desde;
            _fechaHasta.Value = _profesional.Agenda.First().agenda_fecha_hasta;

            DisableFields();
        }

        private void ShowAgenda(CheckBox check, ComboBox desde, ComboBox hasta, ComboBox especialidad, Agendum agenda)
        {
            check.Checked = true;
            desde.Text = agenda.Hora.ToString();
            hasta.Text = agenda.Hora1.ToString();
            especialidad.Text = agenda.Especialidad.ToString();
        }

        private void RegistrarAgendaBtnClick(object sender, System.EventArgs e)
        {
            if (ValidateFields())
            {
                SaveAgendum();
                DisableFields();
            }
        }

        private void SaveAgendum()
        {
            if (_lunesCheck.Checked)
                BuildAgenda((Especialidad)_lunesEspecialidad.SelectedItem, _lunesDesde.SelectedItem, _lunesHasta.SelectedItem, "LUNES");

            if (_martesCheck.Checked)
                BuildAgenda((Especialidad)_martesEspecialidad.SelectedItem, _martesDesde.SelectedItem, _martesHasta.SelectedItem, "MARTES");

            if (_miercolesCheck.Checked)
                BuildAgenda((Especialidad)_miercolesEspecialidad.SelectedItem, _miercolesDesde.SelectedItem, _miercolesHasta.SelectedItem, "MIERCOLES");

            if (_juevesCheck.Checked)
                BuildAgenda((Especialidad)_juevesEspecialidad.SelectedItem, _juevesDesde.SelectedItem, _juevesHasta.SelectedItem, "JUEVES");

            if (_viernesCheck.Checked)
                BuildAgenda((Especialidad)_viernesEspecialidad.SelectedItem, _viernesDesde.SelectedItem, _viernesHasta.SelectedItem, "VIERNES");

            if (_sabadoCheck.Checked)
                BuildAgenda((Especialidad)_sabadoEspecialidad.SelectedItem, _sabadoDesde.SelectedItem, _sabadoHasta.SelectedItem, "SABADO");

            _profesionalDao.SaveAgendum(_profesional);
        }

        private void BuildAgenda(Especialidad especialidad, object horaDesde, object horaHasta, string dia)
        {
            var agenda = new Agendum();

            agenda.profesional_id = _profesional.profesional_id;
            agenda.especialidad_id = especialidad.especialidad_id;
            agenda.Hora1 = (Hora)horaHasta;
            agenda.Hora = (Hora)horaDesde;
            agenda.agenda_dia = dia;
            agenda.agenda_fecha_desde = _fechaDesde.Value;
            agenda.agenda_fecha_hasta = _fechaHasta.Value;

            _profesional.Agenda.Add(agenda);
        }

        private void DisableFields()
        {
            _lunesGroupBox.Enabled = false;
            _martesGroupBox.Enabled = false;
            _miercolesGroupBox.Enabled = false;
            _juevesGroupBox.Enabled = false;
            _viernesGroupBox.Enabled = false;
            _sabadoGroupBox.Enabled = false;
            _registrarAgendaBtn.Enabled = false;
            _fechaDesde.Enabled = false;
            _fechaHasta.Enabled = false;
        }

        private bool ValidateFields()
        {
            StringBuilder sb = new StringBuilder();
            bool oneChecked = false;
            TimeSpan timeDiff = new TimeSpan(0, 0, 0);  

            if (_fechaDesde.Value.CompareTo(_fechaHasta.Value) >= 0)
                sb.AppendLine("Fecha desde debe ser anterior a fecha hasta");

            if (_lunesCheck.Checked)
            {
                if (_lunesDesde.SelectedItem == null || _lunesHasta.SelectedItem == null | _lunesEspecialidad.SelectedItem == null)
                    sb.AppendLine("Debe seleccionar todos los campos en Lunes.");
                else if (((Hora)_lunesDesde.SelectedItem).hora_comienzo.CompareTo(((Hora)_lunesHasta.SelectedItem).hora_comienzo) >= 0)
                    sb.AppendLine("El horario hasta debe ser posterior al desde el dia Lunes.");

                oneChecked = true;

                var desde = ((Hora)_lunesDesde.SelectedItem).hora_comienzo;
                var hasta = ((Hora)_lunesHasta.SelectedItem).hora_comienzo;

                timeDiff = timeDiff.Add(hasta.Subtract(desde));
            }

            if (_martesCheck.Checked)
            {
                if (_martesEspecialidad.SelectedItem == null || _martesDesde.SelectedItem == null | _martesHasta.SelectedItem == null)
                    sb.AppendLine("Debe seleccionar todos los campos en martes.");
                else if (((Hora)_martesDesde.SelectedItem).hora_comienzo.CompareTo(((Hora)_martesHasta.SelectedItem).hora_comienzo) >= 0)
                    sb.AppendLine("El horario hasta debe ser posterior al desde el dia martes.");

                oneChecked = true;

                var desde = ((Hora)_martesDesde.SelectedItem).hora_comienzo;
                var hasta = ((Hora)_martesHasta.SelectedItem).hora_comienzo;

                timeDiff = timeDiff.Add(hasta.Subtract(desde));
            }

            if (_miercolesCheck.Checked)
            {
                if (_miercolesEspecialidad.SelectedItem == null || _miercolesDesde.SelectedItem == null | _miercolesHasta.SelectedItem == null)
                    sb.AppendLine("Debe seleccionar todos los campos en miercoles.");
                else if (((Hora)_miercolesDesde.SelectedItem).hora_comienzo.CompareTo(((Hora)_miercolesHasta.SelectedItem).hora_comienzo) >= 0)
                    sb.AppendLine("El horario hasta debe ser posterior al desde el dia miercoles.");

                oneChecked = true;

                var desde = ((Hora)_miercolesDesde.SelectedItem).hora_comienzo;
                var hasta = ((Hora)_miercolesHasta.SelectedItem).hora_comienzo;

                timeDiff = timeDiff.Add(hasta.Subtract(desde));
            }

            if (_juevesCheck.Checked)
            {
                if (_juevesEspecialidad.SelectedItem == null || _juevesDesde.SelectedItem == null | _juevesHasta.SelectedItem == null)
                    sb.AppendLine("Debe seleccionar todos los campos en jueves.");
                else if (((Hora)_juevesDesde.SelectedItem).hora_comienzo.CompareTo(((Hora)_juevesHasta.SelectedItem).hora_comienzo) >= 0)
                    sb.AppendLine("El horario hasta debe ser posterior al desde el dia jueves.");

                oneChecked = true;

                var desde = ((Hora)_juevesDesde.SelectedItem).hora_comienzo;
                var hasta = ((Hora)_juevesHasta.SelectedItem).hora_comienzo;

                timeDiff = timeDiff.Add(hasta.Subtract(desde));
            }

            if (_viernesCheck.Checked)
            {
                if (_viernesEspecialidad.SelectedItem == null || _viernesDesde.SelectedItem == null | _viernesHasta.SelectedItem == null)
                    sb.AppendLine("Debe seleccionar todos los campos en viernes.");
                else if (((Hora)_viernesDesde.SelectedItem).hora_comienzo.CompareTo(((Hora)_viernesHasta.SelectedItem).hora_comienzo) >= 0)
                    sb.AppendLine("El horario hasta debe ser posterior al desde el dia viernes.");

                oneChecked = true;

                var desde = ((Hora)_viernesDesde.SelectedItem).hora_comienzo;
                var hasta = ((Hora)_viernesHasta.SelectedItem).hora_comienzo;

                timeDiff = timeDiff.Add(hasta.Subtract(desde));
            }

            if (_sabadoCheck.Checked)
            {
                if (_sabadoEspecialidad.SelectedItem == null || _sabadoDesde.SelectedItem == null | _sabadoHasta.SelectedItem == null)
                    sb.AppendLine("Debe seleccionar todos los campos en sabado.");
                else if (((Hora)_sabadoDesde.SelectedItem).hora_comienzo.CompareTo(((Hora)_sabadoHasta.SelectedItem).hora_comienzo) >= 0)
                    sb.AppendLine("El horario hasta debe ser posterior al desde el dia sabado.");

                oneChecked = true;

                var desde = ((Hora)_sabadoDesde.SelectedItem).hora_comienzo;
                var hasta = ((Hora)_sabadoHasta.SelectedItem).hora_comienzo;

                timeDiff = timeDiff.Add(hasta.Subtract(desde));
            }

            if (!oneChecked)
                sb.AppendLine("Debe seleccionar algun dia.");

            if (new TimeSpan(48, 0, 0).CompareTo(timeDiff) < 0)
                sb.AppendLine("No debe superar las 48 horas por semana.");


            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString());
                return false;
            }

            return true;
        }
    }
}
