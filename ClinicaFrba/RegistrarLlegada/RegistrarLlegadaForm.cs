namespace ClinicaFrba.RegistrarLlegada
{
    using System.Windows.Forms;

    public partial class RegistrarLlegadaForm : Form
    {
        public RegistrarLlegadaForm(Form parent)
        {
            InitializeComponent();

            parent.Text = "Registrar Llegada";
        }

        public Panel GetTabContent()
        {
            return _panel;
        }
    }
}
