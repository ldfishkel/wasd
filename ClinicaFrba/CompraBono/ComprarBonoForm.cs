namespace ClinicaFrba.CompraBono
{
    using Menu;
    using System.Windows.Forms;

    public partial class ComprarBonoForm : Form
    {
        public ComprarBonoForm()
        {
           
        }

        public Panel Init(MenuForm parent)
        {
            InitializeComponent();

            parent.Text = "Compra de Bonos";

            return _panel;
        }
    }
}
