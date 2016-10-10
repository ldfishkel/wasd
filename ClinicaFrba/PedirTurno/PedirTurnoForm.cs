namespace ClinicaFrba.PedirTurno
{
    using Menu;
    using System.Windows.Forms;

    public partial class PedirTurnoForm : Form
    {
        public PedirTurnoForm()
        {
            
        }

        public Panel Init(MenuForm parent)
        {
            InitializeComponent();

            parent.Text = "Pedir Turno";

            return _panel;
        }
    }
}
