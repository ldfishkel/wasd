namespace ClinicaFrba.AbmRol
{
    using System.Windows.Forms;

    public partial class ABMRolForm : Form
    {
        public ABMRolForm(Form parent)
        {
            InitializeComponent();

            parent.Text = "ABM Rol";
        }

        public Panel GetTabContent()
        {
            return _panel;
        }
    }
}
