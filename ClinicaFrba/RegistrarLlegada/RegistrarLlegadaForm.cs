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
        private ProfesionalDao _profesionalDao;
        private AfiliadoDao _afiliadoDao;
        private Form _parent;
        private List<Turno> _turnos;

        public RegistrarLlegadaForm(ProfesionalDao profesionalDao, AfiliadoDao afiliadoDao)
        {
            _profesionalDao = profesionalDao;
            _afiliadoDao = afiliadoDao;
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
                    turno.turno_cancelado == null ? "No" : turno.turno_cancelado,
                    "Llego");

            _turnosView.Refresh();
        }

        private void CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
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

                _afiliadoDao.UsarBono(form.Bono().bono_id, turnoId);

                _turnosView.Rows.RemoveAt(form.RowIndex());

                _turnosView.Refresh();
            }
        }

        #region [BUSQUEDA]

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

            _turnos = _profesionalDao.GetTurnos(profesional.profesional_id, especialidad.especialidad_id);

            LoadDataGridView(_turnos);
        }

        private void BuscarClick(object sender, EventArgs e)
        {
            var especialidad = (Especialidad)_especialidad.SelectedItem;

            _turnos = _profesionalDao.GetTurnos(_nombreProfesional.Text);

            LoadDataGridView(_turnos);
        }

        #endregion
    }
}
