namespace ClinicaFrba.AbmRol
{
    using DataAccess;
    using DataAccess.DAO;
    using Menu;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class ABMRolForm : Form
    {
        #region [FIELD]

        private readonly RolDao _rolDao;

        private List<Rol> _roles;

        #endregion

        #region [INIT]

        public ABMRolForm(RolDao rolDao)
        {
            _rolDao = rolDao;
        }

        public Panel Init(MenuForm parent)
        {
            InitializeComponent();

            parent.Text = "ABM Rol";
            parent.FixBounds(_panel);

            Initialize();

            return _panel;
        }

        private void Initialize()
        {
            _rolView.Rows.Clear();
            _roles = _rolDao.GetAll();

            foreach (Rol rol in _rolDao.GetAll())
                if (rol.rol_activo)
                    _rolView.Rows.Add(rol.rol_id, rol.rol_nombre, "Modificar", "Borrar");
        }

        #endregion

        #region [GRID MANIPULATION]

        private void AltaRolClosed(object sender, EventArgs e)
        {
            Initialize();
        }

        private void CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.ColumnIndex == 3)
            {
                int id = (int)_rolView.Rows[e.RowIndex].Cells[0].Value;

                _rolDao.Delete(id);

                Initialize();
            }

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.ColumnIndex == 2)
            {
                int id = (int)_rolView.Rows[e.RowIndex].Cells[0].Value;

                AltaRolForm form = new AltaRolForm(_rolDao, _roles.Find(x => x.rol_id == id));

                form.FormClosed += AltaRolClosed;

                form.Show();
            }
        }

        #endregion

        #region [ACTION]

        private void AltaClick(object sender, System.EventArgs e)
        {
            AltaRolForm form = new AltaRolForm(_rolDao);

            form.FormClosed += AltaRolClosed;

            form.Show();
        }

        #endregion
    }
}
