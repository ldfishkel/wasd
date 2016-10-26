namespace ClinicaFrba.CancelarTurno
{
    using DataAccess;
    using DataAccess.DAO;
    using System;
    using System.Text;
    using System.Windows.Forms;

    public partial class CancelarTurnoDetalleForm : Form
    {
        #region [FIELDS]

        private readonly TurnoDao _turnoDao;

        private int _profesionalId;
        private DateTime _fechaDesde;
        private DateTime _fechaHasta;

        private Profesional _profesional;
        private Afiliado _afiliado;
        private int _turnoId;

        #endregion

        #region [INIT]

        public CancelarTurnoDetalleForm(int turnoId, Afiliado afiliado, TurnoDao turnoDao)
        {
            InitializeComponent();

            _turnoId = turnoId;
            _turnoDao = turnoDao;
            _afiliado = afiliado;

            InitializeCombo();
        }

    
        public CancelarTurnoDetalleForm(int turnoId, Profesional profesional, TurnoDao turnoDao)
        {
            InitializeComponent();

            _turnoId = turnoId;
            _turnoDao = turnoDao;
            _profesional = profesional;

            InitializeCombo();
        }

        public CancelarTurnoDetalleForm(DateTime fechaDesde, DateTime fechaHasta, int profesionalId, TurnoDao turnoDao)
        {
            InitializeComponent();

            _turnoDao = turnoDao;
            _fechaDesde = fechaDesde;
            _fechaHasta = fechaHasta;
            _profesionalId = profesionalId;
            _turnoId = 0;

            InitializeCombo();
        }

        private void InitializeCombo()
        {
            _tipoCancelacion.Items.AddRange(_turnoDao.GetTipoCancelaciones().ToArray());
        }

        #endregion

        #region [ACTION]

        private void CancelarClick(object sender, System.EventArgs e)
        {
            if (ValidateFields())
            {
                CancelarTurnoAction();
                Close();
            }
        }

        private void CancelarTurnoAction()
        {
            TipoCancelacion tipoCancelacion = (TipoCancelacion)_tipoCancelacion.SelectedItem;
            string descripcion = _descripcion.Text;

            if (_turnoId == 0)
                _turnoDao.CancelarTurnos(_fechaDesde, _fechaHasta, _profesionalId, tipoCancelacion.tipocancelacion_id, descripcion);
            else if (_afiliado != null)
                _turnoDao.CancelarTurno("A", _turnoId, tipoCancelacion.tipocancelacion_id, descripcion);
            else if (_profesional != null)
                _turnoDao.CancelarTurno("P", _turnoId, tipoCancelacion.tipocancelacion_id, descripcion);
        }

        private bool ValidateFields()
        {
            StringBuilder sb = new StringBuilder();

            if (_tipoCancelacion.SelectedItem == null)
                sb.AppendLine("Debe seleccionar un tipo de cancelacion");

            if (String.IsNullOrWhiteSpace(_descripcion.Text) || _descripcion.Text == "Descripcion")
                sb.AppendLine("Debe ingresar una descripcion");

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
