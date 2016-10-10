namespace ClinicaFrba.RegistrarAgenda
{
    using System.Windows.Forms;

    public partial class RegistrarAgendaForm : Form
    {
        public RegistrarAgendaForm(Form parent)
        {
            InitializeComponent();

            parent.Text = "Registrar Agenda";
        }

        public Panel GetTabContent()
        {
            return _panel;
        }
    }
}
