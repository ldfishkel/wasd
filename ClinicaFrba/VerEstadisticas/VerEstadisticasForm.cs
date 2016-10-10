namespace ClinicaFrba.VerEstadisticas
{
    using System.Windows.Forms;

    public partial class VerEstadisticasForm : Form
    {
        public VerEstadisticasForm(Form parent)
        {
            InitializeComponent();

            parent.Text = "Estadisticas";
        }

        public Panel GetTabContent()
        {
            return _panel;
        }
    }
}
