namespace ClinicaFrba.RegistrarLlegada
{
    using ClinicaFrba.CompraBono;
    using DataAccess;
    using DataAccess.DAO;
    using Menu;
    using System;
    using System.Windows.Forms;

    public partial class BonosViewForm : Form
    {
        private AfiliadoDao _afiliadoDao;

        private Bono _bono;

        private int _rowIndex;

        private int _nroAfiliado;

        private Form _parent;

        public BonosViewForm(Form form, AfiliadoDao afiliadoDao, int nroAfiliado, int rowIndex)
        {
            InitializeComponent();

            _parent = form;

            _afiliadoDao = afiliadoDao;

            _nroAfiliado = nroAfiliado;

            _bonosCombo.Items.AddRange(_afiliadoDao.GetBonos(nroAfiliado).ToArray());

            _rowIndex = rowIndex;
        }

        public Bono Bono()
        {
            return _bono;
        }

        public int RowIndex()
        {
            return _rowIndex;
        }

        private void ComprarClick(object sender, EventArgs e)
        {
            ComprarBonoForm compraBonoForm = new ComprarBonoForm(_afiliadoDao);

            compraBonoForm.Init((MenuForm)_parent, false);

            compraBonoForm.FormClosed += CompraBonoFormClosed;

            compraBonoForm.Show();
        }

        private void CompraBonoFormClosed(object sender, EventArgs eventArgs)
        {
            _bonosCombo.Items.Clear();
            _bonosCombo.Items.AddRange(_afiliadoDao.GetBonos(_nroAfiliado).ToArray());
        }

        private void _bonosCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_bonosCombo.SelectedItem != null)
                _UsarBtn.Enabled = true;
            else
                _UsarBtn.Enabled = false;
        }

        private void _UsarBtn_Click(object sender, EventArgs e)
        {
            _bono = (Bono)_bonosCombo.SelectedItem;

            Close();
        }
    }
}
