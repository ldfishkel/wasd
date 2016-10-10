namespace ClinicaFrba.AbmRol
{
    using Menu;
    using System.Windows.Forms;

    public partial class ABMRolForm : Form
    {
        public ABMRolForm()
        {

        }

        public Panel Init(MenuForm parent)
        {
            InitializeComponent();

            parent.Text = "ABM Rol";

            return _panel;
        }
    }
}
