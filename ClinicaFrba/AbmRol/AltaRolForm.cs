﻿namespace ClinicaFrba.AbmRol
{
    using DataAccess;
    using DataAccess.DAO;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    public partial class AltaRolForm : Form
    {
        #region [FILEDS]

        private readonly RolDao _rolDao;

        private Rol _rol;
        private bool _modify;

        #endregion

        #region [INIT]

        public AltaRolForm(RolDao rolDao)
        {
            _rolDao = rolDao;
            _rol = new Rol();
            _rol.Funcionalidads = new HashSet<Funcionalidad>();
            _modify = false;

            InitializeComponent();
            InitializeCombo();
        }

        public AltaRolForm(RolDao rolDao, Rol rol)
        {
            InitializeComponent();

            _rolDao = rolDao;
            _rol = rol;
            _rol.Funcionalidads = _rolDao.GetFuncionalidades(_rol.rol_id);

            _modify = true;
            _nombre.Text = rol.rol_nombre;

            Text = "Modificar Rol";

            AgregarClick(null, null);
            InitializeCombo();
        }

        private void InitializeCombo()
        {
            _funcionalidadCombo.Items.AddRange(_rolDao.GetFuncionalidades().ToArray());
        }

        #endregion

        #region [GRID MANIPULATION]

        private void AgregarClick(object sender, EventArgs e)
        {
            Funcionalidad fun = (Funcionalidad)_funcionalidadCombo.SelectedItem;
            if (fun != null && !_rol.Funcionalidads.Any(x => x.funcionalidad_id == fun.funcionalidad_id))
                _rol.Funcionalidads.Add((Funcionalidad)_funcionalidadCombo.SelectedItem);

            _funcionalidadesView.Rows.Clear();

            foreach (Funcionalidad funcionalidad in _rol.Funcionalidads)
            {
                _funcionalidadesView.Rows.Add(funcionalidad.funcionalidad_id, funcionalidad.funcionalidad_nombre, "Quitar");
            }
        }

        private void CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int id = (int)senderGrid.Rows[e.RowIndex].Cells[0].Value;

                _rol.Funcionalidads.Remove(_rol.Funcionalidads.First(x => x.funcionalidad_id == id));

                senderGrid.Rows.RemoveAt(e.RowIndex);
            }
        }

        #endregion

        #region [ACTION]

        private void GuardarClick(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                _rol.rol_nombre = _nombre.Text;
                _rol.rol_activo = true;

                SP_AgregarRol_Result result = null;
                SP_ModificarRol_Result result2 = null;

                if (_modify)
                    result2 = _rolDao.Modify(_rol);
                else
                    result = _rolDao.Guardar(_rol);

                if (result != null && result.status == 1)
                    MessageBox.Show(result.errorMessage);
                else if (result2 != null && result2.status == 1)
                    MessageBox.Show(result2.errorMessage);
                else
                    Close();
            }
        }

        private bool ValidateFields()
        {
            StringBuilder sb = new StringBuilder();

            if (String.IsNullOrEmpty(_nombre.Text))
                sb.AppendLine("Debe ingresar nobmre");

            if (_rol.Funcionalidads.Count == 0)
                sb.AppendLine("Debe agregar funcionalidad");

            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString());
                return false;
            }

            return true;
        }

        #endregion
    }
}
