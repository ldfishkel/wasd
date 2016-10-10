namespace ClinicaFrba.Diagnosticar
{
    using Menu;
    using System.Windows.Forms;

    public partial class DiagnosticarForm : Form
    {
        public DiagnosticarForm()
        {
            
        }

        public Panel Init(MenuForm parent)
        {
            InitializeComponent();

            parent.Text = "Diagnosticar";

            return _panel;
        }
    }
}
