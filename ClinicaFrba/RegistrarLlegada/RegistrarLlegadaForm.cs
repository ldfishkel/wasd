namespace ClinicaFrba.RegistrarLlegada
{
    using Menu;
    using System.Windows.Forms;

    public partial class RegistrarLlegadaForm : Form
    {
        public RegistrarLlegadaForm()
        {
            
        }

        public Panel Init(MenuForm parent)
        {
            InitializeComponent();

            parent.Text = "Registrar Llegada";

            return _panel;
        }
    }
}
