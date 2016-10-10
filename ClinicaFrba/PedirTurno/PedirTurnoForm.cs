namespace ClinicaFrba.PedirTurno
{
    using System.Windows.Forms;

    public partial class PedirTurnoForm : Form
    {
        public PedirTurnoForm(Form parent)
        {
            InitializeComponent();

            parent.Text = "Pedir Turno";
        }

        public Panel GetTabContent()
        {
            return _panel;
        }
    }
}
