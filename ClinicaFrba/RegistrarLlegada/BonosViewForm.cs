namespace ClinicaFrba.RegistrarLlegada
{
    using ClinicaFrba.CompraBono;
    using DataAccess;
    using DataAccess.DAO;
    using System;
    using System.Windows.Forms;

    public partial class BonosViewForm : Form
    {
        private AfiliadoDao _afiliadoDao;

        private Bono _bono;

        private int _rowIndex;

        public BonosViewForm(AfiliadoDao afiliadoDao, int nroAfiliado, int rowIndex)
        {
            InitializeComponent();

            _afiliadoDao = afiliadoDao;

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

            compraBonoForm.Init(null);

            compraBonoForm.FormClosed += CompraBonoFormClosed;

            compraBonoForm.Show();
        }

        private void CompraBonoFormClosed(object sender, EventArgs eventArgs)
        {
            MessageBox.Show("refresh Bonos");
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
