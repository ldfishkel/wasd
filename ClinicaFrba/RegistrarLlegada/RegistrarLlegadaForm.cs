namespace ClinicaFrba.RegistrarLlegada
{
    using DataAccess;
    using DataAccess.DAO;
    using Menu;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using System.Linq;

    public partial class RegistrarLlegadaForm : Form
    {
        private ProfesionalDao _profesionalDao;
        private AfiliadoDao _afiliadoDao;

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

            InitializeCombo();

            return _panel;
        }

        private void InitializeCombo()
        {
            _especialidad.Items.AddRange(_profesionalDao.GetEspecialidades().ToArray());
        }

        private void BuscarClick(object sender, System.EventArgs e)
        {
            var especialidad = (Especialidad)_especialidad.SelectedItem;

            List<Turno> turnos = _profesionalDao.GetTurnos(_nombreProfesional.Text, especialidad);

            LoadDataGridView(turnos);
        }

        private void EspecialidadChanged(object sender, EventArgs e)
        {
            List<Profesional> profesionales = _profesionalDao.GetProfesionales((Especialidad)_especialidad.SelectedItem);

            _profesionalCombo.Items.Clear();
            _profesionalCombo.Items.AddRange(profesionales.ToArray());
        }

        private void ProfesionalChanged(object sender, EventArgs e)
        {
            LoadDataGridView(((Profesional)_profesionalCombo.SelectedItem).Turnoes);
        }

        private void LoadDataGridView(ICollection<Turno> turnos)
        {
            _turnosView.Rows.Clear();

            foreach (Turno turno in turnos)
                _turnosView.Rows.Add(turno.turno_fecha_hora.Hour + ":" + turno.turno_fecha_hora.Minute, turno.Especialidad.especialidad_nombre, 
                     turno.Afiliado.afiliado_nombre + " " + turno.Afiliado.afiliado_apellido, turno.Afiliado.afiliado_numero, "No", "Llego");

            _turnosView.Refresh();
        }

        private void _turnosView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var afiliadoNro = (int)senderGrid.Rows[e.RowIndex].Cells[3].Value;

                BonosViewForm bonosViewForm = new BonosViewForm(_afiliadoDao, afiliadoNro, e.RowIndex);

                bonosViewForm.FormClosed += BonosViewFormClosed;

                bonosViewForm.Show();
            }
        }

        private void BonosViewFormClosed(object sender, EventArgs eventArgs)
        {
            var form = (BonosViewForm)sender;

            if (form.Bono() != null)
            {
                _turnosView.Rows.RemoveAt(form.RowIndex());

                _turnosView.Refresh();
            }
        }
    }
}
