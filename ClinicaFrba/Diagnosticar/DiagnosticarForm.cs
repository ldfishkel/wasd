namespace ClinicaFrba.Diagnosticar
{
    using DataAccess;
    using DataAccess.DAO;
    using Menu;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class DiagnosticarForm : Form
    {
        #region [FIELDS]

        private readonly ProfesionalDao _profesionalDao;

        private Profesional _profesional;

        #endregion

        #region [INIT]

        public DiagnosticarForm(ProfesionalDao profesionalDao)
        {
            _profesionalDao = profesionalDao;
        }

        public Panel Init(MenuForm parent)
        {
            InitializeComponent();

            parent.Text = "Diagnosticar";
            parent.FixBounds(_panel);

            _profesional = _profesionalDao.GetProfesional(parent.UserId());

            LoadConsultasMedicas();

            return _panel;
        }

        #endregion

        #region [GRID MANIPULATION]

        private void LoadConsultasMedicas()
        {
            List<ConsultaMedica> consultasMedicas = _profesionalDao.GetConsultasMedicas(_profesional.profesional_id);

            _consultasMedicasGrid.Rows.Clear();

            foreach (ConsultaMedica consulta in consultasMedicas)
                _consultasMedicasGrid.Rows.Add(
                        consulta.consultamedica_id,
                        consulta.Bono.Afiliado.ToString(),
                        "Resultado"
                    );

            _consultasMedicasGrid.Refresh();
        }

        private void CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int consultaId = (int)senderGrid.Rows[e.RowIndex].Cells[0].Value;

                var resultadoForm = new ResultadoConsultaMedicaForm(_profesionalDao, consultaId);

                resultadoForm.FormClosing += ResultadoFormClosed;

                resultadoForm.Show();
            }
        }

        private void ResultadoFormClosed(object sender, FormClosingEventArgs e)
        {
            LoadConsultasMedicas();
        }

        #endregion
    }
}
