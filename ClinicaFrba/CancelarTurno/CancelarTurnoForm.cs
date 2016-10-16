namespace ClinicaFrba.CancelarTurno
{
    using Menu;
    using System.Windows.Forms;

    public partial class CancelarTurnoForm : Form
    {
        public CancelarTurnoForm()
        {

        }

        public Panel Init(MenuForm parent)
        {
            InitializeComponent();

            parent.Text = "Cancelar Turno";
            parent.FixWidth(_panel);

            return _panel;
        }
    }
}
