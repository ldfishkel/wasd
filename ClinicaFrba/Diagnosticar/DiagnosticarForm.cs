namespace ClinicaFrba.Diagnosticar
{
    using System.Windows.Forms;

    public partial class DiagnosticarForm : Form
    {
        public DiagnosticarForm(Form parent)
        {
            InitializeComponent();

            parent.Text = "Diagnosticar";
        }

        public Panel GetTabContent()
        {
            return _panel;
        }
    }
}
