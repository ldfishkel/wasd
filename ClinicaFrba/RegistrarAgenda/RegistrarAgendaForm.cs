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

        private Dictionary<string, int> _horasNumero;

        public RegistrarAgendaForm(ProfesionalDao profesionalDao)
        {
            _profesionalDao = profesionalDao;
        }

        public Panel Init(MenuForm parent)
        {
            InitializeComponent();

            parent.Text = "Registrar Agenda";
            parent.FixBounds(_panel);

            _profesional = _profesionalDao.GetProfesional(parent.User().usuario_id);

            InitializeDictionary();
            InitializeAgenda();

            return _panel;
        }

        private void InitializeDictionary()
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
            desde.Text = _horasNumero.FirstOrDefault(x => x.Value == agenda.agenda_hora_desde).Key;
            hasta.Text = _horasNumero.FirstOrDefault(x => x.Value == agenda.agenda_hora_hasta).Key;
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
            agenda.agenda_hora_hasta = _horasNumero[(string)horaHasta];
            agenda.agenda_hora_desde = _horasNumero[(string)horaDesde];
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
            TimeSpan timeDiff = ToTimeSpan("00:00");

            if (_fechaDesde.Value.CompareTo(_fechaHasta.Value) >= 0)
                sb.AppendLine("Fecha desde debe ser anterior a fecha hasta");

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
                var hasta = ToTimeSpan(_miercolesHasta.SelectedItem);

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
