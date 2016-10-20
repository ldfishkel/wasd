namespace ClinicaFrba.CancelarTurno
{
    using DataAccess.DAO;
    using System.Windows.Forms;

    public partial class CancelarTurnoDetalleForm : Form
    {
        private TurnoDao _turnoDao;

        public CancelarTurnoDetalleForm(TurnoDao turnoDao, int rowIndex)
        {
            _turnoDao = turnoDao;

            InitializeComponent();
        }

        private void CancelarClick(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
