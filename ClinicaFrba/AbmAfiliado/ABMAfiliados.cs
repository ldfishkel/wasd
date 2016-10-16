namespace ClinicaFrba.AbmAfiliado
{
    using DataAccess;
    using DataAccess.DAO;
    using Menu;
    using System.Windows.Forms;

    public partial class ABMAfiliadosForm : Form
    {
        private AfiliadoDao _afiliadoDao;

        private Usuario _user;
        private Rol _rol;

        public ABMAfiliadosForm(AfiliadoDao afiliadoDao)
        {
            _afiliadoDao = afiliadoDao;
        }

        public Panel Init(MenuForm menuForm)
        {
            InitializeComponent();

            menuForm.Text = "ABM Afiliados";
            _user = menuForm.User();
            _rol = menuForm.Rol();

            InitializeAfiliadosGrid();

            return _panel;
        }

        private void InitializeAfiliadosGrid()
        {
            foreach (Afiliado afiliado in _afiliadoDao.GetAfiliados())
                _afiliadosGrid.Rows.Add(afiliado.afiliado_numero, afiliado.afiliado_nombre, afiliado.Plan, "Ver", "Baja", "Modificar");
        }

        private void AltaClick(object sender, System.EventArgs e)
        {
            var altaAfiliadoForm = new AltaAfiliadoForm();
            altaAfiliadoForm.Show();
        }

        private void _afiliadosGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
