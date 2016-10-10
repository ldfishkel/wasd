namespace ClinicaFrba.CompraBono
{
    using System.Windows.Forms;

    public partial class ComprarBonoForm : Form
    {
        public ComprarBonoForm(Form parent)
        {
            InitializeComponent();

            parent.Text = "Compra de Bonos";
        }

        public Panel GetTabContent()
        {
            return _panel;
        }
    }
}
