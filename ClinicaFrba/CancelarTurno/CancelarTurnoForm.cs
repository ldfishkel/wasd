namespace ClinicaFrba.CancelarTurno
{
    using System.Windows.Forms;

    public partial class CancelarTurnoForm : Form
    {
        public CancelarTurnoForm(Form parent)
        {
            InitializeComponent();

            parent.Text = "Cancelar Turno";
        }

        public Panel GetTabContent()
        {
            return _panel;
        }
    }
}
