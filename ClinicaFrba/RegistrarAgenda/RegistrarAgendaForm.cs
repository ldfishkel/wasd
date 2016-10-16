namespace ClinicaFrba.RegistrarAgenda
{
    using DataAccess;
    using DataAccess.DAO;
    using Menu;
    using System.Windows.Forms;
    using System.Linq;
    using System.Text;
    using System;

    public partial class RegistrarAgendaForm : Form
    {
        private ProfesionalDao _profesionalDao;

        private Profesional _profesional;

        public RegistrarAgendaForm(ProfesionalDao profesionalDao)
        {
            _profesionalDao = profesionalDao;
        }

        public Panel Init(MenuForm parent)
        {
            InitializeComponent();

            parent.Text = "Registrar Agenda";
            parent.FixWidth(_panel);

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
            string[] horas = { "07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00" };
            string[] horasSabado = { "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00" };

            _lunesDesde.Items.AddRange(horas);
            _lunesHasta.Items.AddRange(horas);
            _martesDesde.Items.AddRange(horas);
            _martesHasta.Items.AddRange(horas);
            _miercolesDesde.Items.AddRange(horas);
            _miercolesHasta.Items.AddRange(horas);
            _juevesDesde.Items.AddRange(horas);
            _juevesHasta.Items.AddRange(horas);
            _viernesDesde.Items.AddRange(horas);
            _viernesHasta.Items.AddRange(horas);
            _sabadoDesde.Items.AddRange(horasSabado);
            _sabadoHasta.Items.AddRange(horasSabado);

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
                if (agenda.agenda_dia.Trim().Equals("LUNES"))
                {
                    _lunesCheck.Checked = true;
                    _lunesDesde.Text = agenda.agenda_hora_desde.ToString();
                    _lunesHasta.Text = agenda.agenda_hora_hasta.ToString();
                    _lunesEspecialidad.Text = agenda.Especialidad.ToString();
                }

                if (agenda.agenda_dia.Trim().Equals("MARTES"))
                {
                    _martesCheck.Checked = true;
                    _martesDesde.Text = agenda.agenda_hora_desde.ToString();
                    _martesHasta.Text = agenda.agenda_hora_hasta.ToString();
                    _martesEspecialidad.Text = agenda.Especialidad.ToString();
                }

                if (agenda.agenda_dia.Trim().Equals("MIERCOLES"))
                {
                    _miercolesCheck.Checked = true;
                    _miercolesDesde.Text = agenda.agenda_hora_desde.ToString();
                    _miercolesHasta.Text = agenda.agenda_hora_hasta.ToString();
                    _miercolesEspecialidad.Text = agenda.Especialidad.ToString();
                }

                if (agenda.agenda_dia.Trim().Equals("JUEVES"))
                {
                    _juevesCheck.Checked = true;
                    _juevesDesde.Text = agenda.agenda_hora_desde.ToString();
                    _juevesHasta.Text = agenda.agenda_hora_hasta.ToString();
                    _juevesEspecialidad.Text = agenda.Especialidad.ToString();
                }

                if (agenda.agenda_dia.Trim().Equals("VIERNES"))
                {
                    _viernesCheck.Checked = true;
                    _viernesDesde.Text = agenda.agenda_hora_desde.ToString();
                    _viernesHasta.Text = agenda.agenda_hora_hasta.ToString();
                    _viernesEspecialidad.Text = agenda.Especialidad.ToString();
                }

                if (agenda.agenda_dia.Trim().Equals("SABADO"))
                {
                    _sabadoCheck.Checked = true;
                    _sabadoDesde.Text = agenda.agenda_hora_desde.ToString();
                    _sabadoHasta.Text = agenda.agenda_hora_hasta.ToString();
                    _sabadoEspecialidad.Text = agenda.Especialidad.ToString();
                }
            }

            DisableFields();
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
            {
                var agendaLunes = new Agendum();
                agendaLunes.profesional_id = _profesional.profesional_id;
                agendaLunes.especialidad_id = ((Especialidad)_lunesEspecialidad.SelectedItem).especialidad_id;
                agendaLunes.agenda_hora_hasta = ToTimeSpan(_lunesHasta.SelectedItem);
                agendaLunes.agenda_hora_desde = ToTimeSpan(_lunesDesde.SelectedItem);
                agendaLunes.agenda_dia = "LUNES";
                agendaLunes.agenda_id = Int32.Parse(new StringBuilder().Append(_profesional.profesional_id).Append(0).ToString());
                _profesional.Agenda.Add(agendaLunes);
            }

            if (_martesCheck.Checked)
            {
                var agendamartes = new Agendum();
                agendamartes.profesional_id = _profesional.profesional_id;
                agendamartes.especialidad_id = ((Especialidad)_martesEspecialidad.SelectedItem).especialidad_id;
                agendamartes.agenda_hora_hasta = ToTimeSpan(_martesHasta.SelectedItem);
                agendamartes.agenda_hora_desde = ToTimeSpan(_martesDesde.SelectedItem);
                agendamartes.agenda_dia = "MARTES";
                agendamartes.agenda_id = Int32.Parse(new StringBuilder().Append(_profesional.profesional_id).Append(1).ToString());
                _profesional.Agenda.Add(agendamartes);

            }

            if (_miercolesCheck.Checked)
            {
                var agendamiercoles = new Agendum();
                agendamiercoles.profesional_id = _profesional.profesional_id;
                agendamiercoles.especialidad_id = ((Especialidad)_miercolesEspecialidad.SelectedItem).especialidad_id;
                agendamiercoles.agenda_hora_hasta = ToTimeSpan(_miercolesHasta.SelectedItem);
                agendamiercoles.agenda_hora_desde = ToTimeSpan(_miercolesDesde.SelectedItem);
                agendamiercoles.agenda_dia = "MIERCOLES";
                agendamiercoles.agenda_id = Int32.Parse(new StringBuilder().Append(_profesional.profesional_id).Append(2).ToString());
                _profesional.Agenda.Add(agendamiercoles);
            }

            if (_juevesCheck.Checked)
            {
                var agendajueves = new Agendum();
                agendajueves.profesional_id = _profesional.profesional_id;
                agendajueves.especialidad_id = ((Especialidad)_juevesEspecialidad.SelectedItem).especialidad_id;
                agendajueves.agenda_hora_hasta = ToTimeSpan(_juevesHasta.SelectedItem);
                agendajueves.agenda_hora_desde = ToTimeSpan(_juevesDesde.SelectedItem);
                agendajueves.agenda_dia = "JUEVES";
                agendajueves.agenda_id = Int32.Parse(new StringBuilder().Append(_profesional.profesional_id).Append(3).ToString());
                _profesional.Agenda.Add(agendajueves);
            }

            if (_viernesCheck.Checked)
            {
                var agendaviernes = new Agendum();
                agendaviernes.profesional_id = _profesional.profesional_id;
                agendaviernes.especialidad_id = ((Especialidad)_viernesEspecialidad.SelectedItem).especialidad_id;
                agendaviernes.agenda_hora_hasta = ToTimeSpan(_viernesHasta.SelectedItem);
                agendaviernes.agenda_hora_desde = ToTimeSpan(_viernesDesde.SelectedItem);
                agendaviernes.agenda_dia = "VIERNES";
                agendaviernes.agenda_id = Int32.Parse(new StringBuilder().Append(_profesional.profesional_id).Append(4).ToString());
                _profesional.Agenda.Add(agendaviernes);
            }

            if (_sabadoCheck.Checked)
            {
                var agendasabado = new Agendum();
                agendasabado.profesional_id = _profesional.profesional_id;
                agendasabado.especialidad_id = ((Especialidad)_sabadoEspecialidad.SelectedItem).especialidad_id;
                agendasabado.agenda_hora_hasta = ToTimeSpan(_sabadoHasta.SelectedItem);
                agendasabado.agenda_hora_desde = ToTimeSpan(_sabadoDesde.SelectedItem);
                agendasabado.agenda_dia = "SABADO";
                agendasabado.agenda_id = Int32.Parse(new StringBuilder().Append(_profesional.profesional_id).Append(5).ToString());
                _profesional.Agenda.Add(agendasabado);
            }

            _profesionalDao.SaveAgendum(_profesional);
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
        }

        private bool ValidateFields()
        {
            StringBuilder sb = new StringBuilder();
            bool oneChecked = false;
            TimeSpan timeDiff = ToTimeSpan("00:00");

            if (_lunesCheck.Checked)
            {
                if (_lunesDesde.SelectedItem == null || _lunesHasta.SelectedItem == null | _lunesEspecialidad.SelectedItem == null)
                    sb.AppendLine("Debe seleccionar todos los campos en Lunes.");
                else if (ToTimeSpan(_lunesDesde.SelectedItem).CompareTo(ToTimeSpan(_lunesHasta.SelectedItem)) >= 0)
                    sb.AppendLine("El horario hasta debe ser posterior al desde el dia Lunes.");

                oneChecked = true;

                var desde = ToTimeSpan(_lunesDesde.SelectedItem);
                var hasta = ToTimeSpan(_lunesHasta.SelectedItem);

                timeDiff = timeDiff.Add(hasta.Subtract(desde));
            }

            if (_martesCheck.Checked)
            { 
                if (_martesEspecialidad.SelectedItem == null || _martesDesde.SelectedItem == null | _martesHasta.SelectedItem == null)
                    sb.AppendLine("Debe seleccionar todos los campos en martes.");
                else if (ToTimeSpan(_martesDesde.SelectedItem).CompareTo(ToTimeSpan(_martesHasta.SelectedItem)) >= 0)
                    sb.AppendLine("El horario hasta debe ser posterior al desde el dia martes.");

                oneChecked = true;

                var desde = ToTimeSpan(_martesDesde.SelectedItem);
                var hasta = ToTimeSpan(_martesHasta.SelectedItem);

                timeDiff = timeDiff.Add(hasta.Subtract(desde));
            }

            if (_miercolesCheck.Checked)
            {
                if (_miercolesEspecialidad.SelectedItem == null || _miercolesDesde.SelectedItem == null | _miercolesHasta.SelectedItem == null)
                    sb.AppendLine("Debe seleccionar todos los campos en miercoles.");
                else if (ToTimeSpan(_miercolesDesde.SelectedItem).CompareTo(ToTimeSpan(_miercolesHasta.SelectedItem)) >= 0)
                    sb.AppendLine("El horario hasta debe ser posterior al desde el dia miercoles.");

                oneChecked = true;

                var desde = ToTimeSpan(_miercolesDesde.SelectedItem);
                var hasta= ToTimeSpan(_miercolesHasta.SelectedItem);

                timeDiff = timeDiff.Add(hasta.Subtract(desde));
            }

            if (_juevesCheck.Checked)
            {
                if (_juevesEspecialidad.SelectedItem == null || _juevesDesde.SelectedItem == null | _juevesHasta.SelectedItem == null)
                    sb.AppendLine("Debe seleccionar todos los campos en jueves.");
                else if (ToTimeSpan(_juevesDesde.SelectedItem).CompareTo(ToTimeSpan(_juevesHasta.SelectedItem)) >= 0)
                    sb.AppendLine("El horario hasta debe ser posterior al desde el dia jueves.");

                oneChecked = true;

                var desde = ToTimeSpan(_juevesDesde.SelectedItem);
                var hasta = ToTimeSpan(_juevesHasta.SelectedItem);

                timeDiff = timeDiff.Add(hasta.Subtract(desde));
            }

            if (_viernesCheck.Checked)
            {
                if (_viernesEspecialidad.SelectedItem == null || _viernesDesde.SelectedItem == null | _viernesHasta.SelectedItem == null)
                    sb.AppendLine("Debe seleccionar todos los campos en viernes.");
                else if (ToTimeSpan(_viernesDesde.SelectedItem).CompareTo(ToTimeSpan(_viernesHasta.SelectedItem)) >= 0)
                    sb.AppendLine("El horario hasta debe ser posterior al desde el dia viernes.");

                oneChecked = true;

                var desde = ToTimeSpan(_viernesDesde.SelectedItem);
                var hasta = ToTimeSpan(_viernesHasta.SelectedItem);

                timeDiff = timeDiff.Add(hasta.Subtract(desde));
            }

            if (_sabadoCheck.Checked)
            {
                if (_sabadoEspecialidad.SelectedItem == null || _sabadoDesde.SelectedItem == null | _sabadoHasta.SelectedItem == null)
                    sb.AppendLine("Debe seleccionar todos los campos en sabado.");
                else if (ToTimeSpan(_sabadoDesde.SelectedItem).CompareTo(ToTimeSpan(_sabadoHasta.SelectedItem)) >= 0)
                    sb.AppendLine("El horario hasta debe ser posterior al desde el dia sabado.");

                oneChecked = true;

                var desde = ToTimeSpan(_sabadoDesde.SelectedItem);
                var hasta = ToTimeSpan(_sabadoHasta.SelectedItem);

                timeDiff = timeDiff.Add(hasta.Subtract(desde));
            }

            if (!oneChecked)
                sb.AppendLine("Debe seleccionar algun dia.");

            if (ToTimeSpan("48:00").CompareTo(timeDiff) < 0)
                sb.AppendLine("No debe superar las 48 horas por semana.");


            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString());
                return false;
            }

            return true;
        }

        private TimeSpan ToTimeSpan(object time)
        {
            var timeString = time as string;
            var hour = timeString.Split(':')[0];
            var minutes = timeString.Split(':')[1];

            return new TimeSpan(Int32.Parse(hour), Int32.Parse(minutes), 0);
        }
    }
}
