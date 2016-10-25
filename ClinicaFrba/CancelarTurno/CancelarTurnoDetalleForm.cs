namespace ClinicaFrba.CancelarTurno
{
    using System;
    using System.Windows.Forms;

    public partial class CancelarTurnoDetalleForm : Form
    {
        #region [FIELDS]

        private int _profesionalId;
        private DateTime _fechaDesde;
        private DateTime _fechaHasta;

        private int _turnoId;

        #endregion

        #region [INIT]

        public CancelarTurnoDetalleForm(int turnoId)
        {
            //TODO 10 CREATE TABLE Cancelacion CREATE TABLE TipoCancelacion
            InitializeComponent();

            _turnoId = turnoId;
        }

        public CancelarTurnoDetalleForm(DateTime fechaDesde, DateTime fechaHasta, int profesionalId)
        {
            InitializeComponent();

            _fechaDesde = fechaDesde;
            _fechaHasta = fechaHasta;
            _profesionalId = profesionalId;
            _turnoId = 0;
        }

        #endregion

        #region [ACTION]

        private void CancelarClick(object sender, System.EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
