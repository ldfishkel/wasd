namespace ClinicaFrba.RegistrarAgenda
{
    using Menu;
    using System.Windows.Forms;

    public partial class RegistrarAgendaForm : Form
    {
        public RegistrarAgendaForm()
        {
            
        }

        public Panel Init(MenuForm parent)
        {
            InitializeComponent();

            parent.Text = "Registrar Agenda";

            return _panel;
        }
    }
}
