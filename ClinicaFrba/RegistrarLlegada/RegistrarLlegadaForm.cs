namespace ClinicaFrba.RegistrarLlegada
{
    using DataAccess;
    using DataAccess.DAO;
    using Menu;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class RegistrarLlegadaForm : Form
    {
        #region [FIELDS]

        private readonly ProfesionalDao _profesionalDao;
        private readonly AfiliadoDao _afiliadoDao;
        private readonly TurnoDao _turnoDao;

        private Form _parent;
        private List<Turno> _turnos;

        #endregion

        #region [INIT]

        public RegistrarLlegadaForm(ProfesionalDao profesionalDao, AfiliadoDao afiliadoDao, TurnoDao turnoDao)
        {
            _profesionalDao = profesionalDao;
            _afiliadoDao = afiliadoDao;
            _turnoDao = turnoDao;
        }

        public Panel Init(MenuForm parent)
        {
            InitializeComponent();

            parent.Text = "Registrar Llegada";
            parent.FixBounds(_panel);

            _parent = parent;

            InitializeCombo();

            return _panel;
        }

        private void InitializeCombo()
        {
            _especialidad.Items.AddRange(_profesionalDao.GetEspecialidades().ToArray());
            _tipoEspecialidad.Items.AddRange(_profesionalDao.GetTipoDeEspecialidades().ToArray());
        }

        #endregion

        #region [SEARCH]

        private void TipoEspecialidadChanged(object sender, EventArgs e)
        {
            TipoEspecialidad tipoEspecialidad = (TipoEspecialidad)_tipoEspecialidad.SelectedItem;
            List<Especialidad> especialidades = _profesionalDao.GetEspecialidades(tipoEspecialidad.tipoespecialidad_id);

            _especialidad.Items.Clear();
            _especialidad.Items.AddRange(especialidades.ToArray());
        }

        private void EspecialidadChanged(object sender, EventArgs e)
        {
            Especialidad especialidad = (Especialidad)_especialidad.SelectedItem;
            List<Profesional> profesionales = _profesionalDao.GetProfesionales(especialidad.especialidad_id);

            _profesionalCombo.Items.Clear();
            _profesionalCombo.Items.AddRange(profesionales.ToArray());
        }

        private void ProfesionalChanged(object sender, EventArgs e)
        {
            Profesional profesional = (Profesional)_profesionalCombo.SelectedItem;
            Especialidad especialidad = (Especialidad)_especialidad.SelectedItem;

            _turnos = _turnoDao.GetTurnosProfesional(profesional.profesional_id, especialidad.especialidad_id);

            LoadDataGridView(_turnos);
        }

        private void BuscarClick(object sender, EventArgs e)
        {
            _turnos = _turnoDao.GetTurnosProfesional(_nombreProfesional.Text);

            LoadDataGridView(_turnos);
        }

        #endregion

        #region [GRID MANIPULATION]

        private void LoadDataGridView(ICollection<Turno> turnos)
        {
            _turnosView.Rows.Clear();

            foreach (Turno turno in turnos)
                _turnosView.Rows.Add(
                    turno.turno_id,
                    turno.turno_hora,
                    turno.Profesional.ToString(),
                    turno.Especialidad.especialidad_nombre,
                    turno.Afiliado.ToString(),
                    turno.Afiliado.afiliado_numero,
                    turno.turnocancelado_id == null ? "No" : "Si",
                    turno.turno_llego ? "Si" : "No",
                    turno.turno_llego ? null : "Llego");

            _turnosView.Refresh();
        }

        private void CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && (string)senderGrid.Rows[e.RowIndex].Cells[7].Value == "No")
            {
                var afiliadoNro = (int)senderGrid.Rows[e.RowIndex].Cells[5].Value;

                BonosViewForm bonosViewForm = new BonosViewForm(_parent, _afiliadoDao, afiliadoNro, e.RowIndex);

                bonosViewForm.FormClosed += BonosViewFormClosed;

                bonosViewForm.Show();
            }
        }

        private void BonosViewFormClosed(object sender, EventArgs eventArgs)
        {
            var form = (BonosViewForm)sender;

            if (form.Bono() != null)
            {
                int turnoId = (int)_turnosView.Rows[form.RowIndex()].Cells[0].Value;

                _turnoDao.RegistroLlegada(form.Bono().bono_id, turnoId);

                ReloadDataGridView();
                
            }
        }

        private void ReloadDataGridView()
        {
            if (_profesionalCombo.SelectedItem != null && _especialidad.SelectedItem != null)
                ProfesionalChanged(null, null);
            else if (!String.IsNullOrEmpty(_nombreProfesional.Text))
                BuscarClick(null, null);
            else
            {
                InitializeCombo();
                LoadDataGridView(new List<Turno>());
            }
        }
        
        #endregion
    }
}
