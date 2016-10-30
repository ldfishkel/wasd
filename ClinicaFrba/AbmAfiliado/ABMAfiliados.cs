namespace ClinicaFrba.AbmAfiliado
{
    using DataAccess;
    using DataAccess.DAO;
    using Menu;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class ABMAfiliadosForm : Form
    {
        private AfiliadoDao _afiliadoDao;

        public ABMAfiliadosForm(AfiliadoDao afiliadoDao)
        {
            _afiliadoDao = afiliadoDao;
        }

        public Panel Init(MenuForm menuForm)
        {
            InitializeComponent();

            menuForm.Text = "ABM Afiliados";
            menuForm.FixBounds(_panel);

            InitializeAfiliadosGrid(null, null);

            return _panel;
        }

        private void InitializeAfiliadosGrid(object sender, FormClosingEventArgs e)
        {
            _afiliadosGrid.Rows.Clear();

            foreach (Afiliado afiliado in _afiliadoDao.GetAfiliados())
                _afiliadosGrid.Rows.Add(afiliado.afiliado_numero, afiliado, "Ver", "Modificar", "Baja");
        }

        private void AltaClick(object sender, System.EventArgs e)
        {
            var altaAfiliadoForm = new AltaAfiliadoForm(_afiliadoDao);

            altaAfiliadoForm.FormClosing += InitializeAfiliadosGrid;

            altaAfiliadoForm.Show();
        }

        private void CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(_afiliadosGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn) || e.RowIndex < 0)
                return;

            Afiliado afiliado = (Afiliado)_afiliadosGrid.Rows[e.RowIndex].Cells[1].Value;

            if (e.ColumnIndex == 2)
            {
                afiliado = _afiliadoDao.GetAfiliado(afiliado.usuario_id);
                List<HistorialPlan> historialPlan = _afiliadoDao.HistorialPlan(afiliado.afiliado_id);
                PlanMedico planMedico = _afiliadoDao.GetPlanMedico(afiliado.planmedico_id);

                new DetalleAfiliadoForm(afiliado, planMedico, historialPlan).Show();
            }

            if (e.ColumnIndex == 3)
            {
                afiliado = _afiliadoDao.GetAfiliado(afiliado.usuario_id);
                afiliado.PlanMedico = _afiliadoDao.GetPlanMedico(afiliado.planmedico_id);

                new ModificarAfiliadoForm(afiliado, _afiliadoDao).Show();
            }

            if (e.ColumnIndex == 4)
            {
                var result = MessageBox.Show("Posta?", "Eliminar?", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    _afiliadoDao.DeleteAfiliado(afiliado.afiliado_numero);

                    InitializeAfiliadosGrid(null, null);
                }
            }
        }
    }
}
