﻿namespace ClinicaFrba.AbmAfiliado
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

            InitializeAfiliadosGrid();

            return _panel;
        }

        private void InitializeAfiliadosGrid()
        {
            foreach (Afiliado afiliado in _afiliadoDao.GetAfiliados())
                _afiliadosGrid.Rows.Add(afiliado.afiliado_numero, afiliado, "Ver", "Baja", "Modificar");
        }

        private void AltaClick(object sender, System.EventArgs e)
        {
            var altaAfiliadoForm = new AltaAfiliadoForm(_afiliadoDao);
            altaAfiliadoForm.Show();
        }

        private void CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Afiliado afiliado = (Afiliado)_afiliadosGrid.Rows[e.RowIndex].Cells[1].Value;

            if (e.ColumnIndex == 2)
            {
                afiliado = _afiliadoDao.GetAfiliado(afiliado.usuario_id);
                List<HistorialPlan> historialPlan = _afiliadoDao.HistorialPlan(afiliado.afiliado_id);
                PlanMedico planMedico = _afiliadoDao.GetPlanMedico(afiliado.planmedico_id);

                new DetalleAfiliadoForm(afiliado, planMedico, historialPlan).Show();
            }
        }
    }
}
