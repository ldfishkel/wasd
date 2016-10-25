namespace ClinicaFrba.Diagnosticar
{
    using ClinicaFrba.DataAccess.DAO;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Windows.Forms;

    public partial class ResultadoConsultaMedicaForm : Form
    {
        #region [FIELDS]

        private readonly ProfesionalDao _profesionalDao;

        private int _consultaId;

        private List<string> _sintomas;
        private List<string> _diagnosticos;

        #endregion

        #region [INIT]

        public ResultadoConsultaMedicaForm(ProfesionalDao profesionalDao, int consultaId)
        {
            InitializeComponent();

            _profesionalDao = profesionalDao;
            _consultaId = consultaId;

            _sintomas = new List<string>();
            _diagnosticos = new List<string>();

            LoadGrids();
        }

        #endregion

        #region [GRID MANIPULATION]

        private void LoadGrids()
        {
            _sintomasGrid.Rows.Clear();
            _diagnosticosGrid.Rows.Clear();

            foreach (var sintoma in _sintomas)
                _sintomasGrid.Rows.Add(
                    sintoma,
                    "Quitar"
                    );

            foreach (var diagnostico in _diagnosticos)
                _diagnosticosGrid.Rows.Add(
                    diagnostico,
                    "Quitar"
                    );
        }

        private void AgregarSintomaClick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(_sintomaTxt.Text))
            {
                _sintomas.Add(_sintomaTxt.Text);

                _sintomaTxt.Clear();

                LoadGrids();
            }
        }

        private void AgregarDiagnosticoClick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(_diagnosticoTxt.Text))
            {
                _diagnosticos.Add(_diagnosticoTxt.Text);

                _diagnosticoTxt.Clear();

                LoadGrids();
            }
        }

        private void SintomasCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                _sintomas.RemoveAt(e.RowIndex);

                LoadGrids();
            }
        }

        private void DiagnosticosCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                _diagnosticos.RemoveAt(e.RowIndex);

                LoadGrids();
            }
        }

        #endregion

        #region [ACTION]

        private void GuardarResultadoClick(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                _profesionalDao.SaveResultadoConsulta(_consultaId, _diagnosticos, _sintomas);

                Close();
            }
        }

        private bool ValidateFields()
        {
            StringBuilder sb = new StringBuilder();

            if (_sintomas == null || _sintomas.Count == 0)
                sb.AppendLine("Debe ingresar al menos un sintoma");

            if (_diagnosticos == null || _diagnosticos.Count == 0)
                sb.AppendLine("Debe ingresar al menos un diagnostico");

            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString());
                return false;
            }

            return true;
        }

        #endregion
    }
}
