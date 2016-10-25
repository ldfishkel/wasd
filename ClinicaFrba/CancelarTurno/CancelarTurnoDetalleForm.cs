namespace ClinicaFrba.CancelarTurno
{
    using System.Windows.Forms;

    public partial class CancelarTurnoDetalleForm : Form
    {
        public CancelarTurnoDetalleForm(int rowIndex)
        {
            InitializeComponent();
        }

        private void CancelarClick(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
