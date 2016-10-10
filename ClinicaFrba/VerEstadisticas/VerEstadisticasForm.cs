namespace ClinicaFrba.VerEstadisticas
{
    using Menu;
    using System.Windows.Forms;

    public partial class VerEstadisticasForm : Form
    {
        public VerEstadisticasForm()
        {
            
        }

        public Panel Init(MenuForm parent)
        {
            InitializeComponent();

            parent.Text = "Estadisticas";

            return _panel;
        }
    }
}
